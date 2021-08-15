using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using ProtoBuf;
using System.IO;

namespace ProtoBuffer
{
    [MemoryDiagnoser]
    public class SerializerBenchmarks
    {
        private static readonly User[] _users = Program.GetUsers();

        [Benchmark]
        public void ProtoSerialise()
        {
            Serializer.Deserialize<User[]>(new MemoryStream(Program.GetStream(_users)));
        }

        [Benchmark]
        public void JsonSerialize()
        {
            JsonConvert.DeserializeObject<User[]>(JsonConvert.SerializeObject(_users));
        }
    }
}
