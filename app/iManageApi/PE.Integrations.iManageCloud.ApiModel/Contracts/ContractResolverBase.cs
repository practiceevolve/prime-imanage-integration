using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace PE.Integrations.iManageCloud.ApiModel.Contracts {
    public abstract class ContractResolverBase : DefaultContractResolver {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) {
            var property = base.CreateProperty(member, memberSerialization);
            if (member.GetCustomAttribute<JsonPropertyAttribute>(true) is JsonPropertyAttribute attr)
                property.ShouldSerialize = _ => Properties.Contains(attr.PropertyName);
            return property;
        }
        abstract protected HashSet<string> Properties { get; }
    }
}
