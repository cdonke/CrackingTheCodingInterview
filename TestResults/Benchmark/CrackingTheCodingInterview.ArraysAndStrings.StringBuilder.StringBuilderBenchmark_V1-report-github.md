``` ini

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET Core SDK=5.0.202
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|                    Method |         Categories |                 data |         Mean |      Error |     StdDev |       Median | Ratio | RatioSD |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|-------------------------- |------------------- |--------------------- |-------------:|-----------:|-----------:|-------------:|------:|--------:|-------:|-------:|------:|----------:|
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...)non. [3382]** |    **796.91 ns** |  **15.839 ns** |  **34.767 ns** |    **788.81 ns** |  **1.00** |    **0.00** | **0.3653** | **0.0086** |     **-** |    **6840 B** |
|           MyStringBuilder | Append_Constructor | Lore(...)non. [3382] | 18,295.40 ns | 154.045 ns | 144.094 ns | 18,282.87 ns | 23.05 |    1.02 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...)non. [3382] |    830.98 ns |  16.529 ns |  25.241 ns |    826.85 ns |  1.00 |    0.00 | 0.3691 | 0.0086 |     - |    6912 B |
|           MyStringBuilder |             Append | Lore(...)non. [3382] | 18,225.53 ns | 106.422 ns |  99.547 ns | 18,222.40 ns | 21.99 |    0.93 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...)non. [3382] |  1,460.19 ns |  29.098 ns |  50.192 ns |  1,444.05 ns |  1.00 |    0.00 | 0.7343 | 0.0343 |     - |   13752 B |
|           MyStringBuilder |         AppendLine | Lore(...)non. [3382] | 18,240.95 ns | 126.004 ns | 117.864 ns | 18,196.62 ns | 12.50 |    0.42 | 0.7324 |      - |     - |   14144 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...)non. [3382] |  2,462.74 ns |  48.534 ns |  99.141 ns |  2,454.32 ns |  1.00 |    0.00 | 1.0986 | 0.0496 |     - |   20544 B |
|           MyStringBuilder |           ToString | Lore(...)non. [3382] | 25,868.47 ns | 264.244 ns | 247.174 ns | 25,915.27 ns | 10.39 |    0.49 | 1.4648 | 0.0305 |     - |   27728 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lorem(...)uere. [71]** |     **55.86 ns** |   **1.141 ns** |   **2.356 ns** |     **55.94 ns** |  **1.00** |    **0.00** | **0.0114** |      **-** |     **-** |     **216 B** |
|           MyStringBuilder | Append_Constructor | Lorem(...)uere. [71] |    461.12 ns |   9.137 ns |  15.515 ns |    460.54 ns |  8.25 |    0.46 | 0.1121 | 0.0005 |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lorem(...)uere. [71] |    114.83 ns |   2.313 ns |   2.925 ns |    114.03 ns |  1.00 |    0.00 | 0.0153 |      - |     - |     288 B |
|           MyStringBuilder |             Append | Lorem(...)uere. [71] |    465.85 ns |   9.218 ns |  13.797 ns |    465.23 ns |  4.07 |    0.19 | 0.1121 | 0.0005 |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lorem(...)uere. [71] |    202.40 ns |   3.828 ns |   4.408 ns |    201.06 ns |  1.00 |    0.00 | 0.0269 |      - |     - |     504 B |
|           MyStringBuilder |         AppendLine | Lorem(...)uere. [71] |    474.88 ns |   9.509 ns |  17.861 ns |    472.87 ns |  2.38 |    0.10 | 0.1116 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lorem(...)uere. [71] |    243.93 ns |   4.758 ns |   6.824 ns |    243.91 ns |  1.00 |    0.00 | 0.0358 |      - |     - |     672 B |
|           MyStringBuilder |           ToString | Lorem(...)uere. [71] |    621.50 ns |  12.337 ns |  25.202 ns |    616.55 ns |  2.55 |    0.16 | 0.1297 | 0.0010 |     - |    2432 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** | **Lore(...) ut. [6730]** |  **1,483.81 ns** |  **38.199 ns** | **112.632 ns** |  **1,428.50 ns** |  **1.00** |    **0.00** | **0.7229** | **0.0343** |     **-** |   **13536 B** |
|           MyStringBuilder | Append_Constructor | Lore(...) ut. [6730] | 38,044.32 ns | 289.885 ns | 271.159 ns | 38,078.77 ns | 22.95 |    0.77 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append | Lore(...) ut. [6730] |  1,739.81 ns |  34.543 ns |  57.714 ns |  1,740.84 ns |  1.00 |    0.00 | 0.7267 | 0.0343 |     - |   13608 B |
|           MyStringBuilder |             Append | Lore(...) ut. [6730] | 38,258.28 ns | 315.545 ns | 295.161 ns | 38,135.01 ns | 22.30 |    0.65 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine | Lore(...) ut. [6730] |  2,836.42 ns |  50.544 ns |  60.169 ns |  2,830.07 ns |  1.00 |    0.00 | 1.4496 | 0.1297 |     - |   27144 B |
|           MyStringBuilder |         AppendLine | Lore(...) ut. [6730] | 37,848.13 ns | 254.991 ns | 212.929 ns | 37,902.67 ns | 13.36 |    0.30 | 1.5869 | 0.0610 |     - |   30168 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString | Lore(...) ut. [6730] |  5,098.52 ns | 101.511 ns | 195.577 ns |  5,054.74 ns |  1.00 |    0.00 | 2.1667 | 0.1755 |     - |   40632 B |
|           MyStringBuilder |           ToString | Lore(...) ut. [6730] | 46,987.92 ns | 487.003 ns | 455.543 ns | 46,864.24 ns |  9.01 |    0.39 | 3.0518 | 0.1831 |     - |   57144 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **Lore(...)lus. [659]** |    **205.58 ns** |   **4.149 ns** |  **12.037 ns** |    **203.25 ns** |  **1.00** |    **0.00** | **0.0744** | **0.0002** |     **-** |    **1392 B** |
|           MyStringBuilder | Append_Constructor |  Lore(...)lus. [659] |  2,289.38 ns |  21.310 ns |  19.933 ns |  2,283.37 ns | 10.37 |    0.47 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  Lore(...)lus. [659] |    262.66 ns |   5.122 ns |  10.915 ns |    262.69 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |             Append |  Lore(...)lus. [659] |  2,333.10 ns |  20.726 ns |  19.387 ns |  2,333.60 ns |  8.99 |    0.43 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  Lore(...)lus. [659] |    437.29 ns |   8.520 ns |  13.513 ns |    434.78 ns |  1.00 |    0.00 | 0.1526 | 0.0010 |     - |    2856 B |
|           MyStringBuilder |         AppendLine |  Lore(...)lus. [659] |  2,428.98 ns |  28.337 ns |  26.507 ns |  2,426.52 ns |  5.48 |    0.19 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  Lore(...)lus. [659] |    652.99 ns |  12.892 ns |  32.813 ns |    648.69 ns |  1.00 |    0.00 | 0.2241 | 0.0019 |     - |    4200 B |
|           MyStringBuilder |           ToString |  Lore(...)lus. [659] |  3,419.04 ns |  66.801 ns |  74.249 ns |  3,405.47 ns |  5.00 |    0.24 | 0.2556 |      - |     - |    4784 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| **System.Text.StringBuilder** | **Append_Constructor** |  **orem(...)ros. [310]** |    **111.73 ns** |   **2.273 ns** |   **5.178 ns** |    **111.29 ns** |  **1.00** |    **0.00** | **0.0372** |      **-** |     **-** |     **696 B** |
|           MyStringBuilder | Append_Constructor |  orem(...)ros. [310] |  1,237.01 ns |  19.239 ns |  17.997 ns |  1,237.87 ns | 10.98 |    0.50 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |             Append |  orem(...)ros. [310] |    177.40 ns |   3.562 ns |   8.535 ns |    177.42 ns |  1.00 |    0.00 | 0.0410 |      - |     - |     768 B |
|           MyStringBuilder |             Append |  orem(...)ros. [310] |  1,343.57 ns |  25.587 ns |  28.440 ns |  1,333.78 ns |  7.53 |    0.41 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |         AppendLine |  orem(...)ros. [310] |    298.67 ns |   6.013 ns |  15.305 ns |    296.22 ns |  1.00 |    0.00 | 0.0782 |      - |     - |    1464 B |
|           MyStringBuilder |         AppendLine |  orem(...)ros. [310] |  1,279.80 ns |  25.386 ns |  32.105 ns |  1,279.15 ns |  4.24 |    0.26 | 0.1106 |      - |     - |    2096 B |
|                           |                    |                      |              |            |            |              |       |         |        |        |       |           |
| System.Text.StringBuilder |           ToString |  orem(...)ros. [310] |    403.69 ns |   7.511 ns |  11.242 ns |    403.36 ns |  1.00 |    0.00 | 0.1125 | 0.0005 |     - |    2112 B |
|           MyStringBuilder |           ToString |  orem(...)ros. [310] |  1,788.21 ns |  34.257 ns |  35.179 ns |  1,786.32 ns |  4.40 |    0.15 | 0.1812 |      - |     - |    3392 B |
