``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|                    Method |              Categories |                 data |         Mean |      Error |       StdDev |       Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------------ |--------------------- |-------------:|-----------:|-------------:|-------------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lore(...)non. [3382]** |    **789.85 ns** |  **14.906 ns** |    **13.214 ns** |    **793.67 ns** |  **1.00** |    **0.00** | **0.3653** | **0.0086** |     **-** |    **6840 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lore(...)non. [3382] | 18,351.21 ns |  50.469 ns |    47.209 ns | 18,344.00 ns | 23.24 |    0.41 | 0.7324 |      - |     - |   14144 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lore(...)non. [3382] |    827.43 ns |  27.071 ns |    78.968 ns |    838.15 ns |  1.00 |    0.00 | 0.3691 | 0.0086 |     - |    6912 B |
|           MyStringBuilder |             V1 - Append | Lore(...)non. [3382] | 18,468.25 ns | 117.578 ns |    98.183 ns | 18,478.58 ns | 21.15 |    0.82 | 0.7324 |      - |     - |   14144 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lore(...)non. [3382] |  1,259.35 ns |  45.173 ns |   130.335 ns |  1,202.74 ns |  1.00 |    0.00 | 0.7343 | 0.0343 |     - |   13752 B |
|           MyStringBuilder |         V1 - AppendLine | Lore(...)non. [3382] | 18,445.60 ns | 180.074 ns |   159.631 ns | 18,435.15 ns | 12.30 |    0.30 | 0.7324 |      - |     - |   14144 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lore(...)non. [3382] |  2,689.35 ns |  53.171 ns |   137.252 ns |  2,689.22 ns |  1.00 |    0.00 | 1.0986 | 0.0496 |     - |   20544 B |
|           MyStringBuilder |           V1 - ToString | Lore(...)non. [3382] | 24,170.63 ns | 108.972 ns |   101.932 ns | 24,185.19 ns |  8.73 |    0.33 | 1.4648 | 0.0610 |     - |   27728 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lore(...)non. [3382] |    843.38 ns |  21.744 ns |    63.427 ns |    831.52 ns |  1.00 |    0.00 | 0.3653 | 0.0086 |     - |    6840 B |
|           MyStringBuilder | V2 - Append_Constructor | Lore(...)non. [3382] | 18,335.91 ns | 121.928 ns |   114.051 ns | 18,377.43 ns | 19.89 |    1.13 | 0.7324 |      - |     - |   14144 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lore(...)non. [3382] |    956.96 ns |  26.817 ns |    79.071 ns |    948.60 ns |  1.00 |    0.00 | 0.3691 | 0.0086 |     - |    6912 B |
|           MyStringBuilder |             V2 - Append | Lore(...)non. [3382] | 18,429.40 ns |  75.402 ns |    70.531 ns | 18,424.09 ns | 20.65 |    1.37 | 0.7324 |      - |     - |   14144 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lore(...)non. [3382] |  1,624.24 ns |  41.045 ns |   120.378 ns |  1,611.25 ns |  1.00 |    0.00 | 0.7343 | 0.0343 |     - |   13752 B |
|           MyStringBuilder |         V2 - AppendLine | Lore(...)non. [3382] | 18,550.54 ns |  86.087 ns |    80.526 ns | 18,544.92 ns | 11.26 |    0.91 | 0.7324 |      - |     - |   14144 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lore(...)non. [3382] |  2,543.33 ns |  50.327 ns |   127.184 ns |  2,523.72 ns |  1.00 |    0.00 | 1.0986 | 0.0496 |     - |   20544 B |
|           MyStringBuilder |           V2 - ToString | Lore(...)non. [3382] | 23,622.52 ns | 326.894 ns |   305.777 ns | 23,732.40 ns |  9.24 |    0.54 | 1.4648 | 0.0305 |     - |   27728 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lorem(...)uere. [71]** |     **54.60 ns** |   **1.138 ns** |     **2.272 ns** |     **54.62 ns** |  **1.00** |    **0.00** | **0.0114** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lorem(...)uere. [71] |    484.11 ns |   9.689 ns |    25.863 ns |    485.88 ns |  8.66 |    0.62 | 0.1121 | 0.0005 |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lorem(...)uere. [71] |    118.03 ns |   2.322 ns |     2.385 ns |    117.59 ns |  1.00 |    0.00 | 0.0153 |      - |     - |     288 B |
|           MyStringBuilder |             V1 - Append | Lorem(...)uere. [71] |    501.02 ns |   9.962 ns |    24.624 ns |    497.73 ns |  4.35 |    0.17 | 0.1116 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lorem(...)uere. [71] |    210.74 ns |   3.573 ns |     3.509 ns |    210.41 ns |  1.00 |    0.00 | 0.0269 |      - |     - |     504 B |
|           MyStringBuilder |         V1 - AppendLine | Lorem(...)uere. [71] |    488.16 ns |   9.796 ns |    26.315 ns |    487.65 ns |  2.35 |    0.14 | 0.1116 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lorem(...)uere. [71] |    255.11 ns |   5.071 ns |     7.273 ns |    253.06 ns |  1.00 |    0.00 | 0.0358 |      - |     - |     672 B |
|           MyStringBuilder |           V1 - ToString | Lorem(...)uere. [71] |    737.68 ns |  15.254 ns |    44.496 ns |    730.83 ns |  2.93 |    0.25 | 0.1297 | 0.0010 |     - |    2432 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lorem(...)uere. [71] |     56.93 ns |   1.171 ns |     1.988 ns |     56.81 ns |  1.00 |    0.00 | 0.0114 |      - |     - |     216 B |
|           MyStringBuilder | V2 - Append_Constructor | Lorem(...)uere. [71] |    469.61 ns |  11.293 ns |    32.219 ns |    464.36 ns |  8.64 |    0.67 | 0.1116 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lorem(...)uere. [71] |    119.14 ns |   2.355 ns |     2.978 ns |    119.88 ns |  1.00 |    0.00 | 0.0154 |      - |     - |     288 B |
|           MyStringBuilder |             V2 - Append | Lorem(...)uere. [71] |    465.49 ns |   9.327 ns |    24.895 ns |    460.82 ns |  4.01 |    0.22 | 0.1116 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lorem(...)uere. [71] |    187.58 ns |   3.762 ns |     6.489 ns |    187.24 ns |  1.00 |    0.00 | 0.0269 |      - |     - |     504 B |
|           MyStringBuilder |         V2 - AppendLine | Lorem(...)uere. [71] |    473.66 ns |   9.508 ns |    26.505 ns |    468.63 ns |  2.58 |    0.15 | 0.1116 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lorem(...)uere. [71] |    237.27 ns |   4.758 ns |     6.669 ns |    237.85 ns |  1.00 |    0.00 | 0.0358 |      - |     - |     672 B |
|           MyStringBuilder |           V2 - ToString | Lorem(...)uere. [71] |    587.43 ns |  10.203 ns |    16.182 ns |    586.93 ns |  2.48 |    0.12 | 0.1297 | 0.0010 |     - |    2432 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lore(...) ut. [6730]** |  **1,438.35 ns** |  **28.508 ns** |    **40.885 ns** |  **1,430.94 ns** |  **1.00** |    **0.00** | **0.7229** | **0.0343** |     **-** |   **13536 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lore(...) ut. [6730] | 37,698.41 ns | 249.589 ns |   221.254 ns | 37,671.27 ns | 26.12 |    0.77 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lore(...) ut. [6730] |  1,480.41 ns |  29.368 ns |    59.991 ns |  1,476.81 ns |  1.00 |    0.00 | 0.7267 | 0.0343 |     - |   13608 B |
|           MyStringBuilder |             V1 - Append | Lore(...) ut. [6730] | 38,137.58 ns | 254.359 ns |   225.483 ns | 38,150.78 ns | 24.91 |    1.10 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lore(...) ut. [6730] |  2,915.28 ns |  58.100 ns |   158.064 ns |  2,894.26 ns |  1.00 |    0.00 | 1.4496 | 0.1297 |     - |   27144 B |
|           MyStringBuilder |         V1 - AppendLine | Lore(...) ut. [6730] | 40,168.37 ns | 801.863 ns |   823.454 ns | 40,088.42 ns | 13.20 |    0.80 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lore(...) ut. [6730] |  5,020.58 ns | 100.167 ns |   206.863 ns |  5,002.35 ns |  1.00 |    0.00 | 2.1667 | 0.1755 |     - |   40632 B |
|           MyStringBuilder |           V1 - ToString | Lore(...) ut. [6730] | 47,743.86 ns | 474.007 ns |   395.817 ns | 47,758.53 ns |  9.20 |    0.30 | 3.0518 | 0.1831 |     - |   57145 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lore(...) ut. [6730] |  1,629.41 ns |  32.625 ns |    30.517 ns |  1,619.80 ns |  1.00 |    0.00 | 0.7229 | 0.0343 |     - |   13536 B |
|           MyStringBuilder | V2 - Append_Constructor | Lore(...) ut. [6730] | 37,675.69 ns | 295.061 ns |   261.564 ns | 37,571.54 ns | 23.13 |    0.45 | 1.5869 | 0.0610 |     - |   30169 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lore(...) ut. [6730] |  1,768.23 ns |  35.372 ns |    81.273 ns |  1,770.64 ns |  1.00 |    0.00 | 0.7267 | 0.0343 |     - |   13608 B |
|           MyStringBuilder |             V2 - Append | Lore(...) ut. [6730] | 38,697.16 ns | 735.707 ns | 1,078.390 ns | 38,177.91 ns | 21.75 |    1.20 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lore(...) ut. [6730] |  2,819.06 ns |  56.394 ns |   117.716 ns |  2,806.17 ns |  1.00 |    0.00 | 1.4496 | 0.1297 |     - |   27144 B |
|           MyStringBuilder |         V2 - AppendLine | Lore(...) ut. [6730] | 37,950.38 ns | 337.020 ns |   298.759 ns | 37,858.14 ns | 13.15 |    0.41 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lore(...) ut. [6730] |  5,269.72 ns | 104.512 ns |   284.334 ns |  5,231.79 ns |  1.00 |    0.00 | 2.1667 | 0.1755 |     - |   40632 B |
|           MyStringBuilder |           V2 - ToString | Lore(...) ut. [6730] | 47,675.68 ns | 859.431 ns |   717.663 ns | 47,421.51 ns |  9.52 |    0.73 | 3.0518 | 0.1831 |     - |   57145 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** |  **Lore(...)lus. [659]** |    **203.44 ns** |   **4.054 ns** |     **8.813 ns** |    **203.40 ns** |  **1.00** |    **0.00** | **0.0744** | **0.0002** |     **-** |    **1392 B** |
|           MyStringBuilder | V1 - Append_Constructor |  Lore(...)lus. [659] |  2,311.77 ns |  20.243 ns |    18.935 ns |  2,319.03 ns | 11.31 |    0.54 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append |  Lore(...)lus. [659] |    255.20 ns |   5.141 ns |    10.845 ns |    254.33 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |             V1 - Append |  Lore(...)lus. [659] |  2,382.76 ns |  33.738 ns |    31.559 ns |  2,397.07 ns |  9.23 |    0.42 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine |  Lore(...)lus. [659] |    441.50 ns |   8.820 ns |    18.603 ns |    438.45 ns |  1.00 |    0.00 | 0.1526 | 0.0014 |     - |    2856 B |
|           MyStringBuilder |         V1 - AppendLine |  Lore(...)lus. [659] |  2,366.54 ns |  16.877 ns |    15.787 ns |  2,365.99 ns |  5.36 |    0.27 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString |  Lore(...)lus. [659] |    641.40 ns |  12.782 ns |    28.056 ns |    637.47 ns |  1.00 |    0.00 | 0.2241 | 0.0019 |     - |    4200 B |
|           MyStringBuilder |           V1 - ToString |  Lore(...)lus. [659] |  3,951.86 ns |  59.050 ns |    55.235 ns |  3,953.37 ns |  6.22 |    0.22 | 0.2518 |      - |     - |    4784 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor |  Lore(...)lus. [659] |    216.66 ns |   4.602 ns |    13.425 ns |    215.58 ns |  1.00 |    0.00 | 0.0744 | 0.0002 |     - |    1392 B |
|           MyStringBuilder | V2 - Append_Constructor |  Lore(...)lus. [659] |  2,307.22 ns |  11.369 ns |    10.634 ns |  2,309.37 ns | 10.87 |    0.52 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append |  Lore(...)lus. [659] |    261.86 ns |   6.101 ns |    17.701 ns |    257.72 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |             V2 - Append |  Lore(...)lus. [659] |  2,351.41 ns |  17.046 ns |    15.945 ns |  2,351.19 ns |  8.37 |    0.59 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine |  Lore(...)lus. [659] |    484.31 ns |   9.590 ns |    21.450 ns |    478.80 ns |  1.00 |    0.00 | 0.1526 | 0.0014 |     - |    2856 B |
|           MyStringBuilder |         V2 - AppendLine |  Lore(...)lus. [659] |  2,379.62 ns |  29.258 ns |    22.843 ns |  2,376.64 ns |  4.92 |    0.19 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString |  Lore(...)lus. [659] |    701.28 ns |  14.017 ns |    37.655 ns |    693.54 ns |  1.00 |    0.00 | 0.2241 | 0.0019 |     - |    4200 B |
|           MyStringBuilder |           V2 - ToString |  Lore(...)lus. [659] |  4,026.20 ns |  27.106 ns |    22.635 ns |  4,030.88 ns |  5.78 |    0.25 | 0.2518 |      - |     - |    4784 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** |  **orem(...)ros. [310]** |    **117.87 ns** |   **2.390 ns** |     **6.040 ns** |    **117.07 ns** |  **1.00** |    **0.00** | **0.0372** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | V1 - Append_Constructor |  orem(...)ros. [310] |  1,299.28 ns |  17.049 ns |    14.237 ns |  1,302.31 ns | 10.49 |    0.56 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append |  orem(...)ros. [310] |    193.93 ns |   3.829 ns |     8.720 ns |    193.98 ns |  1.00 |    0.00 | 0.0410 |      - |     - |     768 B |
|           MyStringBuilder |             V1 - Append |  orem(...)ros. [310] |  1,270.09 ns |  24.337 ns |    22.765 ns |  1,271.41 ns |  6.33 |    0.26 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine |  orem(...)ros. [310] |    267.64 ns |   5.872 ns |    17.221 ns |    262.93 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |         V1 - AppendLine |  orem(...)ros. [310] |  1,260.09 ns |  18.269 ns |    17.089 ns |  1,255.04 ns |  4.43 |    0.26 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString |  orem(...)ros. [310] |    397.39 ns |   7.818 ns |    11.938 ns |    398.26 ns |  1.00 |    0.00 | 0.1125 | 0.0005 |     - |    2112 B |
|           MyStringBuilder |           V1 - ToString |  orem(...)ros. [310] |  1,776.35 ns |  19.477 ns |    18.219 ns |  1,777.52 ns |  4.41 |    0.15 | 0.1812 |      - |     - |    3392 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor |  orem(...)ros. [310] |    108.31 ns |   2.190 ns |     4.373 ns |    107.55 ns |  1.00 |    0.00 | 0.0372 |      - |     - |     696 B |
|           MyStringBuilder | V2 - Append_Constructor |  orem(...)ros. [310] |  1,261.31 ns |  24.720 ns |    25.386 ns |  1,266.61 ns | 11.78 |    0.61 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append |  orem(...)ros. [310] |    174.27 ns |   3.482 ns |     7.268 ns |    173.90 ns |  1.00 |    0.00 | 0.0410 |      - |     - |     768 B |
|           MyStringBuilder |             V2 - Append |  orem(...)ros. [310] |  1,269.99 ns |  16.512 ns |    15.446 ns |  1,269.87 ns |  7.32 |    0.30 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine |  orem(...)ros. [310] |    292.77 ns |   5.843 ns |    13.773 ns |    293.81 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |         V2 - AppendLine |  orem(...)ros. [310] |  1,291.51 ns |  23.136 ns |    21.642 ns |  1,287.20 ns |  4.39 |    0.29 | 0.1106 |      - |     - |    2096 B |
|                           |                         |                      |              |            |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString |  orem(...)ros. [310] |    415.84 ns |   8.338 ns |    20.453 ns |    411.49 ns |  1.00 |    0.00 | 0.1125 | 0.0005 |     - |    2112 B |
|           MyStringBuilder |           V2 - ToString |  orem(...)ros. [310] |  1,761.77 ns |  31.143 ns |    30.587 ns |  1,759.16 ns |  4.20 |    0.24 | 0.1812 |      - |     - |    3392 B |
