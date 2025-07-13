using System;
using System.Collections.Generic;
using System.Linq;
using Huffman.Models;

namespace Huffman.Implementation;

public class FrequencyCalculator
{
    public IEnumerable<CharacterFrequency> GetFrequencies(string input)
    {
        var frequencies = CountFrequencies(input);

        return GetNonZeroFrequencies(frequencies);
    }
    
    private static int[] CountFrequencies(string input)
    {
        var frequencies = new int[(int) Math.Pow(256, Constants.CharSizeInBytes)];

        foreach (var c in input)
        {
            frequencies[c]++;
        }

        return frequencies;
    }

    private static IEnumerable<CharacterFrequency> GetNonZeroFrequencies(int[] input)
    {
        var frequencies = new Dictionary<char, int>();

        for (var i = 0; i < (int) Math.Pow(256, Constants.CharSizeInBytes); i++)
        {
            if (input[i] > 0)
            {
                frequencies.Add((char) i, input[i]);
            }
        }

        return frequencies.Select(f => new CharacterFrequency { Character = f.Key, Frequency = f.Value });
    }
}