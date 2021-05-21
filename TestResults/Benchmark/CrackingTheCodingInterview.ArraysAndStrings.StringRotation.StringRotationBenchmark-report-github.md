``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |          s1 |          s2 | expected |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------ |------------ |--------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
|  **FirstTry** |           **a** |          **aa** |    **False** |  **0.8757 ns** | **0.0196 ns** | **0.0183 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |           a |          aa |    False |  0.5945 ns | 0.0224 ns | 0.0210 ns |      - |     - |     - |         - |
|  **FirstTry** |     **gooddog** |     **doggood** |     **True** | **46.1350 ns** | **0.6479 ns** | **0.6061 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |     gooddog |     doggood |     True | 61.7057 ns | 0.7973 ns | 0.6658 ns | 0.0020 |     - |     - |      56 B |
|  **FirstTry** |     **gooddog** |     **oggoodd** |     **True** | **41.3218 ns** | **0.3044 ns** | **0.2542 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |     gooddog |     oggoodd |     True | 62.1957 ns | 0.9279 ns | 0.8679 ns | 0.0020 |     - |     - |      56 B |
|  **FirstTry** |      **hotdog** |      **doghot** |     **True** | **41.0747 ns** | **0.2851 ns** | **0.2528 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |      hotdog |      doghot |     True | 52.2464 ns | 0.7823 ns | 0.7317 ns | 0.0018 |     - |     - |      48 B |
|  **FirstTry** | **waterbottle** | **bottleuater** |    **False** | **97.6236 ns** | **0.6984 ns** | **0.6532 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | bottleuater |    False | 56.5489 ns | 0.9322 ns | 0.8263 ns | 0.0027 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **bottlewater** |     **True** | **76.5149 ns** | **0.5204 ns** | **0.4063 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | bottlewater |     True | 60.1886 ns | 1.0503 ns | 0.9824 ns | 0.0027 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **eebottlewat** |    **False** | **98.7217 ns** | **0.8785 ns** | **0.7788 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | eebottlewat |    False | 66.9977 ns | 1.3424 ns | 1.6485 ns | 0.0027 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **erbottlewat** |     **True** | **84.2191 ns** | **0.5376 ns** | **0.4489 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | erbottlewat |     True | 61.0163 ns | 1.1788 ns | 0.9844 ns | 0.0027 |     - |     - |      72 B |
