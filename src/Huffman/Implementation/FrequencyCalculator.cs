using System;
using System.Collections.Generic;
using System.Linq;
using Huffman.Models;

namespace Huffman.Implementation
{
    public class FrequencyCalculator
    {
        public IEnumerable<CharacterFrequency> GetFrequencies(byte[] input)
        {
            var frequencies = CountFrequencies(input);

            return GetNonZeroFrequencies(frequencies);
        }
    
        private static int[] CountFrequencies(byte[] input)
        {
            var frequencies = new int[256];

            foreach (var c in input)
            {
                frequencies[c]++;
            }

            return frequencies;
        }

        private static IEnumerable<CharacterFrequency> GetNonZeroFrequencies(int[] input)
        {
            var frequencies = new Dictionary<char, int>();

            for (var i = 0; i < 256; i++)
            {
                if (input[i] > 0)
                {
                    frequencies.Add((char) i, input[i]);
                }
            }

            return frequencies.Select(f => new CharacterFrequency { Character = f.Key, Frequency = f.Value });
        }
    }
}