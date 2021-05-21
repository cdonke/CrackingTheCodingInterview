``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|                       Method | Categories |        items | capacity |         Mean |        Error |       StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|----------------------------- |----------- |------------- |--------- |-------------:|-------------:|-------------:|------:|--------:|--------:|--------:|----------:|
| **System.Collections.ArrayList** |        **Add** |  **Int32[1000]** |      **100** |  **24,508.5 ns** |    **389.66 ns** |    **345.42 ns** | **1.000** |  **1.8616** |  **0.2136** |       **-** |   **48952 B** |
|                  MyArrayList |        Add |  Int32[1000] |      100 |   7,033.5 ns |    137.72 ns |    135.26 ns | 0.286 |  0.4730 |  0.0076 |       - |   12560 B |
| **System.Collections.ArrayList** |        **Add** |   **Int32[100]** |      **100** |   **2,024.8 ns** |     **28.61 ns** |     **26.76 ns** | **0.083** |  **0.1221** |       **-** |       **-** |    **3256 B** |
|                  MyArrayList |        Add |   Int32[100] |      100 |     713.6 ns |     10.61 ns |      9.92 ns | 0.029 |  0.0486 |       - |       - |    1288 B |
| **System.Collections.ArrayList** |        **Add** |    **Int32[10]** |      **100** |     **371.8 ns** |      **7.44 ns** |     **14.33 ns** | **0.015** |  **0.0415** |       **-** |       **-** |    **1096 B** |
|                  MyArrayList |        Add |    Int32[10] |      100 |     120.6 ns |      3.50 ns |     10.32 ns | 0.005 |  0.0176 |       - |       - |     464 B |
|                              |            |              |          |              |              |              |       |         |         |         |           |
| **System.Collections.ArrayList** |   **AddRange** |  **Int32[1000]** |      **100** |  **71,963.7 ns** |    **647.84 ns** |    **605.99 ns** | **1.000** |  **1.4648** |  **0.1221** |       **-** |   **40905 B** |
|                  MyArrayList |   AddRange |  Int32[1000] |      100 |   6,971.5 ns |    112.05 ns |    104.81 ns | 0.097 |  0.4730 |  0.0076 |       - |   12560 B |
| **System.Collections.ArrayList** |   **AddRange** |   **Int32[100]** |      **100** |   **7,670.7 ns** |    **137.46 ns** |    **163.63 ns** | **0.107** |  **0.1526** |       **-** |       **-** |    **4080 B** |
|                  MyArrayList |   AddRange |   Int32[100] |      100 |     694.0 ns |      5.18 ns |      4.32 ns | 0.010 |  0.0486 |       - |       - |    1288 B |
| **System.Collections.ArrayList** |   **AddRange** |    **Int32[10]** |      **100** |   **1,075.8 ns** |      **6.49 ns** |      **6.07 ns** | **0.015** |  **0.0458** |       **-** |       **-** |    **1200 B** |
|                  MyArrayList |   AddRange |    Int32[10] |      100 |     125.9 ns |      2.55 ns |      5.92 ns | 0.002 |  0.0176 |       - |       - |     464 B |
|                              |            |              |          |              |              |              |       |         |         |         |           |
| **System.Collections.ArrayList** |      **Clear** |  **Int32[1000]** |      **100** |  **73,649.1 ns** |  **1,284.49 ns** |  **1,201.51 ns** | **1.000** |  **1.4648** |  **0.1221** |       **-** |   **40904 B** |
|                  MyArrayList |      Clear |  Int32[1000] |      100 |   9,548.1 ns |    124.54 ns |    116.49 ns | 0.130 |  0.4730 |       - |       - |   12560 B |
| **System.Collections.ArrayList** |      **Clear** |   **Int32[100]** |      **100** |   **7,393.5 ns** |     **38.07 ns** |     **31.79 ns** | **0.101** |  **0.1526** |       **-** |       **-** |    **4080 B** |
|                  MyArrayList |      Clear |   Int32[100] |      100 |     971.7 ns |      8.70 ns |      7.71 ns | 0.013 |  0.0477 |       - |       - |    1288 B |
| **System.Collections.ArrayList** |      **Clear** |    **Int32[10]** |      **100** |   **1,117.4 ns** |     **14.73 ns** |     **13.78 ns** | **0.015** |  **0.0458** |       **-** |       **-** |    **1200 B** |
|                  MyArrayList |      Clear |    Int32[10] |      100 |     159.6 ns |      3.20 ns |      5.43 ns | 0.002 |  0.0176 |       - |       - |     464 B |
|                              |            |              |          |              |              |              |       |         |         |         |           |
| **System.Collections.ArrayList** |        **Add** | **Int32[10000]** |     **1000** | **321,602.6 ns** |  **6,258.41 ns** |  **7,207.19 ns** |  **1.00** | **39.5508** | **39.5508** | **39.5508** |  **488152 B** |
|                  MyArrayList |        Add | Int32[10000] |     1000 |  65,899.5 ns |  1,255.51 ns |  1,112.97 ns |  0.20 |  4.6387 |  0.8545 |       - |  124161 B |
|                              |            |              |          |              |              |              |       |         |         |         |           |
| System.Collections.ArrayList |   AddRange | Int32[10000] |     1000 | 736,028.6 ns |  7,946.65 ns |  7,433.30 ns |  1.00 | 14.6484 |  5.8594 |       - |  408112 B |
|                  MyArrayList |   AddRange | Int32[10000] |     1000 |  65,878.9 ns |  1,147.39 ns |  1,275.32 ns |  0.09 |  4.6387 |  0.8545 |       - |  124160 B |
|                              |            |              |          |              |              |              |       |         |         |         |           |
| System.Collections.ArrayList |      Clear | Int32[10000] |     1000 | 739,075.5 ns | 13,385.85 ns | 11,866.21 ns |  1.00 | 14.6484 |  5.8594 |       - |  408112 B |
|                  MyArrayList |      Clear | Int32[10000] |     1000 |  92,160.0 ns |  1,388.13 ns |  1,298.46 ns |  0.12 |  4.6387 |  0.8545 |       - |  124161 B |
