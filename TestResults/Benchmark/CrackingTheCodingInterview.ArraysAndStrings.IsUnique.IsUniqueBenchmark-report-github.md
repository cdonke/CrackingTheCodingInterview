``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|          Method |                 data | expected |          Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |--------------------- |--------- |--------------:|-----------:|-----------:|-------:|------:|------:|----------:|
| **&#39;Simple Arrays&#39;** | **qwert(...)*()_+ [56]** |     **True** |   **117.4981 ns** |  **2.4037 ns** |  **2.2485 ns** | **0.0057** |     **-** |     **-** |     **152 B** |
|         HashSet | qwert(...)*()_+ [56] |     True | 1,495.6272 ns | 28.0991 ns | 28.8557 ns | 0.0839 |     - |     - |    2216 B |
| **&#39;Simple Arrays&#39;** | **the q(...)y dog [44]** |    **False** |    **60.4711 ns** |  **1.0761 ns** |  **1.0066 ns** | **0.0057** |     **-** |     **-** |     **152 B** |
|         HashSet | the q(...)y dog [44] |    False |   674.5865 ns | 13.4632 ns | 27.1963 ns | 0.0839 |     - |     - |    2216 B |
| **&#39;Simple Arrays&#39;** |  **the (...) dog [352]** |    **False** |     **0.3980 ns** |  **0.0498 ns** |  **0.0441 ns** |      **-** |     **-** |     **-** |         **-** |
|         HashSet |  the (...) dog [352] |    False |     0.9255 ns |  0.0290 ns |  0.0271 ns |      - |     - |     - |         - |
