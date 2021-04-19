``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.408
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                    Method |         Categories |                 data |         Mean |        Error |       StdDev |       Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------- |--------------------- |-------------:|-------------:|-------------:|-------------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...)non. [3382]** |  **1,332.66 ns** |    **26.475 ns** |    **56.991 ns** |  **1,324.13 ns** |  **1.00** |    **0.00** | **0.3643** | **0.0076** |     **-** |    **6840 B** |
|           MyStringBuilder | Append_Constructor | Lore(...)non. [3382] | 18,763.65 ns |    18.835 ns |    17.619 ns | 18,765.55 ns | 13.56 |    0.53 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...)non. [3382] |  1,473.19 ns |    10.952 ns |    10.245 ns |  1,476.41 ns |  1.00 |    0.00 | 0.3681 | 0.0076 |     - |    6912 B |
|           MyStringBuilder |             Append | Lore(...)non. [3382] | 18,610.37 ns |    40.518 ns |    35.918 ns | 18,607.84 ns | 12.62 |    0.08 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...)non. [3382] |  2,637.25 ns |    48.012 ns |    44.910 ns |  2,635.63 ns |  1.00 |    0.00 | 0.7324 | 0.0343 |     - |   13752 B |
|           MyStringBuilder |         AppendLine | Lore(...)non. [3382] | 18,653.60 ns |    30.366 ns |    28.404 ns | 18,653.56 ns |  7.08 |    0.12 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...)non. [3382] |  3,988.55 ns |    60.088 ns |    56.206 ns |  3,993.79 ns |  1.00 |    0.00 | 1.0986 | 0.0458 |     - |   20544 B |
|           MyStringBuilder |           ToString | Lore(...)non. [3382] | 26,739.62 ns |   124.726 ns |   116.669 ns | 26,725.23 ns |  6.71 |    0.09 | 1.4648 | 0.0305 |     - |   27728 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lorem(...)uere. [71]** |     **69.56 ns** |     **0.852 ns** |     **0.797 ns** |     **69.79 ns** |  **1.00** |    **0.00** | **0.0114** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | Append_Constructor | Lorem(...)uere. [71] |    607.39 ns |    11.801 ns |    12.119 ns |    607.31 ns |  8.72 |    0.24 | 0.1116 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lorem(...)uere. [71] |    127.43 ns |     1.039 ns |     0.972 ns |    127.33 ns |  1.00 |    0.00 | 0.0153 |      - |     - |     288 B |
|           MyStringBuilder |             Append | Lorem(...)uere. [71] |    614.05 ns |    11.710 ns |    10.954 ns |    613.31 ns |  4.82 |    0.08 | 0.1116 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lorem(...)uere. [71] |    211.78 ns |     1.625 ns |     1.520 ns |    211.87 ns |  1.00 |    0.00 | 0.0269 |      - |     - |     504 B |
|           MyStringBuilder |         AppendLine | Lorem(...)uere. [71] |    603.07 ns |     9.578 ns |     8.959 ns |    600.46 ns |  2.85 |    0.05 | 0.1116 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lorem(...)uere. [71] |    279.26 ns |     2.416 ns |     2.142 ns |    279.98 ns |  1.00 |    0.00 | 0.0358 |      - |     - |     672 B |
|           MyStringBuilder |           ToString | Lorem(...)uere. [71] |    784.59 ns |    13.587 ns |    18.599 ns |    781.83 ns |  2.82 |    0.09 | 0.1297 | 0.0010 |     - |    2432 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...) ut. [6730]** |  **2,546.61 ns** |    **50.854 ns** |   **107.268 ns** |  **2,544.89 ns** |  **1.00** |    **0.00** | **0.7210** | **0.0305** |     **-** |   **13536 B** |
|           MyStringBuilder | Append_Constructor | Lore(...) ut. [6730] | 39,231.77 ns |    54.310 ns |    50.802 ns | 39,228.47 ns | 15.37 |    0.73 | 1.5869 | 0.0610 |     - |   30169 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...) ut. [6730] |  2,841.08 ns |    32.262 ns |    30.178 ns |  2,847.75 ns |  1.00 |    0.00 | 0.7248 | 0.0343 |     - |   13608 B |
|           MyStringBuilder |             Append | Lore(...) ut. [6730] | 39,124.04 ns |    81.670 ns |    76.394 ns | 39,133.09 ns | 13.77 |    0.15 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...) ut. [6730] |  4,868.60 ns |    97.058 ns |   206.839 ns |  4,824.74 ns |  1.00 |    0.00 | 1.4496 | 0.1297 |     - |   27144 B |
|           MyStringBuilder |         AppendLine | Lore(...) ut. [6730] | 38,965.24 ns |   230.721 ns |   215.817 ns | 39,010.54 ns |  7.86 |    0.29 | 1.5869 | 0.0610 |     - |   30169 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...) ut. [6730] |  6,760.61 ns |   126.845 ns |   124.578 ns |  6,780.28 ns |  1.00 |    0.00 | 2.1667 | 0.1755 |     - |   40632 B |
|           MyStringBuilder |           ToString | Lore(...) ut. [6730] | 56,440.45 ns | 1,117.567 ns | 1,491.919 ns | 55,484.66 ns |  8.43 |    0.17 | 3.0518 | 0.1831 |     - |   57144 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **Lore(...)lus. [659]** |    **318.95 ns** |     **6.324 ns** |    **10.390 ns** |    **319.07 ns** |  **1.00** |    **0.00** | **0.0744** |      **-** |     **-** |    **1392 B** |
|           MyStringBuilder | Append_Constructor |  Lore(...)lus. [659] |  2,383.13 ns |     9.693 ns |     9.067 ns |  2,383.81 ns |  7.41 |    0.24 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  Lore(...)lus. [659] |    376.24 ns |     7.453 ns |     7.974 ns |    375.67 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |             Append |  Lore(...)lus. [659] |  2,418.87 ns |    18.890 ns |    15.774 ns |  2,423.21 ns |  6.44 |    0.16 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  Lore(...)lus. [659] |    672.37 ns |    12.917 ns |    12.686 ns |    670.16 ns |  1.00 |    0.00 | 0.1526 | 0.0010 |     - |    2856 B |
|           MyStringBuilder |         AppendLine |  Lore(...)lus. [659] |  2,353.56 ns |     9.385 ns |     8.779 ns |  2,354.90 ns |  3.50 |    0.07 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  Lore(...)lus. [659] |    951.49 ns |     9.938 ns |     9.296 ns |    951.53 ns |  1.00 |    0.00 | 0.2241 | 0.0019 |     - |    4200 B |
|           MyStringBuilder |           ToString |  Lore(...)lus. [659] |  3,502.47 ns |    13.375 ns |    12.511 ns |  3,504.86 ns |  3.68 |    0.04 | 0.2556 |      - |     - |    4784 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **orem(...)ros. [310]** |    **159.57 ns** |     **2.105 ns** |     **1.866 ns** |    **159.93 ns** |  **1.00** |    **0.00** | **0.0372** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | Append_Constructor |  orem(...)ros. [310] |  1,331.49 ns |     3.641 ns |     3.040 ns |  1,332.30 ns |  8.35 |    0.10 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  orem(...)ros. [310] |    224.43 ns |     1.341 ns |     1.254 ns |    224.13 ns |  1.00 |    0.00 | 0.0410 |      - |     - |     768 B |
|           MyStringBuilder |             Append |  orem(...)ros. [310] |  1,340.10 ns |     4.320 ns |     3.830 ns |  1,340.49 ns |  5.97 |    0.03 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  orem(...)ros. [310] |    402.80 ns |     4.435 ns |     4.149 ns |    401.20 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |         AppendLine |  orem(...)ros. [310] |  1,355.71 ns |     4.615 ns |     4.317 ns |  1,356.48 ns |  3.37 |    0.04 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |              |              |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  orem(...)ros. [310] |    550.67 ns |     7.476 ns |     6.993 ns |    550.60 ns |  1.00 |    0.00 | 0.1125 |      - |     - |    2112 B |
|           MyStringBuilder |           ToString |  orem(...)ros. [310] |  2,046.44 ns |    34.064 ns |    31.863 ns |  2,040.31 ns |  3.72 |    0.09 | 0.1793 |      - |     - |    3392 B |
