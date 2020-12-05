# Huffman

Bored during Covid, so doing a Huffman encoding routine for fun (yes, I'm an interminable nerd).

![Huffman Tree Visualisation for Stevo](https://github.com/stevehjohn/Huffman/blob/master/Illustration.png "Huffman Tree Visualisation for Stevo")

## Notes

For me, creating the Huffman tree was much easier to reason about when using a Priority Queue.

## Improvements

Have been slowly optimising the code.

See [Benchmarks.md](https://github.com/stevehjohn/Huffman/blob/master/Benchmarks.md) for details of how various commits improved things.

See [Standardised-Benchmarks.md](https://github.com/stevehjohn/Huffman/blob/master/Standardised-Benchmarks.md) for results on a given hardware configuration.

## Initial Results

Downloaded some public domain novels from Project Gutenberg. Here's how they compress.

- A Tale of Two Cities

```
Original size: 792,968 bytes.
Compressed size: 454,568 bytes.
Ratio: 57.32%
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/Huffman/blob/master/visualisations/A%20Tale%20of%20Two%20Cities.html)

- Frankenstein or the Modern Prometheus

```
Original size: 448,844 bytes.
Compressed size: 253,295 bytes.
Ratio: 56.43%
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/Huffman/blob/master/visualisations/Frankenstein%20or%20the%20Modern%20Prometheus.html)

- Great Expectations

```
Original size: 1,035,187 bytes.
Compressed size: 595,235 bytes.
Ratio: 57.50%
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/Huffman/blob/master/visualisations/Great%20Expectations.html)

- Les Misérables

```
Original size: 3,325,127 bytes.
Compressed size: 1,921,391 bytes.
Ratio: 57.78%
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/Huffman/blob/master/visualisations/Les%20Mis%C3%A9rables.html)

- Pride and Prejudice

```
Original size: 790,334 bytes.
Compressed size: 432,705 bytes.
Ratio: 54.75%
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/Huffman/blob/master/visualisations/Pride%20and%20Prejudice.html)

- War of the Worlds

```
Original size: 363,744 bytes.
Compressed size: 207,483 bytes.
Ratio: 57.04%
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/Huffman/blob/master/visualisations/War%20of%20the%20Worlds.html)

Seems to pretty much hover around the 57% mark.

## Fun Observations

H. G. Wells closed all of his open brackets.

![War of the Worlds Brackets Node](https://github.com/stevehjohn/Huffman/blob/master/WotW-Brackets.PNG "War of the Worlds Brackets Node")
