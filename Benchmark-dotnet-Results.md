# Benchmark dotnet

## First Result

### Compression

|                     Method |      Mean |    Error |   StdDev |
|--------------------------- |----------:|---------:|---------:|
|    Compress_Les_MisÚrables | 174.57 ms | 1.653 ms | 1.466 ms |
| Compress_War_of_the_Worlds |  22.25 ms | 0.216 ms | 0.181 ms |

### Decompression

|                       Method |      Mean |    Error |   StdDev |
|----------------------------- |----------:|---------:|---------:|
|    Decompress_Les_MisÚrables | 135.81 ms | 2.708 ms | 2.781 ms |
| Decompress_War_of_the_Worlds |  16.31 ms | 0.161 ms | 0.151 ms |

## Current Result

As of <a href="https://github.com/stevehjohn/Huffman/blob/master/Benchmarks.md#eleventh-benchmark">Eleventh Benchmark</a>

### Compression

|                     Method |      Mean |    Error |   StdDev | Improvement |
|--------------------------- |----------:|---------:|---------:|------------:|
|    Compress_Les_MisÚrables | 118.79 ms | 1.298 ms | 1.151 ms | ~31.9%      |
| Compress_War_of_the_Worlds |  15.08 ms | 0.289 ms | 0.442 ms | ~32.2%      |

### Decompression

|                       Method |      Mean |    Error |   StdDev | Improvement |
|----------------------------- |----------:|---------:|---------:|------------:|
|    Decompress_Les_MisÚrables | 112.13 ms | 1.003 ms | 0.783 ms | ~17.4%      |
| Decompress_War_of_the_Worlds |  14.09 ms | 0.099 ms | 0.077 ms | ~13.6%      |