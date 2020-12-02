# Huffman

Bored during Covid, so doing a Huffman encoding routine for fun (yes, I'm an interminable nerd).

## Notes

For me, creating the Huffman tree was much easier to reason about when using a Priority Queue.

## Results

Downloaded some public domain novels from Project Gutenberg.

Here is the performance on my 2020 Intel(R) Core(TM) i9-9980HK CPU @ 2.40GHz MacBook Pro.

- A Tale of Two Cities

```
Original size: 792,968 bytes.
Compressed size: 454,568 bytes.
Ratio: 57.32%
Time taken to compress: 94 ms.
Decompressed size: 792,968 bytes.
Time taken to decompress: 82 ms.
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/Huffman/blob/master/visualisations/A%20Tale%20of%20Two%20Cities.html)

- Frankenstein or the Modern Prometheus

```
Original size: 448,844 bytes.
Compressed size: 253,295 bytes.
Ratio: 56.43%
Time taken to compress: 52 ms.
Decompressed size: 448,844 bytes.
Time taken to decompress: 46 ms.
```

- Great Expectations

```
Original size: 1,035,187 bytes.
Compressed size: 595,235 bytes.
Ratio: 57.50%
Time taken to compress: 128 ms.
Decompressed size: 1,035,187 bytes.
Time taken to decompress: 111 ms.
```

- Les Misérables

```
Original size: 3,325,127 bytes.
Compressed size: 1,921,391 bytes.
Ratio: 57.78%
Time taken to compress: 398 ms.
Decompressed size: 3,325,127 bytes.
Time taken to decompress: 368 ms.
```

- Pride and Prejudice

```
Original size: 790,334 bytes.
Compressed size: 432,705 bytes.
Ratio: 54.75%
Time taken to compress: 98 ms.
Decompressed size: 790,334 bytes.
Time taken to decompress: 78 ms.
```

- War of the Worlds

```
Original size: 363,744 bytes.
Compressed size: 207,483 bytes.
Ratio: 57.04%
Time taken to compress: 45 ms.
Decompressed size: 363,744 bytes.
Time taken to decompress: 40 ms.
```

Seems to pretty much hover around the 57% mark.