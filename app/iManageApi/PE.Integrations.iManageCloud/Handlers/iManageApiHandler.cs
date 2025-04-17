using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.ApiModel.Contracts;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    [Serializable]
    partial class iManageApiHandler { 
        async Task<T> GetAsync<T>(string? url = null, string? query = null) => await QueryAsync<T>(HttpMethod.Get, $"{url}{(query == null ? string.Empty : $"?{query}")}");
        
        async Task<IPagedList<T>> GetPageAsync<T>(int pageIndex, int pageSize, string url) {
            var query = BuildQuery(pageIndex, pageSize);
            var (ts, total) = await GetAsync<(T[], int)>(url, query);
            return ts.ToPagedList(pageIndex, ts.Length, total);
        }

        async Task<List<T>> GetListAsync<T>(int pageIndex, int pageSize, string url) {
            var query = BuildQuery(pageIndex, pageSize);
            var (ts, total) = await GetAsync<(T[], int)>(url, query);
            return ts.ToList();
        }

        async Task<Stream> GetAsync(string url) {
            var response = await QueryAsync(HttpMethod.Get, url);
            return await response.Content.ReadAsStreamAsync();
        }
        
        async Task<T> PostAsync<T>(string url, object payload) => await QueryAsync<T>(HttpMethod.Post, url, Serialize<T>(payload));
        
        async Task<T> PostAsync<T>(string url, object payload, Stream stream) => await QueryAsync<T>(HttpMethod.Post, url, await SerializeAsync<T>(payload, stream));

        async Task<T> PostDocAsync<T>(string url, object payload, Stream stream) => await QueryPostDocAsync<T>(HttpMethod.Post, url, payload, stream);

        async Task<Stream> PostAsync(string url, object payload) {
            var response = await QueryAsync(HttpMethod.Post, url, Serialize(payload));
            return await response.Content.ReadAsStreamAsync();
        }

        async Task PostAsyncVoid(string url, object payload) => await QueryAsync(HttpMethod.Post, url, Serialize(payload));

        async Task<T> PutAsync<T>(string url, object payload, Stream stream) => await QueryAsync<T>(HttpMethod.Put, url, await SerializeAsync<T>(payload, stream));

        async Task DeleteAsync(string url) => await QueryAsync(HttpMethod.Delete, url);

        async Task<T> PatchAsync<T>(string url, object payload) => await QueryAsync<T>(new HttpMethod("PATCH"), url, Serialize<T>(payload));

        async Task<T> QueryAsync<T>(Func<Task<HttpResponseMessage>> query) {
            var response = await QueryAsync(query);
            return await DeserializeAsync<T>(response.Content);
        }

        private async Task<HttpResponseMessage> QueryAsync(HttpMethod method,string url, HttpContent? payload = null, string? payloadString = null) {
            HttpRequestMessage req = new HttpRequestMessage(method, this._apiEndpointUri + "/" + url);
            req.Headers.Add("X-Auth-Token", this._authToken);
            if (payload != null) {
                req.Content = payload;
                if (payload is MultipartFormDataContent) {
                    req.Content.Headers.Remove("Content-Type");
                    req.Content.Headers.TryAddWithoutValidation("Content-Type", "multipart/form-data; boundary=----WebKitFormBoundaryIVYxOCuSnOuyAHO9");
                }
            }
            HttpResponseMessage response = await iManageApiHandler._httpClient.SendAsync(req);
            string content = string.Empty;

            content = await response.Content.ReadAsStringAsync();
            try {
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex) {
                iManageApiError error = JsonConvert.DeserializeObject<iManageApiError>(content);
                error.Error.CodeMessage += string.Join("\n", content);

                if (!string.IsNullOrEmpty(payloadString)) {
                    error.Error.CodeMessage += string.Join("\n", payloadString);
                }

                throw new iManageApiException(error, (Exception)ex);
            }
            return response;
        }

        async Task<HttpResponseMessage> QueryAsync(Func<Task<HttpResponseMessage>> query) {
            var response = await query();

            try { response.EnsureSuccessStatusCode(); }
            catch (HttpRequestException hre) {
                var error = JsonConvert.DeserializeObject<iManageApiError>(await response.Content.ReadAsStringAsync());
                throw new iManageApiException(error, hre);
            }
            return response;
        }

        async Task<T> QueryAsync<T>(HttpMethod method, string url, HttpContent? payload = null) {
            var response = await QueryAsync(method, url, payload, payload == null? string.Empty : payload.ReadAsStringAsync().Result.ToString());
            return await DeserializeAsync<T>(response.Content);
        }

        async Task<T> QueryPostDocAsync<T>(HttpMethod method, string url, object payload, Stream stream) {
            var response = await QueryPostDocAsync(method, url, payload, stream);
            return await DeserializeAsync<T>(response.Content);
        }



        async Task<HttpResponseMessage> QueryPostDocAsync(HttpMethod method, string url, object payload, Stream stream)
        {
            string content = string.Empty;
            string docName = string.Empty;
            string ext = string.Empty;

            if (payload is DocumentUploadRequest) 
            {
                DocumentUploadRequest p = (DocumentUploadRequest)payload;
                // Set the document metadata
                // document profile and user trustee list
                docName = p.DocProfile.Name;
                ext = p.DocProfile.Extension;
            }

            try {

                ServicePointManager.ServerCertificateValidationCallback = (s, cert, chain, ssl) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Define the upload URL
                string uploadURL = $"{_apiEndpointUri}/{url}";

                // Create HTTP request object
                HttpWebRequest request = WebRequest.CreateHttp(uploadURL);

                // Set request method & headers
                // Authorize the API request by sending the X-Auth-Token, retrieved when logging in, as a header.
                request.Method = method.Method;
                request.Accept = "application/json";
                request.KeepAlive = true;
                request.Headers["X-Auth-Token"] = _authToken;

                // Set  a boundary delimiter and the content type
                string boundaryDelimiter = string.Format("----------{0}", DateTime.Now.Ticks.ToString("x"));
                request.ContentType = string.Format("multipart/form-data; boundary={0}", boundaryDelimiter);

                string boundaryLine = string.Format("\r\n--{0}\r\n", boundaryDelimiter);
                string closingBoundaryLine = string.Format("\r\n--{0}--\r\n", boundaryDelimiter);

                var profile = new {
                    doc_profile = new {
                        name = docName,
                        extension = ext,
                    },
                };

                var cleanprofile = new {
                    doc_profile = new {
                    },
                };

                // text buffer
                StringBuilder sb = new StringBuilder();

                // Create profile payload:
                //  - empty line
                //  - boundary delimiter line
                //  - headers lines 
                //  - empty line
                //  - body (JSON profile)
                sb.Append(boundaryLine);
                sb.Append("Content-Disposition: form-data;name=\"profile\";Content-Type=\"application/json\" \r\n");
                sb.Append("charset=utf-8 \r\n");
                sb.Append("Content-Transfer-Encoding: 8bit \r\n");
                sb.Append("\r\n");

                if (payload is DocumentUploadRequest) {
                    sb.Append(JsonConvert.SerializeObject(profile));
                }
                else {
                    sb.Append(JsonConvert.SerializeObject(cleanprofile));
                }

                // Create the upload file payload
                //  - empty line
                //  - boundary delimiter line
                //  - headers lines
                //  - empty line
                //  - body (file content)
                //  - closing boundary line
                sb.Append(boundaryLine);
                sb.Append(string.Format("Content-Disposition: form-data;name =\"myFile\";filename=\"{0}\" \r\n", docName));
                sb.Append("Content-Type: application/octet-stream;charset=ISO-8859-1 \r\n");
                sb.Append("\r\n");

                // Write
                using (MemoryStream memoryStream = new MemoryStream()) {
                    // convert the text buffer (string) to bytes
                    byte[] toByte = Encoding.ASCII.GetBytes(sb.ToString());

                    // Write those bytes to the memory stream
                    memoryStream.Write(toByte, 0, toByte.Length);

                    // Then read & write the file content (bytes)
                    using (FileStream fileStream = new FileStream((stream as FileStream).Name, FileMode.Open, FileAccess.Read)) {
                        byte[] buffer = new byte[4096];
                        int count;
                        while ((count = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                            memoryStream.Write(buffer, 0, count);
                    }

                    // Then write the closing boundary line
                    toByte = Encoding.ASCII.GetBytes(closingBoundaryLine);
                    memoryStream.Write(toByte, 0, toByte.Length);
                    memoryStream.Flush();

                    // copy everything in memory stream to the request stream
                    request.ContentLength = memoryStream.Length;
                    using (Stream requestStream = request.GetRequestStream()) {
                        memoryStream.WriteTo(requestStream);
                     }
                }

                // Send the POST request (upload) and save the response to a variable.
                var response = new HttpResponseMessage(HttpStatusCode.OK);

                using (var responseApi = (HttpWebResponse)request.GetResponse()) {
                    if (response.StatusCode != System.Net.HttpStatusCode.OK) {
                        content = response.StatusCode.ToString();
                    }
                    using (var reader = new StreamReader(responseApi.GetResponseStream())) {
                        var objText = reader.ReadToEnd();
                        response.Content = new StringContent(objText, Encoding.UTF8, "application/json");
                    }
                }

                return response;
            }
            catch (HttpRequestException hre) {
                var error = JsonConvert.DeserializeObject<iManageApiError>(content);
                throw new iManageApiException(error, hre);
            }
        }

        #region URL generation
        delegate string UriGenerator(params string?[] pars);
        Dictionary<string, UriGenerator> UrlCache = new Dictionary<string, UriGenerator>();
        UriGenerator Url([CallerMemberName] string? caller = null) {
            if (!UrlCache.TryGetValue(caller!, out var generator)) {
                var mi = GetType().GetMethod(caller, BindingFlags.Instance | BindingFlags.NonPublic);
                var attr = mi.GetCustomAttribute<iManageUrlSuffixAttribute>();
                var formats = (string[]?)attr?.Pars?.Clone();

                string Generator(string?[] pars) {
                    if (formats == null)
                        return $"{_prefix}/{string.Join(@"/", pars)}";
                    else {
                        var i = Array.FindIndex(pars, p => p != null);
                        if (i == -1) {
                            var nPars = pars.Length;
                            var nFormats = formats.Length;
                            if (nFormats > nPars) return $"{_prefix}/{string.Format(formats[nPars], pars)}";
                            else return string.Empty;
                        }
                        else return $"{_prefix}/{string.Format(formats[i], pars)}";
                    }
                }
                generator = UrlCache[caller!] = Generator;
            }
            return generator;
        }

        string BuildQuery(int pageIndex, int pageSize) {
            var queryParts = new List<string>();
            if (pageIndex < 0) throw new ArgumentException("Value must be non negative", nameof(pageIndex));
            if (pageSize < 1 || pageSize > 9999) throw new ArgumentException("Value must be between 1 and 9999", nameof(pageSize));
            if (pageIndex > 0) queryParts.Add($"offset={pageIndex * pageSize}");
            queryParts.Add($"limit={pageSize}");
            queryParts.Add($"total=true");
            var query = string.Join("&", queryParts);
            return query;
        }
        #endregion

        #region Content Handling
        static async Task<T> DeserializeAsync<T>(HttpContent content) {
            JObject jo = JObject.Parse(await content.ReadAsStringAsync());
            var retType = typeof(T);
            if(jo.SelectToken("overflow") != null && jo.SelectToken("data") != null) {
                return jo.ToObject<T>()!;
            }
            else if (retType.IsGenericType && retType.GetGenericTypeDefinition() == typeof(ValueTuple<,>)) {
                var types = retType.GetGenericArguments();
                var collection = (jo.SelectToken("data.results") ?? jo.SelectToken("data"))!.ToObject(types[0]);
                var total = (int)jo.SelectToken("total_count")!;
                object[] values = new object[] { collection!, total };
                return (T)retType.GetConstructor(types)!.Invoke(values)!;
            }
            return jo.SelectToken("data")!.ToObject<T>()!;
        }

        static HttpContent Serialize(object payload) => ToJsonContent(payload);
        static HttpContent Serialize<T>(object payload, [CallerMemberName] string? caller = null) => ToJsonContent<T>(payload, caller);
        static async Task<HttpContent> SerializeAsync<T>(object payload, Stream stream, [CallerMemberName] string? caller = null) {
            HttpContent jsonContent = iManageApiHandler.ToJsonContent<T>(payload, caller);
            StreamContent streamContent = new StreamContent(stream);
            byte[] content = await streamContent.ReadAsByteArrayAsync();
            ByteArrayContent byteContent = new ByteArrayContent(content);
            content = (byte[])null;
            MultipartFormDataContent formContent = new MultipartFormDataContent("----WebKitFormBoundaryIVYxOCuSnOuyAHO9");
            formContent.Headers.ContentType.MediaType = "multipart/form-data";
            formContent.Add(jsonContent, "profile");
            formContent.Add((HttpContent)byteContent, "file");
            return (HttpContent)formContent;
        }
        
        static HttpContent ToJsonContent<T>(object payload, string? caller) {
            var contractResolverRequired = payload.GetType().Equals(typeof(T));
            var jsonSerializerSettings = contractResolverRequired ? _jsonSerializerSettingsWithContract[(typeof(T), caller)] : _jsonSerializerSettingsWitoutContract;
            return ToJsonContent(payload, jsonSerializerSettings);
        }
        
        static HttpContent ToJsonContent(object payload, JsonSerializerSettings? settings = null) {
            var json = JsonConvert.SerializeObject(payload, payload.GetType(), settings ?? _jsonSerializerSettingsWitoutContract);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
        #endregion

        #region Helpers
        [AttributeUsage(AttributeTargets.Method, Inherited = false)]
        class iManageUrlSuffixAttribute : Attribute {
            public string[] Pars { get; }
            public iManageUrlSuffixAttribute(params string[] pars) => Pars = pars;
        }
        string UnwindExceptionMessage(Exception x) {
            var sb = new StringBuilder();
            do {
                sb.Append(x.Message);
                x = x.InnerException;
            }
            while (x != null && sb.Append("|") is StringBuilder);
            return sb.ToString();
        }

        class JsonSettings {
            JsonSerializerSettings _jsonSerializerSettings;
            public JsonSettings(IContractResolver contractResolver) =>
                _jsonSerializerSettings = new JsonSerializerSettings {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = contractResolver,
                };
            public JsonSettings() => _jsonSerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

            public static implicit operator JsonSerializerSettings(JsonSettings settings) => settings._jsonSerializerSettings;
        }

        static readonly JsonSettings _jsonSerializerSettingsWitoutContract = new JsonSettings();

        static Dictionary<(Type domainType, string? operation), JsonSettings> _jsonSerializerSettingsWithContract =
            new Dictionary<(Type domainType, string? operation), JsonSettings> {
                { (typeof(Workspace), nameof(PostAsync)), new JsonSettings(ApiWorkspaceCreateRequestContractResolver.Instance) },
                { (typeof(Workspace), nameof(PatchAsync)), new JsonSettings(ApiWorkspaceUpdateRequestContractResolver.Instance) },
                { (typeof(Folder), nameof(PostAsync)), new JsonSettings(ApiFolderCreateRequestContractResolver.Instance) },
                { (typeof(Folder), nameof(PatchAsync)), new JsonSettings(ApiFolderUpdateRequestContractResolver.Instance) },
                { (typeof(Document), nameof(PatchAsync)), new JsonSettings(ApiDocumentUpdateRequestContractResolver.Instance) },
                { (typeof(Template), nameof(PostAsync)), new JsonSettings(ApiTemplateCreateRequestContractResolver.Instance) },
                { (typeof(CustomItem), nameof(PostAsync)), new JsonSettings(ApiCustomItemUpdateRequestContractResolver.Instance) },
                { (typeof(CustomItem), nameof(PatchAsync)), new JsonSettings(ApiCustomItemUpdateRequestContractResolver.Instance) },
        };

        #endregion

        #region Internals
        static readonly HttpClient _httpClient = new HttpClient();
        const string _boundary = "----WebKitFormBoundary7MA4YWxkTrZu0gW"; //From Postman examples
        readonly string _authToken;
        readonly string _apiEndpointUri;
        internal readonly string Library;
        internal int CustomerId { get; private set; }
        string? _prefix;

        internal static async Task<iManageApiHandler> Create(string authToken, string apiEndpointUri, string apiVersion, string library) {
            var instance = new iManageApiHandler(authToken, apiEndpointUri, library);
            instance.CustomerId = await GetCustomerIdAsync();
            instance._prefix = $"{apiVersion}/customers/{instance.CustomerId}";
            return instance;

            //helpers
            async Task<int> GetCustomerIdAsync() {
                var response = await instance.QueryAsync(() => {
                    var req = new HttpRequestMessage(HttpMethod.Get, apiEndpointUri);
                    req.Headers.Add("X-Auth-Token", authToken);
                    return _httpClient.SendAsync(req);
                });
                return JToken.Parse(await response.Content.ReadAsStringAsync()).SelectToken("data.user.customer_id")!.ToObject<int>();
            }
        }

        internal iManageApiHandler(string authToken, string apiEndpointUri, string library) {
            _authToken = authToken;
            _apiEndpointUri = apiEndpointUri;
            Library = library;
        }
        #endregion
    }
}
