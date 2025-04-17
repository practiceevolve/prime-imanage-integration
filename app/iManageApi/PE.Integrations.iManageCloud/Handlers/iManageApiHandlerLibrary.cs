using System.Net.Http;
using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {

        [iManageUrlSuffix(@"libraries/{0}/operations")]
        internal async Task<object> GetLibraryPermissionsAsync(string? library) => await GetAsync<object>(Url()(library));
    }
}
