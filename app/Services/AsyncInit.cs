using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace PE.Mk2.Integrations.IManage.Services
{
    internal interface IAsyncInit
    {
        /// <summary>
        /// Initialise
        /// </summary>
        /// <returns></returns>
        Task InitAsync();

        /// <summary>
        /// Check if service is running correctly
        /// </summary>
        /// <returns></returns>
        HealthCheckResult CheckHealth();
    }
}
