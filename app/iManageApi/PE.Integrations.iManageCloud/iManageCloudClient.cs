using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;
using PE.Integrations.iManageCloud.Handlers;

namespace PE.Integrations.iManageCloud {
    [Serializable]
    public class iManageCloudClient : IiManageCloudClient {
        public static string BuildTokenRequestUri(string host, bool useHttps = true) => $@"{(useHttps ? "https" : "http")}://{host}/auth/oauth2/token";

        public int CustomerId => _.CustomerId;
        
        #region Workspaces
        public virtual async Task<Workspace> CreateWorkspaceAsync(Workspace workspace, string library = _defaultLibrary) => await _.CreateWorkspaceAsync(__(workspace), ___(library));
        public virtual async Task DeleteWorkspaceAsync(string workspaceId, string library = _defaultLibrary) => await _.DeleteWorkspaceAsync(__(workspaceId), ___(library));
        public virtual async Task<Workspace> GetWorkspaceAsync(string workspaceId, string library = _defaultLibrary) => await _.GetWorkspaceAsync(__(workspaceId), ___(library));
        public virtual async Task<IPagedList<Workspace>> GetWorkspacesAsync(int pageIndex = 0, int pageSize = _defaultPageSize, string? library = null) => await _.GetWorkspacesAsync(pageIndex, pageSize, library);
        public virtual async Task<Workspace> UpdateWorkspaceAsync(Workspace workspace) => await _.UpdateWorkspaceAsync(__(workspace));
        public virtual async Task<IPagedList<WorkspaceChild>> GetWorkspaceChildrenAsync(string workspaceId, int pageIndex = 0, int pageSize = _defaultPageSize, string library = _defaultLibrary) => await _.GetWorkspaceChildrenAsync(pageIndex, pageSize, __(workspaceId), ___(library));
        public virtual async Task<object> GetWorkspacePermissionsAsync(string workspaceId, string library = _defaultLibrary) => await _.GetWorkspacePermissionsAsync(__(workspaceId), ___(library));
        #endregion

        #region Library
        public virtual async Task<object> GetLibraryPermissionsAsync(string library = _defaultLibrary) => await _.GetLibraryPermissionsAsync(___(library));
        #endregion

        #region Folders
        public virtual async Task<Folder> CreateFolderAsync(Folder folder, string workspaceId, string library = _defaultLibrary) => await _.CreateFolderAsync(folder, __(workspaceId), ___(library));
        public virtual async Task DeleteFolderAsync(string folderId, string library = _defaultLibrary) => await _.DeleteFolderAsync(__(folderId), ___(library));
        public virtual async Task<Folder> GetFolderAsync(string folderId, string library = _defaultLibrary) => await _.GetFolderAsync(__(folderId), ___(library));
        public virtual async Task<IPagedList<Folder>> GetFoldersAsync(int pageIndex = 0, int pageSize = _defaultPageSize, string library = _defaultLibrary) => await _.GetFoldersAsync(pageIndex, pageSize, ___(library));
        public virtual async Task<Folder> UpdateFolderAsync(Folder folder) => await _.UpdateFolderAsync(__(folder));
        public virtual async Task<Folder> CreateSubfolderAsync(Folder folder, string parentId, string library = _defaultLibrary) => await _.CreateSubfolderAsync(__(folder), __(parentId), ___(library));
        public virtual async Task<IPagedList<FolderChild>> GetFolderChildrenAsync(string folderId, int pageIndex = 0, int pageSize = _defaultPageSize, string library = _defaultLibrary) => await _.GetFolderChildrenAsync(pageIndex, pageSize, __(folderId), ___(library));
        public virtual async Task<FolderSearchResponse> SearchFoldersAsync(FolderSearchRequest request, string library = _defaultLibrary) => await _.SearchFoldersAsync(__(request), ___(library));
        public virtual async Task<DocumentSearchResponse> SearchDocumentsAsync(DocumentSearchRequest request, string library = _defaultLibrary) => await _.SearchDocumentsAsync(__(request), ___(library));
        public virtual async Task<object> GetFolderPermissionsAsync(string id, string? library) => await _.GetFolderPermissionsAsync(__(id), ___(library));
        public virtual async Task<object> GetFolderPropertiesAsync(string id, string? library) => await _.GetFolderPropertiesAsync(__(id), ___(library));
        #endregion

        #region Documents
        public virtual async Task<Document> UploadDocumentToFolderAsync(DocumentUploadRequest request, string folderId, Stream stream, string library = _defaultLibrary) => await _.UploadDocumentToFolderAsync(__(request), __(folderId), __(stream), ___(library));
        public virtual async Task<Document> GetDocumentAsync(string documentId, string library = _defaultLibrary) => await _.GetDocumentAsync(__(documentId), ___(library));
        public virtual async Task<Stream> DownloadDocumentAsync(string documentId, string library = _defaultLibrary) => await _.DownloadDocumentAsync(__(documentId), ___(library));
        public virtual async Task DeleteDocumentVersionAsync(string documentId, string library = _defaultLibrary) => await _.DeleteDocumentVersionAsync(__(documentId), ___(library));
        public virtual async Task DeleteDocumentAsync(string documentId, string library = _defaultLibrary) => await _.DeleteDocumentAsync(__(documentId), ___(library));
        public virtual async Task<IPagedList<Document>> GetDocumentsAsync(int pageIndex = 0, int pageSize = _defaultPageSize, string? folderId = null, string? library = null) {
            if(library == null && folderId != null) library = _defaultLibrary;
            return await _.GetDocumentsAsync(pageIndex, pageSize, folderId, library);
        }
        public virtual async Task<Document> UpdateDocumentAsync(Document document) => await _.UpdateDocumentAsync(__(document));
        public virtual async Task ApplyDocumentLockAsync(string documentId, DocumentLockRequest request, string library = _defaultLibrary) => await _.ApplyDocumentLockAsync(__(documentId), __(request), ___(library));
        public virtual async Task RemoveDocumentLockAsync(string documentId, string library = _defaultLibrary) => await _.RemoveDocumentLockAsync(__(documentId), ___(library));
        public virtual async Task<Stream> CheckoutDocumentAsync(string documentId, DocumentCheckOutRequest request, string library = _defaultLibrary) => await _.CheckoutDocumentAsync(__(documentId), __(request), ___(library));
        public virtual async Task<Document> UploadNewDocumentVersionAsync(string documentId, DocumentUploadNewVersionRequest request, Stream stream, string library = _defaultLibrary) => await _.UploadNewDocumentVersionAsync(__(documentId), __(request), __(stream), ___(library));
        public virtual async Task<Document[]> GetDocumentVersionsAsync(string documentId, string library = _defaultLibrary) => await _.GetDocumentVersionsAsync(__(documentId), ___(library));
        public virtual async Task<Document> UpdateDocumentVersionAsync(string documentId, DocumentUpdateVersionRequest request, Stream stream, string library = _defaultLibrary) => await _.UpdateDocumentVersionAsync(__(documentId), __(request), __(stream), ___(library));
        public virtual async Task<IPagedList<Document>> GetCheckedOutDocumentsAsync(int pageIndex = 0, int pageSize = _defaultPageSize, string? library = null) => await _.GetCheckedOutDocumentsAsync(pageIndex, pageSize, library);
        public virtual async Task<IPagedList<DocumentHistory>> GetDocumentHistoryAsync(string documentId, int pageIndex = 0, int pageSize = _defaultPageSize, string library = _defaultLibrary) => await _.GetDocumentHistoryAsync(pageIndex, pageSize, __(documentId), ___(library));
        public virtual async Task<DocumentActivity[]> GetDocumentActivityHistoryAsync(string documentId, string library = _defaultLibrary) => await _.GetDocumentActivityHistoryAsync(__(documentId), ___(library));
        public virtual async Task<DocumentUser[]> GetDocumentUserHistoryAsync(string documentId, string library = _defaultLibrary) => await _.GetDocumentUserHistoryAsync(__(documentId), ___(library));
        public virtual async Task<Document[]> GetTrashBinDocumentAsync(string documentNumber, string library = _defaultLibrary) => await _.GetTrashBinDocumentAsync(__(documentNumber), ___(library));
        public virtual async Task RestoreTrashBinDocumentAsync(string documentId, TrashBinDocumentsRestorePostRequest request, string library = _defaultLibrary) => await _.RestoreTrashBinDocumentAsync(__(documentId), request, ___(library));
        public virtual async Task DeleteTrashBinDocumentAsync(string documentId, string library = _defaultLibrary) => await _.DeleteTrashBinDocumentAsync(__(documentId), ___(library));
        public virtual async Task MoveDocumentAsync(string folderId, string documentId, DocumentMoveRequest request, string library = _defaultLibrary) => await _.MoveDocumentAsync(__(folderId), __(documentId), __(request), ___(library));
        public virtual async Task MoveFolderAsync(string id, FolderMoveRequest request, string library = _defaultLibrary) => await _.MoveFolderAsync(__(id), __(request), ___(library));
        public virtual async Task<object> GetDocumentPermissionsAsync(string id, string library) => await _.GetDocumentPermissionsAsync(__(id), ___(library));
        public virtual async Task<DocumentClass[]> GetDocumentClassesAsync(string library) => await _.GetDocumentClassesAsync(__(library));
        public virtual async Task<DocumentSubclass[]> GetDocumentSubclassesAsync(string aliasId, string library) => await _.GetDocumentSubclassesAsync(__(aliasId), __(library));

        #endregion

        #region Custom Fields
        public virtual async Task CreateCustomFieldValueAsync(CustomItem customItem, string customTable, string library = _defaultLibrary) => await _.CreateCustomFieldValueAsync(customItem, __(customTable), ___(library));
        public virtual async Task<CustomItem> GetCustomFieldValueAsync(string customTable, string id, string library = _defaultLibrary) => await _.GetCustomFieldValueAsync(__(customTable), __(id), ___(library));
        public virtual async Task<CustomItem[]> GetCustomsAsync(string fieldName, string library = _defaultLibrary) => await _.GetCustomsAsync(__(fieldName), ___(library));
        public virtual async Task<CustomItem> GetCustomFieldParentAliasValueAsync(string customTable, string id, string parentAlias, string library = _defaultLibrary) => await _.GetCustomFieldParentAliasValueAsync(__(customTable), __(id), ___(library), __(parentAlias));
        public virtual async Task DeleteCustomFieldValueAsync(string customTable, string id, string library = _defaultLibrary) => await _.DeleteCustomFieldValueAsync(__(customTable), __(id), ___(library));
        public virtual async Task UpdateCustomFieldAsync(CustomItem customItem, string customTable, string library = "ACTIVE") => await _.UpdateCustomFieldAsync(customItem, __(customTable), ___(library));
        public virtual async Task UpdateCustomFieldWithParentAsync(CustomItem customItem, string customTable, string id, string parentAlias, string library = _defaultLibrary) => await _.UpdateCustomFieldWithParentAsync(customItem, __(customTable), __(id), ___(library), __(parentAlias));

        #endregion

        #region Caption
        public virtual async Task<Caption[]> GetCaptionAsync(string fieldName, string library = "ACTIVE") => await _.GetCaptionAsync(__(fieldName), ___(library));
        #endregion

        #region Forms
        public virtual async Task<object> GetDocumentVisibleFieldsAsync(string library) => await _.GetDocumentVisibleFieldsAsync(___(library));
        #endregion

        #region Users
        public virtual async Task<List<User>> GetUsersAsync(int pageIndex = 0, int pageSize = _defaultPageSize, string library = _defaultLibrary) => await _.GetUsersAsync(pageIndex, pageSize, library);
        #endregion

        #region Internals
        iManageApiHandler? _;
        const int _defaultPageSize = 25;
        const string _defaultLibrary = "ACTIVE";

        T __<T>(T t) {
            if(t == null) throw new ArgumentException("Argument cannot be null");
            return t;
        }

        string ___(string library) {
            return string.IsNullOrEmpty(_?.Library) ? library : (library == _defaultLibrary)?_.Library:library;            
        }

        public class iManageCloudClientOptions {
            public string? AutoToken { get; set; }
            public string? ApiEndpointUri { get; set; }
            public string? ApiVersion { get; set; }
            public string? Library { get; set; }
        }
        public class Builder {
            Action<iManageCloudClientOptions> _configurator;
            public Builder(Action<iManageCloudClientOptions> configurator) => _configurator = configurator;
            public async Task<IiManageCloudClient> Build() {
                var options = new iManageCloudClientOptions { ApiVersion = "v2" };
                _configurator(options);
                var ret = new iManageCloudClient();
                ret._ = await iManageApiHandler.Create(options.AutoToken!, options.ApiEndpointUri!, options.ApiVersion, options.Library!);
                return ret;
            }
        }
        #endregion

        #region Templates
        public virtual async Task<Template> CreateTemplateAsync(Template template, string library = _defaultLibrary) => await _.CreateTemplateAsync(__(template), ___(library));
        public virtual async Task<Template> GetTemplateAsync(string templateId, string library = _defaultLibrary) => await _.GetTemplateAsync(__(templateId), ___(library));
        public virtual async Task<IPagedList<Template>> GetTemplatesAsync(int pageIndex = 0, int pageSize = _defaultPageSize, string library = _defaultLibrary) => await _.GetTemplatesAsync(pageIndex, pageSize, library);
        public virtual async Task DeleteTemplateAsync(string templateId, string library = _defaultLibrary) => await _.DeleteTemplateAsync(__(templateId), ___(library));
        public virtual async Task<List<Template>> GetTemplatesListAsync(int pageIndex = 0, int pageSize = _defaultPageSize, string library = _defaultLibrary) => await _.GetTemplatesListAsync(pageIndex, pageSize, library);
        #endregion
    }

    public interface IiManageCloudClient {
        int CustomerId { get; }
        Task<Stream> CheckoutDocumentAsync(string documentId, DocumentCheckOutRequest request, string library = "ACTIVE");
        Task<Folder> CreateFolderAsync(Folder folder, string workspaceId, string library = "ACTIVE");
        Task DeleteFolderAsync(string folderId, string library = "ACTIVE");
        Task<Folder> CreateSubfolderAsync(Folder folder, string parentId, string library = "ACTIVE");
        Task<Workspace> CreateWorkspaceAsync(Workspace workspace, string library = "ACTIVE");
        Task DeleteDocumentAsync(string documentId, string library = "ACTIVE");
        Task DeleteDocumentVersionAsync(string documentId, string library = "ACTIVE");
        Task DeleteWorkspaceAsync(string workspaceId, string library = "ACTIVE");
        Task<Stream> DownloadDocumentAsync(string documentId, string library = "ACTIVE");
        Task<IPagedList<Document>> GetCheckedOutDocumentsAsync(int pageIndex = 0, int pageSize = 25, string? library = null);
        Task<Document[]> GetDocumentVersionsAsync(string documentId, string library = "ACTIVE");
        Task<DocumentActivity[]> GetDocumentActivityHistoryAsync(string documentId, string library = "ACTIVE");
        Task<Document> GetDocumentAsync(string documentId, string library = "ACTIVE");
        Task<IPagedList<DocumentHistory>> GetDocumentHistoryAsync(string documentId, int pageIndex = 0, int pageSize = 25, string library = "ACTIVE");
        Task<IPagedList<Document>> GetDocumentsAsync(int pageIndex = 0, int pageSize = 25, string? folderId = null, string? library = null);
        Task<DocumentUser[]> GetDocumentUserHistoryAsync(string documentId, string library = "ACTIVE");
        Task<Folder> GetFolderAsync(string folderId, string library = "ACTIVE");
        Task<IPagedList<FolderChild>> GetFolderChildrenAsync(string folderId, int pageIndex = 0, int pageSize = 25, string library = "ACTIVE");
        Task<IPagedList<Folder>> GetFoldersAsync(int pageIndex = 0, int pageSize = 25, string library = "ACTIVE");
        Task<Workspace> GetWorkspaceAsync(string workspaceId, string library = "ACTIVE");
        Task<IPagedList<WorkspaceChild>> GetWorkspaceChildrenAsync(string workspaceId, int pageIndex = 0, int pageSize = 25, string library = "ACTIVE");
        Task<object> GetWorkspacePermissionsAsync(string workspaceId, string library = "ACTIVE");
        Task<IPagedList<Workspace>> GetWorkspacesAsync(int pageIndex = 0, int pageSize = 25, string? library = null);
        Task<object> GetLibraryPermissionsAsync(string library = "ACTIVE");
        Task<Template> CreateTemplateAsync(Template template, string library = "ACTIVE");
        Task<Template> GetTemplateAsync(string templateId, string library = "ACTIVE");
        Task DeleteTemplateAsync(string templateId, string library = "ACTIVE");
        Task<IPagedList<Template>> GetTemplatesAsync(int pageIndex = 0, int pageSize = 25, string library = "ACTIVE");
        Task<List<Template>> GetTemplatesListAsync(int pageIndex = 0, int pageSize = 25, string library = "ACTIVE");
        Task ApplyDocumentLockAsync(string documentId, DocumentLockRequest request, string library = "ACTIVE");
        Task RemoveDocumentLockAsync(string documentId, string library = "ACTIVE");
        Task<Document> UpdateDocumentAsync(Document document);
        Task<Document> UpdateDocumentVersionAsync(string documentId, DocumentUpdateVersionRequest request, Stream stream, string library = "ACTIVE");
        Task<Folder> UpdateFolderAsync(Folder folder);
        Task<Workspace> UpdateWorkspaceAsync(Workspace workspace);
        Task<Document> UploadDocumentToFolderAsync(DocumentUploadRequest request, string folderId, Stream stream, string library = "ACTIVE");
        Task<Document> UploadNewDocumentVersionAsync(string documentId, DocumentUploadNewVersionRequest request, Stream stream, string library = "ACTIVE");
        Task CreateCustomFieldValueAsync(CustomItem customItem, string customTable, string library = "ACTIVE");
        Task UpdateCustomFieldAsync(CustomItem customItem, string customTable, string library = "ACTIVE");
        Task UpdateCustomFieldWithParentAsync(CustomItem customItem, string customTable, string id, string parentAlias, string library = "ACTIVE");
        Task<CustomItem> GetCustomFieldValueAsync(string customTable, string id, string library = "ACTIVE");
        Task<CustomItem[]> GetCustomsAsync(string fieldName, string library = "ACTIVE");
        Task<Caption[]> GetCaptionAsync(string fieldName, string library = "ACTIVE");
        Task<object> GetDocumentVisibleFieldsAsync(string library = "ACTIVE");
        Task<List<User>> GetUsersAsync(int pageIndex = 0, int pageSize = 25, string library = "ACTIVE");
        Task<CustomItem> GetCustomFieldParentAliasValueAsync(string customTable, string id, string parentAlias, string library = "ACTIVE");
        Task DeleteCustomFieldValueAsync(string customTable, string id, string library = "ACTIVE");
        Task<FolderSearchResponse> SearchFoldersAsync(FolderSearchRequest request, string library = "ACTIVE");
        Task<DocumentSearchResponse> SearchDocumentsAsync(DocumentSearchRequest request, string library = "ACTIVE");
        Task<Document[]> GetTrashBinDocumentAsync(string documentNumber, string library = "ACTIVE");
        Task RestoreTrashBinDocumentAsync(string documentId, TrashBinDocumentsRestorePostRequest request, string library = "ACTIVE");
        Task DeleteTrashBinDocumentAsync(string documentId, string library = "ACTIVE");
        Task MoveDocumentAsync(string folderId, string documentId, DocumentMoveRequest request, string library = "ACTIVE");
        Task MoveFolderAsync(string id, FolderMoveRequest request, string library = "ACTIVE");
        Task<object> GetDocumentPermissionsAsync(string id, string library = "ACTIVE");
        Task<DocumentClass[]> GetDocumentClassesAsync(string library = "ACTIVE");
        Task<DocumentSubclass[]> GetDocumentSubclassesAsync(string aliasId, string library = "ACTIVE");
        Task<object> GetFolderPermissionsAsync(string id, string library = "ACTIVE");
        Task<object> GetFolderPropertiesAsync(string id, string library = "ACTIVE");

    }

}
