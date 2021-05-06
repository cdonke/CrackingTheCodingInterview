``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|    Method |          s1 |          s2 | expected |       Mean |     Error |    StdDev |     Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------ |------------ |--------- |-----------:|----------:|----------:|-----------:|-------:|------:|------:|----------:|
|  **FirstTry** |           **a** |          **aa** |    **False** |  **0.4256 ns** | **0.0271 ns** | **0.0253 ns** |  **0.4277 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |           a |          aa |    False |  0.6777 ns | 0.0222 ns | 0.0197 ns |  0.6781 ns |      - |     - |     - |         - |
|  **FirstTry** |     **gooddog** |     **doggood** |     **True** | **45.6503 ns** | **0.4414 ns** | **0.4128 ns** | **45.5968 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |     gooddog |     doggood |     True | 63.0446 ns | 0.8602 ns | 0.8046 ns | 62.8333 ns | 0.0020 |     - |     - |      56 B |
|  **FirstTry** |     **gooddog** |     **oggoodd** |     **True** | **41.5890 ns** | **0.3339 ns** | **0.2960 ns** | **41.5842 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |     gooddog |     oggoodd |     True | 62.2274 ns | 0.3314 ns | 0.2938 ns | 62.2111 ns | 0.0020 |     - |     - |      56 B |
|  **FirstTry** |      **hotdog** |      **doghot** |     **True** | **36.0514 ns** | **0.7557 ns** | **1.2625 ns** | **35.9338 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |      hotdog |      doghot |     True | 42.5270 ns | 0.8818 ns | 1.8012 ns | 42.6123 ns | 0.0018 |     - |     - |      48 B |
|  **FirstTry** | **waterbottle** | **bottleuater** |    **False** | **84.1026 ns** | **1.6961 ns** | **2.0191 ns** | **83.8081 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | bottleuater |    False | 43.5059 ns | 0.9093 ns | 2.3145 ns | 43.3839 ns | 0.0027 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **bottlewater** |     **True** | **65.6141 ns** | **1.0695 ns** | **1.2731 ns** | **65.4162 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | bottlewater |     True | 47.3589 ns | 0.9828 ns | 2.6904 ns | 47.4060 ns | 0.0027 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **eebottlewat** |    **False** | **84.3221 ns** | **1.6647 ns** | **1.9817 ns** | **84.1659 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | eebottlewat |    False | 55.1330 ns | 1.6191 ns | 4.7740 ns | 53.6488 ns | 0.0027 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **erbottlewat** |     **True** | **72.4675 ns** | **1.4626 ns** | **1.1419 ns** | **72.6608 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | erbottlewat |     True | 47.1808 ns | 0.9604 ns | 2.3916 ns | 47.2025 ns | 0.0027 |     - |     - |      72 B |
