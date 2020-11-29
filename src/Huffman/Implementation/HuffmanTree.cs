using System.Collections.Generic;
using System.Linq;
using System.Text;
using Huffman.Models;

namespace Huffman.Implementation
{
    public class HuffmanTree
    {
        public HuffmanNode Root { get; set; }
        private HuffmanNode[] _nodes;

        public void Build(IEnumerable<CharacterFrequency> input)
        {
            var queue = new PriorityQueue<HuffmanNode>();

            var frequencies = input.ToList();

            _nodes = new HuffmanNode[frequencies.Count];

            var count = 0;

            foreach (var item in frequencies)
            {
                var node = new HuffmanNode { Frequency = item.Frequency, Character = item.Character };
                
                queue.Add(node);

                _nodes[count] = node;

                count++;
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

                left.Parent = node;
                right.Parent = node;

                queue.Add(node);
            }

            Root = queue.PopMin();
        }

        public string GetPath(char character)
        {
            var node = _nodes.Single(n => n.Character == character);

            var pathToRoot = new List<HuffmanNode>();

            while (node != null)
            {
                pathToRoot.Add(node);

                node = node.Parent;
            }

            var path = new StringBuilder();

            for (var i = pathToRoot.Count - 1; i > 0; i--)
            {
                path.Append(ReferenceEquals(pathToRoot[i - 1], pathToRoot[i].Left) ? '0' : '1');
            }

            return path.ToString();
        }
    }
}