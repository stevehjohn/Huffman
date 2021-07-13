# Benchmark dotnet

## First Result

### Compression

|                     Method |      Mean |    Error |   StdDev |
|--------------------------- |----------:|---------:|---------:|
|    Compress_Les_Misérables | 174.57 ms | 1.653 ms | 1.466 ms |
| Compress_War_of_the_Worlds |  22.25 ms | 0.216 ms | 0.181 ms |

### Decompression

|                       Method |      Mean |    Error |   StdDev |
|----------------------------- |----------:|---------:|---------:|
|    Decompress_Les_Misérables | 135.81 ms | 2.708 ms | 2.781 ms |
| Decompress_War_of_the_Worlds |  16.31 ms | 0.161 ms | 0.151 ms |

## Current Result

As of <a href="https://github.com/stevehjohn/Huffman/blob/master/Benchmarks.md#twelfth-benchmark">Twelfth Benchmark</a>

### Compression

|                     Method |      Mean |    Error |   StdDev |
|--------------------------- |----------:|---------:|---------:|
|    Compress_Les_Misérables | 103.38 ms | 0.736 ms | 0.652 ms |
| Compress_War_of_the_Worlds |  12.42 ms | 0.092 ms | 0.086 ms |

### Decompression

|                       Method |      Mean |    Error |   StdDev | Improvement |
|----------------------------- |----------:|---------:|---------:|------------:|
|    Decompress_Les_Misérables | 112.13 ms | 1.003 ms | 0.783 ms | ~17.4%      |
| Decompress_War_of_the_Worlds |  14.09 ms | 0.099 ms | 0.077 ms | ~13.6%      |