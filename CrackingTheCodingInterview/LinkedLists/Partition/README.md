# Exercise
Write code to partition a linked list around a value x, such that all nodes less than x come 
before all nodes greater than or equal to x. If x is contained within the list, the values of x only need 
to be after the elements less than x (see below). The partition element x can appear anywhere in the 
"right partition"; it does not need to appear between the left and right partitions. 

## Example
```
*Input:* 3 -> 5 -> 8 -> 5 -> 10 -> 2 -> 1 [partition=5]
*Output:* 3 -> 1 -> 2 -> 10 -> 5 -> 5 -> 8

```

# Hints
- [#3](../../../hints.md#3)
- [#24](../../../hints.md#24)

# Benchmark

**Last update:** Fri May 21 01:20:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|   Method |                 list | partition |               result |     Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------------------- |---------- |--------------------- |---------:|--------:|--------:|-------:|------:|------:|----------:|
| FirstTry | Syste(...)nt32] [53] |         5 | Syste(...)nt32] [53] | 400.8 ns | 5.92 ns | 5.54 ns | 0.0229 |     - |     - |     608 B |
