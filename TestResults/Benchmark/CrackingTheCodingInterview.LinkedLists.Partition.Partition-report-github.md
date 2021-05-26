``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |                 list | partition |               result |     Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------------------- |---------- |--------------------- |---------:|--------:|--------:|-------:|------:|------:|----------:|
| FirstTry | Syste(...)nt32] [53] |         5 | Syste(...)nt32] [53] | 351.8 ns | 3.58 ns | 3.35 ns | 0.0324 |     - |     - |     608 B |
