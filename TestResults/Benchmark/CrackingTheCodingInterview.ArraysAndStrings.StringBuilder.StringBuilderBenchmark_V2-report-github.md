``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                    Method |         Categories |                 data |        Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------- |--------------------- |------------:|-----------:|-----------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...)non. [3382]** |   **678.20 ns** |  **13.220 ns** |  **24.505 ns** |  **1.00** |    **0.00** | **0.3653** | **0.0086** |     **-** |    **6840 B** |
|           MyStringBuilder | Append_Constructor | Lore(...)non. [3382] | 1,095.39 ns |  21.236 ns |  31.127 ns |  1.61 |    0.08 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...)non. [3382] |   858.99 ns |  17.132 ns |  33.816 ns |  1.00 |    0.00 | 0.3691 | 0.0086 |     - |    6912 B |
|           MyStringBuilder |             Append | Lore(...)non. [3382] | 1,174.78 ns |  21.747 ns |  58.423 ns |  1.37 |    0.09 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...)non. [3382] | 1,526.19 ns |  30.222 ns |  68.830 ns |  1.00 |    0.00 | 0.7343 | 0.0343 |     - |   13752 B |
|           MyStringBuilder |         AppendLine | Lore(...)non. [3382] | 1,143.93 ns |  22.916 ns |  49.817 ns |  0.75 |    0.05 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...)non. [3382] | 2,419.19 ns |  47.301 ns |  66.310 ns |  1.00 |    0.00 | 1.0986 | 0.0496 |     - |   20544 B |
|           MyStringBuilder |           ToString | Lore(...)non. [3382] | 2,735.10 ns |  53.131 ns |  85.796 ns |  1.13 |    0.05 | 1.2627 | 0.0381 |     - |   23672 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lorem(...)uere. [71]** |    **54.95 ns** |   **1.143 ns** |   **1.745 ns** |  **1.00** |    **0.00** | **0.0115** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | Append_Constructor | Lorem(...)uere. [71] |   214.81 ns |   4.294 ns |  10.206 ns |  4.01 |    0.19 | 0.1104 | 0.0007 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lorem(...)uere. [71] |   111.35 ns |   2.220 ns |   2.467 ns |  1.00 |    0.00 | 0.0154 |      - |     - |     288 B |
|           MyStringBuilder |             Append | Lorem(...)uere. [71] |   228.23 ns |   4.611 ns |   9.101 ns |  2.09 |    0.10 | 0.1104 | 0.0007 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lorem(...)uere. [71] |   189.14 ns |   3.828 ns |   4.701 ns |  1.00 |    0.00 | 0.0269 |      - |     - |     504 B |
|           MyStringBuilder |         AppendLine | Lorem(...)uere. [71] |   249.90 ns |   4.877 ns |   9.161 ns |  1.32 |    0.05 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lorem(...)uere. [71] |   249.34 ns |   5.030 ns |   9.448 ns |  1.00 |    0.00 | 0.0358 |      - |     - |     672 B |
|           MyStringBuilder |           ToString | Lorem(...)uere. [71] |   343.12 ns |   6.845 ns |  14.588 ns |  1.39 |    0.08 | 0.1283 | 0.0010 |     - |    2400 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...) ut. [6730]** | **1,673.69 ns** |  **30.259 ns** |  **55.330 ns** |  **1.00** |    **0.00** | **0.7229** | **0.0343** |     **-** |   **13536 B** |
|           MyStringBuilder | Append_Constructor | Lore(...) ut. [6730] | 2,096.06 ns |  38.822 ns |  79.303 ns |  1.25 |    0.06 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...) ut. [6730] | 1,734.26 ns |  33.459 ns |  45.798 ns |  1.00 |    0.00 | 0.7267 | 0.0343 |     - |   13608 B |
|           MyStringBuilder |             Append | Lore(...) ut. [6730] | 2,143.84 ns |  42.431 ns |  52.109 ns |  1.24 |    0.04 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...) ut. [6730] | 2,533.71 ns |  67.603 ns | 192.875 ns |  1.00 |    0.00 | 1.4496 | 0.1297 |     - |   27144 B |
|           MyStringBuilder |         AppendLine | Lore(...) ut. [6730] | 2,080.41 ns |  41.042 ns |  40.309 ns |  0.72 |    0.03 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...) ut. [6730] | 5,139.08 ns | 102.445 ns | 173.960 ns |  1.00 |    0.00 | 2.1667 | 0.1755 |     - |   40632 B |
|           MyStringBuilder |           ToString | Lore(...) ut. [6730] | 5,697.64 ns | 106.169 ns |  99.310 ns |  1.11 |    0.05 | 2.4033 | 0.1297 |     - |   45064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **Lore(...)lus. [659]** |   **204.22 ns** |   **4.085 ns** |   **6.238 ns** |  **1.00** |    **0.00** | **0.0744** | **0.0002** |     **-** |    **1392 B** |
|           MyStringBuilder | Append_Constructor |  Lore(...)lus. [659] |   266.67 ns |   5.328 ns |  10.885 ns |  1.30 |    0.06 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  Lore(...)lus. [659] |   261.71 ns |   5.265 ns |  15.191 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |             Append |  Lore(...)lus. [659] |   269.70 ns |   5.388 ns |  10.508 ns |  1.00 |    0.04 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  Lore(...)lus. [659] |   430.37 ns |   8.507 ns |   8.355 ns |  1.00 |    0.00 | 0.1526 | 0.0014 |     - |    2856 B |
|           MyStringBuilder |         AppendLine |  Lore(...)lus. [659] |   302.37 ns |   6.043 ns |   9.408 ns |  0.70 |    0.02 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  Lore(...)lus. [659] |   644.58 ns |  12.871 ns |  22.201 ns |  1.00 |    0.00 | 0.2241 | 0.0019 |     - |    4200 B |
|           MyStringBuilder |           ToString |  Lore(...)lus. [659] |   683.32 ns |  13.354 ns |  22.676 ns |  1.06 |    0.05 | 0.2537 | 0.0010 |     - |    4752 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **orem(...)ros. [310]** |   **112.00 ns** |   **2.269 ns** |   **4.318 ns** |  **1.00** |    **0.00** | **0.0372** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | Append_Constructor |  orem(...)ros. [310] |   235.59 ns |   4.700 ns |  11.351 ns |  2.11 |    0.12 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  orem(...)ros. [310] |   171.51 ns |   3.398 ns |   5.862 ns |  1.00 |    0.00 | 0.0410 |      - |     - |     768 B |
|           MyStringBuilder |             Append |  orem(...)ros. [310] |   247.33 ns |   4.964 ns |   9.798 ns |  1.44 |    0.08 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  orem(...)ros. [310] |   301.57 ns |   5.996 ns |  14.932 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |         AppendLine |  orem(...)ros. [310] |   278.94 ns |   5.587 ns |  12.381 ns |  0.92 |    0.06 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  orem(...)ros. [310] |   407.20 ns |   8.161 ns |   8.732 ns |  1.00 |    0.00 | 0.1125 | 0.0005 |     - |    2112 B |
|           MyStringBuilder |           ToString |  orem(...)ros. [310] |   474.98 ns |   9.511 ns |  20.677 ns |  1.19 |    0.06 | 0.1793 | 0.0010 |     - |    3360 B |
