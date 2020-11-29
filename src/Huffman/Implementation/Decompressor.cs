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

            return null;
        }
    }
}