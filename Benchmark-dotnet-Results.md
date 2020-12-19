# Benchmark dotnet

## First Result

### Compression

|            Method |      Mean |    Error |   StdDev |
|------------------ |----------:|---------:|---------:|
|    Les_Misérables | 115.49 ms | 1.335 ms | 1.249 ms |
| War_of_the_Worlds |  14.62 ms | 0.205 ms | 0.182 ms |

### Decompression

|                    Method |     Mean |   Error |  StdDev |
|-------------------------- |---------:|--------:|--------:|
| Decompress_Les_Misérables | 116.5 ms | 2.28 ms | 2.53 ms |

## Current Result

As of <a href="https://github.com/stevehjohn/Huffman/blob/master/Benchmarks.md#eleventh-benchmark">Eleventh Benchmark</a>

### Compression

|            Method |      Mean |    Error |   StdDev |
|------------------ |----------:|---------:|---------:|
|    Les_Misérables | 118.79 ms | 1.298 ms | 1.151 ms |
| War_of_the_Worlds |  15.08 ms | 0.289 ms | 0.442 ms |

### Decompression

|            Method |      Mean |    Error |   StdDev |
|------------------ |----------:|---------:|---------:|
|    Les_Misérables | 112.13 ms | 1.003 ms | 0.783 ms |
| War_of_the_Worlds |  14.09 ms | 0.099 ms | 0.077 ms |