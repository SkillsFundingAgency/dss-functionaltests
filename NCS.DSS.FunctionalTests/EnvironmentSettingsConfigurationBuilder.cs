using Microsoft.Extensions.Configuration;
using System.IO;

namespace FunctionalTests
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
            configurationBuilder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            configurationBuilder.AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true);
            return configurationBuilder.Build();
        }
    }
}
