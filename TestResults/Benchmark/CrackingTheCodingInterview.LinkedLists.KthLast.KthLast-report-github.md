``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |                 list | kth | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |---- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** | **Syste(...)nt32] [53]** |   **1** |        **1** | **11.480 ns** | **0.0074 ns** | **0.0069 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   1 |        1 | 20.725 ns | 0.0383 ns | 0.0299 ns |     - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** |   **2** |        **2** | **11.333 ns** | **0.0044 ns** | **0.0041 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   2 |        2 | 22.029 ns | 0.0109 ns | 0.0102 ns |     - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** |   **4** |        **4** |  **9.879 ns** | **0.0032 ns** | **0.0030 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   4 |        4 | 18.830 ns | 0.0263 ns | 0.0233 ns |     - |     - |     - |         - |
