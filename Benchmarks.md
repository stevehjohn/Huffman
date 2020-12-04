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

### Fourth Benchmark

Replacing `List&lt;byte&gt;` with `byte[]` in Blob class.

https://github.com/stevehjohn/Huffman/commit/d59b6940013c5501fbf5a4132f0ea1ac3345ef43

```
Compression:   300 ms
Decompression: 366 ms
```

### Fifth Benchmark

Removing calls to `OriginalLength` property.

https://github.com/stevehjohn/Huffman/commit/df95e5f2761aa6bd3ade70ad8c7385b6ea48c362

```
Compression:   307 ms
Decompression: 327 ms
```
