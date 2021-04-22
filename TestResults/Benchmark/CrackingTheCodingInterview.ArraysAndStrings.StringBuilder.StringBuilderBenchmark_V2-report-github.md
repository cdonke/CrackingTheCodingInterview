``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  DefaultJob : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT


```
|                    Method |         Categories |                 data |        Mean |     Error |     StdDev |      Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------- |--------------------- |------------:|----------:|-----------:|------------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...)non. [3382]** |   **765.58 ns** | **15.331 ns** |  **31.660 ns** |   **764.90 ns** |  **1.00** |    **0.00** | **0.3653** | **0.0086** |     **-** |    **6840 B** |
|           MyStringBuilder | Append_Constructor | Lore(...)non. [3382] | 1,070.88 ns | 21.073 ns |  43.520 ns | 1,063.85 ns |  1.40 |    0.07 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...)non. [3382] |   851.53 ns | 17.017 ns |  44.831 ns |   846.34 ns |  1.00 |    0.00 | 0.3691 | 0.0086 |     - |    6912 B |
|           MyStringBuilder |             Append | Lore(...)non. [3382] | 1,102.49 ns | 21.730 ns |  42.894 ns | 1,095.67 ns |  1.29 |    0.08 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...)non. [3382] | 1,440.05 ns | 27.499 ns |  25.723 ns | 1,442.99 ns |  1.00 |    0.00 | 0.7343 | 0.0343 |     - |   13752 B |
|           MyStringBuilder |         AppendLine | Lore(...)non. [3382] | 1,095.92 ns | 21.895 ns |  55.331 ns | 1,083.12 ns |  0.77 |    0.04 | 0.5379 | 0.0191 |     - |   10088 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...)non. [3382] | 2,401.61 ns | 47.748 ns |  90.845 ns | 2,400.92 ns |  1.00 |    0.00 | 1.0986 | 0.0496 |     - |   20544 B |
|           MyStringBuilder |           ToString | Lore(...)non. [3382] | 2,720.02 ns | 51.825 ns | 102.297 ns | 2,709.46 ns |  1.14 |    0.06 | 1.2627 | 0.0381 |     - |   23672 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lorem(...)uere. [71]** |    **55.07 ns** |  **1.142 ns** |   **1.909 ns** |    **54.57 ns** |  **1.00** |    **0.00** | **0.0115** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | Append_Constructor | Lorem(...)uere. [71] |   209.41 ns |  4.187 ns |   7.222 ns |   209.97 ns |  3.81 |    0.21 | 0.1104 | 0.0007 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lorem(...)uere. [71] |   112.65 ns |  2.153 ns |   2.014 ns |   112.87 ns |  1.00 |    0.00 | 0.0153 |      - |     - |     288 B |
|           MyStringBuilder |             Append | Lorem(...)uere. [71] |   225.38 ns |  4.545 ns |   7.076 ns |   223.66 ns |  2.03 |    0.07 | 0.1104 | 0.0007 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lorem(...)uere. [71] |   190.08 ns |  3.775 ns |   4.196 ns |   189.85 ns |  1.00 |    0.00 | 0.0269 |      - |     - |     504 B |
|           MyStringBuilder |         AppendLine | Lorem(...)uere. [71] |   245.90 ns |  4.920 ns |   7.660 ns |   246.48 ns |  1.30 |    0.05 | 0.1104 | 0.0007 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lorem(...)uere. [71] |   251.19 ns |  4.997 ns |   8.751 ns |   249.73 ns |  1.00 |    0.00 | 0.0358 |      - |     - |     672 B |
|           MyStringBuilder |           ToString | Lorem(...)uere. [71] |   323.98 ns |  6.382 ns |   8.071 ns |   322.33 ns |  1.30 |    0.06 | 0.1283 | 0.0010 |     - |    2400 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...) ut. [6730]** | **1,444.53 ns** | **28.781 ns** |  **54.057 ns** | **1,428.95 ns** |  **1.00** |    **0.00** | **0.7229** | **0.0343** |     **-** |   **13536 B** |
|           MyStringBuilder | Append_Constructor | Lore(...) ut. [6730] | 2,059.92 ns | 38.751 ns |  84.242 ns | 2,046.04 ns |  1.43 |    0.07 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...) ut. [6730] | 1,749.87 ns | 32.103 ns |  48.050 ns | 1,745.05 ns |  1.00 |    0.00 | 0.7267 | 0.0343 |     - |   13608 B |
|           MyStringBuilder |             Append | Lore(...) ut. [6730] | 2,105.76 ns | 41.687 ns |  88.839 ns | 2,077.58 ns |  1.20 |    0.06 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...) ut. [6730] | 2,764.57 ns | 52.147 ns |  78.051 ns | 2,766.19 ns |  1.00 |    0.00 | 1.4496 | 0.1297 |     - |   27144 B |
|           MyStringBuilder |         AppendLine | Lore(...) ut. [6730] | 2,141.30 ns | 41.453 ns | 118.268 ns | 2,110.73 ns |  0.77 |    0.04 | 0.9651 | 0.0572 |     - |   18088 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...) ut. [6730] | 4,921.22 ns | 94.806 ns | 116.430 ns | 4,953.38 ns |  1.00 |    0.00 | 2.1667 | 0.1755 |     - |   40632 B |
|           MyStringBuilder |           ToString | Lore(...) ut. [6730] | 5,742.84 ns | 85.303 ns |  94.814 ns | 5,713.98 ns |  1.17 |    0.03 | 2.4033 | 0.1297 |     - |   45064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **Lore(...)lus. [659]** |   **192.46 ns** |  **3.438 ns** |   **2.871 ns** |   **191.71 ns** |  **1.00** |    **0.00** | **0.0744** | **0.0002** |     **-** |    **1392 B** |
|           MyStringBuilder | Append_Constructor |  Lore(...)lus. [659] |   263.56 ns |  5.221 ns |  14.554 ns |   259.75 ns |  1.39 |    0.07 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  Lore(...)lus. [659] |   245.30 ns |  4.952 ns |   7.563 ns |   245.43 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |             Append |  Lore(...)lus. [659] |   263.57 ns |  5.200 ns |   4.342 ns |   263.97 ns |  1.06 |    0.05 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  Lore(...)lus. [659] |   427.16 ns |  8.539 ns |  17.054 ns |   426.89 ns |  1.00 |    0.00 | 0.1526 | 0.0014 |     - |    2856 B |
|           MyStringBuilder |         AppendLine |  Lore(...)lus. [659] |   297.63 ns |  5.968 ns |  13.832 ns |   294.48 ns |  0.70 |    0.05 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  Lore(...)lus. [659] |   635.90 ns | 12.475 ns |  21.183 ns |   632.91 ns |  1.00 |    0.00 | 0.2241 | 0.0019 |     - |    4200 B |
|           MyStringBuilder |           ToString |  Lore(...)lus. [659] |   666.54 ns | 13.119 ns |  27.383 ns |   658.48 ns |  1.05 |    0.06 | 0.2537 | 0.0010 |     - |    4752 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **orem(...)ros. [310]** |   **110.63 ns** |  **2.249 ns** |   **6.268 ns** |   **108.77 ns** |  **1.00** |    **0.00** | **0.0372** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | Append_Constructor |  orem(...)ros. [310] |   220.95 ns |  4.454 ns |   5.303 ns |   220.22 ns |  1.95 |    0.11 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  orem(...)ros. [310] |   175.02 ns |  3.491 ns |   5.928 ns |   174.81 ns |  1.00 |    0.00 | 0.0410 |      - |     - |     768 B |
|           MyStringBuilder |             Append |  orem(...)ros. [310] |   267.58 ns |  5.363 ns |  13.553 ns |   265.49 ns |  1.50 |    0.09 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  orem(...)ros. [310] |   288.88 ns |  5.702 ns |  10.282 ns |   289.90 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |         AppendLine |  orem(...)ros. [310] |   267.14 ns |  5.330 ns |  11.811 ns |   265.86 ns |  0.93 |    0.05 | 0.1101 | 0.0005 |     - |    2064 B |
|                           |                    |                      |             |           |            |             |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  orem(...)ros. [310] |   384.33 ns | 11.396 ns |  33.243 ns |   380.47 ns |  1.00 |    0.00 | 0.1125 | 0.0005 |     - |    2112 B |
|           MyStringBuilder |           ToString |  orem(...)ros. [310] |   461.68 ns |  9.087 ns |  17.290 ns |   458.98 ns |  1.13 |    0.08 | 0.1793 | 0.0010 |     - |    3360 B |
