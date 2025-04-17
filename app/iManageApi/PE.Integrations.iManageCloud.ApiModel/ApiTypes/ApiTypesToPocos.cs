//Auto generated - do not modify
using System;
using Newtonsoft.Json;

namespace PE.Integrations.iManageCloud.ApiModel.ApiTypes {
    [Serializable]
    public class ApiCustomItem {
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("enabled")] public bool? Enabled { get; set; }
        [JsonProperty("hipaa")] public bool? Hipaa { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        
        [Serializable]
        public class ParentClass  {
            [JsonProperty("id")] public string Id { get; set; }
        }
        [JsonProperty("parent")] public ParentClass  Parent { get; set; }
    }

    [Serializable]
    public class ApiCaption {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("label")] public string Label { get; set; }
        [JsonProperty("num")] public int Num { get; set; }
        [JsonProperty("locale")] public int Locale { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
    }

    [Serializable]
    public class ApiUser {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("full_name")] public string FullName { get; set; }
        [JsonProperty("allow_logon")] public bool Allow_Logon { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("user_num")] public int User_Num { get; set; }
        [JsonProperty("preferred_library")] public string Preferred_Library { get; set; }
        [JsonProperty("user_nos")] public int User_Nos { get; set; }
        [JsonProperty("is_external")] public bool Is_External { get; set; }
        [JsonProperty("login")] public bool Login { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
    }

    public class ApiDocument {
        [JsonProperty("access")] public string Access { get; set; }
        [JsonProperty("access_time")] public DateTime? AccessTime { get; set; }
        [JsonProperty("activity_date")] public DateTime? ActivityDate { get; set; }
        [JsonProperty("arch_req")] public string ArchReq { get; set; }
        [JsonProperty("author")] public string Author { get; set; }
        [JsonProperty("author_description")] public string AuthorDescription { get; set; }
        [JsonProperty("checkout_comment")] public string CheckoutComment { get; set; }
        [JsonProperty("checkout_date")] public DateTime? CheckoutDate { get; set; }
        [JsonProperty("checkout_due_date")] public DateTime? CheckoutDueDate { get; set; }
        [JsonProperty("checkout_path")] public string CheckoutPath { get; set; }
        [JsonProperty("checksum")] public string Checksum { get; set; }
        [JsonProperty("class")] public string Class { get; set; }
        [JsonProperty("class_description")] public string ClassDescription { get; set; }
        [JsonProperty("comment")] public string Comment { get; set; }
        [JsonProperty("create_date")] public DateTime? CreateDate { get; set; }
        [JsonProperty("custom1")] public string Custom1 { get; set; }
        [JsonProperty("custom1_description")] public string Custom1Description { get; set; }
        [JsonProperty("custom2")] public string Custom2 { get; set; }
        [JsonProperty("custom2_description")] public string Custom2Description { get; set; }
        [JsonProperty("custom3")] public string Custom3 { get; set; }
        [JsonProperty("custom3_description")] public string Custom3Description { get; set; }
        [JsonProperty("custom4")] public string Custom4 { get; set; }
        [JsonProperty("custom4_description")] public string Custom4Description { get; set; }
        [JsonProperty("custom5")] public string Custom5 { get; set; }
        [JsonProperty("custom5_description")] public string Custom5Description { get; set; }
        [JsonProperty("custom6")] public string Custom6 { get; set; }
        [JsonProperty("custom6_description")] public string Custom6Description { get; set; }
        [JsonProperty("custom7")] public string Custom7 { get; set; }
        [JsonProperty("custom7_description")] public string Custom7Description { get; set; }
        [JsonProperty("custom8")] public string Custom8 { get; set; }
        [JsonProperty("custom8_description")] public string Custom8Description { get; set; }
        [JsonProperty("custom9")] public string Custom9 { get; set; }
        [JsonProperty("custom9_description")] public string Custom9Description { get; set; }
        [JsonProperty("custom10")] public string Custom10 { get; set; }
        [JsonProperty("custom10_description")] public string Custom10Description { get; set; }
        [JsonProperty("custom11")] public string Custom11 { get; set; }
        [JsonProperty("custom11_description")] public string Custom11Description { get; set; }
        [JsonProperty("custom12")] public string Custom12 { get; set; }
        [JsonProperty("custom12_description")] public string Custom12Description { get; set; }
        [JsonProperty("custom13")] public string Custom13 { get; set; }
        [JsonProperty("custom14")] public string Custom14 { get; set; }
        [JsonProperty("custom15")] public string Custom15 { get; set; }
        [JsonProperty("custom16")] public string Custom16 { get; set; }
        [JsonProperty("custom17")] public decimal? Custom17 { get; set; }
        [JsonProperty("custom18")] public decimal? Custom18 { get; set; }
        [JsonProperty("custom19")] public decimal? Custom19 { get; set; }
        [JsonProperty("custom20")] public decimal? Custom20 { get; set; }
        [JsonProperty("custom21")] public DateTime? Custom21 { get; set; }
        [JsonProperty("custom22")] public DateTime? Custom22 { get; set; }
        [JsonProperty("custom23")] public DateTime? Custom23 { get; set; }
        [JsonProperty("custom24")] public DateTime? Custom24 { get; set; }
        [JsonProperty("custom25")] public bool? Custom25 { get; set; }
        [JsonProperty("custom26")] public bool? Custom26 { get; set; }
        [JsonProperty("custom27")] public bool? Custom27 { get; set; }
        [JsonProperty("custom28")] public bool? Custom28 { get; set; }
        [JsonProperty("custom29")] public string Custom29 { get; set; }
        [JsonProperty("custom29_description")] public string Custom29Description { get; set; }
        [JsonProperty("custom30")] public string Custom30 { get; set; }
        [JsonProperty("custom30_description")] public string Custom30Description { get; set; }
        [JsonProperty("custom31")] public string Custom31 { get; set; }
        [JsonProperty("custom31_description")] public string Custom31Description { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("declared_date")] public DateTime? DeclaredDate { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("document_number")] public int? DocumentNumber { get; set; }
        [JsonProperty("alias")] public string Alias { get; set; }
        [JsonProperty("edit_date")] public DateTime? EditDate { get; set; }
        [JsonProperty("edit_profile_date")] public DateTime? EditProfileDate { get; set; }
        [JsonProperty("effective_security")] public string EffectiveSecurity { get; set; }
        [JsonProperty("extension")] public string Extension { get; set; }
        [JsonProperty("file_create_date")] public DateTime? FileCreateDate { get; set; }
        [JsonProperty("file_edit_date")] public DateTime? FileEditDate { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("is_in_use")] public bool? IsInUse { get; set; }
        [JsonProperty("in_use_by")] public string InUseBy { get; set; }
        [JsonProperty("in_use_by_description")] public string InUseByDescription { get; set; }
        [JsonProperty("is_archived")] public bool? IsArchived { get; set; }
        [JsonProperty("is_declared")] public bool? IsDeclared { get; set; }
        [JsonProperty("is_checked_out")] public bool? IsCheckedOut { get; set; }
        [JsonProperty("is_external")] public bool? IsExternal { get; set; }
        [JsonProperty("is_external_as_normal")] public bool? IsExternalAsNormal { get; set; }
        [JsonProperty("is_hipaa")] public bool? IsHipaa { get; set; }
        [JsonProperty("is_latest")] public bool? IsLatest { get; set; }
        [JsonProperty("latest")] public string Latest { get; set; }
        [JsonProperty("is_most_recent_activity")] public bool? IsMostRecentActivity { get; set; }
        [JsonProperty("is_related")] public bool? IsRelated { get; set; }
        [JsonProperty("is_restorable")] public bool? IsRestorable { get; set; }
        [JsonProperty("iwl")] public string Iwl { get; set; }
        [JsonProperty("last_user")] public string LastUser { get; set; }
        [JsonProperty("last_user_description")] public string LastUserDescription { get; set; }
        [JsonProperty("share_url")] public string ShareUrl { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("operator")] public string Operator { get; set; }
        [JsonProperty("operator_description")] public string OperatorDescription { get; set; }
        [JsonProperty("retain_days")] public int? RetainDays { get; set; }
        [JsonProperty("size")] public int? Size { get; set; }
        [JsonProperty("subclass")] public string Subclass { get; set; }
        [JsonProperty("subclass_description")] public string SubclassDescription { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("type_description")] public string TypeDescription { get; set; }
        [JsonProperty("version")] public int? Version { get; set; }
        [JsonProperty("workspace_id")] public string WorkspaceId { get; set; }
        [JsonProperty("workspace_name")] public string WorkspaceName { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
        public class AttachmentsClass  {
        [JsonProperty("attachment_id")] public string AttachmentId { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("size")] public int? Size { get; set; }
        }
        [JsonProperty("attachments")] public AttachmentsClass [] Attachments { get; set; }
        [JsonProperty("bcc")] public string Bcc { get; set; }
        [JsonProperty("cc")] public string Cc { get; set; }
        [JsonProperty("conversation_count")] public int? ConversationCount { get; set; }
        [JsonProperty("conversation_id")] public string ConversationId { get; set; }
        [JsonProperty("conversation_name")] public string ConversationName { get; set; }
        [JsonProperty("from")] public string From { get; set; }
        [JsonProperty("has_attachment")] public bool? HasAttachment { get; set; }
        [JsonProperty("received_date")] public DateTime? ReceivedDate { get; set; }
        [JsonProperty("sent_date")] public DateTime? SentDate { get; set; }
        [JsonProperty("subject")] public string Subject { get; set; }
        [JsonProperty("to")] public string To { get; set; }
    }
    public class ApiDocumentActivity {
        [JsonProperty("alias")] public string Alias { get; set; }
        [JsonProperty("count")] public int? Count { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
    }
    public class ApiDocumentCheckoutRequest {
        [JsonProperty("appname")] public string Appname { get; set; }
        [JsonProperty("comments")] public string Comments { get; set; }
        [JsonProperty("due_date")] public DateTime? DueDate { get; set; }
        [JsonProperty("location")] public string Location { get; set; }
        [JsonProperty("path")] public string Path { get; set; }
    }
    public class ApiDocumentHistory {
        [JsonProperty("document_number")] public int? DocumentNumber { get; set; }
        [JsonProperty("version")] public int? Version { get; set; }
        [JsonProperty("activity")] public string Activity { get; set; }
        [JsonProperty("application_name")] public string ApplicationName { get; set; }
        [JsonProperty("activity_date")] public DateTime? ActivityDate { get; set; }
        [JsonProperty("duration")] public int? Duration { get; set; }
        [JsonProperty("pages_printed")] public int? PagesPrinted { get; set; }
        [JsonProperty("user")] public string User { get; set; }
        [JsonProperty("activity_code")] public int? ActivityCode { get; set; }
        [JsonProperty("location")] public string Location { get; set; }
        [JsonProperty("comments")] public string Comments { get; set; }
        [JsonProperty("data1")] public string Data1 { get; set; }
        [JsonProperty("data2")] public string Data2 { get; set; }
        [JsonProperty("num1")] public string Num1 { get; set; }
        [JsonProperty("num2")] public string Num2 { get; set; }
        [JsonProperty("num3")] public string Num3 { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("has_journal")] public bool? HasJournal { get; set; }
        [JsonProperty("user_fullname")] public string UserFullname { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("document_id")] public string DocumentId { get; set; }
    }
    public class ApiDocumentLockRequest {
        [JsonProperty("due_date")] public string DueDate { get; set; }
        [JsonProperty("path")] public string Path { get; set; }
        [JsonProperty("comments")] public string Comments { get; set; }
        [JsonProperty("location")] public string Location { get; set; }
    }
    public class ApiDocumentMoveRequest {
        public class AuditClass  {
        [JsonProperty("comments")] public string Comments { get; set; }
        }
        [JsonProperty("audit")] public AuditClass  Audit { get; set; }
        [JsonProperty("destination_folder_id")] public string DestinationFolderId { get; set; }
        [JsonProperty("destination_id")] public string DestinationId { get; set; }
        [JsonProperty("update_profile")] public bool? UpdateProfile { get; set; }
        [JsonProperty("update_security")] public bool? UpdateSecurity { get; set; }
    }
    public class ApiDocumentProfileWithOperations {
        public class DataClass  {
        [JsonProperty("access")] public string Access { get; set; }
        [JsonProperty("access_time")] public DateTime? AccessTime { get; set; }
        [JsonProperty("activity_date")] public DateTime? ActivityDate { get; set; }
        [JsonProperty("arch_req")] public string ArchReq { get; set; }
        [JsonProperty("author")] public string Author { get; set; }
        [JsonProperty("author_description")] public string AuthorDescription { get; set; }
        [JsonProperty("checkout_comment")] public string CheckoutComment { get; set; }
        [JsonProperty("checkout_date")] public DateTime? CheckoutDate { get; set; }
        [JsonProperty("checkout_due_date")] public DateTime? CheckoutDueDate { get; set; }
        [JsonProperty("checkout_path")] public string CheckoutPath { get; set; }
        [JsonProperty("checksum")] public string Checksum { get; set; }
        [JsonProperty("class")] public string Class { get; set; }
        [JsonProperty("class_description")] public string ClassDescription { get; set; }
        [JsonProperty("comment")] public string Comment { get; set; }
        [JsonProperty("create_date")] public DateTime? CreateDate { get; set; }
        [JsonProperty("custom1")] public string Custom1 { get; set; }
        [JsonProperty("custom1_description")] public string Custom1Description { get; set; }
        [JsonProperty("custom2")] public string Custom2 { get; set; }
        [JsonProperty("custom2_description")] public string Custom2Description { get; set; }
        [JsonProperty("custom3")] public string Custom3 { get; set; }
        [JsonProperty("custom3_description")] public string Custom3Description { get; set; }
        [JsonProperty("custom4")] public string Custom4 { get; set; }
        [JsonProperty("custom4_description")] public string Custom4Description { get; set; }
        [JsonProperty("custom5")] public string Custom5 { get; set; }
        [JsonProperty("custom5_description")] public string Custom5Description { get; set; }
        [JsonProperty("custom6")] public string Custom6 { get; set; }
        [JsonProperty("custom6_description")] public string Custom6Description { get; set; }
        [JsonProperty("custom7")] public string Custom7 { get; set; }
        [JsonProperty("custom7_description")] public string Custom7Description { get; set; }
        [JsonProperty("custom8")] public string Custom8 { get; set; }
        [JsonProperty("custom8_description")] public string Custom8Description { get; set; }
        [JsonProperty("custom9")] public string Custom9 { get; set; }
        [JsonProperty("custom9_description")] public string Custom9Description { get; set; }
        [JsonProperty("custom10")] public string Custom10 { get; set; }
        [JsonProperty("custom10_description")] public string Custom10Description { get; set; }
        [JsonProperty("custom11")] public string Custom11 { get; set; }
        [JsonProperty("custom11_description")] public string Custom11Description { get; set; }
        [JsonProperty("custom12")] public string Custom12 { get; set; }
        [JsonProperty("custom12_description")] public string Custom12Description { get; set; }
        [JsonProperty("custom13")] public string Custom13 { get; set; }
        [JsonProperty("custom14")] public string Custom14 { get; set; }
        [JsonProperty("custom15")] public string Custom15 { get; set; }
        [JsonProperty("custom16")] public string Custom16 { get; set; }
        [JsonProperty("custom17")] public decimal? Custom17 { get; set; }
        [JsonProperty("custom18")] public decimal? Custom18 { get; set; }
        [JsonProperty("custom19")] public decimal? Custom19 { get; set; }
        [JsonProperty("custom20")] public decimal? Custom20 { get; set; }
        [JsonProperty("custom21")] public DateTime? Custom21 { get; set; }
        [JsonProperty("custom22")] public DateTime? Custom22 { get; set; }
        [JsonProperty("custom23")] public DateTime? Custom23 { get; set; }
        [JsonProperty("custom24")] public DateTime? Custom24 { get; set; }
        [JsonProperty("custom25")] public bool? Custom25 { get; set; }
        [JsonProperty("custom26")] public bool? Custom26 { get; set; }
        [JsonProperty("custom27")] public bool? Custom27 { get; set; }
        [JsonProperty("custom28")] public bool? Custom28 { get; set; }
        [JsonProperty("custom29")] public string Custom29 { get; set; }
        [JsonProperty("custom29_description")] public string Custom29Description { get; set; }
        [JsonProperty("custom30")] public string Custom30 { get; set; }
        [JsonProperty("custom30_description")] public string Custom30Description { get; set; }
        [JsonProperty("custom31")] public string Custom31 { get; set; }
        [JsonProperty("custom31_description")] public string Custom31Description { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("declared_date")] public DateTime? DeclaredDate { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("document_number")] public int? DocumentNumber { get; set; }
        [JsonProperty("alias")] public string Alias { get; set; }
        [JsonProperty("edit_date")] public DateTime? EditDate { get; set; }
        [JsonProperty("edit_profile_date")] public DateTime? EditProfileDate { get; set; }
        [JsonProperty("effective_security")] public string EffectiveSecurity { get; set; }
        [JsonProperty("extension")] public string Extension { get; set; }
        [JsonProperty("file_create_date")] public DateTime? FileCreateDate { get; set; }
        [JsonProperty("file_edit_date")] public DateTime? FileEditDate { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("is_in_use")] public bool? IsInUse { get; set; }
        [JsonProperty("in_use_by")] public string InUseBy { get; set; }
        [JsonProperty("in_use_by_description")] public string InUseByDescription { get; set; }
        [JsonProperty("is_archived")] public bool? IsArchived { get; set; }
        [JsonProperty("is_declared")] public bool? IsDeclared { get; set; }
        [JsonProperty("is_checked_out")] public bool? IsCheckedOut { get; set; }
        [JsonProperty("is_external")] public bool? IsExternal { get; set; }
        [JsonProperty("is_external_as_normal")] public bool? IsExternalAsNormal { get; set; }
        [JsonProperty("is_hipaa")] public bool? IsHipaa { get; set; }
        [JsonProperty("is_latest")] public bool? IsLatest { get; set; }
        [JsonProperty("latest")] public string Latest { get; set; }
        [JsonProperty("is_most_recent_activity")] public bool? IsMostRecentActivity { get; set; }
        [JsonProperty("is_related")] public bool? IsRelated { get; set; }
        [JsonProperty("is_restorable")] public bool? IsRestorable { get; set; }
        [JsonProperty("iwl")] public string Iwl { get; set; }
        [JsonProperty("last_user")] public string LastUser { get; set; }
        [JsonProperty("last_user_description")] public string LastUserDescription { get; set; }
        [JsonProperty("share_url")] public string ShareUrl { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("operator")] public string Operator { get; set; }
        [JsonProperty("operator_description")] public string OperatorDescription { get; set; }
        [JsonProperty("retain_days")] public int? RetainDays { get; set; }
        [JsonProperty("size")] public int? Size { get; set; }
        [JsonProperty("subclass")] public string Subclass { get; set; }
        [JsonProperty("subclass_description")] public string SubclassDescription { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("type_description")] public string TypeDescription { get; set; }
        [JsonProperty("version")] public int? Version { get; set; }
        [JsonProperty("workspace_id")] public string WorkspaceId { get; set; }
        [JsonProperty("workspace_name")] public string WorkspaceName { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
        public class AttachmentsClass  {
        [JsonProperty("attachment_id")] public string AttachmentId { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("size")] public int? Size { get; set; }
        }
        [JsonProperty("attachments")] public AttachmentsClass [] Attachments { get; set; }
        [JsonProperty("bcc")] public string Bcc { get; set; }
        [JsonProperty("cc")] public string Cc { get; set; }
        [JsonProperty("conversation_count")] public int? ConversationCount { get; set; }
        [JsonProperty("conversation_id")] public string ConversationId { get; set; }
        [JsonProperty("conversation_name")] public string ConversationName { get; set; }
        [JsonProperty("from")] public string From { get; set; }
        [JsonProperty("has_attachment")] public bool? HasAttachment { get; set; }
        [JsonProperty("received_date")] public DateTime? ReceivedDate { get; set; }
        [JsonProperty("sent_date")] public DateTime? SentDate { get; set; }
        [JsonProperty("subject")] public string Subject { get; set; }
        [JsonProperty("to")] public string To { get; set; }
        public class OperationsClass  {
        [JsonProperty("archive")] public bool? Archive { get; set; }
        [JsonProperty("copy")] public bool? Copy { get; set; }
        [JsonProperty("create_new_version")] public bool? CreateNewVersion { get; set; }
        [JsonProperty("declare")] public bool? Declare { get; set; }
        [JsonProperty("delete")] public bool? Delete { get; set; }
        [JsonProperty("freeze")] public bool? Freeze { get; set; }
        [JsonProperty("lock")] public bool? Lock { get; set; }
        [JsonProperty("move")] public bool? Move { get; set; }
        [JsonProperty("relate")] public bool? Relate { get; set; }
        [JsonProperty("replace")] public bool? Replace { get; set; }
        [JsonProperty("restore")] public bool? Restore { get; set; }
        [JsonProperty("set_security")] public bool? SetSecurity { get; set; }
        [JsonProperty("undeclare")] public bool? Undeclare { get; set; }
        [JsonProperty("unfreeze")] public bool? Unfreeze { get; set; }
        [JsonProperty("unlock")] public bool? Unlock { get; set; }
        [JsonProperty("update")] public bool? Update { get; set; }
        }
        [JsonProperty("operations")] public OperationsClass  Operations { get; set; }
        }
        [JsonProperty("data")] public DataClass  Data { get; set; }
        public class WarningsClass  {
        [JsonProperty("field")] public string Field { get; set; }
        [JsonProperty("error")] public string Error { get; set; }
        }
        [JsonProperty("warnings")] public WarningsClass [] Warnings { get; set; }
    }
    public class ApiDocumentSearchRequest {
        [JsonProperty("limit")] public int? Limit { get; set; }
        [JsonProperty("timezone_offset")] public int? TimezoneOffset { get; set; }
        public class ProfileFieldsClass  {
        [JsonProperty("document")] public string[] Document { get; set; }
        }
        [JsonProperty("profile_fields")] public ProfileFieldsClass  ProfileFields { get; set; }
        public class FiltersClass  {
        [JsonProperty("edit_date")] public string EditDate { get; set; }
        [JsonProperty("edit_date_from")] public string EditDateFrom { get; set; }
        [JsonProperty("edit_date_to")] public string EditDateTo { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("exclude_emails")] public bool? ExcludeEmails { get; set; }
        [JsonProperty("email_only")] public bool? EmailOnly { get; set; }
        [JsonProperty("anywhere")] public string Anywhere { get; set; }
        [JsonProperty("user")] public string User { get; set; }
        [JsonProperty("author")] public string Author { get; set; }
        [JsonProperty("operator")] public string Operator { get; set; }
        [JsonProperty("owner")] public string Owner { get; set; }
        [JsonProperty("comments")] public string Comments { get; set; }
        [JsonProperty("container_id")] public string ContainerId { get; set; }
        [JsonProperty("include_subtree")] public bool? IncludeSubtree { get; set; }
        [JsonProperty("personalized")] public bool? Personalized { get; set; }
        [JsonProperty("custom1")] public string Custom1 { get; set; }
        [JsonProperty("libraries")] public string Libraries { get; set; }
        [JsonProperty("custom2")] public string Custom2 { get; set; }
        [JsonProperty("custom3")] public string Custom3 { get; set; }
        [JsonProperty("custom4")] public string Custom4 { get; set; }
        [JsonProperty("custom5")] public string Custom5 { get; set; }
        [JsonProperty("custom6")] public string Custom6 { get; set; }
        [JsonProperty("custom7")] public string Custom7 { get; set; }
        [JsonProperty("custom8")] public string Custom8 { get; set; }
        [JsonProperty("custom9")] public string Custom9 { get; set; }
        [JsonProperty("custom10")] public string Custom10 { get; set; }
        [JsonProperty("custom11")] public string Custom11 { get; set; }
        [JsonProperty("custom12")] public string Custom12 { get; set; }
        [JsonProperty("custom13")] public string Custom13 { get; set; }
        [JsonProperty("custom14")] public string Custom14 { get; set; }
        [JsonProperty("custom15")] public string Custom15 { get; set; }
        [JsonProperty("custom16")] public string Custom16 { get; set; }
        [JsonProperty("custom21_from")] public string Custom21From { get; set; }
        [JsonProperty("custom22_from")] public string Custom22From { get; set; }
        [JsonProperty("custom23_from")] public string Custom23From { get; set; }
        [JsonProperty("custom24_from")] public string Custom24From { get; set; }
        [JsonProperty("custom21_to")] public string Custom21To { get; set; }
        [JsonProperty("custom22_to")] public string Custom22To { get; set; }
        [JsonProperty("custom23_to")] public string Custom23To { get; set; }
        [JsonProperty("custom24_to")] public string Custom24To { get; set; }
        [JsonProperty("custom21_relative")] public string Custom21Relative { get; set; }
        [JsonProperty("custom22_relative")] public string Custom22Relative { get; set; }
        [JsonProperty("custom23_relative")] public string Custom23Relative { get; set; }
        [JsonProperty("custom24_relative")] public string Custom24Relative { get; set; }
        [JsonProperty("custom25")] public bool? Custom25 { get; set; }
        [JsonProperty("custom26")] public bool? Custom26 { get; set; }
        [JsonProperty("custom27")] public bool? Custom27 { get; set; }
        [JsonProperty("custom28")] public bool? Custom28 { get; set; }
        [JsonProperty("custom29")] public string Custom29 { get; set; }
        [JsonProperty("custom30")] public string Custom30 { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("name_comments")] public string NameComments { get; set; }
        [JsonProperty("create_date")] public string CreateDate { get; set; }
        [JsonProperty("create_date_from")] public string CreateDateFrom { get; set; }
        [JsonProperty("create_date_to")] public string CreateDateTo { get; set; }
        [JsonProperty("alias")] public string Alias { get; set; }
        [JsonProperty("sent_date")] public string SentDate { get; set; }
        [JsonProperty("received_date")] public string ReceivedDate { get; set; }
        [JsonProperty("has_attachment")] public bool? HasAttachment { get; set; }
        [JsonProperty("subject")] public string Subject { get; set; }
        [JsonProperty("sender")] public string Sender { get; set; }
        [JsonProperty("recipient")] public string Recipient { get; set; }
        [JsonProperty("last_user")] public string LastUser { get; set; }
        [JsonProperty("checked_out")] public bool? CheckedOut { get; set; }
        [JsonProperty("in_use_by")] public string InUseBy { get; set; }
        [JsonProperty("in_use")] public bool? InUse { get; set; }
        [JsonProperty("exclude_shortcuts")] public bool? ExcludeShortcuts { get; set; }
        [JsonProperty("body")] public string Body { get; set; }
        }
        [JsonProperty("filters")] public FiltersClass  Filters { get; set; }
    }
    public class ApiDocumentUpdateVersionRequest {
        public class DocProfileClass  {
        public class AuditClass  {
        [JsonProperty("comments")] public string Comments { get; set; }
        }
        [JsonProperty("audit")] public AuditClass  Audit { get; set; }
        [JsonProperty("author")] public string Author { get; set; }
        [JsonProperty("class")] public string Class { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("operator")] public string Operator { get; set; }
        [JsonProperty("subclass")] public string Subclass { get; set; }
        [JsonProperty("retain_days")] public int? RetainDays { get; set; }
        [JsonProperty("is_declared")] public bool? IsDeclared { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("is_checked_out")] public bool? IsCheckedOut { get; set; }
        [JsonProperty("comment")] public string Comment { get; set; }
        [JsonProperty("custom1")] public string Custom1 { get; set; }
        [JsonProperty("custom2")] public string Custom2 { get; set; }
        [JsonProperty("custom3")] public string Custom3 { get; set; }
        [JsonProperty("custom4")] public string Custom4 { get; set; }
        [JsonProperty("custom5")] public string Custom5 { get; set; }
        [JsonProperty("custom6")] public string Custom6 { get; set; }
        [JsonProperty("custom7")] public string Custom7 { get; set; }
        [JsonProperty("custom8")] public string Custom8 { get; set; }
        [JsonProperty("custom9")] public string Custom9 { get; set; }
        [JsonProperty("custom10")] public string Custom10 { get; set; }
        [JsonProperty("custom11")] public string Custom11 { get; set; }
        [JsonProperty("custom12")] public string Custom12 { get; set; }
        [JsonProperty("custom13")] public string Custom13 { get; set; }
        [JsonProperty("custom14")] public string Custom14 { get; set; }
        [JsonProperty("custom15")] public string Custom15 { get; set; }
        [JsonProperty("custom16")] public string Custom16 { get; set; }
        [JsonProperty("custom17")] public decimal? Custom17 { get; set; }
        [JsonProperty("custom18")] public decimal? Custom18 { get; set; }
        [JsonProperty("custom19")] public decimal? Custom19 { get; set; }
        [JsonProperty("custom20")] public decimal? Custom20 { get; set; }
        [JsonProperty("custom21")] public DateTime? Custom21 { get; set; }
        [JsonProperty("custom22")] public DateTime? Custom22 { get; set; }
        [JsonProperty("custom23")] public DateTime? Custom23 { get; set; }
        [JsonProperty("custom24")] public DateTime? Custom24 { get; set; }
        [JsonProperty("custom25")] public bool? Custom25 { get; set; }
        [JsonProperty("custom26")] public bool? Custom26 { get; set; }
        [JsonProperty("custom27")] public bool? Custom27 { get; set; }
        [JsonProperty("custom28")] public bool? Custom28 { get; set; }
        [JsonProperty("custom29")] public string Custom29 { get; set; }
        [JsonProperty("custom30")] public string Custom30 { get; set; }
        [JsonProperty("custom31")] public string Custom31 { get; set; }
        [JsonProperty("extension")] public string Extension { get; set; }
        [JsonProperty("content_type")] public string ContentType { get; set; }
        [JsonProperty("file_create_date")] public DateTime? FileCreateDate { get; set; }
        [JsonProperty("file_edit_date")] public DateTime? FileEditDate { get; set; }
        [JsonProperty("is_external")] public bool? IsExternal { get; set; }
        [JsonProperty("is_hipaa")] public bool? IsHipaa { get; set; }
        [JsonProperty("keep_locked")] public bool? KeepLocked { get; set; }
        [JsonProperty("checksum")] public string Checksum { get; set; }
        }
        [JsonProperty("doc_profile")] public DocProfileClass  DocProfile { get; set; }
    }
    public class ApiDocumentUploadNewVersionRequest {
        public class AuditClass  {
        [JsonProperty("comments")] public string Comments { get; set; }
        }
        [JsonProperty("audit")] public AuditClass  Audit { get; set; }
        public class DocProfileClass  {
            [JsonProperty("author")] public string Author { get; set; }
            [JsonProperty("checksum")] public string Checksum { get; set; }
            [JsonProperty("class")] public string Class { get; set; }
            [JsonProperty("extension")] public string Extension { get; set; }
            [JsonProperty("type")] public string Type { get; set; }
        }
        [JsonProperty("doc_profile")] public DocProfileClass  DocProfile { get; set; }
        public class GroupTrusteesClass  {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("access_level")] public string AccessLevel { get; set; }
        }
        [JsonProperty("group_trustees")] public GroupTrusteesClass [] GroupTrustees { get; set; }
        [JsonProperty("keep_locked")] public bool? KeepLocked { get; set; }
        public class UserTrusteesClass  {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("access_level")] public string AccessLevel { get; set; }
        }
        [JsonProperty("user_trustees")] public UserTrusteesClass [] UserTrustees { get; set; }
        [JsonProperty("warnings_for_required_and_disabled_fields")] public bool? WarningsForRequiredAndDisabledFields { get; set; }
    }
    public class ApiDocumentUploadRequest {
        [JsonProperty("warnings_for_required_and_disabled_fields")] public bool? WarningsForRequiredAndDisabledFields { get; set; }
        [JsonProperty("keep_locked")] public bool? KeepLocked { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }
        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom3")] 
        public string Custom3 { get; set; }

        [JsonProperty("custom4")] 
        public string Custom4 { get; set; }

        [JsonProperty("custom5")] 
        public string Custom5 { get; set; }

        [JsonProperty("custom6")] 
        public string Custom6 { get; set; }

        [JsonProperty("custom7")] 
        public string Custom7 { get; set; }

        [JsonProperty("custom8")] 
        public string Custom8 { get; set; }

        [JsonProperty("custom9")] 
        public string Custom9 { get; set; }

        [JsonProperty("custom10")] 
        public string Custom10 { get; set; }

        [JsonProperty("custom11")] 
        public string Custom11 { get; set; }

        [JsonProperty("custom12")] 
        public string Custom12 { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")] 
        public string Custom15 { get; set; }
        [JsonProperty("custom16")] 
        public string Custom16 { get; set; }
        [JsonProperty("custom17")] 
        public decimal? Custom17 { get; set; }
        [JsonProperty("custom18")] 
        public decimal? Custom18 { get; set; }
        [JsonProperty("custom19")] 
        public decimal? Custom19 { get; set; }
        [JsonProperty("custom20")] 
        public decimal? Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")] 
        public string Custom24 { get; set; }

        [JsonProperty("custom25")] 
        public bool? Custom25 { get; set; }

        [JsonProperty("custom26")] 
        public bool? Custom26 { get; set; }

        [JsonProperty("custom27")] 
        public bool? Custom27 { get; set; }

        [JsonProperty("custom28")] 
        public bool? Custom28 { get; set; }

        public class AuditClass  {
        [JsonProperty("comments")] public string Comments { get; set; }
        }
        [JsonProperty("audit")] public AuditClass  Audit { get; set; }
        public class DocProfileClass  {

            [JsonProperty("custom3")]
            public string Custom3 { get; set; }

            [JsonProperty("custom4")]
            public string Custom4 { get; set; }

            [JsonProperty("custom5")]
            public string Custom5 { get; set; }

            [JsonProperty("custom6")]
            public string Custom6 { get; set; }

            [JsonProperty("custom7")]
            public string Custom7 { get; set; }

            [JsonProperty("custom8")]
            public string Custom8 { get; set; }

            [JsonProperty("custom9")]
            public string Custom9 { get; set; }

            [JsonProperty("custom10")]
            public string Custom10 { get; set; }

            [JsonProperty("custom11")]
            public string Custom11 { get; set; }

            [JsonProperty("custom12")]
            public string Custom12 { get; set; }

            [JsonProperty("custom13")]
            public string Custom13 { get; set; }

            [JsonProperty("custom14")]
            public string Custom14 { get; set; }

            [JsonProperty("custom15")]
            public string Custom15 { get; set; }

            [JsonProperty("custom16")]
            public string Custom16 { get; set; }

            [JsonProperty("custom17")]
            public decimal? Custom17 { get; set; }
            [JsonProperty("custom18")]
            public decimal? Custom18 { get; set; }
            [JsonProperty("custom19")]
            public decimal? Custom19 { get; set; }
            [JsonProperty("custom20")]
            public decimal? Custom20 { get; set; }

            [JsonProperty("custom21")]
            public string Custom21 { get; set; }

            [JsonProperty("custom22")]
            public string Custom22 { get; set; }

            [JsonProperty("custom23")]
            public string Custom23 { get; set; }

            [JsonProperty("custom24")]
            public string Custom24 { get; set; }

            [JsonProperty("custom25")]
            public bool? Custom25 { get; set; }

            [JsonProperty("custom26")]
            public bool? Custom26 { get; set; }

            [JsonProperty("custom27")]
            public bool? Custom27 { get; set; }

            [JsonProperty("custom28")]
            public bool? Custom28 { get; set; }
            [JsonProperty("name")] public string Name { get; set; }
            [JsonProperty("extension")] public string Extension { get; set; }
            [JsonProperty("type")] public string Type { get; set; }
            [JsonProperty("size")] public int? Size { get; set; }
            [JsonProperty("author")] public string Author { get; set; }
            [JsonProperty("checksum")] public string Checksum { get; set; }
            [JsonProperty("class")] public string Class { get; set; }
            [JsonProperty("subclass")] public string Subclass { get; set; }
            [JsonProperty("content_type")] public string ContentType { get; set; }
            [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
            [JsonProperty("file_create_date")] public DateTime? FileCreateDate { get; set; }
            [JsonProperty("file_edit_date")] public DateTime? FileEditDate { get; set; }
            [JsonProperty("is_hipaa")] public bool? IsHipaa { get; set; }
            [JsonProperty("retain_days")] public int? RetainDays { get; set; }
            [JsonProperty("operator")] public string Operator { get; set; }
        }
        [JsonProperty("doc_profile")] public DocProfileClass  DocProfile { get; set; }
        public class UserTrusteesClass  {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("access_level")] public string AccessLevel { get; set; }
        }
        [JsonProperty("user_trustees")] public UserTrusteesClass [] UserTrustees { get; set; }
        public class GroupTrusteesClass  {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("access_level")] public string AccessLevel { get; set; }
        }
        [JsonProperty("group_trustees")] public GroupTrusteesClass [] GroupTrustees { get; set; }
    }
    public class ApiDocumentUser {
        [JsonProperty("activity_count")] public int? ActivityCount { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("full_name")] public string FullName { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("login")] public bool? Login { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
    }

    [Serializable]
    public class ApiDocumentClass {
        [JsonProperty("id")] public string? Id { get; set; }
        [JsonProperty("description")] public string? Description { get; set; }
        [JsonProperty("required_fields")] public string[] RequiredFields { get; set; }
        [JsonProperty("indexable")] public bool? Indexable { get; set; }
        [JsonProperty("shadow")] public bool? Shadow { get; set; }
        [JsonProperty("retain")] public int? Retain { get; set; }
        [JsonProperty("default_security")] public string? DefaultSecurity { get; set; }
        [JsonProperty("subclass_required")] public bool? SubclassRequired { get; set; }
        [JsonProperty("database")] public string? Database { get; set; }
    }

    [Serializable]
    public class ApiDocumentSubclass {
        [JsonProperty("id")] public string? Id { get; set; }
        [JsonProperty("description")] public string? Description { get; set; }
        [JsonProperty("required_fields")] public string[] RequiredFields { get; set; }
        [JsonProperty("shadow")] public bool? Shadow { get; set; }
        [JsonProperty("retain")] public int? Retain { get; set; }
        [JsonProperty("default_security")] public string? DefaultSecurity { get; set; }
        
        [Serializable]
        public class ParentClass {
            [JsonProperty("id")] public string Id { get; set; }
        }

        [JsonProperty("database")] public string? Database { get; set; }
    }

    public class ApiError {
        public class ErrorClass  {
        [JsonProperty("code")] public string Code { get; set; }
        [JsonProperty("code_message")] public string CodeMessage { get; set; }
        [JsonProperty("dms_version")] public string DmsVersion { get; set; }
        [JsonProperty("transaction")] public string Transaction { get; set; }
        public class MessagesClass  {
        [JsonProperty("code")] public string Code { get; set; }
        [JsonProperty("code_message")] public string CodeMessage { get; set; }
        [JsonProperty("field")] public string Field { get; set; }
        }
        [JsonProperty("messages")] public MessagesClass [] Messages { get; set; }
        }
        [JsonProperty("error")] public ErrorClass  Error { get; set; }
    }
    public class ApiFolderMoveRequest {
        [JsonProperty("destination_folder_id")] public string DestinationFolderId { get; set; }
        [JsonProperty("destination_id")] public string DestinationId { get; set; }
    }
    public class ApiTrashBinDocumentsRestorePostRequest {
        [JsonProperty("comments")] public string Comments { get; set; }
        [JsonProperty("folder_ids")] public string[] FolderIds { get; set; }
        [JsonProperty("for_user")] public string ForUser { get; set; }
    }
    public class ApiFolder {
        [JsonProperty("activity_date")] public DateTime? ActivityDate { get; set; }
        [JsonProperty("container_saved_search_id")] public string ContainerSavedSearchId { get; set; }
        [JsonProperty("content_saved_search_id")] public string ContentSavedSearchId { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("edit_date")] public DateTime? EditDate { get; set; }
        [JsonProperty("effective_security")] public string EffectiveSecurity { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("folder_type")] public string FolderType { get; set; }
        [JsonProperty("has_documents")] public bool? HasDocuments { get; set; }
        [JsonProperty("has_security")] public bool? HasSecurity { get; set; }
        [JsonProperty("has_subfolders")] public bool? HasSubfolders { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("imanage_share_eid")] public string ImanageShareEid { get; set; }
        [JsonProperty("imanage_share_url")] public string ImanageShareUrl { get; set; }
        [JsonProperty("inherited_default_security")] public string InheritedDefaultSecurity { get; set; }
        [JsonProperty("is_container_saved_search")] public bool? IsContainerSavedSearch { get; set; }
        [JsonProperty("is_content_saved_search")] public bool? IsContentSavedSearch { get; set; }
        [JsonProperty("is_external")] public bool? IsExternal { get; set; }
        [JsonProperty("is_external_as_normal")] public bool? IsExternalAsNormal { get; set; }
        [JsonProperty("location")] public string Location { get; set; }
        [JsonProperty("my_matters_shortcut_id")] public string MyMattersShortcutId { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("owner")] public string Owner { get; set; }
        [JsonProperty("owner_description")] public string OwnerDescription { get; set; }
        [JsonProperty("parent_id")] public string ParentId { get; set; }
        public class ProfileClass {
            [JsonProperty("class")] public string Class { get; set; }
            [JsonProperty("subclass")] public string Subclass { get; set; }
            [JsonProperty("author")] public string Author { get; set; }
            [JsonProperty("custom1")] public string Custom1 { get; set; }
            [JsonProperty("custom2")] public string Custom2 { get; set; }
            [JsonProperty("custom3")] public string Custom3 { get; set; }
            [JsonProperty("custom4")] public string Custom4 { get; set; }
            [JsonProperty("custom5")] public string Custom5 { get; set; }
            [JsonProperty("custom6")] public string Custom6 { get; set; }    
            [JsonProperty("custom7")] public string Custom7 { get; set; }
            [JsonProperty("custom8")] public string Custom8 { get; set; }          
            [JsonProperty("custom9")] public string Custom9 { get; set; }       
            [JsonProperty("custom10")] public string Custom10 { get; set; }     
            [JsonProperty("custom11")] public string Custom11 { get; set; }  
            [JsonProperty("custom12")] public string Custom12 { get; set; }  
            [JsonProperty("custom13")] public string Custom13 { get; set; }
            [JsonProperty("custom14")] public string Custom14 { get; set; }   
            [JsonProperty("custom15")] public string Custom15 { get; set; } 
            [JsonProperty("custom16")] public string Custom16 { get; set; }      
            [JsonProperty("custom17")] public decimal? Custom17 { get; set; } 
            [JsonProperty("custom18")] public decimal? Custom18 { get; set; }
            [JsonProperty("custom19")] public decimal? Custom19 { get; set; }
            [JsonProperty("custom20")] public decimal? Custom20 { get; set; }  
            [JsonProperty("custom21")] public string Custom21 { get; set; } 
            [JsonProperty("custom22")] public string Custom22 { get; set; }  
            [JsonProperty("custom23")] public string Custom23 { get; set; } 
            [JsonProperty("custom24")] public string Custom24 { get; set; }   
            [JsonProperty("custom25")] public bool? Custom25 { get; set; } 
            [JsonProperty("custom26")] public bool? Custom26 { get; set; }  
            [JsonProperty("custom27")] public bool? Custom27 { get; set; } 
            [JsonProperty("custom28")] public bool? Custom28 { get; set; }
            [JsonProperty("custom29")] public string Custom29 { get; set; }
            [JsonProperty("custom30")] public string Custom30 { get; set; }
            [JsonProperty("custom31")] public string Custom31 { get; set; }
        }
        [JsonProperty("profile")] public ProfileClass Profile { get; set; }
        [JsonProperty("project_custom1")] public string ProjectCustom1 { get; set; }
        [JsonProperty("project_custom2")] public string ProjectCustom2 { get; set; }
        [JsonProperty("project_custom3")] public string ProjectCustom3 { get; set; }
        [JsonProperty("security_policy")] public string SecurityPolicy { get; set; }
        [JsonProperty("subtype")] public string Subtype { get; set; }
        [JsonProperty("view_type")] public string ViewType { get; set; }
        [JsonProperty("workspace_id")] public string WorkspaceId { get; set; }
        [JsonProperty("workspace_name")] public string WorkspaceName { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
    }
    public class ApiFolderChild {
        [JsonProperty("activity_date")] public DateTime? ActivityDate { get; set; }
        [JsonProperty("content_saved_search_id")] public string ContentSavedSearchId { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("edit_date")] public DateTime? EditDate { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("folder_type")] public string FolderType { get; set; }
        [JsonProperty("inherited_default_security")] public string InheritedDefaultSecurity { get; set; }
        [JsonProperty("has_documents")] public bool? HasDocuments { get; set; }
        [JsonProperty("has_subfolders")] public bool? HasSubfolders { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("is_container_saved_search")] public bool? IsContainerSavedSearch { get; set; }
        [JsonProperty("is_content_saved_search")] public bool? IsContentSavedSearch { get; set; }
        [JsonProperty("is_external")] public bool? IsExternal { get; set; }
        [JsonProperty("is_external_as_normal")] public bool? IsExternalAsNormal { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("owner")] public string Owner { get; set; }
        [JsonProperty("owner_description")] public string OwnerDescription { get; set; }

        public class ProfileClass {
            [JsonProperty("class")] public string Class { get; set; }
            [JsonProperty("subclass")] public string Subclass { get; set; }
            [JsonProperty("author")] public string Author { get; set; }
            [JsonProperty("custom1")] public string Custom1 { get; set; }
            [JsonProperty("custom2")] public string Custom2 { get; set; }
            [JsonProperty("custom3")] public string Custom3 { get; set; }
            [JsonProperty("custom4")] public string Custom4 { get; set; }
            [JsonProperty("custom5")] public string Custom5 { get; set; }
            [JsonProperty("custom6")] public string Custom6 { get; set; }
            [JsonProperty("custom7")] public string Custom7 { get; set; }
            [JsonProperty("custom8")] public string Custom8 { get; set; }
            [JsonProperty("custom9")] public string Custom9 { get; set; }
            [JsonProperty("custom10")] public string Custom10 { get; set; }
            [JsonProperty("custom11")] public string Custom11 { get; set; }
            [JsonProperty("custom12")] public string Custom12 { get; set; }
            [JsonProperty("custom13")] public string Custom13 { get; set; }
            [JsonProperty("custom14")] public string Custom14 { get; set; }
            [JsonProperty("custom15")] public string Custom15 { get; set; }
            [JsonProperty("custom16")] public string Custom16 { get; set; }
            [JsonProperty("custom17")] public decimal? Custom17 { get; set; }
            [JsonProperty("custom18")] public decimal? Custom18 { get; set; }
            [JsonProperty("custom19")] public decimal? Custom19 { get; set; }
            [JsonProperty("custom20")] public decimal? Custom20 { get; set; }
            [JsonProperty("custom21")] public string Custom21 { get; set; }
            [JsonProperty("custom22")] public string Custom22 { get; set; }
            [JsonProperty("custom23")] public string Custom23 { get; set; }
            [JsonProperty("custom24")] public string Custom24 { get; set; }
            [JsonProperty("custom25")] public bool? Custom25 { get; set; }
            [JsonProperty("custom26")] public bool? Custom26 { get; set; }
            [JsonProperty("custom27")] public bool? Custom27 { get; set; }
            [JsonProperty("custom28")] public bool? Custom28 { get; set; }
            [JsonProperty("custom29")] public string Custom29 { get; set; }
            [JsonProperty("custom30")] public string Custom30 { get; set; }
            [JsonProperty("custom31")] public string Custom31 { get; set; }
        }
        [JsonProperty("profile")] public ProfileClass Profile { get; set; }
        [JsonProperty("parent_id")] public string ParentId { get; set; }
        [JsonProperty("project_custom1")] public string ProjectCustom1 { get; set; }
        [JsonProperty("project_custom2")] public string ProjectCustom2 { get; set; }
        [JsonProperty("project_custom3")] public string ProjectCustom3 { get; set; }
        public class TargetClass  {
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("folder_type")] public string FolderType { get; set; }
        [JsonProperty("doc_type")] public string DocType { get; set; }
        [JsonProperty("document_number")] public int? DocumentNumber { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("subtype")] public string Subtype { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
        }
        [JsonProperty("target")] public TargetClass  Target { get; set; }
        [JsonProperty("view_type")] public string ViewType { get; set; }
        [JsonProperty("workspace_id")] public string WorkspaceId { get; set; }
        [JsonProperty("workspace_name")] public string WorkspaceName { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
        [JsonProperty("document_number")] public int? DocumentNumber { get; set; }
        [JsonProperty("author")] public string Author { get; set; }
        [JsonProperty("author_description")] public string AuthorDescription { get; set; }
        [JsonProperty("class")] public string Class { get; set; }
        [JsonProperty("subclass")] public string Subclass { get; set; }
        [JsonProperty("content_type")] public string ContentType { get; set; }
        [JsonProperty("create_date")] public DateTime? CreateDate { get; set; }
        [JsonProperty("declared")] public bool? Declared { get; set; }
        [JsonProperty("edit_profile_date")] public DateTime? EditProfileDate { get; set; }
        [JsonProperty("extension")] public string Extension { get; set; }
        [JsonProperty("file_create_date")] public DateTime? FileCreateDate { get; set; }
        [JsonProperty("file_edit_date")] public DateTime? FileEditDate { get; set; }
        [JsonProperty("has_attachment")] public bool? HasAttachment { get; set; }
        [JsonProperty("in_use")] public bool? InUse { get; set; }
        [JsonProperty("indexable")] public bool? Indexable { get; set; }
        [JsonProperty("is_checked_out")] public bool? IsCheckedOut { get; set; }
        [JsonProperty("is_hipaa")] public bool? IsHipaa { get; set; }
        [JsonProperty("is_restorable")] public bool? IsRestorable { get; set; }
        [JsonProperty("iwl")] public string Iwl { get; set; }
        [JsonProperty("last_user")] public string LastUser { get; set; }
        [JsonProperty("last_user_description")] public string LastUserDescription { get; set; }
        [JsonProperty("location")] public string Location { get; set; }
        [JsonProperty("operator")] public string Operator { get; set; }
        [JsonProperty("operator_description")] public string OperatorDescription { get; set; }
        [JsonProperty("retain_days")] public int? RetainDays { get; set; }
        [JsonProperty("size")] public int? Size { get; set; }
        [JsonProperty("shortcut_id")] public string ShortcutId { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("version")] public int? Version { get; set; }
        [JsonProperty("conversation_id")] public string ConversationId { get; set; }
        [JsonProperty("conversation_name")] public string ConversationName { get; set; }
        [JsonProperty("subject")] public string Subject { get; set; }
        [JsonProperty("from")] public string From { get; set; }
        [JsonProperty("to")] public string To { get; set; }
        [JsonProperty("sent_date")] public DateTime? SentDate { get; set; }
        [JsonProperty("custom1")] public string Custom1 { get; set; }
        [JsonProperty("custom1_description")] public string Custom1Description { get; set; }
        [JsonProperty("custom2")] public string Custom2 { get; set; }
        [JsonProperty("custom2_description")] public string Custom2Description { get; set; }
        [JsonProperty("custom3")] public string Custom3 { get; set; }
        [JsonProperty("custom3_description")] public string Custom3Description { get; set; }
        [JsonProperty("custom4")] public string Custom4 { get; set; }
        [JsonProperty("custom4_description")] public string Custom4Description { get; set; }
        [JsonProperty("custom5")] public string Custom5 { get; set; }
        [JsonProperty("custom5_description")] public string Custom5Description { get; set; }
        [JsonProperty("custom6")] public string Custom6 { get; set; }
        [JsonProperty("custom6_description")] public string Custom6Description { get; set; }
        [JsonProperty("custom7")] public string Custom7 { get; set; }
        [JsonProperty("custom7_description")] public string Custom7Description { get; set; }
        [JsonProperty("custom8")] public string Custom8 { get; set; }
        [JsonProperty("custom8_description")] public string Custom8Description { get; set; }
        [JsonProperty("custom9")] public string Custom9 { get; set; }
        [JsonProperty("custom9_description")] public string Custom9Description { get; set; }
        [JsonProperty("custom10")] public string Custom10 { get; set; }
        [JsonProperty("custom10_description")] public string Custom10Description { get; set; }
        [JsonProperty("custom11")] public string Custom11 { get; set; }
        [JsonProperty("custom11_description")] public string Custom11Description { get; set; }
        [JsonProperty("custom12")] public string Custom12 { get; set; }
        [JsonProperty("custom12_description")] public string Custom12Description { get; set; }
        [JsonProperty("custom13")] public string Custom13 { get; set; }
        [JsonProperty("custom14")] public string Custom14 { get; set; }
        [JsonProperty("custom15")] public string Custom15 { get; set; }
        [JsonProperty("custom16")] public string Custom16 { get; set; }
        [JsonProperty("custom17")] public int? Custom17 { get; set; }
        [JsonProperty("custom18")] public int? Custom18 { get; set; }
        [JsonProperty("custom19")] public decimal? Custom19 { get; set; }
        [JsonProperty("custom20")] public int? Custom20 { get; set; }
        [JsonProperty("custom21")] public DateTime? Custom21 { get; set; }
        [JsonProperty("custom22")] public DateTime? Custom22 { get; set; }
        [JsonProperty("custom23")] public DateTime? Custom23 { get; set; }
        [JsonProperty("custom24")] public DateTime? Custom24 { get; set; }
        [JsonProperty("custom25")] public bool? Custom25 { get; set; }
        [JsonProperty("custom26")] public bool? Custom26 { get; set; }
        [JsonProperty("custom27")] public bool? Custom27 { get; set; }
        [JsonProperty("custom28")] public bool? Custom28 { get; set; }
        [JsonProperty("custom29")] public string Custom29 { get; set; }
        [JsonProperty("custom29_description")] public string Custom29Description { get; set; }
        [JsonProperty("custom30")] public string Custom30 { get; set; }
        [JsonProperty("custom30_description")] public string Custom30Description { get; set; }
        [JsonProperty("custom31")] public string Custom31 { get; set; }
        [JsonProperty("custom31_description")] public string Custom31Description { get; set; }
    }
    public class ApiFolderSearchRequest {
        [JsonProperty("limit")] public int? Limit { get; set; }
        [JsonProperty("timezone_offset")] public int? TimezoneOffset { get; set; }
        public class ProfileFieldsClass  {
        [JsonProperty("folder")] public string[] Folder { get; set; }
        }
        [JsonProperty("profile_fields")] public ProfileFieldsClass  ProfileFields { get; set; }
        public class FiltersClass  {
        [JsonProperty("libraries")] public string Libraries { get; set; }
        [JsonProperty("container_id")] public string ContainerId { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("include_ids")] public string IncludeIds { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("name_or_description")] public string NameOrDescription { get; set; }
        [JsonProperty("owner")] public string Owner { get; set; }
        [JsonProperty("reference_database")] public string ReferenceDatabase { get; set; }
        [JsonProperty("workspace_name")] public string WorkspaceName { get; set; }
        }
        [JsonProperty("filters")] public FiltersClass  Filters { get; set; }
    }
    public class ApiWorkspace {
        [JsonProperty("activity_date")] public DateTime? ActivityDate { get; set; }
        [JsonProperty("create_date")] public DateTime? CreateDate { get; set; }
        [JsonProperty("custom1")] public string Custom1 { get; set; }
        [JsonProperty("custom1_description")] public string Custom1Description { get; set; }
        [JsonProperty("custom2")] public string Custom2 { get; set; }
        [JsonProperty("custom2_description")] public string Custom2Description { get; set; }
        [JsonProperty("custom3")] public string Custom3 { get; set; }
        [JsonProperty("custom3_description")] public string Custom3Description { get; set; }
        [JsonProperty("custom4")] public string Custom4 { get; set; }
        [JsonProperty("custom4_description")] public string Custom4Description { get; set; }
        [JsonProperty("custom5")] public string Custom5 { get; set; }
        [JsonProperty("custom5_description")] public string Custom5Description { get; set; }
        [JsonProperty("custom6")] public string Custom6 { get; set; }
        [JsonProperty("custom6_description")] public string Custom6Description { get; set; }
        [JsonProperty("custom7")] public string Custom7 { get; set; }
        [JsonProperty("custom7_description")] public string Custom7Description { get; set; }
        [JsonProperty("custom8")] public string Custom8 { get; set; }
        [JsonProperty("custom8_description")] public string Custom8Description { get; set; }
        [JsonProperty("custom9")] public string Custom9 { get; set; }
        [JsonProperty("custom9_description")] public string Custom9Description { get; set; }
        [JsonProperty("custom10")] public string Custom10 { get; set; }
        [JsonProperty("custom10_description")] public string Custom10Description { get; set; }
        [JsonProperty("custom11")] public string Custom11 { get; set; }
        [JsonProperty("custom11_description")] public string Custom11Description { get; set; }
        [JsonProperty("custom12")] public string Custom12 { get; set; }
        [JsonProperty("custom12_description")] public string Custom12Description { get; set; }
        [JsonProperty("custom13")] public string Custom13 { get; set; }
        [JsonProperty("custom14")] public string Custom14 { get; set; }
        [JsonProperty("custom15")] public string Custom15 { get; set; }
        [JsonProperty("custom16")] public string Custom16 { get; set; }
        [JsonProperty("custom17")] public decimal? Custom17 { get; set; }
        [JsonProperty("custom18")] public decimal? Custom18 { get; set; }
        [JsonProperty("custom19")] public decimal? Custom19 { get; set; }
        [JsonProperty("custom20")] public decimal? Custom20 { get; set; }
        [JsonProperty("custom21")] public DateTime? Custom21 { get; set; }
        [JsonProperty("custom22")] public DateTime? Custom22 { get; set; }
        [JsonProperty("custom23")] public DateTime? Custom23 { get; set; }
        [JsonProperty("custom24")] public DateTime? Custom24 { get; set; }
        [JsonProperty("custom25")] public bool? Custom25 { get; set; }
        [JsonProperty("custom26")] public bool? Custom26 { get; set; }
        [JsonProperty("custom27")] public bool? Custom27 { get; set; }
        [JsonProperty("custom28")] public bool? Custom28 { get; set; }
        [JsonProperty("custom29")] public string Custom29 { get; set; }
        [JsonProperty("custom29_description")] public string Custom29Description { get; set; }
        [JsonProperty("custom30")] public string Custom30 { get; set; }
        [JsonProperty("custom30_description")] public string Custom30Description { get; set; }
        [JsonProperty("custom31")] public string Custom31 { get; set; }
        [JsonProperty("custom31_description")] public string Custom31Description { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("declared_date")] public DateTime? DeclaredDate { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("document_number")] public int? DocumentNumber { get; set; }
        [JsonProperty("edit_date")] public DateTime? EditDate { get; set; }
        [JsonProperty("effective_security")] public string EffectiveSecurity { get; set; }
        [JsonProperty("has_subfolders")] public bool? HasSubfolders { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("is_declared")] public bool? IsDeclared { get; set; }
        [JsonProperty("is_external")] public bool? IsExternal { get; set; }
        [JsonProperty("is_external_as_normal")] public bool? IsExternalAsNormal { get; set; }
        [JsonProperty("is_hipaa")] public bool? IsHipaa { get; set; }
        [JsonProperty("iwl")] public string Iwl { get; set; }
        [JsonProperty("last_user")] public string LastUser { get; set; }
        [JsonProperty("last_user_description")] public string LastUserDescription { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("owner")] public string Owner { get; set; }
        [JsonProperty("owner_description")] public string OwnerDescription { get; set; }
        public class ProfileClass  {
        }
        [JsonProperty("profile")] public ProfileClass  Profile { get; set; }
        [JsonProperty("project_custom1")] public string ProjectCustom1 { get; set; }
        [JsonProperty("project_custom2")] public string ProjectCustom2 { get; set; }
        [JsonProperty("project_custom3")] public string ProjectCustom3 { get; set; }
        [JsonProperty("retain_days")] public int? RetainDays { get; set; }
        [JsonProperty("subclass")] public string Subclass { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
    }
    public class ApiWorkspaceChild {
        [JsonProperty("activity_date")] public DateTime? ActivityDate { get; set; }
        [JsonProperty("container_saved_search_id")] public string ContainerSavedSearchId { get; set; }
        [JsonProperty("content_saved_search_id")] public string ContentSavedSearchId { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("edit_date")] public DateTime? EditDate { get; set; }
        [JsonProperty("effective_security")] public string EffectiveSecurity { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("folder_type")] public string FolderType { get; set; }
        [JsonProperty("has_documents")] public bool? HasDocuments { get; set; }
        [JsonProperty("has_security")] public bool? HasSecurity { get; set; }
        [JsonProperty("has_subfolders")] public bool? HasSubfolders { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("imanage_share_eid")] public string ImanageShareEid { get; set; }
        [JsonProperty("imanage_share_url")] public string ImanageShareUrl { get; set; }
        [JsonProperty("inherited_default_security")] public string InheritedDefaultSecurity { get; set; }
        [JsonProperty("is_container_saved_search")] public bool? IsContainerSavedSearch { get; set; }
        [JsonProperty("is_content_saved_search")] public bool? IsContentSavedSearch { get; set; }
        [JsonProperty("is_external")] public bool? IsExternal { get; set; }
        [JsonProperty("is_external_as_normal")] public bool? IsExternalAsNormal { get; set; }
        [JsonProperty("location")] public string Location { get; set; }
        [JsonProperty("my_matters_shortcut_id")] public string MyMattersShortcutId { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("owner")] public string Owner { get; set; }
        [JsonProperty("owner_description")] public string OwnerDescription { get; set; }
        [JsonProperty("parent_id")] public string ParentId { get; set; }
        [JsonProperty("project_custom1")] public string ProjectCustom1 { get; set; }
        [JsonProperty("project_custom2")] public string ProjectCustom2 { get; set; }
        [JsonProperty("project_custom3")] public string ProjectCustom3 { get; set; }
        [JsonProperty("security_policy")] public string SecurityPolicy { get; set; }
        [JsonProperty("subtype")] public string Subtype { get; set; }
        [JsonProperty("view_type")] public string ViewType { get; set; }
        [JsonProperty("workspace_id")] public string WorkspaceId { get; set; }
        [JsonProperty("workspace_name")] public string WorkspaceName { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
    }
    public class ApiWorkspaceWithOperations {
        [JsonProperty("activity_date")] public DateTime? ActivityDate { get; set; }
        [JsonProperty("create_date")] public DateTime? CreateDate { get; set; }
        [JsonProperty("custom1")] public string Custom1 { get; set; }
        [JsonProperty("custom1_description")] public string Custom1Description { get; set; }
        [JsonProperty("custom2")] public string Custom2 { get; set; }
        [JsonProperty("custom2_description")] public string Custom2Description { get; set; }
        [JsonProperty("custom3")] public string Custom3 { get; set; }
        [JsonProperty("custom3_description")] public string Custom3Description { get; set; }
        [JsonProperty("custom4")] public string Custom4 { get; set; }
        [JsonProperty("custom4_description")] public string Custom4Description { get; set; }
        [JsonProperty("custom5")] public string Custom5 { get; set; }
        [JsonProperty("custom5_description")] public string Custom5Description { get; set; }
        [JsonProperty("custom6")] public string Custom6 { get; set; }
        [JsonProperty("custom6_description")] public string Custom6Description { get; set; }
        [JsonProperty("custom7")] public string Custom7 { get; set; }
        [JsonProperty("custom7_description")] public string Custom7Description { get; set; }
        [JsonProperty("custom8")] public string Custom8 { get; set; }
        [JsonProperty("custom8_description")] public string Custom8Description { get; set; }
        [JsonProperty("custom9")] public string Custom9 { get; set; }
        [JsonProperty("custom9_description")] public string Custom9Description { get; set; }
        [JsonProperty("custom10")] public string Custom10 { get; set; }
        [JsonProperty("custom10_description")] public string Custom10Description { get; set; }
        [JsonProperty("custom11")] public string Custom11 { get; set; }
        [JsonProperty("custom11_description")] public string Custom11Description { get; set; }
        [JsonProperty("custom12")] public string Custom12 { get; set; }
        [JsonProperty("custom12_description")] public string Custom12Description { get; set; }
        [JsonProperty("custom13")] public string Custom13 { get; set; }
        [JsonProperty("custom14")] public string Custom14 { get; set; }
        [JsonProperty("custom15")] public string Custom15 { get; set; }
        [JsonProperty("custom16")] public string Custom16 { get; set; }
        [JsonProperty("custom17")] public decimal? Custom17 { get; set; }
        [JsonProperty("custom18")] public decimal? Custom18 { get; set; }
        [JsonProperty("custom19")] public decimal? Custom19 { get; set; }
        [JsonProperty("custom20")] public decimal? Custom20 { get; set; }
        [JsonProperty("custom21")] public DateTime? Custom21 { get; set; }
        [JsonProperty("custom22")] public DateTime? Custom22 { get; set; }
        [JsonProperty("custom23")] public DateTime? Custom23 { get; set; }
        [JsonProperty("custom24")] public DateTime? Custom24 { get; set; }
        [JsonProperty("custom25")] public bool? Custom25 { get; set; }
        [JsonProperty("custom26")] public bool? Custom26 { get; set; }
        [JsonProperty("custom27")] public bool? Custom27 { get; set; }
        [JsonProperty("custom28")] public bool? Custom28 { get; set; }
        [JsonProperty("custom29")] public string Custom29 { get; set; }
        [JsonProperty("custom29_description")] public string Custom29Description { get; set; }
        [JsonProperty("custom30")] public string Custom30 { get; set; }
        [JsonProperty("custom30_description")] public string Custom30Description { get; set; }
        [JsonProperty("custom31")] public string Custom31 { get; set; }
        [JsonProperty("custom31_description")] public string Custom31Description { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("declared_date")] public DateTime? DeclaredDate { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("document_number")] public int? DocumentNumber { get; set; }
        [JsonProperty("edit_date")] public DateTime? EditDate { get; set; }
        [JsonProperty("effective_security")] public string EffectiveSecurity { get; set; }
        [JsonProperty("has_subfolders")] public bool? HasSubfolders { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("is_declared")] public bool? IsDeclared { get; set; }
        [JsonProperty("is_external")] public bool? IsExternal { get; set; }
        [JsonProperty("is_external_as_normal")] public bool? IsExternalAsNormal { get; set; }
        [JsonProperty("is_hipaa")] public bool? IsHipaa { get; set; }
        [JsonProperty("iwl")] public string Iwl { get; set; }
        [JsonProperty("last_user")] public string LastUser { get; set; }
        [JsonProperty("last_user_description")] public string LastUserDescription { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("owner")] public string Owner { get; set; }
        [JsonProperty("owner_description")] public string OwnerDescription { get; set; }
        public class ProfileClass  {
        }
        [JsonProperty("profile")] public ProfileClass  Profile { get; set; }
        [JsonProperty("project_custom1")] public string ProjectCustom1 { get; set; }
        [JsonProperty("project_custom2")] public string ProjectCustom2 { get; set; }
        [JsonProperty("project_custom3")] public string ProjectCustom3 { get; set; }
        [JsonProperty("retain_days")] public int? RetainDays { get; set; }
        [JsonProperty("subclass")] public string Subclass { get; set; }
        [JsonProperty("wstype")] public string Wstype { get; set; }
        public class OperationsClass  {
        [JsonProperty("add_custom_folders")] public bool? AddCustomFolders { get; set; }
        [JsonProperty("add_folders")] public bool? AddFolders { get; set; }
        [JsonProperty("change_name")] public bool? ChangeName { get; set; }
        [JsonProperty("modify")] public bool? Modify { get; set; }
        [JsonProperty("remove")] public bool? Remove { get; set; }
        [JsonProperty("remove_folders")] public bool? RemoveFolders { get; set; }
        [JsonProperty("set_default_security")] public bool? SetDefaultSecurity { get; set; }
        [JsonProperty("set_security")] public bool? SetSecurity { get; set; }
        [JsonProperty("update_content_shortcut")] public bool? UpdateContentShortcut { get; set; }
        [JsonProperty("default_security_values")] public string[] DefaultSecurityValues { get; set; }
        }
        [JsonProperty("operations")] public OperationsClass  Operations { get; set; }
    }

    [Serializable]
    public class ApiTemplate {
        [JsonProperty("activity_date")]  public DateTime? ActivityDate { get; set; }
        [JsonProperty("author")] public string Author { get; set; }
        [JsonProperty("author_description")] public string AuthorDescription { get; set; }
        [JsonProperty("class")] public string Class { get; set; }
        [JsonProperty("comment")] public string Comment { get; set; }
        [JsonProperty("content_type")] public string Content_type { get; set; }
        [JsonProperty("conversation_id")] public string Conversation_id { get; set; }
        [JsonProperty("conversation_name")] public string Conversation_name { get; set; }
        [JsonProperty("create_date")] public DateTime? CreateDate { get; set; }
        [JsonProperty("custom1")] public string Custom1 { get; set; }
        [JsonProperty("custom1_description")] public string Custom1_description { get; set; }
        [JsonProperty("custom2")] public string Custom2 { get; set; }
        [JsonProperty("custom2_description")] public string Custom2_description { get; set; }
        [JsonProperty("custom3")] public string Custom3 { get; set; }
        [JsonProperty("custom3_description")] public string Custom3_description { get; set; }
        [JsonProperty("custom4")] public string Custom4 { get; set; }
        [JsonProperty("custom4_description")] public string Custom4_description { get; set; }
        [JsonProperty("custom5")] public string Custom5 { get; set; }
        [JsonProperty("custom5_description")] public string Custom5_description { get; set; }
        [JsonProperty("custom6")] public string Custom6 { get; set; }
        [JsonProperty("custom6_description")] public string Custom6_description { get; set; }
        [JsonProperty("custom7")] public string Custom7 { get; set; }
        [JsonProperty("custom7_description")] public string Custom7_description { get; set; }
        [JsonProperty("custom8")] public string Custom8 { get; set; }
        [JsonProperty("custom8_description")] public string Custom8_description { get; set; }
        [JsonProperty("custom9")] public string Custom9 { get; set; }
        [JsonProperty("custom9_description")] public string Custom9_description { get; set; }
        [JsonProperty("custom10")] public string Custom10 { get; set; }
        [JsonProperty("custom10_description")] public string Custom10_description { get; set; }
        [JsonProperty("custom11")] public string Custom11 { get; set; }
        [JsonProperty("custom11_description")] public string Custom11_description { get; set; }
        [JsonProperty("custom12")] public string Custom12 { get; set; }
        [JsonProperty("custom12_description")] public string Custom12_description { get; set; }
        [JsonProperty("custom13")] public string Custom13 { get; set; }
        [JsonProperty("custom14")] public string Custom14 { get; set; }
        [JsonProperty("custom15")] public string Custom15 { get; set; }
        [JsonProperty("custom16")] public string Custom16 { get; set; }
        [JsonProperty("custom17")] public string Custom17 { get; set; }
        [JsonProperty("custom18")] public string Custom18 { get; set; }
        [JsonProperty("custom19")] public string Custom19 { get; set; } 
        [JsonProperty("custom20")] public string Custom20 { get; set; }
        [JsonProperty("custom21")] public string Custom21 { get; set; }
        [JsonProperty("custom22")] public string Custom22 { get; set; }
        [JsonProperty("custom23")] public string Custom23 { get; set; }
        [JsonProperty("custom24")] public string Custom24 { get; set; }
        [JsonProperty("custom25")] public string Custom25 { get; set; }
        [JsonProperty("custom26")] public string Custom26 { get; set; }
        [JsonProperty("custom27")] public string Custom27 { get; set; }
        [JsonProperty("custom28")] public string Custom28 { get; set; }
        [JsonProperty("custom29")] public string Custom29 { get; set; }
        [JsonProperty("custom29_description")] public string Custom29_description { get; set; }
        [JsonProperty("custom30")] public string Custom30 { get; set; }
        [JsonProperty("custom30_description")] public string Custom30_description { get; set; }
        [JsonProperty("database")] public string Database { get; set; }
        [JsonProperty("default_security")] public string DefaultSecurity { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("edit_date")] public DateTime? EditDate { get; set; }
        [JsonProperty("edit_profile_date")] public DateTime? EditProfileDate { get; set; }
        [JsonProperty("extension")] public string Extension { get; set; }
        [JsonProperty("file_create_date")] public DateTime? FileCreateDate { get; set; }
        [JsonProperty("file_edit_date")] public DateTime? FileEditDate { get; set; }
        [JsonProperty("has_attachment")] public bool HasAttachment { get; set; }
        [JsonProperty("has_documents")] public bool HasDocuments { get; set; }
        [JsonProperty("has_subfolders")] public bool HasSubfolders { get; set; }
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("in_use")] public bool InUse { get; set; }
        [JsonProperty("is_container_saved_search")] public bool IsContainerSavedSearch { get; set; }
        [JsonProperty("is_content_saved_search")] public bool IsContentSavedSearch { get; set; }
        [JsonProperty("is_external_as_normal")] public bool IsExternalAsNormal { get; set; }
        [JsonProperty("is_hipaa")] public bool IsHipaa { get; set; }
        [JsonProperty("is_restorable")] public bool IsRestorable { get; set; }
        [JsonProperty("iwl")] public string Iwl { get; set; }
        [JsonProperty("last_user")] public string LastUser { get; set; }
        [JsonProperty("last_user_description")] public string LastUserDescription { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("operator")] public string Operator { get; set; }
        [JsonProperty("operator_description")] public string OperatorDescription { get; set; }
        [JsonProperty("owner")] public string Owner { get; set; }
        [JsonProperty("owner_description")] public string OwnerDescription { get; set; }
        [JsonProperty("project_custom1")] public string Projectcustom1 { get; set; }
        [JsonProperty("project_custom2")] public string Projectcustom2 { get; set; }
        [JsonProperty("project_custom3")] public string Projectcustom3 { get; set; }
        [JsonProperty("size")] public int Size { get; set; }
        [JsonProperty("sub_class")] public string Subclass { get; set; }
        [JsonProperty("subject")] public string Subject { get; set; }
        [JsonProperty("subtype")] public string Subtype { get; set; }
        [JsonProperty("type")] public string Type { get; set; }
        [JsonProperty("version")] public int Version { get; set; }

    }
}

