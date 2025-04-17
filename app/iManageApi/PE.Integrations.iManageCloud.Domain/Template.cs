using System;
using PE.Integrations.iManageCloud.ApiModel.ApiTypes;

namespace PE.Integrations.iManageCloud.Domain {
    [Serializable]
    public class Template : ApiTemplate {
        public Template(string name, string defaultSecurity = "public") {
            Name = name;
            DefaultSecurity = defaultSecurity;
        }
    }
}
