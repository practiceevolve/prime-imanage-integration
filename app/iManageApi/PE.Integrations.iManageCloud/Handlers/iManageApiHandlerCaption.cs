using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {

        [iManageUrlSuffix(@"libraries/{0}/captions/{1}?language=en-gb")]
        internal async Task<Caption[]> GetCaptionAsync(string fieldName, string library) => await GetAsync<Caption[]>(Url()(library, fieldName));

    }
}
