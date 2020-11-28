using System.Collections.Generic;
using Huffman.Models;

namespace Huffman.Infrastructure
{
    public static class HuffmanTreeBuilder
    {
        public static HuffmanNode BuildHuffmanTree(IEnumerable<CharacterFrequency> input)
        {
            var queue = new PriorityQueue<HuffmanNode>();

            foreach (var item in input)
            {
                queue.Add(new HuffmanNode { Frequency = item.Frequency, Character = item.Character });
            }

            while (queue.Length > 1)
            {
                var left = queue.PopMin();

                var right = queue.PopMin();

                var node = new HuffmanNode
                           {
                               Frequency = left.Frequency + right.Frequency,
                               Left = left,
                               Right = right
                           };

                queue.Add(node);
            }

            return queue.PopMin();
        }

    }
}