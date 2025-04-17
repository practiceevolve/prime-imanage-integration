using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PE.Common.DataTypes;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud.Handlers {
    partial class iManageApiHandler {
        [iManageUrlSuffix(@"libraries/{0}/folders/{1}/documents")]
        internal async Task<Document> UploadDocumentToFolderAsync(DocumentUploadRequest request, string folderId, Stream stream, string library) {
            EnsureContentAvailable(stream);
            return await PostAsync<Document>(Url()(library, folderId), request, stream);
        }

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}")]
        internal async Task<Document> GetDocumentAsync(string id, string library) => await GetAsync<Document>(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/download")]
        internal async Task<Stream> DownloadDocumentAsync(string id, string library) => await GetAsync(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}")]
        internal async Task DeleteDocumentVersionAsync(string id, string library) => await DeleteAsync(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}")]
        public async Task DeleteDocumentAsync(string id, string library) {
            var versions = await GetDocumentVersionsAsync(id, library);
            await Task.WhenAll(versions.Select(version => DeleteDocumentVersionAsync(version.Id, library)));
        }

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}/documents", @"libraries/{0}/documents", "documents")]
        internal async Task<IPagedList<Document>> GetDocumentsAsync(int pageIndex, int pageSize, string? folderId, string? library) => await GetPageAsync<Document>(pageIndex, pageSize, Url()(library, folderId));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}")]
        internal async Task<Document> UpdateDocumentAsync(Document document) => await PatchAsync<Document>(Url()(document.Database, document.Id), document);

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/lock")]
        internal async Task ApplyDocumentLockAsync(string id, DocumentLockRequest request, string library) => await PostAsync(Url()(library, id), request);

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/lock")]
        internal async Task RemoveDocumentLockAsync(string id, string library) => await DeleteAsync(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/checkout")]
        internal async Task<Stream> CheckoutDocumentAsync(string id, DocumentCheckOutRequest request, string library) => await PostAsync(Url()(library, id), request);

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/file")]
        internal async Task<Document> UpdateDocumentVersionAsync(string id, DocumentUpdateVersionRequest request, Stream stream, string library) {
            EnsureContentAvailable(stream);
            return await PutAsync<Document>(Url()(library, id), request, stream);
        }

        [iManageUrlSuffix(@"libraries/{0}/documents/checked-out", "documents/checked-out")]
        internal async Task<IPagedList<Document>> GetCheckedOutDocumentsAsync(int pageIndex, int pageSize, string? library) => await GetPageAsync<Document>(pageIndex, pageSize, Url()(library));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/versions")]
        internal async Task<Document> UploadNewDocumentVersionAsync(string id, DocumentUploadNewVersionRequest request, Stream stream, string library) {
            EnsureContentAvailable(stream);
            return await PostAsync<Document>(Url()(library, id), request, stream);
        }

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/versions")]
        internal async Task<Document[]> GetDocumentVersionsAsync(string id, string library) => await GetAsync<Document[]>(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/history")]
        internal async Task<IPagedList<DocumentHistory>> GetDocumentHistoryAsync(int pageIndex, int pageSize, string id, string library) => await GetPageAsync<DocumentHistory>(pageIndex, pageSize, Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/history/activities")]
        internal async Task<DocumentActivity[]> GetDocumentActivityHistoryAsync(string id, string library) => await GetAsync<DocumentActivity[]>(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/history/users")]
        internal async Task<DocumentUser[]> GetDocumentUserHistoryAsync(string id, string library) => await GetAsync<DocumentUser[]>(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/documents/search")]
        internal async Task<DocumentSearchResponse> SearchDocumentsAsync(DocumentSearchRequest request, string library) => await PostAsync<DocumentSearchResponse>(Url()(library), request);

        [iManageUrlSuffix(@"libraries/{0}/trash-bin/documents")]
        internal async Task<Document[]> GetTrashBinDocumentAsync(string documentNumber, string library) => await GetAsync<Document[]>(Url()(library), $"document_number={documentNumber}");

        [iManageUrlSuffix(@"libraries/{0}/trash-bin/documents/{1}/restore")]
        internal async Task RestoreTrashBinDocumentAsync(string id, TrashBinDocumentsRestorePostRequest request, string library) => await PostAsync(Url()(library,id), request);

        [iManageUrlSuffix(@"libraries/{0}/trash-bin/documents/{1}")]
        internal async Task DeleteTrashBinDocumentAsync(string id, string library) => await DeleteAsync(Url()(library, id));

        [iManageUrlSuffix(@"libraries/{0}/folders/{1}/documents/{2}/move")]
        internal async Task MoveDocumentAsync(string folderId, string id, DocumentMoveRequest request, string library) => await PostAsync(Url()(library, folderId, id), request);

        //internal async Task<Folder> DownloadDocumentWithFilenameAsync() => throw new NotImplementedException();

        [iManageUrlSuffix(@"libraries/{0}/documents/{1}/operations")]
        internal async Task<object> GetDocumentPermissionsAsync(string id, string library) => await GetAsync<object>(Url()(library, id));

        [iManageUrlSuffix(@"/libraries/{0}/classes")]
        internal async Task<DocumentClass[]> GetDocumentClassesAsync(string library) => await GetAsync<DocumentClass[]>(Url()(library));

        [iManageUrlSuffix(@"/libraries/{0}/classes/{1}/subclasses")]
        internal async Task<DocumentSubclass[]> GetDocumentSubclassesAsync(string aliasId, string library) => await GetAsync<DocumentSubclass[]>(Url()(library, aliasId));


        #region Helpers
        void EnsureContentAvailable(Stream stream) {
            string? error = null;
            if (stream == null) error = "The stream is null";
            else if (!stream.CanRead) error = "The stream cannot be read";
            else if (stream.Position > 0) error = $"The stream must be freshly created (position = {stream.Position})";

            if (error != null) throw new InvalidOperationException(error);
        }
        #endregion
    }
}
