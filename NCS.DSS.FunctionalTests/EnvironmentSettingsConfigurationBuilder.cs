using Microsoft.Extensions.Configuration;
using System.IO;

namespace NCS.DSS.FunctionalTests
{
    public class EnvironmentSettingsConfigurationBuilder
    {
        string AppName;

        public EnvironmentSettingsConfigurationBuilder(string appName)
        {
            AppName = appName;
        }

        public IConfiguration BuildConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()); ;
            configurationBuilder
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.local.json")
                .AddEnvironmentVariables();;
            return configurationBuilder.Build();
        }
    }
}
