using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {
        [iManageUrlSuffix(@"libraries/{0}/workspaces/{1}/folders")]
        internal async Task<Folder> CreateFolderAsync(Folder folder, string id, string library) => await PostAsync<Folder>(Url()(library, id), folder);

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}")]
        internal async Task DeleteFolderAsync(string id, string? library) => await DeleteAsync(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}")]
        internal async Task<Folder> GetFolderAsync(string id, string? library) => await GetAsync<Folder>(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/folders", "folders")]
        internal async Task<IPagedList<Folder>> GetFoldersAsync(int pageIndex, int pageSize, string library) => await GetPageAsync<Folder>(pageIndex, pageSize, Url()(library));

        [iManageUrlSuffix(@"libraries/{0}/folders/search")]
        internal async Task<FolderSearchResponse> SearchFoldersAsync(FolderSearchRequest request, string library ) => await PostAsync<FolderSearchResponse>(Url()(library),request);

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}")]
        internal async Task<Folder> UpdateFolderAsync(Folder folder) => await PatchAsync<Folder>(Url()(folder.Database, folder.Id), folder);

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}/children")] //TO:Test missing
        internal async Task<IPagedList<FolderChild>> GetFolderChildrenAsync(int pageIndex, int pageSize, string id, string library) => await GetPageAsync<FolderChild>(pageIndex, pageSize, Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}/subfolders")]
        internal async Task<Folder> CreateSubfolderAsync(Folder folder, string parentId, string library) => await PostAsync<Folder>(Url()(library, parentId), folder);

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}/move")]
        internal async Task MoveFolderAsync(string id, FolderMoveRequest request, string library) => await PostAsync(Url()(library, id), request);

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}/operations")]
        internal async Task<object> GetFolderPermissionsAsync(string id, string? library) => await GetAsync<object>(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}/name-value-pairs")]
        internal async Task<object> GetFolderPropertiesAsync(string id, string? library) => await GetAsync<object>(Url()(library, id));
    }
}
