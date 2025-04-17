using PE.Integrations.iManageCloud.ApiModel.ApiTypes;

namespace PE.Integrations.iManageCloud.Domain {
    public class Folder : ApiFolder { }
    public class FolderChild : ApiFolderChild { }
    public class FolderSearchRequest : ApiFolderSearchRequest { }
    public class FolderSearchResponse {
        public Folder[] Data { get; set; }
        public bool Overflow { get; set; }
    }
    public class FolderSearchFilter : ApiFolderSearchRequest.FiltersClass { }

    public class FolderMoveRequest : ApiFolderMoveRequest {
        public FolderMoveRequest() : base() { }
    }
}
