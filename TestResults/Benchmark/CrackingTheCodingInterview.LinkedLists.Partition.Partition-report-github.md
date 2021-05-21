``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |                 list | partition |               result |     Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------------------- |---------- |--------------------- |---------:|--------:|--------:|-------:|------:|------:|----------:|
| FirstTry | Syste(...)nt32] [53] |         5 | Syste(...)nt32] [53] | 400.8 ns | 5.92 ns | 5.54 ns | 0.0229 |     - |     - |     608 B |
