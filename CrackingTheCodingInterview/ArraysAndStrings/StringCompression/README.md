# String Compression
Implement a method to perform basic string compression using the counts of repeated characters.  
For example, the string `aabcccccaaa` would become `a2blc5a3`.  
If the "compressed" string would not become smaller than the original string, your method should return 
the original string.  
You can assume the string has only uppercase and lowercase letters (a - z). 

## Line of thinking
- If `len(A) == 1`, there is no way the result would be smaller. Return `A`.
- The most crucial point is how to build the string at the end.
   - There are several options to hold the information while parsing... `StringBuilder`, `char[]`+`int[]`, Stacks. 
   but at the end, building the result string presents an allocation cost.
- Because of that, StringBuilder might be the better choice.


# Hints
- [#92](../../../hints.md#92)
- [#110](../../../hints.md#110)

# Benchmark

**Last update:** Wed May 26 14:53:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|          Method |                A |  expected |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |----------------- |---------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
|   **StringBuilder** |                **a** |         **a** |   **0.6979 ns** | **0.0071 ns** | **0.0063 ns** |      **-** |     **-** |     **-** |         **-** |
| &#39;SB Refactored&#39; |                a |         a |   0.5028 ns | 0.0033 ns | 0.0031 ns |      - |     - |     - |         - |
|   **StringBuilder** |      **aabcccccaaa** |  **a2b1c5a3** | **238.3602 ns** | **0.4394 ns** | **0.4110 ns** | **0.0076** |     **-** |     **-** |     **144 B** |
| &#39;SB Refactored&#39; |      aabcccccaaa |  a2b1c5a3 | 243.8392 ns | 0.6603 ns | 0.6177 ns | 0.0076 |     - |     - |     144 B |
|   **StringBuilder** | **aabccccccccccaaa** | **a2b1c10a3** | **246.3230 ns** | **0.6602 ns** | **0.6175 ns** | **0.0081** |     **-** |     **-** |     **152 B** |
| &#39;SB Refactored&#39; | aabccccccccccaaa | a2b1c10a3 | 257.2566 ns | 0.2299 ns | 0.2038 ns | 0.0081 |     - |     - |     152 B |
|   **StringBuilder** |               **ab** |        **ab** | **115.3873 ns** | **0.1424 ns** | **0.1262 ns** | **0.0041** |     **-** |     **-** |      **80 B** |
| &#39;SB Refactored&#39; |               ab |        ab |  73.3115 ns | 0.6902 ns | 0.5764 ns | 0.0042 |     - |     - |      80 B |
|   **StringBuilder** |              **abc** |       **abc** | **246.8339 ns** | **0.3069 ns** | **0.2562 ns** | **0.0091** |     **-** |     **-** |     **176 B** |
| &#39;SB Refactored&#39; |              abc |       abc | 119.0472 ns | 0.2435 ns | 0.2278 ns | 0.0045 |     - |     - |      88 B |
