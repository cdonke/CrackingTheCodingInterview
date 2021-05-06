``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                    Method |              Categories |                 data |         Mean |        Error |       StdDev |       Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------------ |--------------------- |-------------:|-------------:|-------------:|-------------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lore(...)non. [3382]** |    **713.93 ns** |    **14.230 ns** |    **20.858 ns** |    **712.40 ns** |  **1.00** |    **0.00** | **0.2613** | **0.0057** |     **-** |    **6840 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lore(...)non. [3382] | 11,555.67 ns |   311.216 ns |   917.628 ns | 11,406.63 ns | 15.14 |    0.64 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lore(...)non. [3382] |    774.34 ns |    15.432 ns |    24.026 ns |    775.60 ns |  1.00 |    0.00 | 0.2642 | 0.0067 |     - |    6912 B |
|           MyStringBuilder |             V1 - Append | Lore(...)non. [3382] | 13,467.65 ns |   268.591 ns |   589.564 ns | 13,671.05 ns | 16.96 |    0.86 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lore(...)non. [3382] |  1,766.51 ns |    86.124 ns |   253.938 ns |  1,756.43 ns |  1.00 |    0.00 | 0.5226 | 0.0229 |     - |   13752 B |
|           MyStringBuilder |         V1 - AppendLine | Lore(...)non. [3382] | 13,509.45 ns |   266.395 ns |   622.690 ns | 13,609.11 ns |  7.68 |    1.05 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lore(...)non. [3382] |  2,200.64 ns |    71.543 ns |   201.789 ns |  2,126.77 ns |  1.00 |    0.00 | 0.7858 | 0.0343 |     - |   20544 B |
|           MyStringBuilder |           V1 - ToString | Lore(...)non. [3382] | 17,821.28 ns |   710.291 ns | 2,094.308 ns | 17,641.21 ns |  8.10 |    1.23 | 1.0376 | 0.0305 |     - |   27728 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lore(...)non. [3382] |    965.05 ns |    43.724 ns |   125.452 ns |    957.04 ns |  1.00 |    0.00 | 0.2613 | 0.0057 |     - |    6840 B |
|           MyStringBuilder | V2 - Append_Constructor | Lore(...)non. [3382] | 12,510.58 ns |   244.868 ns |   459.921 ns | 12,520.11 ns | 12.60 |    1.96 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lore(...)non. [3382] |    788.20 ns |    14.187 ns |    29.298 ns |    782.91 ns |  1.00 |    0.00 | 0.2642 | 0.0067 |     - |    6912 B |
|           MyStringBuilder |             V2 - Append | Lore(...)non. [3382] | 11,381.89 ns |   234.323 ns |   690.906 ns | 11,359.02 ns | 14.66 |    0.99 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lore(...)non. [3382] |  1,278.65 ns |    24.661 ns |    52.555 ns |  1,281.84 ns |  1.00 |    0.00 | 0.5245 | 0.0248 |     - |   13752 B |
|           MyStringBuilder |         V2 - AppendLine | Lore(...)non. [3382] | 11,675.22 ns |   289.484 ns |   853.550 ns | 11,562.55 ns |  9.37 |    0.85 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lore(...)non. [3382] |  2,156.26 ns |    42.823 ns |   124.236 ns |  2,130.36 ns |  1.00 |    0.00 | 0.7858 | 0.0343 |     - |   20544 B |
|           MyStringBuilder |           V2 - ToString | Lore(...)non. [3382] | 16,970.58 ns |   555.826 ns | 1,638.867 ns | 16,610.08 ns |  7.91 |    0.87 | 1.0376 | 0.0305 |     - |   27728 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lorem(...)uere. [71]** |     **49.90 ns** |     **2.070 ns** |     **6.007 ns** |     **48.33 ns** |  **1.00** |    **0.00** | **0.0082** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lorem(...)uere. [71] |    351.43 ns |     6.987 ns |    17.656 ns |    352.58 ns |  7.06 |    1.06 | 0.0801 | 0.0005 |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lorem(...)uere. [71] |     89.29 ns |     1.876 ns |     5.530 ns |     88.78 ns |  1.00 |    0.00 | 0.0110 |      - |     - |     288 B |
|           MyStringBuilder |             V1 - Append | Lorem(...)uere. [71] |    439.71 ns |    33.777 ns |    99.593 ns |    411.50 ns |  4.94 |    1.11 | 0.0801 | 0.0005 |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lorem(...)uere. [71] |    172.60 ns |     8.434 ns |    24.736 ns |    169.16 ns |  1.00 |    0.00 | 0.0191 |      - |     - |     504 B |
|           MyStringBuilder |         V1 - AppendLine | Lorem(...)uere. [71] |    490.87 ns |    30.309 ns |    89.368 ns |    500.24 ns |  2.87 |    0.52 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lorem(...)uere. [71] |    245.99 ns |     6.854 ns |    20.209 ns |    246.02 ns |  1.00 |    0.00 | 0.0253 |      - |     - |     672 B |
|           MyStringBuilder |           V1 - ToString | Lorem(...)uere. [71] |    635.90 ns |    41.870 ns |   123.453 ns |    594.49 ns |  2.62 |    0.63 | 0.0925 |      - |     - |    2432 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lorem(...)uere. [71] |     58.41 ns |     2.549 ns |     7.516 ns |     57.54 ns |  1.00 |    0.00 | 0.0082 |      - |     - |     216 B |
|           MyStringBuilder | V2 - Append_Constructor | Lorem(...)uere. [71] |    495.75 ns |    51.386 ns |   151.513 ns |    405.16 ns |  8.46 |    2.25 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lorem(...)uere. [71] |    110.20 ns |     3.623 ns |    10.683 ns |    111.52 ns |  1.00 |    0.00 | 0.0110 |      - |     - |     288 B |
|           MyStringBuilder |             V2 - Append | Lorem(...)uere. [71] |    571.87 ns |    36.385 ns |   107.281 ns |    602.18 ns |  5.25 |    1.15 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lorem(...)uere. [71] |    207.66 ns |     5.753 ns |    16.963 ns |    207.65 ns |  1.00 |    0.00 | 0.0191 |      - |     - |     504 B |
|           MyStringBuilder |         V2 - AppendLine | Lorem(...)uere. [71] |    522.53 ns |    26.648 ns |    78.573 ns |    526.33 ns |  2.54 |    0.50 | 0.0801 | 0.0005 |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lorem(...)uere. [71] |    294.45 ns |     8.778 ns |    25.883 ns |    304.57 ns |  1.00 |    0.00 | 0.0253 |      - |     - |     672 B |
|           MyStringBuilder |           V2 - ToString | Lorem(...)uere. [71] |    809.79 ns |    22.248 ns |    65.598 ns |    835.80 ns |  2.78 |    0.42 | 0.0925 |      - |     - |    2432 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lore(...) ut. [6730]** |  **2,327.92 ns** |   **155.372 ns** |   **455.679 ns** |  **2,314.48 ns** |  **1.00** |    **0.00** | **0.5169** | **0.0229** |     **-** |   **13536 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lore(...) ut. [6730] | 28,925.91 ns |   433.481 ns |   405.478 ns | 28,883.66 ns | 11.26 |    1.07 | 1.1292 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lore(...) ut. [6730] |  1,998.72 ns |   134.576 ns |   394.689 ns |  1,864.03 ns |  1.00 |    0.00 | 0.5188 | 0.0229 |     - |   13608 B |
|           MyStringBuilder |             V1 - Append | Lore(...) ut. [6730] | 27,469.47 ns |   587.673 ns | 1,732.768 ns | 28,300.12 ns | 14.21 |    2.63 | 1.1292 | 0.0916 |     - |   30168 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lore(...) ut. [6730] |  3,483.24 ns |   269.528 ns |   786.226 ns |  3,253.82 ns |  1.00 |    0.00 | 1.0300 | 0.0916 |     - |   27144 B |
|           MyStringBuilder |         V1 - AppendLine | Lore(...) ut. [6730] | 27,125.09 ns |   539.937 ns | 1,162.272 ns | 27,236.17 ns |  7.29 |    1.39 | 1.1292 | 0.0916 |     - |   30168 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lore(...) ut. [6730] |  7,949.86 ns |   586.534 ns | 1,729.408 ns |  8,210.97 ns |  1.00 |    0.00 | 1.5488 | 0.1373 |     - |   40632 B |
|           MyStringBuilder |           V1 - ToString | Lore(...) ut. [6730] | 40,456.41 ns |   462.751 ns |   432.857 ns | 40,353.19 ns |  4.45 |    0.68 | 2.1362 | 0.1221 |     - |   57144 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lore(...) ut. [6730] |  1,712.93 ns |    65.591 ns |   179.555 ns |  1,668.36 ns |  1.00 |    0.00 | 0.5150 | 0.0229 |     - |   13536 B |
|           MyStringBuilder | V2 - Append_Constructor | Lore(...) ut. [6730] | 27,343.55 ns |   540.308 ns | 1,230.555 ns | 27,588.59 ns | 15.77 |    1.83 | 1.1292 | 0.0916 |     - |   30168 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lore(...) ut. [6730] |  1,827.50 ns |    63.521 ns |   187.293 ns |  1,760.73 ns |  1.00 |    0.00 | 0.5188 | 0.0229 |     - |   13608 B |
|           MyStringBuilder |             V2 - Append | Lore(...) ut. [6730] | 23,934.24 ns |   582.952 ns | 1,691.249 ns | 23,875.42 ns | 13.22 |    1.65 | 1.1292 | 0.0916 |     - |   30168 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lore(...) ut. [6730] |  2,796.83 ns |   123.796 ns |   363.072 ns |  2,711.94 ns |  1.00 |    0.00 | 1.0338 | 0.0916 |     - |   27144 B |
|           MyStringBuilder |         V2 - AppendLine | Lore(...) ut. [6730] | 24,606.96 ns |   508.789 ns | 1,500.177 ns | 24,780.77 ns |  8.94 |    1.22 | 1.1292 | 0.0916 |     - |   30168 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lore(...) ut. [6730] |  5,605.09 ns |   319.631 ns |   942.439 ns |  5,575.02 ns |  1.00 |    0.00 | 1.5488 | 0.1373 |     - |   40632 B |
|           MyStringBuilder |           V2 - ToString | Lore(...) ut. [6730] | 37,166.70 ns | 1,167.582 ns | 3,442.642 ns | 37,222.45 ns |  6.77 |    1.03 | 2.1362 | 0.1221 |     - |   57144 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** |  **Lore(...)lus. [659]** |    **208.78 ns** |     **7.793 ns** |    **21.981 ns** |    **204.91 ns** |  **1.00** |    **0.00** | **0.0529** |      **-** |     **-** |    **1392 B** |
|           MyStringBuilder | V1 - Append_Constructor |  Lore(...)lus. [659] |  2,098.56 ns |    41.605 ns |    54.099 ns |  2,101.15 ns | 10.02 |    1.05 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append |  Lore(...)lus. [659] |    284.69 ns |    22.285 ns |    65.707 ns |    254.26 ns |  1.00 |    0.00 | 0.0558 |      - |     - |    1464 B |
|           MyStringBuilder |             V1 - Append |  Lore(...)lus. [659] |  2,097.67 ns |    41.599 ns |    59.660 ns |  2,108.84 ns |  8.17 |    0.72 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine |  Lore(...)lus. [659] |    513.13 ns |    23.709 ns |    69.907 ns |    502.31 ns |  1.00 |    0.00 | 0.1087 | 0.0010 |     - |    2856 B |
|           MyStringBuilder |         V1 - AppendLine |  Lore(...)lus. [659] |  2,147.44 ns |    41.651 ns |    63.606 ns |  2,153.96 ns |  4.27 |    0.54 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString |  Lore(...)lus. [659] |    948.97 ns |    43.773 ns |   129.064 ns |    935.25 ns |  1.00 |    0.00 | 0.1602 |      - |     - |    4200 B |
|           MyStringBuilder |           V1 - ToString |  Lore(...)lus. [659] |  3,290.85 ns |    79.629 ns |   234.787 ns |  3,393.20 ns |  3.55 |    0.64 | 0.1793 |      - |     - |    4784 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor |  Lore(...)lus. [659] |    390.54 ns |     7.731 ns |     7.593 ns |    390.95 ns |  1.00 |    0.00 | 0.0529 |      - |     - |    1392 B |
|           MyStringBuilder | V2 - Append_Constructor |  Lore(...)lus. [659] |  2,115.55 ns |    27.788 ns |    25.993 ns |  2,116.07 ns |  5.42 |    0.13 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append |  Lore(...)lus. [659] |    371.35 ns |    13.338 ns |    39.328 ns |    377.09 ns |  1.00 |    0.00 | 0.0558 |      - |     - |    1464 B |
|           MyStringBuilder |             V2 - Append |  Lore(...)lus. [659] |  2,017.19 ns |    40.309 ns |    89.323 ns |  2,026.97 ns |  5.35 |    0.63 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine |  Lore(...)lus. [659] |    653.30 ns |    29.539 ns |    87.096 ns |    656.48 ns |  1.00 |    0.00 | 0.1087 | 0.0010 |     - |    2856 B |
|           MyStringBuilder |         V2 - AppendLine |  Lore(...)lus. [659] |  2,095.55 ns |    40.324 ns |    55.196 ns |  2,087.66 ns |  3.57 |    0.56 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString |  Lore(...)lus. [659] |    865.36 ns |    47.725 ns |   140.719 ns |    873.14 ns |  1.00 |    0.00 | 0.1602 | 0.0010 |     - |    4200 B |
|           MyStringBuilder |           V2 - ToString |  Lore(...)lus. [659] |  3,327.02 ns |    54.635 ns |    48.433 ns |  3,331.80 ns |  3.40 |    0.39 | 0.1793 |      - |     - |    4784 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** |  **orem(...)ros. [310]** |    **149.40 ns** |     **9.160 ns** |    **27.008 ns** |    **151.47 ns** |  **1.00** |    **0.00** | **0.0265** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | V1 - Append_Constructor |  orem(...)ros. [310] |  1,139.41 ns |    28.525 ns |    84.106 ns |  1,155.29 ns |  7.86 |    1.50 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append |  orem(...)ros. [310] |    209.15 ns |    11.450 ns |    33.759 ns |    201.46 ns |  1.00 |    0.00 | 0.0293 |      - |     - |     768 B |
|           MyStringBuilder |             V1 - Append |  orem(...)ros. [310] |  1,243.44 ns |    24.840 ns |    27.610 ns |  1,253.70 ns |  5.00 |    0.49 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine |  orem(...)ros. [310] |    273.82 ns |    13.132 ns |    38.719 ns |    265.78 ns |  1.00 |    0.00 | 0.0558 |      - |     - |    1464 B |
|           MyStringBuilder |         V1 - AppendLine |  orem(...)ros. [310] |  1,159.10 ns |    52.808 ns |   155.706 ns |  1,251.81 ns |  4.36 |    1.00 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString |  orem(...)ros. [310] |    530.64 ns |    28.903 ns |    85.222 ns |    532.81 ns |  1.00 |    0.00 | 0.0801 |      - |     - |    2112 B |
|           MyStringBuilder |           V1 - ToString |  orem(...)ros. [310] |  1,432.84 ns |    60.118 ns |   177.259 ns |  1,368.19 ns |  2.81 |    0.76 | 0.1297 |      - |     - |    3392 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor |  orem(...)ros. [310] |    110.36 ns |     3.034 ns |     8.898 ns |    110.17 ns |  1.00 |    0.00 | 0.0265 |      - |     - |     696 B |
|           MyStringBuilder | V2 - Append_Constructor |  orem(...)ros. [310] |    956.06 ns |    28.958 ns |    85.385 ns |    955.16 ns |  8.73 |    1.04 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append |  orem(...)ros. [310] |    198.68 ns |    15.265 ns |    45.010 ns |    204.91 ns |  1.00 |    0.00 | 0.0293 |      - |     - |     768 B |
|           MyStringBuilder |             V2 - Append |  orem(...)ros. [310] |  1,046.97 ns |    40.640 ns |   119.829 ns |  1,036.27 ns |  5.68 |    1.99 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine |  orem(...)ros. [310] |    340.32 ns |    23.199 ns |    68.404 ns |    327.45 ns |  1.00 |    0.00 | 0.0558 | 0.0002 |     - |    1464 B |
|           MyStringBuilder |         V2 - AppendLine |  orem(...)ros. [310] |  1,158.57 ns |    42.028 ns |   123.922 ns |  1,219.38 ns |  3.53 |    0.78 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString |  orem(...)ros. [310] |    404.10 ns |    19.204 ns |    55.101 ns |    402.32 ns |  1.00 |    0.00 | 0.0806 |      - |     - |    2112 B |
|           MyStringBuilder |           V2 - ToString |  orem(...)ros. [310] |  1,298.29 ns |    25.838 ns |    62.894 ns |  1,297.69 ns |  3.16 |    0.38 | 0.1297 |      - |     - |    3392 B |
