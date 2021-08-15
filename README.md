# DotnetCore
Adding sample project for dot net core
In Protobuff project, I tried to compare between JSON and protobuff serializer, here are my findings
|         Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
|--------------- |----------:|----------:|----------:|-------:|----------:|
| ProtoSerialise |  6.031 us | 0.1199 us | 0.1902 us | 1.0071 |      2 KB |
|  JsonSerialize | 23.302 us | 0.4562 us | 0.7102 us | 4.6692 |      7 KB |

In TestConfiguration project, tried to add multiple JSON files and tried to deserilize complex object stored in configuration files.
