``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |                    A | expected |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |--------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Syste(...)nt32] [53]** | **Int32[3]** | **124.31 ns** | **2.585 ns** | **2.418 ns** | **0.0062** |     **-** |     **-** |     **168 B** |
| SecondTry | Syste(...)nt32] [53] | Int32[3] |  22.36 ns | 0.163 ns | 0.144 ns |      - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** | **Int32[9]** | **504.99 ns** | **5.415 ns** | **4.801 ns** | **0.0248** |     **-** |     **-** |     **664 B** |
| SecondTry | Syste(...)nt32] [53] | Int32[9] | 104.93 ns | 1.446 ns | 1.282 ns |      - |     - |     - |         - |
