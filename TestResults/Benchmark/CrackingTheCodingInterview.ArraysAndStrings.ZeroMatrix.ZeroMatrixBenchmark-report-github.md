``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  Job-CYBFUF : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|   Method |          A |     Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |----------- |---------:|----------:|----------:|------:|------:|------:|----------:|
| FirstTry | Int32[][4] | 1.223 μs | 0.0347 μs | 0.1000 μs |     - |     - |     - |      56 B |
| FirstTry | Int32[][4] | 1.216 μs | 0.0324 μs | 0.0939 μs |     - |     - |     - |      56 B |
| FirstTry | Int32[][4] | 1.380 μs | 0.0487 μs | 0.1429 μs |     - |     - |     - |      56 B |
