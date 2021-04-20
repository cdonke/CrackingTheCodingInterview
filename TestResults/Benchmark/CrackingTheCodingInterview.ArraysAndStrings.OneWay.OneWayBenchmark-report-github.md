``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|   Method |     A |      B | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------ |------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
| **FirstTry** |  **pale** |   **bake** |    **False** | **12.933 ns** | **0.0355 ns** | **0.0296 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |   **bale** |     **True** | **11.840 ns** | **0.0198 ns** | **0.0185 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |     **pa** |    **False** |  **1.171 ns** | **0.0013 ns** | **0.0012 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **paale** |     **True** | **13.287 ns** | **0.2987 ns** | **0.2934 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **pales** |     **True** | **12.874 ns** | **0.0056 ns** | **0.0050 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** | **paless** |    **False** |  **1.193 ns** | **0.0020 ns** | **0.0018 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |    **ple** |     **True** |  **7.410 ns** | **0.0076 ns** | **0.0067 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **pales** |   **pale** |     **True** | **11.961 ns** | **0.0340 ns** | **0.0319 ns** |     **-** |     **-** |     **-** |         **-** |
