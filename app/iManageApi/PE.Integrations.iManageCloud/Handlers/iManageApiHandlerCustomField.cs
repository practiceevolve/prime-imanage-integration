using System.Net.Http;
using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {
        [iManageUrlSuffix(@"libraries/{0}/customs/{1}")]
        internal async Task CreateCustomFieldValueAsync(CustomItem customItem, string customTable, string library) => await PostAsyncVoid(Url()(library, customTable), customItem);

        [iManageUrlSuffix(@"libraries/{0}/customs/{1}/search")]
        internal async Task<CustomItem[]> GetCustomsAsync(string fieldName, string library) => await GetAsync<CustomItem[]>(Url()(library, fieldName));

        [iManageUrlSuffix(@"libraries/{0}/customs/{1}/{2}")]
        internal async Task<CustomItem> GetCustomFieldValueAsync(string customTable, string id, string library) => await GetAsync<CustomItem>(Url()(library, customTable, id));
        

        [iManageUrlSuffix(@"libraries/{0}/customs/{1}/{2}?parent_alias={3}")]
        internal async Task<CustomItem> GetCustomFieldParentAliasValueAsync(string customTable, string id, string library, string parentAlias) => await GetAsync<CustomItem>(Url()(library, customTable, id, parentAlias));
        

        [iManageUrlSuffix(@"libraries/{0}/customs/{1}/{2}")]
        internal async Task UpdateCustomFieldAsync(CustomItem customItem, string customTable, string library) => await PatchAsync<CustomItem>(Url()(library, customTable, customItem.Id), customItem);

        [iManageUrlSuffix(@"libraries/{0}/customs/{1}/{2}?parent_alias={3}")]
        internal async Task UpdateCustomFieldWithParentAsync(CustomItem customItem, string customTable, string id, string library, string parentAlias) => await PatchAsync<CustomItem>(Url()(library, customTable, id, parentAlias), customItem);


        [iManageUrlSuffix(@"libraries/{0}/customs/{1}/{2}")]
        internal async Task DeleteCustomFieldValueAsync(string customTable, string id, string library) => await DeleteAsync(Url()(library, customTable, id));
    }
}
