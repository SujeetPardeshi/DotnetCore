using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConfiguration
{
    public class EnvDetails
    {
        public string Env { get; set; }
        public int ThresholdCount { get; set; }
        public bool UseSerilog { get; set; }
        public List<UserDetails> UserDetails { get; set; }
        public Dictionary<string, string> ProcessDetails { get; set; }

        public void DisplayProcessDetails()
        {
            foreach (var detail in ProcessDetails)
            {
                Console.WriteLine($"{detail.Key}-{detail.Value}");
            }
        }

        public override string ToString()
        {
            return $"{Env}-{ThresholdCount}-{UseSerilog}-{string.Join('.', UserDetails.Select(_ => _.ToString()))}";
        }
    }

    public class UserDetails
    {
        public string Name { get; set; }
        public string Profession { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Profession}";
        }
    }
}
