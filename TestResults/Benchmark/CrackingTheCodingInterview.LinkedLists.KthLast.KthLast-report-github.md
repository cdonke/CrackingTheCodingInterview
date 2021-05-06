``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|    Method |                 list | kth | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |---- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** | **Syste(...)nt32] [53]** |   **1** |        **1** |  **9.209 ns** | **0.2272 ns** | **0.2704 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   1 |        1 | 16.395 ns | 0.3716 ns | 0.4961 ns |     - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** |   **2** |        **2** |  **8.678 ns** | **0.2166 ns** | **0.3793 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   2 |        2 | 16.072 ns | 0.3358 ns | 0.2804 ns |     - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** |   **4** |        **4** |  **6.193 ns** | **0.1610 ns** | **0.1582 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   4 |        4 | 16.322 ns | 0.3613 ns | 0.4823 ns |     - |     - |     - |         - |
