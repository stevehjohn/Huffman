﻿namespace Huffman.Implementation;

public class Decompressor
{
    private readonly HuffmanTree _huffmanTree;

    public Decompressor()
    {
        _huffmanTree = new HuffmanTree();
    }

    public string Decompress(byte[] input)
    {
        var data = new CompressedData();

        data.Load(input);

        _huffmanTree.Build(data.Frequencies);

        var originalLength = data.OriginalLength;

        var output = new char[originalLength];

        var bits = new BitReader(data.Data);

        var node = _huffmanTree.Root;

        var position = 0;

        while (position < originalLength)
        {
            if (node.Character != '\0')
            {
                output[position] = node.Character;

                node = _huffmanTree.Root;

                position++;
            }

            node = bits.Read() ? node.Right : node.Left;
        }

        return new string(output);
    }
}