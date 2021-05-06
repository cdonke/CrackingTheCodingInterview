``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|          Method |                A |  expected |        Mean |     Error |     StdDev |      Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |----------------- |---------- |------------:|----------:|-----------:|------------:|-------:|------:|------:|----------:|
|   **StringBuilder** |                **a** |         **a** |   **0.3156 ns** | **0.1051 ns** |  **0.1329 ns** |   **0.3310 ns** |      **-** |     **-** |     **-** |         **-** |
| &#39;SB Refactored&#39; |                a |         a |   0.4014 ns | 0.1077 ns |  0.1645 ns |   0.3853 ns |      - |     - |     - |         - |
|   **StringBuilder** |      **aabcccccaaa** |  **a2b1c5a3** | **217.4893 ns** | **4.4448 ns** |  **6.7877 ns** | **217.7359 ns** | **0.0055** |     **-** |     **-** |     **144 B** |
| &#39;SB Refactored&#39; |      aabcccccaaa |  a2b1c5a3 | 227.5730 ns | 4.6257 ns | 10.8124 ns | 225.5325 ns | 0.0055 |     - |     - |     144 B |
|   **StringBuilder** | **aabccccccccccaaa** | **a2b1c10a3** | **250.9112 ns** | **7.3254 ns** | **21.5993 ns** | **258.5167 ns** | **0.0057** |     **-** |     **-** |     **152 B** |
| &#39;SB Refactored&#39; | aabccccccccccaaa | a2b1c10a3 | 238.3658 ns | 4.7560 ns |  7.4045 ns | 236.9805 ns | 0.0057 |     - |     - |     152 B |
|   **StringBuilder** |               **ab** |        **ab** | **123.4199 ns** | **2.6530 ns** |  **7.8223 ns** | **126.5404 ns** | **0.0030** |     **-** |     **-** |      **80 B** |
| &#39;SB Refactored&#39; |               ab |        ab |  79.5598 ns | 0.6130 ns |  0.5734 ns |  79.4046 ns | 0.0030 |     - |     - |      80 B |
|   **StringBuilder** |              **abc** |       **abc** | **263.7245 ns** | **3.5718 ns** |  **3.3410 ns** | **263.9064 ns** | **0.0067** |     **-** |     **-** |     **176 B** |
| &#39;SB Refactored&#39; |              abc |       abc | 128.1809 ns | 1.3724 ns |  1.2838 ns | 128.1020 ns | 0.0033 |     - |     - |      88 B |
