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

**Last update:** Wed May 26 14:53:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|          Method |                 data | expected |          Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------- |--------------------- |--------- |--------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
| **&#39;Simple Arrays&#39;** | **qwert(...)*()_+ [56]** |     **True** |    **99.4037 ns** |  **1.6480 ns** |  **1.5415 ns** | **0.0081** |      **-** |     **-** |     **152 B** |
|         HashSet | qwert(...)*()_+ [56] |     True | 1,323.8313 ns | 19.3651 ns | 18.1142 ns | 0.1183 |      - |     - |    2216 B |
| **&#39;Simple Arrays&#39;** | **the q(...)y dog [44]** |    **False** |    **49.3369 ns** |  **0.8964 ns** |  **0.6998 ns** | **0.0081** |      **-** |     **-** |     **152 B** |
|         HashSet | the q(...)y dog [44] |    False |   525.3112 ns | 10.3996 ns | 23.0449 ns | 0.1183 | 0.0010 |     - |    2216 B |
| **&#39;Simple Arrays&#39;** |  **the (...) dog [352]** |    **False** |     **0.4945 ns** |  **0.0060 ns** |  **0.0047 ns** |      **-** |      **-** |     **-** |         **-** |
|         HashSet |  the (...) dog [352] |    False |     1.0983 ns |  0.0008 ns |  0.0007 ns |      - |      - |     - |         - |
