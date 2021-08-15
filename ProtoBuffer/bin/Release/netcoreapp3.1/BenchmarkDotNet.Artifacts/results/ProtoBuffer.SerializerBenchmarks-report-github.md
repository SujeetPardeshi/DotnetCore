``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i5-6200U CPU 2.30GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
|         Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
|--------------- |----------:|----------:|----------:|----------:|-------:|----------:|
| ProtoSerialise |  7.261 μs | 0.2323 μs | 0.6776 μs |  6.939 μs | 1.0071 |      2 KB |
|  JsonSerialize | 26.578 μs | 0.5167 μs | 0.6718 μs | 26.642 μs | 4.6692 |      7 KB |
