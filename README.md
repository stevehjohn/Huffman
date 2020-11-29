# Huffman

Bored during Covid, so doing a Huffman encoding routine for fun (yes, I'm an interminable nerd).

## Notes

For me, creating the Huffman tree was much easier to reason about when using a Priority Queue.

## Results

Downloaded some public domain novels from Project Gutenberg.

Here is the performance on my 2020 Intel(R) Core(TM) i9-9980HK CPU @ 2.40GHz MacBook Pro.

- Great Expectations

```
Original size: 1,035,187 bytes.
Compressed size: 595,235 bytes.
Ratio: 57.50%
Time taken to compress: 197 ms.
Decompressed size: 1,035,187 bytes.
Time taken to decompress: 185 ms.
```

- Les Misérables

```
Original size: 3,325,127 bytes.
Compressed size: 1,921,391 bytes.
Ratio: 57.78%
Time taken to compress: 566 ms.
Decompressed size: 3,325,127 bytes.
Time taken to decompress: 492 ms.
```

- War of the Worlds

```
Original size: 363,744 bytes.
Compressed size: 207,483 bytes.
Ratio: 57.04%
Time taken to compress: 125 ms.
Decompressed size: 363,744 bytes.
Time taken to decompress: 119 ms.
```