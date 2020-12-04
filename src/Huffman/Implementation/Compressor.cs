using System.Collections.Generic;
using System.Linq;

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

            _pathCache = new Dictionary<char, string>();

            for (var i = 0; i < input.Length; i++)
            {
                var character = input[i];

                _pathCache.TryGetValue(character, out var path);

                if (path == null)
                {
                    path = _huffmanTree.GetPath(character);

                    _pathCache.Add(character, path);

                    blob.Append(path);
                }
                else
                {
                    blob.Append(path);
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
    }
}