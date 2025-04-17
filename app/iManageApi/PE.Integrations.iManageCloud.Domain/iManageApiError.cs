using System;
using System.Collections.Generic;
using System.Text;
using PE.Integrations.iManageCloud.ApiModel.ApiTypes;

namespace PE.Integrations.iManageCloud.Domain {
    public class iManageApiError : ApiError {
        public override string ToString() => $"{Error?.CodeMessage}";
    }

    public static class ApiErrorCode {
        public const string InvalidParamater = "NRC_INVALID_PARAM";
        public const string NoRecord = "NRC_NO_RECORD";
    }
}
