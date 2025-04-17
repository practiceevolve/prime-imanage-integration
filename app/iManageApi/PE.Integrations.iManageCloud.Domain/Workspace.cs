using PE.Integrations.iManageCloud.ApiModel.ApiTypes;

namespace PE.Integrations.iManageCloud.Domain {
    public class Workspace : ApiWorkspace {
        public Workspace(string name, string defaultSecurity = "public") {
            Name = name;
            DefaultSecurity = defaultSecurity;
        }
    }
    public class WorkspaceChild : ApiWorkspaceChild { }
}
