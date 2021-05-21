``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.203
  [Host]     : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT
  DefaultJob : .NET Core 3.1.15 (CoreCLR 4.700.21.21202, CoreFX 4.700.21.21402), X64 RyuJIT


```
|                    Method |              Categories |                 data |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------------ |--------------------- |-------------:|-----------:|-----------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lore(...)non. [3382]** |  **1,598.20 ns** |  **54.622 ns** | **161.054 ns** |  **1.00** |    **0.00** | **0.2613** | **0.0057** |     **-** |    **6840 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lore(...)non. [3382] | 13,906.06 ns | 157.925 ns | 147.723 ns | 10.30 |    0.86 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lore(...)non. [3382] |  1,548.73 ns |  46.357 ns | 136.685 ns |  1.00 |    0.00 | 0.2632 | 0.0057 |     - |    6912 B |
|           MyStringBuilder |             V1 - Append | Lore(...)non. [3382] | 13,928.00 ns | 164.090 ns | 153.490 ns |  8.59 |    0.57 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lore(...)non. [3382] |  2,826.16 ns |  89.782 ns | 264.723 ns |  1.00 |    0.00 | 0.5226 | 0.0229 |     - |   13752 B |
|           MyStringBuilder |         V1 - AppendLine | Lore(...)non. [3382] | 14,069.47 ns | 207.144 ns | 193.762 ns |  4.69 |    0.22 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lore(...)non. [3382] |  4,086.42 ns | 232.254 ns | 684.805 ns |  1.00 |    0.00 | 0.7858 | 0.0305 |     - |   20544 B |
|           MyStringBuilder |           V1 - ToString | Lore(...)non. [3382] | 19,852.21 ns | 283.734 ns | 251.523 ns |  4.76 |    0.51 | 1.0376 | 0.0305 |     - |   27728 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lore(...)non. [3382] |  1,416.91 ns |  64.121 ns | 189.062 ns |  1.00 |    0.00 | 0.2613 | 0.0057 |     - |    6840 B |
|           MyStringBuilder | V2 - Append_Constructor | Lore(...)non. [3382] | 13,978.50 ns | 107.672 ns |  84.063 ns | 11.43 |    1.44 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lore(...)non. [3382] |  1,523.19 ns |  61.761 ns | 182.103 ns |  1.00 |    0.00 | 0.2632 | 0.0057 |     - |    6912 B |
|           MyStringBuilder |             V2 - Append | Lore(...)non. [3382] | 14,171.59 ns | 255.226 ns | 238.738 ns |  8.61 |    0.82 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lore(...)non. [3382] |  2,620.41 ns | 109.101 ns | 321.688 ns |  1.00 |    0.00 | 0.5226 | 0.0229 |     - |   13752 B |
|           MyStringBuilder |         V2 - AppendLine | Lore(...)non. [3382] | 14,021.18 ns | 194.492 ns | 181.928 ns |  5.66 |    0.62 | 0.5341 | 0.0153 |     - |   14144 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lore(...)non. [3382] |  3,956.32 ns | 188.172 ns | 554.831 ns |  1.00 |    0.00 | 0.7858 | 0.0305 |     - |   20544 B |
|           MyStringBuilder |           V2 - ToString | Lore(...)non. [3382] | 20,024.53 ns | 191.230 ns | 178.876 ns |  5.75 |    0.39 | 1.0376 | 0.0305 |     - |   27728 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lorem(...)uere. [71]** |     **75.52 ns** |   **1.538 ns** |   **2.693 ns** |  **1.00** |    **0.00** | **0.0082** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lorem(...)uere. [71] |    639.26 ns |  12.587 ns |  23.949 ns |  8.46 |    0.51 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lorem(...)uere. [71] |    131.03 ns |   1.490 ns |   1.321 ns |  1.00 |    0.00 | 0.0110 |      - |     - |     288 B |
|           MyStringBuilder |             V1 - Append | Lorem(...)uere. [71] |    659.70 ns |  10.800 ns |  13.659 ns |  5.03 |    0.11 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lorem(...)uere. [71] |    225.95 ns |   4.162 ns |   3.893 ns |  1.00 |    0.00 | 0.0191 |      - |     - |     504 B |
|           MyStringBuilder |         V1 - AppendLine | Lorem(...)uere. [71] |    662.21 ns |  13.283 ns |  13.045 ns |  2.93 |    0.08 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lorem(...)uere. [71] |    288.43 ns |   5.502 ns |   6.336 ns |  1.00 |    0.00 | 0.0253 |      - |     - |     672 B |
|           MyStringBuilder |           V1 - ToString | Lorem(...)uere. [71] |    804.91 ns |  16.062 ns |  30.168 ns |  2.80 |    0.13 | 0.0925 |      - |     - |    2432 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lorem(...)uere. [71] |     79.41 ns |   1.474 ns |   1.378 ns |  1.00 |    0.00 | 0.0082 |      - |     - |     216 B |
|           MyStringBuilder | V2 - Append_Constructor | Lorem(...)uere. [71] |    612.73 ns |  12.234 ns |  27.863 ns |  7.86 |    0.43 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lorem(...)uere. [71] |    127.12 ns |   2.581 ns |   4.972 ns |  1.00 |    0.00 | 0.0110 |      - |     - |     288 B |
|           MyStringBuilder |             V2 - Append | Lorem(...)uere. [71] |    621.13 ns |  12.451 ns |  34.295 ns |  4.92 |    0.29 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lorem(...)uere. [71] |    235.93 ns |   4.174 ns |   4.286 ns |  1.00 |    0.00 | 0.0191 |      - |     - |     504 B |
|           MyStringBuilder |         V2 - AppendLine | Lorem(...)uere. [71] |    623.15 ns |  12.402 ns |  31.568 ns |  2.72 |    0.13 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lorem(...)uere. [71] |    283.91 ns |   5.407 ns |   5.785 ns |  1.00 |    0.00 | 0.0253 |      - |     - |     672 B |
|           MyStringBuilder |           V2 - ToString | Lorem(...)uere. [71] |    779.98 ns |  15.366 ns |  28.860 ns |  2.78 |    0.12 | 0.0925 |      - |     - |    2432 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** | **Lore(...) ut. [6730]** |  **2,777.08 ns** |  **76.668 ns** | **226.058 ns** |  **1.00** |    **0.00** | **0.5150** | **0.0229** |     **-** |   **13536 B** |
|           MyStringBuilder | V1 - Append_Constructor | Lore(...) ut. [6730] | 28,686.26 ns | 402.597 ns | 376.590 ns | 10.22 |    1.04 | 1.1292 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append | Lore(...) ut. [6730] |  3,268.07 ns |  65.199 ns | 187.067 ns |  1.00 |    0.00 | 0.5188 | 0.0229 |     - |   13608 B |
|           MyStringBuilder |             V1 - Append | Lore(...) ut. [6730] | 28,928.85 ns | 553.009 ns | 614.668 ns |  9.10 |    0.42 | 1.1292 | 0.0916 |     - |   30168 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine | Lore(...) ut. [6730] |  4,641.62 ns | 204.386 ns | 599.429 ns |  1.00 |    0.00 | 1.0300 | 0.0916 |     - |   27144 B |
|           MyStringBuilder |         V1 - AppendLine | Lore(...) ut. [6730] | 28,497.25 ns | 257.881 ns | 228.605 ns |  6.14 |    0.47 | 1.1292 | 0.0916 |     - |   30168 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString | Lore(...) ut. [6730] |  6,732.97 ns | 185.691 ns | 538.722 ns |  1.00 |    0.00 | 1.5488 | 0.1373 |     - |   40632 B |
|           MyStringBuilder |           V1 - ToString | Lore(...) ut. [6730] | 40,319.49 ns | 546.198 ns | 456.100 ns |  6.10 |    0.43 | 2.1362 | 0.1221 |     - |   57144 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor | Lore(...) ut. [6730] |  2,901.84 ns |  90.456 ns | 266.711 ns |  1.00 |    0.00 | 0.5150 | 0.0229 |     - |   13536 B |
|           MyStringBuilder | V2 - Append_Constructor | Lore(...) ut. [6730] | 28,520.06 ns | 140.016 ns | 124.120 ns | 10.73 |    1.09 | 1.1292 | 0.0916 |     - |   30168 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append | Lore(...) ut. [6730] |  2,583.36 ns |  75.504 ns | 217.845 ns |  1.00 |    0.00 | 0.5188 | 0.0229 |     - |   13608 B |
|           MyStringBuilder |             V2 - Append | Lore(...) ut. [6730] | 28,213.84 ns | 221.398 ns | 196.263 ns | 10.89 |    0.81 | 1.1292 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine | Lore(...) ut. [6730] |  4,194.75 ns | 190.591 ns | 555.962 ns |  1.00 |    0.00 | 1.0338 | 0.0916 |     - |   27144 B |
|           MyStringBuilder |         V2 - AppendLine | Lore(...) ut. [6730] | 28,812.16 ns | 433.102 ns | 383.933 ns |  7.90 |    0.54 | 1.1292 | 0.0610 |     - |   30168 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString | Lore(...) ut. [6730] |  6,718.05 ns | 221.922 ns | 654.342 ns |  1.00 |    0.00 | 1.5488 | 0.1373 |     - |   40632 B |
|           MyStringBuilder |           V2 - ToString | Lore(...) ut. [6730] | 40,169.09 ns | 609.581 ns | 570.202 ns |  5.81 |    0.60 | 2.1362 | 0.1221 |     - |   57144 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** |  **Lore(...)lus. [659]** |    **281.97 ns** |   **9.071 ns** |  **26.317 ns** |  **1.00** |    **0.00** | **0.0529** |      **-** |     **-** |    **1392 B** |
|           MyStringBuilder | V1 - Append_Constructor |  Lore(...)lus. [659] |  2,070.03 ns |  19.708 ns |  16.457 ns |  7.29 |    0.65 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append |  Lore(...)lus. [659] |    356.19 ns |  13.429 ns |  39.594 ns |  1.00 |    0.00 | 0.0558 |      - |     - |    1464 B |
|           MyStringBuilder |             V1 - Append |  Lore(...)lus. [659] |  2,068.35 ns |   7.817 ns |   6.103 ns |  6.70 |    0.56 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine |  Lore(...)lus. [659] |    641.08 ns |  24.585 ns |  72.103 ns |  1.00 |    0.00 | 0.1087 | 0.0010 |     - |    2856 B |
|           MyStringBuilder |         V1 - AppendLine |  Lore(...)lus. [659] |  2,119.00 ns |  40.033 ns |  37.447 ns |  3.27 |    0.26 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString |  Lore(...)lus. [659] |    901.97 ns |  29.837 ns |  87.976 ns |  1.00 |    0.00 | 0.1602 | 0.0010 |     - |    4200 B |
|           MyStringBuilder |           V1 - ToString |  Lore(...)lus. [659] |  3,315.01 ns |  43.912 ns |  41.076 ns |  3.50 |    0.29 | 0.1793 |      - |     - |    4784 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor |  Lore(...)lus. [659] |    316.84 ns |  10.772 ns |  31.761 ns |  1.00 |    0.00 | 0.0529 |      - |     - |    1392 B |
|           MyStringBuilder | V2 - Append_Constructor |  Lore(...)lus. [659] |  2,089.61 ns |  23.592 ns |  18.419 ns |  7.05 |    0.70 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append |  Lore(...)lus. [659] |    362.31 ns |   9.478 ns |  27.945 ns |  1.00 |    0.00 | 0.0558 |      - |     - |    1464 B |
|           MyStringBuilder |             V2 - Append |  Lore(...)lus. [659] |  2,069.17 ns |  19.310 ns |  17.118 ns |  5.51 |    0.28 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine |  Lore(...)lus. [659] |    618.73 ns |  16.765 ns |  48.639 ns |  1.00 |    0.00 | 0.1087 | 0.0010 |     - |    2856 B |
|           MyStringBuilder |         V2 - AppendLine |  Lore(...)lus. [659] |  2,083.10 ns |  21.134 ns |  18.735 ns |  3.52 |    0.32 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString |  Lore(...)lus. [659] |    982.62 ns |  25.363 ns |  74.384 ns |  1.00 |    0.00 | 0.1602 |      - |     - |    4200 B |
|           MyStringBuilder |           V2 - ToString |  Lore(...)lus. [659] |  3,355.14 ns |  42.799 ns |  37.940 ns |  3.42 |    0.24 | 0.1793 |      - |     - |    4784 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **V1 - Append_Constructor** |  **orem(...)ros. [310]** |    **182.80 ns** |   **4.095 ns** |  **12.074 ns** |  **1.00** |    **0.00** | **0.0265** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | V1 - Append_Constructor |  orem(...)ros. [310] |  1,242.69 ns |  10.326 ns |   9.154 ns |  7.05 |    0.56 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V1 - Append |  orem(...)ros. [310] |    222.68 ns |   4.580 ns |  13.360 ns |  1.00 |    0.00 | 0.0293 |      - |     - |     768 B |
|           MyStringBuilder |             V1 - Append |  orem(...)ros. [310] |  1,224.84 ns |  11.329 ns |  10.043 ns |  5.48 |    0.37 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V1 - AppendLine |  orem(...)ros. [310] |    399.68 ns |   8.103 ns |  23.893 ns |  1.00 |    0.00 | 0.0558 |      - |     - |    1464 B |
|           MyStringBuilder |         V1 - AppendLine |  orem(...)ros. [310] |  1,298.24 ns |  25.539 ns |  30.403 ns |  3.32 |    0.20 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V1 - ToString |  orem(...)ros. [310] |    605.21 ns |  13.598 ns |  40.093 ns |  1.00 |    0.00 | 0.0801 |      - |     - |    2112 B |
|           MyStringBuilder |           V1 - ToString |  orem(...)ros. [310] |  1,863.25 ns |  28.293 ns |  26.465 ns |  2.92 |    0.07 | 0.1297 |      - |     - |    3392 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder | V2 - Append_Constructor |  orem(...)ros. [310] |    186.63 ns |   5.621 ns |  16.574 ns |  1.00 |    0.00 | 0.0265 |      - |     - |     696 B |
|           MyStringBuilder | V2 - Append_Constructor |  orem(...)ros. [310] |  1,255.71 ns |  23.238 ns |  21.737 ns |  6.68 |    0.38 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             V2 - Append |  orem(...)ros. [310] |    243.37 ns |   4.911 ns |   9.808 ns |  1.00 |    0.00 | 0.0293 |      - |     - |     768 B |
|           MyStringBuilder |             V2 - Append |  orem(...)ros. [310] |  1,255.50 ns |  17.294 ns |  15.331 ns |  5.22 |    0.18 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         V2 - AppendLine |  orem(...)ros. [310] |    422.58 ns |   8.490 ns |  20.013 ns |  1.00 |    0.00 | 0.0558 |      - |     - |    1464 B |
|           MyStringBuilder |         V2 - AppendLine |  orem(...)ros. [310] |  1,260.92 ns |  16.026 ns |  13.382 ns |  2.95 |    0.11 | 0.0801 |      - |     - |    2096 B |
|                           |                         |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           V2 - ToString |  orem(...)ros. [310] |    565.10 ns |  20.641 ns |  60.861 ns |  1.00 |    0.00 | 0.0801 |      - |     - |    2112 B |
|           MyStringBuilder |           V2 - ToString |  orem(...)ros. [310] |  1,908.51 ns |  34.096 ns |  30.225 ns |  3.10 |    0.22 | 0.1297 |      - |     - |    3392 B |
