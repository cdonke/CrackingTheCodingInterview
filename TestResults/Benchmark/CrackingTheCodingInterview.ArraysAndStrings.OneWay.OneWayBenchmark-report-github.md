``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |     A |      B | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------ |------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
| **FirstTry** |  **pale** |   **bake** |    **False** | **12.944 ns** | **0.1119 ns** | **0.1046 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |   **bale** |     **True** |  **9.641 ns** | **0.1099 ns** | **0.0974 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |     **pa** |    **False** |  **1.181 ns** | **0.0153 ns** | **0.0136 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **paale** |     **True** |  **9.952 ns** | **0.0509 ns** | **0.0476 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **pales** |     **True** |  **8.460 ns** | **0.0845 ns** | **0.0790 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** | **paless** |    **False** |  **1.551 ns** | **0.0555 ns** | **0.0433 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |    **ple** |     **True** |  **8.247 ns** | **0.1708 ns** | **0.1514 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **pales** |   **pale** |     **True** |  **8.036 ns** | **0.0755 ns** | **0.0706 ns** |     **-** |     **-** |     **-** |         **-** |
