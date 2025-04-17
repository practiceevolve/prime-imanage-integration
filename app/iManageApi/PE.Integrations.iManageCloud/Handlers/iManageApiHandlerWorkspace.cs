using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {
        [iManageUrlSuffix(@"libraries/{0}/workspaces")]
        internal async Task<Workspace> CreateWorkspaceAsync(Workspace worspace, string? library) => await PostAsync<Workspace>(Url()(library), worspace);
        
        [iManageUrlSuffix(@"libraries/{0}/workspaces/{1}")]
        internal async Task DeleteWorkspaceAsync(string id, string? library) => await DeleteAsync(Url()(library, id));
        
        [iManageUrlSuffix(@"libraries/{0}/workspaces/{1}")]
        internal async Task<Workspace> GetWorkspaceAsync(string id, string? library) => await GetAsync<Workspace>(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/workspaces", "workspaces")]
        internal async Task<IPagedList<Workspace>> GetWorkspacesAsync(int pageIndex, int pageSize, string? library) => await GetPageAsync<Workspace>(pageIndex, pageSize, Url()(library));

        [iManageUrlSuffix(@"libraries/{0}/workspaces/{1}")]
        internal async Task<Workspace> UpdateWorkspaceAsync(Workspace workspace) => await PatchAsync<Workspace>(Url()(workspace.Database, workspace.Id), workspace);

        [iManageUrlSuffix(@"libraries/{0}/workspaces/{1}/children")]
        internal async Task<IPagedList<WorkspaceChild>> GetWorkspaceChildrenAsync(int pageIndex, int pageSize, string id, string? library) => await GetPageAsync<WorkspaceChild>(pageIndex, pageSize, Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/workspaces/{1}/operations")]
        internal async Task<object> GetWorkspacePermissionsAsync(string id, string? library) => await GetAsync<object>(Url()(library, id));

    }
}
