``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                    Method |         Categories |                 data |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------- |--------------------- |-------------:|-----------:|-----------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...)non. [3382]** |    **780.96 ns** |  **15.660 ns** |  **24.381 ns** |  **1.00** |    **0.00** | **0.3653** | **0.0086** |     **-** |    **6840 B** |
|           MyStringBuilder | Append_Constructor | Lore(...)non. [3382] | 18,313.72 ns | 107.025 ns | 100.111 ns | 23.78 |    0.87 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...)non. [3382] |    810.57 ns |  16.185 ns |  33.424 ns |  1.00 |    0.00 | 0.3691 | 0.0086 |     - |    6912 B |
|           MyStringBuilder |             Append | Lore(...)non. [3382] | 18,401.90 ns | 111.191 ns | 104.008 ns | 22.50 |    0.98 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...)non. [3382] |  1,427.86 ns |  28.570 ns |  56.394 ns |  1.00 |    0.00 | 0.7343 | 0.0343 |     - |   13752 B |
|           MyStringBuilder |         AppendLine | Lore(...)non. [3382] | 18,225.36 ns | 103.624 ns |  96.930 ns | 13.02 |    0.38 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...)non. [3382] |  2,403.83 ns |  47.817 ns | 113.643 ns |  1.00 |    0.00 | 1.0986 | 0.0496 |     - |   20544 B |
|           MyStringBuilder |           ToString | Lore(...)non. [3382] | 23,083.12 ns | 407.064 ns | 380.768 ns |  9.54 |    0.51 | 1.4648 | 0.0305 |     - |   27728 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lorem(...)uere. [71]** |     **54.25 ns** |   **1.122 ns** |   **2.555 ns** |  **1.00** |    **0.00** | **0.0114** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | Append_Constructor | Lorem(...)uere. [71] |    463.25 ns |   9.236 ns |  22.306 ns |  8.55 |    0.63 | 0.1116 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lorem(...)uere. [71] |    111.70 ns |   1.892 ns |   2.103 ns |  1.00 |    0.00 | 0.0154 |      - |     - |     288 B |
|           MyStringBuilder |             Append | Lorem(...)uere. [71] |    433.15 ns |   8.675 ns |  17.325 ns |  3.93 |    0.14 | 0.1121 | 0.0005 |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lorem(...)uere. [71] |    187.75 ns |   3.762 ns |   5.395 ns |  1.00 |    0.00 | 0.0269 |      - |     - |     504 B |
|           MyStringBuilder |         AppendLine | Lorem(...)uere. [71] |    467.60 ns |   9.288 ns |  16.748 ns |  2.49 |    0.13 | 0.1121 | 0.0005 |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lorem(...)uere. [71] |    246.19 ns |   4.832 ns |   4.962 ns |  1.00 |    0.00 | 0.0358 |      - |     - |     672 B |
|           MyStringBuilder |           ToString | Lorem(...)uere. [71] |    618.51 ns |  11.783 ns |  28.232 ns |  2.47 |    0.09 | 0.1297 | 0.0010 |     - |    2432 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...) ut. [6730]** |  **1,675.38 ns** |  **33.034 ns** |  **68.221 ns** |  **1.00** |    **0.00** | **0.7229** | **0.0343** |     **-** |   **13536 B** |
|           MyStringBuilder | Append_Constructor | Lore(...) ut. [6730] | 38,331.37 ns | 413.575 ns | 386.858 ns | 22.89 |    1.16 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...) ut. [6730] |  1,715.12 ns |  33.465 ns |  58.610 ns |  1.00 |    0.00 | 0.7267 | 0.0343 |     - |   13608 B |
|           MyStringBuilder |             Append | Lore(...) ut. [6730] | 38,258.89 ns | 381.051 ns | 356.436 ns | 22.49 |    0.92 | 1.5869 | 0.0610 |     - |   30169 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...) ut. [6730] |  2,835.00 ns |  56.189 ns | 112.216 ns |  1.00 |    0.00 | 1.4496 | 0.1297 |     - |   27144 B |
|           MyStringBuilder |         AppendLine | Lore(...) ut. [6730] | 37,954.23 ns | 368.033 ns | 344.259 ns | 13.52 |    0.53 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...) ut. [6730] |  4,903.16 ns |  95.018 ns | 126.846 ns |  1.00 |    0.00 | 2.1667 | 0.1755 |     - |   40632 B |
|           MyStringBuilder |           ToString | Lore(...) ut. [6730] | 47,099.76 ns | 477.946 ns | 423.687 ns |  9.67 |    0.29 | 3.0518 | 0.1831 |     - |   57145 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **Lore(...)lus. [659]** |    **198.62 ns** |   **4.014 ns** |   **9.303 ns** |  **1.00** |    **0.00** | **0.0744** | **0.0002** |     **-** |    **1392 B** |
|           MyStringBuilder | Append_Constructor |  Lore(...)lus. [659] |  2,348.01 ns |  22.948 ns |  21.466 ns | 11.94 |    0.41 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  Lore(...)lus. [659] |    253.29 ns |   4.901 ns |   9.675 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |             Append |  Lore(...)lus. [659] |  2,397.35 ns |  37.205 ns |  34.802 ns |  9.48 |    0.39 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  Lore(...)lus. [659] |    468.90 ns |   9.373 ns |  26.129 ns |  1.00 |    0.00 | 0.1526 | 0.0014 |     - |    2856 B |
|           MyStringBuilder |         AppendLine |  Lore(...)lus. [659] |  2,363.00 ns |  12.544 ns |  11.120 ns |  5.23 |    0.29 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  Lore(...)lus. [659] |    646.65 ns |  12.788 ns |  25.242 ns |  1.00 |    0.00 | 0.2241 | 0.0019 |     - |    4200 B |
|           MyStringBuilder |           ToString |  Lore(...)lus. [659] |  3,402.44 ns |  31.158 ns |  27.621 ns |  5.33 |    0.23 | 0.2556 |      - |     - |    4784 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **orem(...)ros. [310]** |    **110.17 ns** |   **2.229 ns** |   **4.451 ns** |  **1.00** |    **0.00** | **0.0372** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | Append_Constructor |  orem(...)ros. [310] |  1,261.20 ns |  17.083 ns |  15.979 ns | 11.60 |    0.58 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  orem(...)ros. [310] |    157.75 ns |   3.363 ns |   9.915 ns |  1.00 |    0.00 | 0.0410 |      - |     - |     768 B |
|           MyStringBuilder |             Append |  orem(...)ros. [310] |  1,291.08 ns |  18.177 ns |  17.003 ns |  7.61 |    0.40 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  orem(...)ros. [310] |    283.75 ns |   5.682 ns |  16.119 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |         AppendLine |  orem(...)ros. [310] |  1,246.89 ns |  16.890 ns |  14.973 ns |  4.49 |    0.24 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  orem(...)ros. [310] |    393.04 ns |   7.818 ns |  15.433 ns |  1.00 |    0.00 | 0.1125 |      - |     - |    2112 B |
|           MyStringBuilder |           ToString |  orem(...)ros. [310] |  1,778.30 ns |  27.606 ns |  25.823 ns |  4.56 |    0.10 | 0.1812 |      - |     - |    3392 B |
