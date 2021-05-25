``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  Job-YPZHDC : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|   Method |          A |     Mean |     Error |    StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |----------- |---------:|----------:|----------:|---------:|------:|------:|------:|----------:|
| FirstTry | Int32[][4] | 1.694 μs | 0.0411 μs | 0.1213 μs | 1.700 μs |     - |     - |     - |      56 B |
| FirstTry | Int32[][4] | 1.655 μs | 0.0389 μs | 0.1018 μs | 1.700 μs |     - |     - |     - |      56 B |
| FirstTry | Int32[][4] | 1.527 μs | 0.0401 μs | 0.1177 μs | 1.500 μs |     - |     - |     - |      56 B |
