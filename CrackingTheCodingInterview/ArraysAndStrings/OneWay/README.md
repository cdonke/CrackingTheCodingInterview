# One Way
There are three types of edits that can be performed on strings: insert a character, 
remove a character, or replace a character. Given two strings, write a function to check if they are 
one edit (or zero edits) away

## Line of thinking
- Insert or Remove a character follows the same principal. +/-n appart in Length. This way `0 <= |len(A)-len(B)| < 2`. 
If it's out of this range, More than 1 insertion/replacement has been made, and it's false.
- Replacement means something changed. Since I can only do 1 change, if a letter is different at the current iteration, 
the next MUST be equal to evaluate true. So we move one of the pointers ahead.
- On each iteraction, we count the changes. At the end `changes <= 1`.

# Hints
- [#23](../../../hints.md#23)
- [#97](../../../hints.md#97)
- [#130](../../../hints.md#130)

# Benchmark

**Last update:** Thu May  6 15:49:47 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|   Method |     A |      B | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------ |------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
| **FirstTry** |  **pale** |   **bake** |    **False** | **11.154 ns** | **0.2318 ns** | **0.2168 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |   **bale** |     **True** |  **9.389 ns** | **0.2347 ns** | **0.3133 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |     **pa** |    **False** |  **1.074 ns** | **0.0663 ns** | **0.1013 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **paale** |     **True** |  **8.497 ns** | **0.1887 ns** | **0.3047 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **pales** |     **True** |  **7.989 ns** | **0.1662 ns** | **0.1473 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** | **paless** |    **False** |  **1.056 ns** | **0.0624 ns** | **0.0719 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |    **ple** |     **True** |  **6.998 ns** | **0.1715 ns** | **0.1604 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **pales** |   **pale** |     **True** |  **7.027 ns** | **0.1801 ns** | **0.2696 ns** |     **-** |     **-** |     **-** |         **-** |
