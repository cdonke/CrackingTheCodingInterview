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

**Last update:** Wed May 26 14:53:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |     A |      B | expected |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------ |------- |--------- |----------:|----------:|----------:|------:|------:|------:|----------:|
| **FirstTry** |  **pale** |   **bake** |    **False** | **12.887 ns** | **0.0218 ns** | **0.0204 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |   **bale** |     **True** | **11.797 ns** | **0.0196 ns** | **0.0183 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |     **pa** |    **False** |  **1.174 ns** | **0.0015 ns** | **0.0012 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **paale** |     **True** | **12.968 ns** | **0.0055 ns** | **0.0049 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |  **pales** |     **True** |  **7.832 ns** | **0.0064 ns** | **0.0057 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** | **paless** |    **False** |  **1.218 ns** | **0.0007 ns** | **0.0007 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** |  **pale** |    **ple** |     **True** |  **9.000 ns** | **0.0094 ns** | **0.0084 ns** |     **-** |     **-** |     **-** |         **-** |
| **FirstTry** | **pales** |   **pale** |     **True** | **11.950 ns** | **0.0287 ns** | **0.0268 ns** |     **-** |     **-** |     **-** |         **-** |
