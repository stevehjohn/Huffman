﻿using System;
using System.Collections.Generic;
using System.Linq;
using Huffman.Models;

namespace Huffman.Implementation;

public class Compressor
{
    private readonly FrequencyCalculator _frequencyCalculator;
    private readonly HuffmanTree _huffmanTree;

    private string[] _pathCache;

    public Compressor()
    {
        _frequencyCalculator = new FrequencyCalculator();
        _huffmanTree = new HuffmanTree();
    }

    public unsafe byte[] Compress(string input)
    {
        var frequencies = _frequencyCalculator.GetFrequencies(input).ToList();

        _huffmanTree.Build(frequencies);

        var blob = new Blob();

        BuildPathCache(frequencies);

        var length = input.Length;

        fixed (char* inputPointer = input)
        {
            for (var i = 0; i < length; i++)
            {
                blob.Append(_pathCache[inputPointer[i]]);
            }
        }

        var data = new CompressedData
        {
            Data = blob.ToByteArray(),
            Frequencies = frequencies,
            OriginalLength = input.Length
        };

        return data.Save();
    }

    private void BuildPathCache(List<CharacterFrequency> frequencies)
    {
        _pathCache = new string[(int) Math.Pow(256, Constants.CharSizeInBytes)];

        frequencies.ForEach(f => _pathCache[f.Character] = _huffmanTree.GetPath(f.Character));
    }
}