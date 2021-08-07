using Microsoft.Extensions.Configuration;

namespace TestConfiguration
{
    partial class Program
    {
        public class ConfigurationTester
        {
            private readonly IConfigurationRoot _configuration;

            public ConfigurationTester()
            {
                _configuration = GetConfiguration();               
            }

            public EnvDetails GetEnvDetails()
            {
                var envDetails = new EnvDetails();
                _configuration.Bind("EnvDetails", envDetails);
                return envDetails;
            }

            public T GetValue<T>(string key) => _configuration.GetValue<T>(key);

            private IConfigurationRoot GetConfiguration()
            {
                return new ConfigurationBuilder().
                    AddJsonFile("appsettings.json").
                    AddJsonFile("sampleconfiguration.json").
                    AddEnvironmentVariables().
                    Build();
            }
        }
    }
}
