``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  Job-QRKKPS : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|   Method |          A |     Mean |     Error |    StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |----------- |---------:|----------:|----------:|---------:|------:|------:|------:|----------:|
| FirstTry | Int32[][4] | 1.420 μs | 0.0354 μs | 0.1022 μs | 1.400 μs |     - |     - |     - |      56 B |
| FirstTry | Int32[][4] | 1.371 μs | 0.0334 μs | 0.0806 μs | 1.400 μs |     - |     - |     - |      56 B |
| FirstTry | Int32[][4] | 1.477 μs | 0.0459 μs | 0.1346 μs | 1.500 μs |     - |     - |     - |      56 B |
