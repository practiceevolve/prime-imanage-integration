//Auto generated - do not modify
using System.Collections.Generic;

namespace PE.Integrations.iManageCloud.ApiModel.Contracts {
    public class ApiDocumentUpdateRequestContractResolver : ContractResolverBase {
        public static ApiDocumentUpdateRequestContractResolver Instance { get; } = new ApiDocumentUpdateRequestContractResolver();
        protected override HashSet<string> Properties =>
            new HashSet<string>(
                new string[] {
                    "audit",
                    "author",
                    "class",
                    "alias",
                    "name",
                    "operator",
                    "subclass",
                    "retain_days",
                    "is_declared",
                    "default_security",
                    "is_checked_out",
                    "comment",
                    "custom1",
                    "custom2",
                    "custom3",
                    "custom4",
                    "custom5",
                    "custom6",
                    "custom7",
                    "custom8",
                    "custom9",
                    "custom10",
                    "custom11",
                    "custom12",
                    "custom13",
                    "custom14",
                    "custom15",
                    "custom16",
                    "custom17",
                    "custom18",
                    "custom19",
                    "custom20",
                    "custom21",
                    "custom22",
                    "custom23",
                    "custom24",
                    "custom25",
                    "custom26",
                    "custom27",
                    "custom28",
                    "custom29",
                    "custom30",
                    "custom31",
                    "extension",
                    "content_type",
                    "file_create_date",
                    "file_edit_date",
                    "is_hipaa",
                    "keep_locked",
                    "warnings_for_required_and_disabled_fields",
                }
            );
    }

    public class ApiCustomItemUpdateRequestContractResolver : ContractResolverBase {
        public static ApiCustomItemUpdateRequestContractResolver Instance { get; } = new ApiCustomItemUpdateRequestContractResolver();
        protected override HashSet<string> Properties =>
            new HashSet<string>(
                new string[] {
                    "description",
                    "enabled",
                    "parent",
                    "hipaa"
                }
            );
    }
    public class ApiFolderCreateRequestContractResolver : ContractResolverBase {
        public static ApiFolderCreateRequestContractResolver Instance { get; } = new ApiFolderCreateRequestContractResolver();
        protected override HashSet<string> Properties =>
            new HashSet<string>(
                new string[] {
                    "class",
                    "subclass",
                    "author",
                    "custom1",
                    "custom2",
                    "custom3",
                    "custom4",
                    "custom5",
                    "custom6",
                    "custom7",
                    "custom8",
                    "custom9",
                    "custom10",
                    "custom11",
                    "custom12",
                    "custom13",
                    "custom14",
                    "custom15",
                    "custom16",
                    "custom17",
                    "custom18",
                    "custom19",
                    "custom20",
                    "custom21",
                    "custom22",
                    "custom23",
                    "custom24",
                    "custom25",
                    "custom26",
                    "custom27",
                    "custom28",
                    "custom29",
                    "custom30",
                    "custom31",
                    "default_security",
                    "description",
                    "email",
                    "group_trustees",
                    "is_external_as_normal",
                    "name",
                    "owner",
                    "parent_id",
                    "profile",
                    "project_custom1",
                    "project_custom2",
                    "project_custom3",
                    "user_trustees",
                }
            );
    }
    public class ApiFolderSearchRequestContractResolver : ContractResolverBase {
        public static ApiFolderSearchRequestContractResolver Instance { get; } = new ApiFolderSearchRequestContractResolver();
        protected override HashSet<string> Properties =>
            new HashSet<string>(
                new string[] {
                    "limit",
                    "timezone_offset",
                    "profile_fields",
                    "filters",
                }
            );
    }
    public class ApiFolderUpdateRequestContractResolver : ContractResolverBase {
        public static ApiFolderUpdateRequestContractResolver Instance { get; } = new ApiFolderUpdateRequestContractResolver();
        protected override HashSet<string> Properties =>
            new HashSet<string>(
                new string[] {
                    "default_security",
                    "description",
                    "email",
                    "is_external_as_normal",
                    "name",
                    "owner",
                    "parent_id",
                    "profile",
                    "project_custom1",
                    "project_custom2",
                    "project_custom3",
                }
            );
    }
    public class ApiWorkspaceCreateRequestContractResolver : ContractResolverBase {
        public static ApiWorkspaceCreateRequestContractResolver Instance { get; } = new ApiWorkspaceCreateRequestContractResolver();
        protected override HashSet<string> Properties =>
            new HashSet<string>(
                new string[] {
                    "custom1",
                    "custom2",
                    "custom3",
                    "custom4",
                    "custom5",
                    "custom6",
                    "custom7",
                    "custom8",
                    "custom9",
                    "custom10",
                    "custom11",
                    "custom12",
                    "custom13",
                    "custom14",
                    "custom15",
                    "custom16",
                    "custom17",
                    "custom18",
                    "custom19",
                    "custom20",
                    "custom21",
                    "custom22",
                    "custom23",
                    "custom24",
                    "custom25",
                    "custom26",
                    "custom27",
                    "custom28",
                    "custom29",
                    "custom30",
                    "custom31",
                    "declared_date",
                    "default_security",
                    "description",
                    "is_declared",
                    "is_external_as_normal",
                    "name",
                    "owner",
                    "profile",
                    "project_custom1",
                    "project_custom2",
                    "project_custom3",
                    "retain_days",
                    "subclass",
                }
            );
    }

    public class ApiTemplateCreateRequestContractResolver : ContractResolverBase {
        public static ApiTemplateCreateRequestContractResolver Instance { get; } = new ApiTemplateCreateRequestContractResolver();
        protected override HashSet<string> Properties =>
            new HashSet<string>(
                new string[] {
                    "custom1",
                    "custom2",
                    "custom3",
                    "custom4",
                    "custom5",
                    "custom6",
                    "custom7",
                    "custom8",
                    "custom9",
                    "custom10",
                    "custom11",
                    "custom12",
                    "custom13",
                    "custom14",
                    "custom15",
                    "custom16",
                    "custom17",
                    "custom18",
                    "custom19",
                    "custom20",
                    "custom21",
                    "custom22",
                    "custom23",
                    "custom24",
                    "custom25",
                    "custom26",
                    "custom27",
                    "custom28",
                    "custom29",
                    "custom30",
                    "activity_date",
                    "author",
                    "author_description",
                    "class",
                    "comment",
                    "content_type",
                    "conversation_id",
                    "conversation_name",
                    "create_date",
                    "database",
                    "default_security",
                    "description",
                    "edit_date",
                    "edit_profile_date",
                    "extension",
                    "file_create_date",
                    "file_edit_date",
                    "has_attachment",
                    "has_documents",
                    "has_subfolders",
                    "id",
                    "in_use",
                    "is_container_saved_search",
                    "is_content_saved_search",
                    "is_external_as_normal",
                    "is_hipaa",
                    "is_restorable",
                    "iwl",
                    "last_user",
                    "last_user_description",
                    "name",
                    "operator",
                    "operator_description",
                    "owner",
                    "owner_description",
                    "project_custom1",
                    "project_custom2",
                    "project_custom3",
                    "size",
                    "sub_class",
                    "subject",
                    "subtype",
                    "type",
                    "version",
                    "declared_date",
                    "default_security",
                    "description",
                    "is_declared",
                    "is_external_as_normal",
                    "name",
                    "owner",
                    "profile",
                    "project_custom1",
                    "project_custom2",
                    "project_custom3",
                    "retain_days",
                    "subclass",
                }
            );
    }

    public class ApiWorkspaceUpdateRequestContractResolver : ContractResolverBase {
        public static ApiWorkspaceUpdateRequestContractResolver Instance { get; } = new ApiWorkspaceUpdateRequestContractResolver();
        protected override HashSet<string> Properties =>
            new HashSet<string>(
                new string[] {
                    "custom1",
                    "custom2",
                    "custom3",
                    "custom4",
                    "custom5",
                    "custom6",
                    "custom7",
                    "custom8",
                    "custom9",
                    "custom10",
                    "custom11",
                    "custom12",
                    "custom13",
                    "custom14",
                    "custom15",
                    "custom16",
                    "custom17",
                    "custom18",
                    "custom19",
                    "custom20",
                    "custom21",
                    "custom22",
                    "custom23",
                    "custom24",
                    "custom25",
                    "custom26",
                    "custom27",
                    "custom28",
                    "custom29",
                    "custom30",
                    "custom31",
                    "declared_date",
                    "default_security",
                    "description",
                    "is_declared",
                    "is_external_as_normal",
                    "name",
                    "owner",
                    "profile",
                    "project_custom1",
                    "project_custom2",
                    "project_custom3",
                    "retain_days",
                    "subclass",
                }
            );
    }
}
