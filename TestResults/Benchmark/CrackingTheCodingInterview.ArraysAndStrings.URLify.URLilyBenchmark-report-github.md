``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                  Method |                input | len |             expected |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--------------------- |---- |--------------------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|   **&#39;Using StringBuilder&#39;** |   **Christiano Donke  ** |  **16** |   **Christiano%20Donke** | **188.92 ns** | **2.914 ns** | **2.726 ns** | **0.0145** |     **-** |     **-** |     **272 B** |
| &#39;Using in-place string&#39; |   Christiano Donke   |  16 |   Christiano%20Donke |  71.57 ns | 1.419 ns | 1.327 ns | 0.0068 |     - |     - |     128 B |
|   **&#39;Using StringBuilder&#39;** | **Chris(...)      [31]** |  **25** | **Chris(...)Donke [31]** | **262.00 ns** | **2.953 ns** | **2.618 ns** | **0.0157** |     **-** |     **-** |     **296 B** |
| &#39;Using in-place string&#39; | Chris(...)      [31] |  25 | Chris(...)Donke [31] | 108.67 ns | 1.409 ns | 1.318 ns | 0.0094 |     - |     - |     176 B |
|   **&#39;Using StringBuilder&#39;** |    **Mr John Smith    ** |  **13** |    **Mr%20John%20Smith** | **193.90 ns** | **3.965 ns** | **3.894 ns** | **0.0141** |     **-** |     **-** |     **264 B** |
| &#39;Using in-place string&#39; |    Mr John Smith     |  13 |    Mr%20John%20Smith |  70.66 ns | 1.439 ns | 1.414 ns | 0.0063 |     - |     - |     120 B |
