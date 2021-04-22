``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-TSPEUX : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|   Method |          A |     Mean |     Error |    StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |----------- |---------:|----------:|----------:|---------:|------:|------:|------:|----------:|
| FirstTry | Int32[][4] | 1.443 μs | 0.0411 μs | 0.1185 μs | 1.500 μs |     - |     - |     - |      56 B |
| FirstTry | Int32[][4] | 1.571 μs | 0.0475 μs | 0.1402 μs | 1.550 μs |     - |     - |     - |      56 B |
| FirstTry | Int32[][4] | 1.421 μs | 0.0375 μs | 0.1089 μs | 1.400 μs |     - |     - |     - |      56 B |
