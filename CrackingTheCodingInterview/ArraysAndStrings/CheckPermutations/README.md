# Check Permutations
Given two strings, write a method to decide if one is a permutation of the other.

## Thinking
- If lengths are different, they are not the permutation.
- Consider ASCII vs Unicode for allocation

## Possibilities
- It's possible to create 2 `int[ASCII TABLE SIZE(128)]`, and increment when the char is found, 
and then compare the lists for the same counts.
  - Not implemented, but would be an O(n), with more allocation.
- On the other hand, it's possible to use only one `int[128]` and increment with `string A` and decrement with 
`string B`. This way, the list must have only `0's` at the end to be equal.
  - O(n).
- Convert `A` and `B` to `char[]`, sort the array, return to `string` and compare. Not the best performance, but the cleaner code.
  - Loop twice on each string... It's a O(n), more precisely O(2n).
- In some sense, following the last option, we can compare the `char[]` instead of returning to string. This will save a lot of allocation space.
  - More than O(n), perhaps O(n log n) due sorting.


# Hints
- [#1](../../../hints.md#1)
- [#84](../../../hints.md#84)
- [#122](../../../hints.md#122)
- [#131](../../../hints.md#131)


# Benchmark

**Last update:** Wed May 26 14:53:31 UTC 2021

``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|                       Method |                   A |                   B | expected |            Mean |         Error |        StdDev |          Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |-------------------- |-------------------- |--------- |----------------:|--------------:|--------------:|----------------:|------:|--------:|-------:|------:|------:|----------:|
|                   **&#39;int[128]&#39;** | **Iore(...)met. [500]** | **s tm(...),llt [500]** |    **False** |   **1,310.9890 ns** |    **25.5023 ns** |    **36.5746 ns** |   **1,290.3532 ns** |  **1.00** |    **0.00** | **0.0286** |     **-** |     **-** |     **536 B** |
|                    Hashtable | Iore(...)met. [500] | s tm(...),llt [500] |    False | 100,689.9016 ns |   456.0214 ns |   426.5627 ns | 100,774.4764 ns | 76.44 |    2.28 | 4.2725 |     - |     - |   80304 B |
| &#39;String to char[] to string&#39; | Iore(...)met. [500] | s tm(...),llt [500] |    False |  17,888.0837 ns |    90.3345 ns |    84.4990 ns |  17,879.1820 ns | 13.58 |    0.41 | 0.2136 |     - |     - |    4096 B |
|           &#39;String to char[]&#39; | Iore(...)met. [500] | s tm(...),llt [500] |    False |  17,399.3741 ns |   128.9871 ns |   120.6546 ns |  17,368.5121 ns | 13.21 |    0.47 | 0.0916 |     - |     - |    2048 B |
|                              |                     |                     |          |                 |               |               |                 |       |         |        |       |       |           |
|                   **&#39;int[128]&#39;** | **Lore(...)met. [500]** | **s tm(...),llt [500]** |     **True** |   **1,322.3301 ns** |     **2.9594 ns** |     **2.4712 ns** |   **1,321.3715 ns** |  **1.00** |    **0.00** | **0.0286** |     **-** |     **-** |     **536 B** |
|                    Hashtable | Lore(...)met. [500] | s tm(...),llt [500] |     True | 129,296.5417 ns | 2,515.9948 ns | 2,471.0434 ns | 129,858.2338 ns | 97.87 |    2.01 | 5.1270 |     - |     - |   99176 B |
| &#39;String to char[] to string&#39; | Lore(...)met. [500] | s tm(...),llt [500] |     True |  17,881.2003 ns |    77.5592 ns |    72.5489 ns |  17,883.2071 ns | 13.52 |    0.05 | 0.2136 |     - |     - |    4096 B |
|           &#39;String to char[]&#39; | Lore(...)met. [500] | s tm(...),llt [500] |     True |  17,953.7076 ns |   113.3546 ns |   106.0319 ns |  17,966.4177 ns | 13.58 |    0.09 | 0.0916 |     - |     - |    2048 B |
|                              |                     |                     |          |                 |               |               |                 |       |         |        |       |       |           |
|                   **&#39;int[128]&#39;** |              **abbcde** |              **abbbed** |    **False** |     **160.7757 ns** |     **3.4829 ns** |    **10.2693 ns** |     **157.7871 ns** |  **1.00** |    **0.00** | **0.0286** |     **-** |     **-** |     **536 B** |
|                    Hashtable |              abbcde |              abbbed |    False |   1,818.8927 ns |    18.7069 ns |    17.4985 ns |   1,824.5350 ns | 10.31 |    0.41 | 0.1030 |     - |     - |    1928 B |
| &#39;String to char[] to string&#39; |              abbcde |              abbbed |    False |     173.6994 ns |     1.3534 ns |     1.2660 ns |     174.0299 ns |  0.98 |    0.04 | 0.0083 |     - |     - |     160 B |
|           &#39;String to char[]&#39; |              abbcde |              abbbed |    False |     122.9020 ns |     0.4534 ns |     0.4241 ns |     122.8542 ns |  0.70 |    0.02 | 0.0041 |     - |     - |      80 B |
|                              |                     |                     |          |                 |               |               |                 |       |         |        |       |       |           |
|                   **&#39;int[128]&#39;** |              **abbcde** |              **acbbed** |     **True** |     **197.2851 ns** |     **4.0062 ns** |     **5.4837 ns** |     **197.9877 ns** |  **1.00** |    **0.00** | **0.0286** |     **-** |     **-** |     **536 B** |
|                    Hashtable |              abbcde |              acbbed |     True |   1,939.7734 ns |    19.6918 ns |    18.4197 ns |   1,939.8330 ns |  9.89 |    0.31 | 0.1030 |     - |     - |    1928 B |
| &#39;String to char[] to string&#39; |              abbcde |              acbbed |     True |     177.7176 ns |     1.8776 ns |     1.7563 ns |     178.2546 ns |  0.91 |    0.03 | 0.0083 |     - |     - |     160 B |
|           &#39;String to char[]&#39; |              abbcde |              acbbed |     True |     126.9940 ns |     0.6282 ns |     0.5569 ns |     126.9028 ns |  0.65 |    0.02 | 0.0041 |     - |     - |      80 B |
|                              |                     |                     |          |                 |               |               |                 |       |         |        |       |       |           |
|                   **&#39;int[128]&#39;** |               **abbde** |              **abbbed** |    **False** |       **2.0174 ns** |     **0.0054 ns** |     **0.0048 ns** |       **2.0174 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                    Hashtable |               abbde |              abbbed |    False |       2.1336 ns |     0.0923 ns |     0.0863 ns |       2.1316 ns |  1.05 |    0.04 |      - |     - |     - |         - |
| &#39;String to char[] to string&#39; |               abbde |              abbbed |    False |       0.5904 ns |     0.0537 ns |     0.0502 ns |       0.5639 ns |  0.29 |    0.03 |      - |     - |     - |         - |
|           &#39;String to char[]&#39; |               abbde |              abbbed |    False |       1.1835 ns |     0.0046 ns |     0.0043 ns |       1.1833 ns |  0.59 |    0.00 |      - |     - |     - |         - |
|                              |                     |                     |          |                 |               |               |                 |       |         |        |       |       |           |
|                   **&#39;int[128]&#39;** |                 **abc** |                **abcd** |    **False** |       **1.2815 ns** |     **0.0009 ns** |     **0.0008 ns** |       **1.2813 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                    Hashtable |                 abc |                abcd |    False |       1.7827 ns |     0.0157 ns |     0.0131 ns |       1.7802 ns |  1.39 |    0.01 |      - |     - |     - |         - |
| &#39;String to char[] to string&#39; |                 abc |                abcd |    False |       0.5558 ns |     0.0004 ns |     0.0003 ns |       0.5558 ns |  0.43 |    0.00 |      - |     - |     - |         - |
|           &#39;String to char[]&#39; |                 abc |                abcd |    False |       1.0184 ns |     0.0082 ns |     0.0073 ns |       1.0166 ns |  0.79 |    0.01 |      - |     - |     - |         - |
|                              |                     |                     |          |                 |               |               |                 |       |         |        |       |       |           |
|                   **&#39;int[128]&#39;** |                 **abc** |                 **bac** |     **True** |     **175.0236 ns** |     **3.5538 ns** |     **8.3070 ns** |     **173.4872 ns** |  **1.00** |    **0.00** | **0.0286** |     **-** |     **-** |     **536 B** |
|                    Hashtable |                 abc |                 bac |     True |     926.1087 ns |     6.3520 ns |     5.9417 ns |     926.0381 ns |  5.08 |    0.23 | 0.0515 |     - |     - |     968 B |
| &#39;String to char[] to string&#39; |                 abc |                 bac |     True |     145.6357 ns |     0.8510 ns |     0.7106 ns |     145.6697 ns |  0.79 |    0.03 | 0.0067 |     - |     - |     128 B |
|           &#39;String to char[]&#39; |                 abc |                 bac |     True |      97.2653 ns |     0.4741 ns |     0.4203 ns |      97.3446 ns |  0.53 |    0.03 | 0.0033 |     - |     - |      64 B |
