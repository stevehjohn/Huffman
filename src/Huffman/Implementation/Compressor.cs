﻿using System.Collections.Generic;
using System.Linq;
using Huffman.Infrastructure;
using Huffman.Models;

namespace Huffman.Implementation
{
    public class Compressor
    {
        public byte[] Compress(string input)
        {
            var frequencies = DetermineFrequencies(input);

            var distinctFrequencies = GetFrequencies(frequencies);

            var huffmanTree = BuildHuffmanTree(distinctFrequencies);

            return null;
        }

        private static int[] DetermineFrequencies(string input)
        {
            var frequencies = new int[Constants.CharSize];

            foreach (var c in input)
            {
                frequencies[c]++;
            }

            return frequencies;
        }

        private static IEnumerable<CharacterFrequency> GetFrequencies(int[] input)
        {
            var frequencies = new Dictionary<char, int>();

            for (var i = 0; i < Constants.CharSize; i++)
            {
                if (input[i] > 0)
                {
                    frequencies.Add((char) i, input[i]);
                }
            }

            return frequencies.Select(f => new CharacterFrequency { Character = f.Key, Frequency = f.Value });
        }

        private static HuffmanNode BuildHuffmanTree(IEnumerable<CharacterFrequency> input)
        {

        }
    }
}