# Benchmark dotnet

## First Result

### Compression

| Method                     |      Mean |    Error |   StdDev |
|----------------------------|----------:|---------:|---------:|
| Compress_Les_Misérables    | 174.57 ms | 1.653 ms | 1.466 ms |
| Compress_War_of_the_Worlds |  22.25 ms | 0.216 ms | 0.181 ms |

### Decompression

| Method                       |      Mean |    Error |   StdDev |
|------------------------------|----------:|---------:|---------:|
| Decompress_Les_Misérables    | 135.81 ms | 2.708 ms | 2.781 ms |
| Decompress_War_of_the_Worlds |  16.31 ms | 0.161 ms | 0.151 ms |

## Current Result

As of <a href="https://github.com/stevehjohn/Huffman/blob/master/Benchmarks.md#thirteenth-benchmark">Thirteenth Benchmark</a>

### Compression

| Method                     |      Mean |    Error |   StdDev | Improvement |
|----------------------------|----------:|---------:|---------:|------------:|
| Compress_Les_Misérables    | 103.56 ms | 1.155 ms | 0.965 ms |      ~40.7% |
| Compress_War_of_the_Worlds |  12.75 ms | 0.179 ms | 0.168 ms |      ~26.3% |

### Decompression

| Method                       |      Mean |     Error |    StdDev | Improvement |
|------------------------------|----------:|----------:|----------:|------------:|
| Decompress_Les_Misérables    | 81.255 ms | 1.1592 ms | 1.0843 ms |      ~40.2% |
| Decompress_War_of_the_Worlds |  9.855 ms | 0.0753 ms | 0.0668 ms |      ~39.6% |