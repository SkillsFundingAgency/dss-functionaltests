using System;
using System.Collections;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace FunctionalTests
{
    public class EnvironmentSettings 
    {
        private static readonly IConfiguration Configuration =
            new EnvironmentSettingsConfigurationBuilder(nameof(NCS.DSS.FunctionalTests)).BuildConfiguration();

        public string BaseUrl => Configuration["RestService:BaseUrl"];
        public string TouchPointId => Configuration["RestService:TouchPointId"];
        public string SubscriptionKey => Configuration["RestService:SubscriptionKey"];
        public bool IsRunningInTfsPipeline { get; } = GetIsRunningInTfsPipeline();

         private static bool GetIsRunningInTfsPipeline() => Environment.GetEnvironmentVariables()
            .Cast<DictionaryEntry>()
            .Any(x => (string.Equals(x.Key?.ToString(), "SYSTEM_HOSTTYPE", StringComparison.OrdinalIgnoreCase) ||
                       string.Equals(x.Key?.ToString(), "SYSTEM", StringComparison.OrdinalIgnoreCase)) &&
                      string.Equals(x.Value?.ToString(), "release", StringComparison.OrdinalIgnoreCase));
    }
}
