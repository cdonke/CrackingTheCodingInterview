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

**Last update:** Thu Apr 22 19:44:34 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|          Method |                 data | expected |          Mean |      Error |     StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------- |--------------------- |--------- |--------------:|-----------:|-----------:|-------:|-------:|------:|----------:|
| **&#39;Simple Arrays&#39;** | **qwert(...)*()_+ [56]** |     **True** |   **100.5332 ns** |  **1.8298 ns** |  **1.7116 ns** | **0.0081** |      **-** |     **-** |     **152 B** |
|         HashSet | qwert(...)*()_+ [56] |     True | 1,374.8572 ns | 20.0585 ns | 18.7627 ns | 0.1183 |      - |     - |    2216 B |
| **&#39;Simple Arrays&#39;** | **the q(...)y dog [44]** |    **False** |    **47.2387 ns** |  **0.9888 ns** |  **1.2143 ns** | **0.0081** |      **-** |     **-** |     **152 B** |
|         HashSet | the q(...)y dog [44] |    False |   473.8533 ns |  8.7472 ns | 11.6773 ns | 0.1183 | 0.0010 |     - |    2216 B |
| **&#39;Simple Arrays&#39;** |  **the (...) dog [352]** |    **False** |     **0.4991 ns** |  **0.0045 ns** |  **0.0042 ns** |      **-** |      **-** |     **-** |         **-** |
|         HashSet |  the (...) dog [352] |    False |     1.0865 ns |  0.0013 ns |  0.0013 ns |      - |      - |     - |         - |
