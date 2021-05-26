# Exercise

Write code to remove duplicates from an unsorted linked list.

*Follow up:*  
How would you solve this problem if a temporary buffer is not allowed?


## Complexity
### First Try:
*Space:* O(n)  
*Time:* O(n)

### Second Try:
*Space:* O(1) - in-place  
*Time:* O(n²)



# Hints
- [#9](../../../hints.md#9)
- [#40](../../../hints.md#40)

# Benchmark

**Last update:** Wed May 26 14:53:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |                    A | expected |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |--------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** | **Syste(...)nt32] [53]** | **Int32[3]** | **116.98 ns** | **2.321 ns** | **2.171 ns** | **0.0088** |     **-** |     **-** |     **168 B** |
| SecondTry | Syste(...)nt32] [53] | Int32[3] |  22.80 ns | 0.013 ns | 0.012 ns |      - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** | **Int32[9]** | **444.13 ns** | **6.361 ns** | **5.950 ns** | **0.0353** |     **-** |     **-** |     **664 B** |
| SecondTry | Syste(...)nt32] [53] | Int32[9] | 111.87 ns | 0.520 ns | 0.461 ns |      - |     - |     - |         - |
