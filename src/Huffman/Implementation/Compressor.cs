using System.Collections.Generic;
using System.Linq;
using Huffman.Models;

namespace Huffman.Implementation
{
    public class Compressor
    {
        public byte[] Compress(string input)
        {
            var frequencies = DetermineFrequencies(input);

            var orderedFrequencies = GetOrderedFrequencies(frequencies);

            return null;
        }

        private static int[] DetermineFrequencies(string input)
        {
            var frequencies = new int[65535];

            foreach (var c in input)
            {
                frequencies[c]++;
            }

            return frequencies;
        }

        private static IOrderedEnumerable<CharacterFrequency> GetOrderedFrequencies(int[] input)
        {
            var frequencies = new Dictionary<char, int>();

            for (var i = 0; i < 65535; i++)
            {
                if (input[i] > 0)
                {
                    frequencies.Add((char) i, input[i]);
                }
            }

            return frequencies.Select(f => new CharacterFrequency { Character = f.Key, Frequency = f.Value }).OrderByDescending(f => f.Frequency);
        }
    }
}