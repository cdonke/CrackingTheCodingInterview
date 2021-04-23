﻿# String Compression
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

**Last update:** Thu Apr 22 19:44:34 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|          Method |                A |  expected |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |----------------- |---------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
|   **StringBuilder** |                **a** |         **a** |   **0.6976 ns** | **0.0058 ns** | **0.0048 ns** |      **-** |     **-** |     **-** |         **-** |
| &#39;SB Refactored&#39; |                a |         a |   0.4018 ns | 0.0183 ns | 0.0171 ns |      - |     - |     - |         - |
|   **StringBuilder** |      **aabcccccaaa** |  **a2b1c5a3** | **237.7676 ns** | **0.4442 ns** | **0.4155 ns** | **0.0076** |     **-** |     **-** |     **144 B** |
| &#39;SB Refactored&#39; |      aabcccccaaa |  a2b1c5a3 | 243.5706 ns | 0.4889 ns | 0.4334 ns | 0.0076 |     - |     - |     144 B |
|   **StringBuilder** | **aabccccccccccaaa** | **a2b1c10a3** | **247.5140 ns** | **0.4154 ns** | **0.3683 ns** | **0.0081** |     **-** |     **-** |     **152 B** |
| &#39;SB Refactored&#39; | aabccccccccccaaa | a2b1c10a3 | 256.8831 ns | 0.6381 ns | 0.5969 ns | 0.0081 |     - |     - |     152 B |
|   **StringBuilder** |               **ab** |        **ab** | **114.7935 ns** | **0.4244 ns** | **0.3970 ns** | **0.0041** |     **-** |     **-** |      **80 B** |
| &#39;SB Refactored&#39; |               ab |        ab |  72.4693 ns | 0.7048 ns | 0.6593 ns | 0.0042 |     - |     - |      80 B |
|   **StringBuilder** |              **abc** |       **abc** | **248.9445 ns** | **0.6357 ns** | **0.5635 ns** | **0.0091** |     **-** |     **-** |     **176 B** |
| &#39;SB Refactored&#39; |              abc |       abc | 118.9601 ns | 0.5328 ns | 0.4984 ns | 0.0045 |     - |     - |      88 B |