``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|    Method |                    A | expected |      Mean |    Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |--------- |----------:|---------:|----------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Syste(...)nt32] [53]** | **Int32[3]** |  **87.50 ns** | **1.846 ns** |  **5.296 ns** | **0.0063** |     **-** |     **-** |     **168 B** |
| SecondTry | Syste(...)nt32] [53] | Int32[3] |  17.94 ns | 0.410 ns |  0.548 ns |      - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** | **Int32[9]** | **359.27 ns** | **7.212 ns** | **18.998 ns** | **0.0253** |     **-** |     **-** |     **664 B** |
| SecondTry | Syste(...)nt32] [53] | Int32[9] |  84.85 ns | 1.778 ns |  1.747 ns |      - |     - |     - |         - |
