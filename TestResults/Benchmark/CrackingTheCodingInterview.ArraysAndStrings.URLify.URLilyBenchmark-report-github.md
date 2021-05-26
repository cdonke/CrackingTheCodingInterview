``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|                  Method |                input | len |             expected |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--------------------- |---- |--------------------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|   **&#39;Using StringBuilder&#39;** |   **Christiano Donke  ** |  **16** |   **Christiano%20Donke** | **191.21 ns** | **2.789 ns** | **2.608 ns** | **0.0145** |     **-** |     **-** |     **272 B** |
| &#39;Using in-place string&#39; |   Christiano Donke   |  16 |   Christiano%20Donke |  79.12 ns | 1.450 ns | 1.356 ns | 0.0068 |     - |     - |     128 B |
|   **&#39;Using StringBuilder&#39;** | **Chris(...)      [31]** |  **25** | **Chris(...)Donke [31]** | **271.28 ns** | **1.851 ns** | **1.546 ns** | **0.0157** |     **-** |     **-** |     **296 B** |
| &#39;Using in-place string&#39; | Chris(...)      [31] |  25 | Chris(...)Donke [31] | 113.82 ns | 1.854 ns | 1.734 ns | 0.0093 |     - |     - |     176 B |
|   **&#39;Using StringBuilder&#39;** |    **Mr John Smith    ** |  **13** |    **Mr%20John%20Smith** | **187.92 ns** | **1.578 ns** | **1.476 ns** | **0.0141** |     **-** |     **-** |     **264 B** |
| &#39;Using in-place string&#39; |    Mr John Smith     |  13 |    Mr%20John%20Smith |  73.27 ns | 0.988 ns | 0.924 ns | 0.0063 |     - |     - |     120 B |
