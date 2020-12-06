using System.Collections.Generic;
using System.Linq;
using Huffman.Models;

namespace Huffman.Implementation
{
    public class FrequencyCalculator
    {
        public IEnumerable<StringFrequency> GetFrequencies(string input)
        {
            var words = input.Split(' ');

            var frequencies = new Dictionary<string, int>
                              {
                                  { " ", input.Count(c => c == ' ') }
                              };

            foreach (var word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies.Add(word, 1);
                }
            }

            return frequencies.Select(f => new StringFrequency { String = f.Key, Frequency = f.Value });
        }
    }
}