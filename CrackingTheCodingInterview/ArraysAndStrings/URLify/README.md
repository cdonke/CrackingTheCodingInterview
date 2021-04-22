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

**Last update:** Thu Apr 22 19:44:34 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                  Method |                input | len |             expected |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |--------------------- |---- |--------------------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|   **&#39;Using StringBuilder&#39;** |   **Christiano Donke  ** |  **16** |   **Christiano%20Donke** | **191.23 ns** | **3.215 ns** | **3.007 ns** | **0.0145** |     **-** |     **-** |     **272 B** |
| &#39;Using in-place string&#39; |   Christiano Donke   |  16 |   Christiano%20Donke |  79.52 ns | 1.167 ns | 1.092 ns | 0.0068 |     - |     - |     128 B |
|   **&#39;Using StringBuilder&#39;** | **Chris(...)      [31]** |  **25** | **Chris(...)Donke [31]** | **262.62 ns** | **1.753 ns** | **1.554 ns** | **0.0157** |     **-** |     **-** |     **296 B** |
| &#39;Using in-place string&#39; | Chris(...)      [31] |  25 | Chris(...)Donke [31] | 107.50 ns | 1.867 ns | 1.746 ns | 0.0094 |     - |     - |     176 B |
|   **&#39;Using StringBuilder&#39;** |    **Mr John Smith    ** |  **13** |    **Mr%20John%20Smith** | **184.47 ns** | **2.098 ns** | **1.859 ns** | **0.0141** |     **-** |     **-** |     **264 B** |
| &#39;Using in-place string&#39; |    Mr John Smith     |  13 |    Mr%20John%20Smith |  66.96 ns | 1.345 ns | 1.382 ns | 0.0063 |     - |     - |     120 B |
