using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {

        [iManageUrlSuffix(@"libraries/{0}/users")]
        internal async Task<List<User>> GetUsersAsync(int pageIndex, int pageSize, string? library) => await GetListAsync<User>(pageIndex, pageSize, Url()(library));

    }
}
