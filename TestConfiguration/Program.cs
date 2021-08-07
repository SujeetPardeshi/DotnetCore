using System;

namespace TestConfiguration
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var configurationTester = new ConfigurationTester();

            var envDetails = configurationTester.GetEnvDetails();
            Console.WriteLine(envDetails);
            Console.WriteLine("Process details");
            envDetails.DisplayProcessDetails();
            Console.WriteLine($"Hello World!" + configurationTester.GetValue<int>("test"));
        }
    }
}
