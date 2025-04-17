using System;
using PE.Integrations.iManageCloud.Domain;

namespace PE.Integrations.iManageCloud {
    [Serializable]
    public class iManageApiException : Exception {
        public iManageApiException(iManageApiError apiError, Exception inner) : base(apiError?.ToString(), inner) => ApiError = apiError;
        public iManageApiError ApiError { get; }
    }
}
