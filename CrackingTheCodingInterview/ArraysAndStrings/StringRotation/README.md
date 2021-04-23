﻿# String Rotation
Assume you have a method `isSubstring` which checks if one word is a substring 
of another.  
Given two strings, `s1` and `s2`, write code to check if `s2` is a rotation of `s1` using only one 
call to `isSubstring`  

(e.g., "waterbottle" is a rotation of"erbottlewat"). 

## Line of thinking
### First Try
- Loop through rotate string until find the strings start matching
- Calculate the position to compare using a circular position (`string[position % length]`)
- Use `2*len` a secure stop-point, in case the string doesn't match
- Slower, but no allocation required.

### Second Try
- Concatenates the rotated string (`s2+s2`) to join the parts rotated
- After, call the `isSubstring(s1,s2)` to find if the concatenated string have the original one
- Faster, but requires allocation

# Hints
- [#34](../../../hints.md#34)
- [#88](../../../hints.md#88)
- [#104](../../../hints.md#104)


# Benchmark

**Last update:** Thu Apr 22 19:44:34 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|    Method |          s1 |          s2 | expected |     Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------ |------------ |--------- |---------:|---------:|---------:|-------:|------:|------:|----------:|
|  **FirstTry** |     **gooddog** |     **doggood** |     **True** | **43.46 ns** | **0.008 ns** | **0.006 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |     gooddog |     doggood |     True | 65.94 ns | 0.433 ns | 0.405 ns | 0.0030 |     - |     - |      56 B |
|  **FirstTry** |     **gooddog** |     **oggoodd** |     **True** | **39.43 ns** | **0.008 ns** | **0.007 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |     gooddog |     oggoodd |     True | 65.32 ns | 0.342 ns | 0.320 ns | 0.0030 |     - |     - |      56 B |
|  **FirstTry** |      **hotdog** |      **doghot** |     **True** | **39.50 ns** | **0.074 ns** | **0.070 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry |      hotdog |      doghot |     True | 54.80 ns | 0.258 ns | 0.242 ns | 0.0026 |     - |     - |      48 B |
|  **FirstTry** | **waterbottle** | **bottleuater** |    **False** | **91.23 ns** | **0.074 ns** | **0.069 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | bottleuater |    False | 57.58 ns | 0.717 ns | 0.671 ns | 0.0038 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **bottlewater** |     **True** | **73.32 ns** | **0.262 ns** | **0.245 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | bottlewater |     True | 60.55 ns | 0.729 ns | 0.682 ns | 0.0038 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **eebottlewat** |    **False** | **90.73 ns** | **0.022 ns** | **0.017 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | eebottlewat |    False | 69.82 ns | 0.398 ns | 0.372 ns | 0.0038 |     - |     - |      72 B |
|  **FirstTry** | **waterbottle** | **erbottlewat** |     **True** | **79.61 ns** | **0.024 ns** | **0.021 ns** |      **-** |     **-** |     **-** |         **-** |
| SecondTry | waterbottle | erbottlewat |     True | 61.93 ns | 0.673 ns | 0.629 ns | 0.0038 |     - |     - |      72 B |