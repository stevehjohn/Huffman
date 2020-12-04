# Benchmarks Over Time

## Les Misérables

Average taken over 20 compression decompression cycles, in Debug build with debugger attached. 
This is to purposefully slow it down so that efficiency improvements are more noticable.

### First Benchmark

```
Compression:   382 ms
Decompression: 367 ms
```

### Second Benchmark

Removing division and modulus from BitReader class.

https://github.com/stevehjohn/Huffman/commit/6771779f9f2177d2514f6a7323e992cdde1b3a4b

```
Compression:   384 ms
Decompression: 355 ms
```

### Third Benchmark

Removing division and modulus from Blob class.

https://github.com/stevehjohn/Huffman/commit/f3f3e26fbc06a8a656b1a4def72c38fb95b42bc9

```
Compression:   373 ms
Decompression: 362 ms
```
