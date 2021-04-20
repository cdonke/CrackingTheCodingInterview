# Is Unique
Implement an algorithm to determine if a string has all unique characters. 
What if you cannot use additional data structures? 

## Line of thinking
- Ask if string is ASCII or Unicode. ASCII have 128 characteres, while Unicode over 143k.
- If string exceeds the ASCII table size (considering an ASCII string), it is already false, because you cannot write an string with more than the avaiable chars without repeating.
- 

## First Try
**Time Complexity:** O(n)  
**Space Complexity:** O(1)

## Second Try
**Time Complexity:** O(n)  
**Space Complexity:** O(1)



# Hints
- [#44](../../../hints.md#44)
- [#117](../../../hints.md#117)
- [#132](../../../hints.md#132)

# Benchmark

**Last update:** Tue Apr 20 00:06:54 UTC 2021

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
