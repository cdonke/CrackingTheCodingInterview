``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |    N |  M | i | j | expected |     Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |----- |--- |-- |-- |--------- |---------:|----------:|----------:|------:|------:|------:|----------:|
| **SecondTry** | **1024** | **19** | **2** | **6** |     **1100** | **1.331 ns** | **0.0423 ns** | **0.0396 ns** |     **-** |     **-** |     **-** |         **-** |
|  ThirdTry | 1024 | 19 | 2 | 6 |     1100 | 1.085 ns | 0.0180 ns | 0.0168 ns |     - |     - |     - |         - |
| **SecondTry** | **2047** | **19** | **2** | **6** |     **1999** | **1.097 ns** | **0.0144 ns** | **0.0135 ns** |     **-** |     **-** |     **-** |         **-** |
|  ThirdTry | 2047 | 19 | 2 | 6 |     1999 | 1.104 ns | 0.0092 ns | 0.0086 ns |     - |     - |     - |         - |
