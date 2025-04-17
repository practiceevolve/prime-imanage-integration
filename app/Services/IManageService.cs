using Microsoft.Extensions.Diagnostics.HealthChecks;
using PE.Integrations.iManageCloud;
using System.Text;
using System.Text.Json;
using static PE.Integrations.iManageCloud.iManageCloudClient;
using PE.Integrations.iManageCloud.Domain;
using PE.Integrations.iManageCloud.ApiModel.ApiTypes;
using PE.Mk2.Integrations.IManage.Configurations;

namespace PE.Mk2.Integrations.IManage.Services
{
    public class IManageService(ILogger<IManageService> logger, IManageConfig config) : IAsyncInit
    {
        private HealthCheckResult _healthStatus;
        private IiManageCloudClient _iManageClient;
        private DateTime _iManageClientAuthExpiry;
        private string _iManageClientRefreshToken;

        public async Task EnsureClient(string clientNumber, string displayName)
        {
            await EnsureIManageClientOk();

            clientNumber = Sanitise(clientNumber);

            try
            {
                var custom1Field = await _iManageClient.GetCustomFieldValueAsync(nameof(Workspace.Custom1), clientNumber, config.Library);
            }
            catch (iManageApiException ex)
            {
                if (ex.ApiError.Error.Code == "NRC_NO_RECORD")
                {
                    var ci = new CustomItem();
                    ci.Id = clientNumber;
                    ci.Description = displayName;
                    ci.Enabled = true;

                    await _iManageClient.CreateCustomFieldValueAsync(ci, nameof(Workspace.Custom1), config.Library);
                }
            }

            return;
        }

        public async Task EnsureMatter(string clientNumber, string matterNumber, string matterTitle)
        {
            await EnsureIManageClientOk();

            clientNumber = Sanitise(clientNumber);
            matterNumber = Sanitise(matterNumber);

            // 1. Ensure Custom1 and Custom2 lookups exist for client and matter

            var custom1Field = await _iManageClient.GetCustomFieldValueAsync(nameof(Workspace.Custom1), clientNumber, config.Library);

            try
            {
                var custom2Field = await _iManageClient.GetCustomFieldParentAliasValueAsync(nameof(Workspace.Custom2), matterNumber, custom1Field.Id, config.Library);
            }
            catch (iManageApiException ex)
            {
                if (ex.ApiError.Error.Code == "NRC_NO_RECORD")
                {
                    var p = new ApiCustomItem.ParentClass();
                    p.Id = custom1Field.Id;

                    CustomItem customItem = new CustomItem()
                    {
                        Id = matterNumber,
                        Description = matterNumber,
                        Enabled = true,
                        Parent = p
                    };

                    await _iManageClient.CreateCustomFieldValueAsync(customItem, nameof(Workspace.Custom2), config.Library);
                }
                else
                {
                    throw;
                }
            }

            // 2. Ensure Workspace exists

            var workspace = await GetWorkspaceByClientAndMatter(clientNumber, matterNumber);

            if (workspace == null)
            {
                var newWorkspace = new Workspace(clientNumber, clientNumber);
                newWorkspace.Name = matterNumber;
                newWorkspace.Description = matterTitle;

                newWorkspace.DefaultSecurity = "Public";

                newWorkspace.Custom1 = clientNumber;
                newWorkspace.Custom2 = matterNumber;

                workspace = await _iManageClient.CreateWorkspaceAsync(newWorkspace, config.Library);
            }

            // 3. Ensure a folder exists with configured default folder name

            var folder = await GetFolderByName(workspace.Id, config.DefaultFolderName);

            if (folder == null)
            {
                var newFolder = new Folder();
                newFolder.Name = config.DefaultFolderName;
                _ = await _iManageClient.CreateFolderAsync(newFolder, workspace.Id, config.Library);
            }
        }

        public async Task UploadDocument(string documentId, string clientNumber, string matterNumber, string fileName, Stream fileContent)
        {
            await EnsureIManageClientOk();

            clientNumber = Sanitise(clientNumber);
            matterNumber = Sanitise(matterNumber);

            // 1. Get workspace and folder id's as required for doc upload

            var workspace = await GetWorkspaceByClientAndMatter(clientNumber, matterNumber);
            var folder = await GetFolderByName(workspace.Id, config.DefaultFolderName);

            // 2. Upload document

            string ext = "";
            if (fileName.Contains('.'))
            {
                ext = fileName.Substring(fileName.LastIndexOf('.') + 1);
                fileName = fileName.Substring(0, fileName.LastIndexOf('.'));
            }

            var document = await _iManageClient.UploadDocumentToFolderAsync(new DocumentUploadRequest(fileName, ext, clientNumber, matterNumber), folder.Id, fileContent, config.Library);
        }

        /// <summary>
        /// Change all illegal ids
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string Sanitise(string input) => input.Replace('/', '-');

        public async Task InitAsync()
        {
            try
            {
                var setupResult = await SetupIManageCloudClient(config);

                _iManageClient = setupResult.Item1;
                _iManageClientAuthExpiry = setupResult.Item2;
                _iManageClientRefreshToken = setupResult.Item3;

                _healthStatus = HealthCheckResult.Healthy();
            }
            catch (Exception ex)
            {
                _healthStatus = HealthCheckResult.Unhealthy($"Failed to setup IManage Client [{ex.Message}]");
                throw;
            }
        }

        private static async Task<(IiManageCloudClient, DateTime, string)> SetupIManageCloudClient(IManageConfig config)
        {
            try
            {
                // 1. get auth token

                string authToken = "";
                DateTime expires;
                string refreshToken = "";

                var request = new HttpRequestMessage(HttpMethod.Post, config.OAuthTokenUrl);
                request.Headers.Add("User-Agent", "PEPrime-IManage");
                request.Headers.Add("Accept", "application/json");
                var collection = new List<KeyValuePair<string, string>>
                {
                    new("grant_type","password"),
                    new("scope","admin"),
                    new("client_id", config.ClientId),
                    new("client_secret", config.ClientSecret),
                    new("username", config.AdminUserName),
                    new("password", config.AdminUserPassword),
                };
                var content = new FormUrlEncodedContent(collection);
                request.Content = content;

                using var tokenClient = new HttpClient();
                var response = await tokenClient.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    //logger.LogInformation("iManage token retrieved");
                    var tokenResponse = await JsonDocument.ParseAsync(response.Content.ReadAsStream());

                    authToken = tokenResponse.RootElement.GetProperty("access_token").GetString();
                    if (string.IsNullOrEmpty(authToken))
                        throw new Exception("unable to obtain access_token value from token response");

                    refreshToken = tokenResponse.RootElement.GetProperty("refresh_token").GetString();
                    if (string.IsNullOrEmpty(refreshToken))
                        throw new Exception("unable to obtain refreshToken value from token response");

                    var expires_in = tokenResponse.RootElement.GetProperty("expires_in").GetInt32();
                    //if (!int.TryParse(expires_in, out int expires_in_seconds))
                        //throw new Exception("unable to obtain expires_in value from token response");

                    expires = DateTime.Now.AddSeconds(expires_in - 5);
                }
                else
                {
                    throw new Exception(await response.Content.ReadAsStringAsync());
                }

                // 2. initialise imanage client using gained auth token

                Action<iManageCloudClientOptions> configurator = options =>
                {
                    options.ApiEndpointUri = config.ApiUrl;
                    options.AutoToken = authToken;
                    options.Library = config.Library;
                };

                var clientBuilder = new Builder(configurator);
                var client = await clientBuilder.Build();

                return (client, expires, refreshToken);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task EnsureIManageClientOk()
        {
            if (_iManageClientAuthExpiry < DateTime.Now)
            {
                try
                {
                    // iManage library doesn't appear to be able to use the refresh token
                    // so we are forced to create a new client instance

                    var setupResult = await SetupIManageCloudClient(config);

                    _iManageClient = setupResult.Item1;
                    _iManageClientAuthExpiry = setupResult.Item2;
                    _iManageClientRefreshToken = setupResult.Item3;

                    _healthStatus = HealthCheckResult.Healthy();
                }
                catch (Exception ex)
                {
                    _healthStatus = HealthCheckResult.Unhealthy($"Failed to refresh IManage Client [{ex.Message}]");
                    throw;
                }
            }
        }

        private async Task<Workspace?> GetWorkspaceByClientAndMatter(string clientCode, string matterCode)
        {
            Workspace? workspace = null;

            bool found = false;
            int pageIndex = 0;
            const int PageSize = 10;

            while (!found)
            {
                var workspaces = await _iManageClient.GetWorkspacesAsync(pageIndex, PageSize);

                workspace
                = workspaces.Rows.Where(workspace =>
                string.Equals(workspace.Custom1, clientCode, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(workspace.Custom2, matterCode, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

                found = workspace != null;

                if (found || !workspaces.Rows.Any())
                    break;

                pageIndex++;
            }

            return workspace;
        }

        private async Task<Folder?> GetFolderByName(string workspaceId, string folderName)
        {
            Folder? folder = null;

            bool found = false;
            int pageIndex = 0;
            const int PageSize = 10;

            while (!found)
            {
                var folders = await _iManageClient.GetFoldersAsync(pageIndex, PageSize);

                folder =
                folders.Rows.Where(folder =>
                folder.WorkspaceId == workspaceId &&
                string.Equals(folder.Name, folderName, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

                found = folder != null;

                if (found || !folders.Rows.Any())
                    break;

                pageIndex++;
            }

            return folder;
        }

        /// <summary>
        /// Validate IManage config
        /// </summary>
        /// <param name="iManageConfig"></param>
        /// <returns></returns>
        public async Task<IList<string>?> Validate(IManageConfig iManageConfig)
        {
            try
            {
                await SetupIManageCloudClient(iManageConfig);
                return null;
            }
            catch (Exception ex)
            {
                return [ex.Message];
            }
        }

        public HealthCheckResult CheckHealth()
        {
            return _healthStatus;
        }
    }
    public class IManageServiceFactory(ILogger<IManageService> logger)
    {
        private readonly Dictionary<string, IManageService> _tenants = [];

        public IManageService Create(string tenantAlias, IManageConfig config)
        {
            if (string.IsNullOrWhiteSpace(tenantAlias)) throw new ArgumentNullException(nameof(tenantAlias));
            if (!_tenants.TryGetValue(tenantAlias, out var service))
            {
                _tenants[tenantAlias] = service = new(logger, config);
            }
            return service;
        }

        public IManageService Get(string tenantAlias)
        {
            if (!_tenants.TryGetValue(tenantAlias, out var service))
            {
                throw new Exception($"Cannot find configuration for tenant {tenantAlias}");
            }
            return service;
        }
    }

}
