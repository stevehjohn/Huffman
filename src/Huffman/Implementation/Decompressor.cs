using System.Text;

namespace Huffman.Implementation
{
    public class Decompressor
    {
        private readonly HuffmanTree _huffmanTree;

        public Decompressor()
        {
            _huffmanTree = new HuffmanTree();
        }

        public string Decompress(byte[] input)
        {
            var data = new CompressedData();

            data.Load(input);

            _huffmanTree.Build(data.Frequencies);

            var output = new StringBuilder();

            var bits = new BitReader(data.Data);

            var node = _huffmanTree.Root;

            var originalLength = data.OriginalLength;

            while (output.Length < originalLength)
            {
                if (node.Character != '\0')
                {
                    output.Append(node.Character);

                    node = _huffmanTree.Root;
                }

                node = bits.Read() ? node.Right : node.Left;
            }

            return output.ToString();
        }
    }
}