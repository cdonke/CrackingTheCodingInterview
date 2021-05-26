``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |          s1 |          s2 | expected |       Mean |     Error |    StdDev |     Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------ |------------ |--------- |-----------:|----------:|----------:|-----------:|-------:|------:|------:|----------:|
|  **FirstTry** |           **a** |          **aa** |    **False** |  **0.5568 ns** | **0.0624 ns** | **0.0789 ns** |  **0.4950 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |           a |          aa |    False |  0.4278 ns | 0.0051 ns | 0.0048 ns |  0.4285 ns |      - |     - |     - |         - |
|  **FirstTry** |     **gooddog** |     **doggood** |     **True** | **43.4388 ns** | **0.0049 ns** | **0.0044 ns** | **43.4383 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |     gooddog |     doggood |     True | 66.3184 ns | 0.2888 ns | 0.2702 ns | 66.3148 ns | 0.0030 |     - |     - |      56 B |
|  **FirstTry** |     **gooddog** |     **oggoodd** |     **True** | **39.2333 ns** | **0.0721 ns** | **0.0674 ns** | **39.2474 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |     gooddog |     oggoodd |     True | 66.3029 ns | 0.0904 ns | 0.0801 ns | 66.2939 ns | 0.0030 |     - |     - |      56 B |
|  **FirstTry** |      **hotdog** |      **doghot** |     **True** | **39.4442 ns** | **0.0078 ns** | **0.0073 ns** | **39.4463 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |      hotdog |      doghot |     True | 53.9402 ns | 0.3080 ns | 0.2731 ns | 54.0542 ns | 0.0026 |     - |     - |      48 B |
|  **FirstTry** | **waterbottle** | **bottleuater** |    **False** | **92.0921 ns** | **1.8841 ns** | **2.0160 ns** | **90.8645 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | bottleuater |    False | 59.1001 ns | 0.3972 ns | 0.3715 ns | 59.2557 ns | 0.0038 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **bottlewater** |     **True** | **73.2149 ns** | **0.3382 ns** | **0.3163 ns** | **73.3794 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | bottlewater |     True | 60.8220 ns | 0.6094 ns | 0.5700 ns | 60.8115 ns | 0.0038 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **eebottlewat** |    **False** | **92.9674 ns** | **0.2983 ns** | **0.2791 ns** | **92.8752 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | eebottlewat |    False | 69.5139 ns | 0.3176 ns | 0.2970 ns | 69.5145 ns | 0.0038 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **erbottlewat** |     **True** | **79.5950 ns** | **0.0212 ns** | **0.0198 ns** | **79.5875 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | erbottlewat |     True | 61.3055 ns | 0.4849 ns | 0.4299 ns | 61.4080 ns | 0.0038 |     - |     - |      72 B |
