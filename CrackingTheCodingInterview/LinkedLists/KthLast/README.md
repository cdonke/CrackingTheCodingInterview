# Exercise

Implement an algorithm to find the kth to last element of a singly linked list.


# Hints
- [#8](../../../hints.md#8)
- [#25](../../../hints.md#25)
- [#41](../../../hints.md#41)
- [#67](../../../hints.md#67)
- [#126](../../../hints.md#126)

# Benchmark

**Last update:** Fri May 21 01:20:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|    Method |                 list | kth | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |---- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  **FirstTry** | **Syste(...)nt32] [53]** |   **1** |        **1** | **12.154 ns** | **0.1501 ns** | **0.1253 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   1 |        1 | 21.067 ns | 0.3917 ns | 0.3664 ns |     - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** |   **2** |        **2** |  **9.679 ns** | **0.2223 ns** | **0.2379 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   2 |        2 | 19.288 ns | 0.4262 ns | 0.3986 ns |     - |     - |     - |         - |
|  **FirstTry** | **Syste(...)nt32] [53]** |   **4** |        **4** |  **7.114 ns** | **0.0800 ns** | **0.0710 ns** |     **-** |     **-** |     **-** |         **-** |
| SecondTry | Syste(...)nt32] [53] |   4 |        4 | 18.230 ns | 0.4053 ns | 0.7512 ns |     - |     - |     - |         - |
