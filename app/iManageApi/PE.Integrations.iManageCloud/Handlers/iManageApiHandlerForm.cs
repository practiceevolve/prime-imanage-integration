using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {

        [iManageUrlSuffix(@"libraries/{0}/forms/visible-fields?form_type=edit_document")]
        internal async Task<object> GetDocumentVisibleFieldsAsync(string library) => await GetAsync<object>(Url()(library));

    }
}
