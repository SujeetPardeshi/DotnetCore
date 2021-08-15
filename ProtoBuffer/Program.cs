using System;
using System.IO;
using BenchmarkDotNet.Running;
using ProtoBuf;

namespace ProtoBuffer
{
    class Program
    {
        private static User[] _users = GetUsers();

        static void Main(string[] args)
        {
            var serialisedUsers = GetStream(_users);
            var users = Serializer.Deserialize<User[]>(new MemoryStream(serialisedUsers));
            File.WriteAllBytes("Prtobuff_user_output", serialisedUsers);
            File.WriteAllText("JSON_user_output.json", Newtonsoft.Json.JsonConvert.SerializeObject(users));

            Console.WriteLine("SizeOf Protobuf serialized file:{0}", GetSizeOfFile("Prtobuff_user_output")); // 150
            Console.WriteLine("SizeOf JSON serialized file:{0}", GetSizeOfFile("JSON_user_output.json")); // 370

            BenchmarkRunner.Run<SerializerBenchmarks>();
        }

        internal static User[] GetUsers()
        {
            return new[]
            {
                new User{ Address = "Pune", Id = 1, Name = "User1"},
                new User{ Address = "Pune", Id = 2, Name = "User2"},
                new User{ Address = "Pune", Id = 3, Name = "User3"},
                new User{ Address = "Pune", Id = 4, Name = "User4"},
                new User{ Address = "Pune", Id = 5, Name = "User5"},
                new User{ Address = "Pune", Id = 6, Name = "User6"},
                new User{ Address = "Pune", Id = 7, Name = "User7"},
                new User{ Address = "Pune", Id = 8, Name = "User8"},
                new User{ Address = "Pune", Id = 9, Name = "User9"},
            };
        }

        internal static byte[] GetStream<T>(T obj)
        {
            using var stream = new MemoryStream();
            Serializer.Serialize(stream, obj);
            return stream.ToArray();
        }

        private static double GetSizeOfFile(string fileName) => new FileInfo(fileName).Length;
    }
}
