``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|          Method |                 data | expected |          Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------- |--------------------- |--------- |--------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
| **&#39;Simple Arrays&#39;** | **qwert(...)*()_+ [56]** |     **True** |   **123.5359 ns** |  **2.5244 ns** |  **2.2378 ns** | **0.0081** |      **-** |     **-** |     **152 B** |
|         HashSet | qwert(...)*()_+ [56] |     True | 1,328.3090 ns | 26.2966 ns | 35.9950 ns | 0.1183 |      - |     - |    2216 B |
| **&#39;Simple Arrays&#39;** | **the q(...)y dog [44]** |    **False** |    **47.3529 ns** |  **0.9959 ns** |  **1.9888 ns** | **0.0081** |      **-** |     **-** |     **152 B** |
|         HashSet | the q(...)y dog [44] |    False |   488.6977 ns |  9.8103 ns | 18.9010 ns | 0.1183 | 0.0010 |     - |    2216 B |
| **&#39;Simple Arrays&#39;** |  **the (...) dog [352]** |    **False** |     **0.4957 ns** |  **0.0011 ns** |  **0.0010 ns** |      **-** |      **-** |     **-** |         **-** |
|         HashSet |  the (...) dog [352] |    False |     1.0792 ns |  0.0009 ns |  0.0008 ns |      - |      - |     - |         - |
