using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {

        [iManageUrlSuffix(@"libraries/{0}/templates")]
        internal async Task<Template> CreateTemplateAsync(Template template, string? library) => await PostAsync<Template>(Url()(library), template);
        
        [iManageUrlSuffix(@"libraries/{0}/templates/{1}")]
        internal async Task DeleteTemplateAsync(string id, string? library) => await DeleteAsync(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/templates?id={1}")]
        internal async Task<Template> GetTemplateAsync(string id, string? library) => await GetAsync<Template>(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/templates", "templates")]
        internal async Task<IPagedList<Template>> GetTemplatesAsync(int pageIndex, int pageSize, string? library) => await GetPageAsync<Template>(pageIndex, pageSize, Url()(library));

        [iManageUrlSuffix(@"libraries/{0}/templates", "templates")]
        internal async Task<List<Template>> GetTemplatesListAsync(int pageIndex, int pageSize, string? library) => await GetListAsync<Template>(pageIndex, pageSize, Url()(library));

    }
}
