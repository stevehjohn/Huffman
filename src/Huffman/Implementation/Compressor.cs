using System;
using System.Collections.Generic;
using System.Linq;
using Huffman.Models;

namespace Huffman.Implementation
{
    public class Compressor
    {
        private readonly FrequencyCalculator _frequencyCalculator;
        private readonly HuffmanTree _huffmanTree;

        private Dictionary<char, string> _pathCache;

        public Compressor()
        {
            _frequencyCalculator = new FrequencyCalculator();
            _huffmanTree = new HuffmanTree();
        }

        public byte[] Compress(string input)
        {
            var frequencies = _frequencyCalculator.GetFrequencies(input).ToList();

            _huffmanTree.Build(frequencies);

            var blob = new Blob();

            BuildPathCache(frequencies);

            for (var i = 0; i < input.Length; i++)
            {
                var character = input[i];

                blob.Append(_pathCache[character]);
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
            _pathCache = new Dictionary<char, string>();

            frequencies.ForEach(f => _pathCache.Add(f.Character, _huffmanTree.GetPath(f.Character)));
        }
    }
}