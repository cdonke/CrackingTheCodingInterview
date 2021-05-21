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

**Last update:** Fri May 21 01:20:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|                  Method |                input | len |             expected |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--------------------- |---- |--------------------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|   **&#39;Using StringBuilder&#39;** |   **Christiano Donke  ** |  **16** |   **Christiano%20Donke** | **197.25 ns** | **3.246 ns** | **4.220 ns** | **0.0103** |     **-** |     **-** |     **272 B** |
| &#39;Using in-place string&#39; |   Christiano Donke   |  16 |   Christiano%20Donke |  76.41 ns | 1.312 ns | 1.163 ns | 0.0049 |     - |     - |     128 B |
|   **&#39;Using StringBuilder&#39;** | **Chris(...)      [31]** |  **25** | **Chris(...)Donke [31]** | **255.69 ns** | **1.515 ns** | **1.343 ns** | **0.0110** |     **-** |     **-** |     **296 B** |
| &#39;Using in-place string&#39; | Chris(...)      [31] |  25 | Chris(...)Donke [31] | 104.71 ns | 0.904 ns | 0.801 ns | 0.0067 |     - |     - |     176 B |
|   **&#39;Using StringBuilder&#39;** |    **Mr John Smith    ** |  **13** |    **Mr%20John%20Smith** | **203.21 ns** | **4.131 ns** | **6.055 ns** | **0.0100** |     **-** |     **-** |     **264 B** |
| &#39;Using in-place string&#39; |    Mr John Smith     |  13 |    Mr%20John%20Smith |  77.63 ns | 1.651 ns | 2.713 ns | 0.0045 |     - |     - |     120 B |
