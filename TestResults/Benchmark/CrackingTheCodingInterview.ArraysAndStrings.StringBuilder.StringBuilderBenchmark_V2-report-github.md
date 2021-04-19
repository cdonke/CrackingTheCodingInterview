``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=3.1.408
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                    Method |         Categories |                 data |        Mean |      Error |     StdDev |      Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------- |--------------------- |------------:|-----------:|-----------:|------------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...)non. [3382]** | **1,276.07 ns** |  **24.591 ns** |  **29.274 ns** | **1,270.45 ns** |  **1.00** |    **0.00** | **0.3643** | **0.0076** |     **-** |    **6840 B** |
|           MyStringBuilder | Append_Constructor | Lore(...)non. [3382] | 1,818.39 ns |  32.809 ns |  30.690 ns | 1,813.33 ns |  1.42 |    0.03 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...)non. [3382] | 1,367.78 ns |  25.989 ns |  40.462 ns | 1,361.68 ns |  1.00 |    0.00 | 0.3681 | 0.0076 |     - |    6912 B |
|           MyStringBuilder |             Append | Lore(...)non. [3382] | 1,849.14 ns |  32.065 ns |  35.640 ns | 1,846.08 ns |  1.35 |    0.04 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...)non. [3382] | 2,553.10 ns |  50.668 ns |  81.819 ns | 2,568.55 ns |  1.00 |    0.00 | 0.7324 | 0.0343 |     - |   13752 B |
|           MyStringBuilder |         AppendLine | Lore(...)non. [3382] | 1,998.37 ns |  30.950 ns |  28.950 ns | 1,995.79 ns |  0.80 |    0.03 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...)non. [3382] | 4,079.95 ns |  81.572 ns |  90.667 ns | 4,076.86 ns |  1.00 |    0.00 | 1.0986 | 0.0458 |     - |   20544 B |
|           MyStringBuilder |           ToString | Lore(...)non. [3382] | 4,693.64 ns |  91.013 ns | 115.103 ns | 4,701.25 ns |  1.15 |    0.04 | 1.2589 | 0.0381 |     - |   23672 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lorem(...)uere. [71]** |    **71.28 ns** |   **0.472 ns** |   **0.394 ns** |    **71.30 ns** |  **1.00** |    **0.00** | **0.0114** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | Append_Constructor | Lorem(...)uere. [71] |   396.14 ns |   5.014 ns |   4.691 ns |   397.16 ns |  5.55 |    0.07 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lorem(...)uere. [71] |   129.21 ns |   0.349 ns |   0.291 ns |   129.27 ns |  1.00 |    0.00 | 0.0153 |      - |     - |     288 B |
|           MyStringBuilder |             Append | Lorem(...)uere. [71] |   406.34 ns |   7.947 ns |  11.895 ns |   410.38 ns |  3.10 |    0.11 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lorem(...)uere. [71] |   212.15 ns |   3.167 ns |   2.962 ns |   212.53 ns |  1.00 |    0.00 | 0.0269 |      - |     - |     504 B |
|           MyStringBuilder |         AppendLine | Lorem(...)uere. [71] |   398.91 ns |   7.997 ns |  20.786 ns |   399.67 ns |  1.83 |    0.08 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lorem(...)uere. [71] |   283.50 ns |   2.806 ns |   2.624 ns |   284.59 ns |  1.00 |    0.00 | 0.0358 |      - |     - |     672 B |
|           MyStringBuilder |           ToString | Lorem(...)uere. [71] |   508.01 ns |  10.069 ns |   9.889 ns |   506.97 ns |  1.79 |    0.04 | 0.1278 | 0.0010 |     - |    2400 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...) ut. [6730]** | **1,725.44 ns** |  **34.336 ns** |  **80.934 ns** | **1,721.19 ns** |  **1.00** |    **0.00** | **0.7229** | **0.0343** |     **-** |   **13536 B** |
|           MyStringBuilder | Append_Constructor | Lore(...) ut. [6730] | 2,143.54 ns |  42.291 ns |  56.457 ns | 2,142.02 ns |  1.26 |    0.07 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...) ut. [6730] | 1,771.40 ns |  34.696 ns |  57.006 ns | 1,768.04 ns |  1.00 |    0.00 | 0.7267 | 0.0343 |     - |   13608 B |
|           MyStringBuilder |             Append | Lore(...) ut. [6730] | 2,281.31 ns |  45.344 ns |  96.632 ns | 2,283.82 ns |  1.28 |    0.06 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...) ut. [6730] | 2,990.37 ns |  59.624 ns | 161.196 ns | 2,975.06 ns |  1.00 |    0.00 | 1.4496 | 0.1297 |     - |   27144 B |
|           MyStringBuilder |         AppendLine | Lore(...) ut. [6730] | 2,124.04 ns |  44.298 ns | 127.099 ns | 2,086.49 ns |  0.71 |    0.05 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...) ut. [6730] | 5,002.13 ns |  99.930 ns | 122.723 ns | 4,956.11 ns |  1.00 |    0.00 | 2.1667 | 0.1755 |     - |   40632 B |
|           MyStringBuilder |           ToString | Lore(...) ut. [6730] | 5,810.13 ns | 114.264 ns | 101.292 ns | 5,818.76 ns |  1.16 |    0.03 | 2.4033 | 0.1297 |     - |   45064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **Lore(...)lus. [659]** |   **212.04 ns** |   **4.260 ns** |  **11.589 ns** |   **210.15 ns** |  **1.00** |    **0.00** | **0.0744** | **0.0002** |     **-** |    **1392 B** |
|           MyStringBuilder | Append_Constructor |  Lore(...)lus. [659] |   272.77 ns |   5.498 ns |  11.952 ns |   272.68 ns |  1.27 |    0.10 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  Lore(...)lus. [659] |   254.29 ns |   4.978 ns |  11.134 ns |   254.33 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |             Append |  Lore(...)lus. [659] |   283.00 ns |   7.137 ns |  20.820 ns |   275.52 ns |  1.15 |    0.09 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  Lore(...)lus. [659] |   424.11 ns |   8.074 ns |   7.929 ns |   424.50 ns |  1.00 |    0.00 | 0.1526 | 0.0014 |     - |    2856 B |
|           MyStringBuilder |         AppendLine |  Lore(...)lus. [659] |   290.71 ns |   5.789 ns |  11.561 ns |   288.89 ns |  0.69 |    0.03 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  Lore(...)lus. [659] |   629.80 ns |  12.490 ns |  17.912 ns |   632.49 ns |  1.00 |    0.00 | 0.2241 | 0.0019 |     - |    4200 B |
|           MyStringBuilder |           ToString |  Lore(...)lus. [659] |   641.38 ns |  12.841 ns |  27.087 ns |   635.59 ns |  1.02 |    0.05 | 0.2537 | 0.0010 |     - |    4752 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **orem(...)ros. [310]** |   **110.65 ns** |   **3.130 ns** |   **9.081 ns** |   **110.74 ns** |  **1.00** |    **0.00** | **0.0372** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | Append_Constructor |  orem(...)ros. [310] |   252.25 ns |   6.817 ns |  19.778 ns |   251.31 ns |  2.30 |    0.28 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  orem(...)ros. [310] |   197.79 ns |   3.908 ns |   3.464 ns |   198.52 ns |  1.00 |    0.00 | 0.0410 |      - |     - |     768 B |
|           MyStringBuilder |             Append |  orem(...)ros. [310] |   264.09 ns |   5.324 ns |  12.654 ns |   261.49 ns |  1.38 |    0.08 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  orem(...)ros. [310] |   304.11 ns |   6.077 ns |  12.684 ns |   302.09 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |         AppendLine |  orem(...)ros. [310] |   283.65 ns |   5.632 ns |   9.564 ns |   283.99 ns |  0.94 |    0.05 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |            |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  orem(...)ros. [310] |   427.37 ns |   8.537 ns |   9.832 ns |   427.54 ns |  1.00 |    0.00 | 0.1125 | 0.0005 |     - |    2112 B |
|           MyStringBuilder |           ToString |  orem(...)ros. [310] |   506.32 ns |  10.126 ns |  25.589 ns |   503.01 ns |  1.20 |    0.05 | 0.1793 | 0.0010 |     - |    3360 B |
