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

**Last update:** Thu May  6 15:49:47 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|          Method |                 data | expected |          Mean |      Error |     StdDev |        Median |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------- |--------------------- |--------- |--------------:|-----------:|-----------:|--------------:|-------:|-------:|------:|----------:|
| **&#39;Simple Arrays&#39;** | **qwert(...)*()_+ [56]** |     **True** |   **115.3732 ns** |  **2.3053 ns** |  **2.8311 ns** |   **116.1381 ns** | **0.0057** |      **-** |     **-** |     **152 B** |
|         HashSet | qwert(...)*()_+ [56] |     True | 1,394.3026 ns | 33.4914 ns | 98.7502 ns | 1,414.3274 ns | 0.0839 |      - |     - |    2216 B |
| **&#39;Simple Arrays&#39;** | **the q(...)y dog [44]** |    **False** |    **50.5610 ns** |  **2.1101 ns** |  **6.2215 ns** |    **51.0943 ns** | **0.0058** |      **-** |     **-** |     **152 B** |
|         HashSet | the q(...)y dog [44] |    False |   482.7513 ns | 24.6712 ns | 71.1821 ns |   456.5579 ns | 0.0844 | 0.0005 |     - |    2216 B |
| **&#39;Simple Arrays&#39;** |  **the (...) dog [352]** |    **False** |     **0.2440 ns** |  **0.0519 ns** |  **0.0710 ns** |     **0.2358 ns** |      **-** |      **-** |     **-** |         **-** |
|         HashSet |  the (...) dog [352] |    False |     0.9267 ns |  0.0602 ns |  0.0534 ns |     0.9292 ns |      - |      - |     - |         - |
