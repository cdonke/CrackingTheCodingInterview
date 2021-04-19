``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.408
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|          Method |                 data | expected |          Mean |      Error |     StdDev |        Median |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------- |--------------------- |--------- |--------------:|-----------:|-----------:|--------------:|-------:|-------:|------:|----------:|
| **&#39;Simple Arrays&#39;** | **qwert(...)*()_+ [56]** |     **True** |   **125.6083 ns** |  **0.4010 ns** |  **0.3751 ns** |   **125.5938 ns** | **0.0081** |      **-** |     **-** |     **152 B** |
|         HashSet | qwert(...)*()_+ [56] |     True | 1,458.2612 ns | 28.2707 ns | 42.3143 ns | 1,436.9095 ns | 0.1183 |      - |     - |    2216 B |
| **&#39;Simple Arrays&#39;** | **the q(...)y dog [44]** |    **False** |    **57.4268 ns** |  **0.4754 ns** |  **0.4446 ns** |    **57.6379 ns** | **0.0081** |      **-** |     **-** |     **152 B** |
|         HashSet | the q(...)y dog [44] |    False |   658.0169 ns | 10.3958 ns |  9.7243 ns |   662.3744 ns | 0.1183 | 0.0010 |     - |    2216 B |
| **&#39;Simple Arrays&#39;** |  **the (...) dog [352]** |    **False** |     **0.6785 ns** |  **0.0631 ns** |  **0.0925 ns** |     **0.6268 ns** |      **-** |      **-** |     **-** |         **-** |
|         HashSet |  the (...) dog [352] |    False |     1.0985 ns |  0.0045 ns |  0.0040 ns |     1.0995 ns |      - |      - |     - |         - |
