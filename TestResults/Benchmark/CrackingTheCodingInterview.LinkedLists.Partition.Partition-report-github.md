``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|   Method |                 list | partition |               result |     Mean |    Error |   StdDev |   Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------------------- |---------- |--------------------- |---------:|---------:|---------:|---------:|-------:|------:|------:|----------:|
| FirstTry | Syste(...)nt32] [53] |         5 | Syste(...)nt32] [53] | 297.7 ns | 10.76 ns | 31.71 ns | 289.4 ns | 0.0229 |     - |     - |     608 B |
