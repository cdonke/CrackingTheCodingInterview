``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|   Method |     A |      B | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------ |------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
| **FirstTry** |  **pale** |   **bake** |    **False** | **11.549 ns** | **0.0454 ns** | **0.0425 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |   **bale** |     **True** |  **9.274 ns** | **0.0065 ns** | **0.0057 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |     **pa** |    **False** |  **1.157 ns** | **0.0016 ns** | **0.0015 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **paale** |     **True** | **12.964 ns** | **0.0063 ns** | **0.0059 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **pales** |     **True** |  **7.842 ns** | **0.0038 ns** | **0.0032 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** | **paless** |    **False** |  **2.371 ns** | **0.0021 ns** | **0.0019 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |    **ple** |     **True** |  **7.434 ns** | **0.0071 ns** | **0.0059 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **pales** |   **pale** |     **True** | **11.973 ns** | **0.0304 ns** | **0.0284 ns** |     **-** |     **-** |     **-** |         **-** |
