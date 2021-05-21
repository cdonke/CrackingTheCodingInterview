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

**Last update:** Fri May 21 01:20:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|          Method |                A |  expected |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |----------------- |---------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
|   **StringBuilder** |                **a** |         **a** |   **0.2804 ns** | **0.0652 ns** | **0.0610 ns** |      **-** |     **-** |     **-** |         **-** |
| &#39;SB Refactored&#39; |                a |         a |   0.3480 ns | 0.0432 ns | 0.0404 ns |      - |     - |     - |         - |
|   **StringBuilder** |      **aabcccccaaa** |  **a2b1c5a3** | **249.3399 ns** | **2.4381 ns** | **2.2806 ns** | **0.0052** |     **-** |     **-** |     **144 B** |
| &#39;SB Refactored&#39; |      aabcccccaaa |  a2b1c5a3 | 257.2607 ns | 2.5119 ns | 2.2267 ns | 0.0052 |     - |     - |     144 B |
|   **StringBuilder** | **aabccccccccccaaa** | **a2b1c10a3** | **261.5078 ns** | **4.1708 ns** | **3.9014 ns** | **0.0057** |     **-** |     **-** |     **152 B** |
| &#39;SB Refactored&#39; | aabccccccccccaaa | a2b1c10a3 | 272.7786 ns | 4.2466 ns | 3.9723 ns | 0.0057 |     - |     - |     152 B |
|   **StringBuilder** |               **ab** |        **ab** | **125.2313 ns** | **2.6085 ns** | **3.2989 ns** | **0.0029** |     **-** |     **-** |      **80 B** |
| &#39;SB Refactored&#39; |               ab |        ab |  79.1037 ns | 0.8890 ns | 0.7881 ns | 0.0030 |     - |     - |      80 B |
|   **StringBuilder** |              **abc** |       **abc** | **255.2310 ns** | **2.7486 ns** | **2.2952 ns** | **0.0067** |     **-** |     **-** |     **176 B** |
| &#39;SB Refactored&#39; |              abc |       abc | 130.8327 ns | 2.0285 ns | 1.7982 ns | 0.0033 |     - |     - |      88 B |
