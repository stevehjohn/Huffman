using Huffman.Infrastructure;

namespace Huffman.Models
{
    public class HuffmanNode
    {
        public char Character { get; set; }

        [Priority]
        public int Frequency { get; set; }

        public HuffmanNode Left { get; set; }

        public HuffmanNode Right { get; set; }
    }
}