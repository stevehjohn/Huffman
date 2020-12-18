# Benchmarks Over Time

## Les Misérables

Average taken over 20 cycles each of compression and decompression, in Debug build with debugger attached. 
This is to purposefully slow it down so that efficiency improvements are more noticable.

Percentage improvement figures are between current and previous benchmark rather than current and first.

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
Decompression: 355 ms ↓ ~3.3%
```

### Third Benchmark

Removing modulus from Blob class.

https://github.com/stevehjohn/Huffman/commit/f3f3e26fbc06a8a656b1a4def72c38fb95b42bc9

```
Compression:   373 ms ↓ ~2.9%
Decompression: 362 ms
```

### Fourth Benchmark

Replacing `List<byte>` with `byte[]` in Blob class.

https://github.com/stevehjohn/Huffman/commit/d59b6940013c5501fbf5a4132f0ea1ac3345ef43

```
Compression:   300 ms ↓ ~19.6%
Decompression: 366 ms
```

### Fifth Benchmark

Removing calls to `OriginalLength` property.

https://github.com/stevehjohn/Huffman/commit/df95e5f2761aa6bd3ade70ad8c7385b6ea48c362

```
Compression:   307 ms
Decompression: 327 ms ↓ ~10.7%
```

### Sixth Benchmark

Replace `foreach` loop with `for` loop over input string.

https://github.com/stevehjohn/Huffman/commit/4dfd629f3aae1d5da4c2a849576038db81d7bfcd

```
Compression:   298 ms ↓ ~2.9%
Decompression: 327 ms
```

### Seventh Benchmark

Replace `StringBuilder` with `char[]`.

https://github.com/stevehjohn/Huffman/commit/84cab7ab81a0c966abe8b639a8fa08e54480416a

```
Compression:   298 ms
Decompression: 315 ms ↓ ~3.7%
```

### Eighth Benchmark

Pre-build path cache.

https://github.com/stevehjohn/Huffman/commit/35c38a44d6c7b57882ee742893ab8c109870fb22

```
Compression:   291 ms ↓ ~2.3%
Decompression: 315 ms
```

### Ninth Benchmark

Pre-build path cache into array rather than dictionary.

https://github.com/stevehjohn/Huffman/commit/e2651dd774fcff428542ad1eb10fb3ba1c479480

```
Compression:   275 ms ↓ ~5.5%
Decompression: 315 ms
```

### Tenth Benchmark

Tweaking `BitReader`.

https://github.com/stevehjohn/Huffman/commit/71807f6443cc727389e8a414303834004592e4f2

```
No discernable difference.
```

### Eleventh Benchmark

Reduce dereferencing of `_data` in `BitReader`.

https://github.com/stevehjohn/Huffman/commit/5203d0bc473f1742a9d7a782a49029c781370839

```
Compression:    267 ms
Decompression:  293 ms ↓ ~7.0%
```

## Current Overall Improvement

<br/>

| | Initial Time | Latest Time | % Improvement |
| --- | --- | --- | --- |
| Compression: | 382 ms | 275 ms | 28.0% |
| Decompression: | 367 ms | 293 ms | 20.2% |
