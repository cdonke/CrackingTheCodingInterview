# URLify
Write a method to replace all spaces in a string with '%20'. You may assume that the string 
has sufficient space at the end to hold the additional characters, and that you are given the "true" 
length of the string. 

## Example
**Input:**  "Mr John Smith    ", 13  
**Output:** "Mr%20John%20Smith"


# Hints
- [#53](../../../hints.md#53)
- [#118](../../../hints.md#118)


# Benchmark

**Last update:** Thu May  6 15:49:47 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                  Method |                input | len |             expected |      Mean |    Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--------------------- |---- |--------------------- |----------:|---------:|----------:|-------:|------:|------:|----------:|
|   **&#39;Using StringBuilder&#39;** |   **Christiano Donke  ** |  **16** |   **Christiano%20Donke** | **158.52 ns** | **3.255 ns** |  **8.911 ns** | **0.0103** |     **-** |     **-** |     **272 B** |
| &#39;Using in-place string&#39; |   Christiano Donke   |  16 |   Christiano%20Donke |  56.97 ns | 1.231 ns |  2.703 ns | 0.0049 |     - |     - |     128 B |
|   **&#39;Using StringBuilder&#39;** | **Chris(...)      [31]** |  **25** | **Chris(...)Donke [31]** | **212.22 ns** | **4.324 ns** | **10.689 ns** | **0.0112** |     **-** |     **-** |     **296 B** |
| &#39;Using in-place string&#39; | Chris(...)      [31] |  25 | Chris(...)Donke [31] |  77.79 ns | 1.653 ns |  4.524 ns | 0.0067 |     - |     - |     176 B |
|   **&#39;Using StringBuilder&#39;** |    **Mr John Smith    ** |  **13** |    **Mr%20John%20Smith** | **148.91 ns** | **3.254 ns** |  **9.493 ns** | **0.0100** |     **-** |     **-** |     **264 B** |
| &#39;Using in-place string&#39; |    Mr John Smith     |  13 |    Mr%20John%20Smith |  52.10 ns | 1.354 ns |  3.927 ns | 0.0045 |     - |     - |     120 B |
