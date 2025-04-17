using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using PE.Integrations.iManageCloud.ApiModel.ApiTypes;

namespace PE.Integrations.iManageCloud.Domain {
    public class Document : ApiDocument { }
    public class DocumentUploadRequest : ApiDocumentUploadRequest {
        public DocumentUploadRequest(string? name = null, string? extension = null, string? custom1 = null, string? custom2 = null) {
            if (string.IsNullOrWhiteSpace(custom1) && string.IsNullOrWhiteSpace(extension)) {
                extension = Path.GetExtension(name);
                if (extension == null) throw new ArgumentException("At last one of type and extension must have a significant value, or name must include the extension");
                if (extension.Equals(string.Empty)) custom1 = "unspecified";
                else extension = extension.Split('.')[1];
                name = Path.GetFileNameWithoutExtension(name);
            }

            if (!string.IsNullOrEmpty(custom1)) {
                this.Custom1 = custom1;
            }

            if (!string.IsNullOrEmpty(custom2)) {
                this.Custom2 = custom2;
            }

            this.WarningsForRequiredAndDisabledFields = new bool?(false);
            this.DocProfile = new ApiDocumentUploadRequest.DocProfileClass() {
                Name = name,
                Type = string.Empty,
                Extension = extension
            };
        }
    }

    public class DocumentUploadNewVersionRequest : ApiDocumentUploadNewVersionRequest {
        public DocumentUploadNewVersionRequest() {
            DocProfile = new DocProfileClass();
        }
    }
    public class DocumentUpdateVersionRequest : ApiDocumentUpdateVersionRequest {
        public DocumentUpdateVersionRequest() {
            DocProfile = new DocProfileClass();
        }
    }

    public class DocumentCheckOutRequest : ApiDocumentCheckoutRequest {
        public DocumentCheckOutRequest(string application) : base() { Appname = application; }
    }
    public class DocumentLockRequest : ApiDocumentLockRequest {
        public DocumentLockRequest() : base() { }
    }
    public class DocumentHistory : ApiDocumentHistory { }
    public class DocumentActivity : ApiDocumentActivity { }
    public class DocumentUser : ApiDocumentUser { }

    [Serializable]
    public class DocumentClass: ApiDocumentClass { }

    [Serializable]
    public class DocumentSubclass : ApiDocumentSubclass { }
    public class DocumentSearchRequest : ApiDocumentSearchRequest { }
    public class DocumentSearchResponse {
        public Document[] Data { get; set; }
        public bool Overflow { get; set; }
    }

    public class DocumentSearchFilter : DocumentSearchRequest.FiltersClass { }
    public class TrashBinDocumentsRestorePostRequest : ApiTrashBinDocumentsRestorePostRequest {
        public TrashBinDocumentsRestorePostRequest() : base() { this.FolderIds = new string[] { }; }
    }

    public class DocumentMoveRequest : ApiDocumentMoveRequest {
        public DocumentMoveRequest() : base() { }
    }
}
