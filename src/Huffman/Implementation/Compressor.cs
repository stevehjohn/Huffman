namespace Huffman.Implementation
{
    public class Compressor
    {
        private readonly FrequencyCalculator _frequencyCalculator;
        private readonly HuffmanTree _huffmanTree;
        
        public Compressor()
        {
            _frequencyCalculator = new FrequencyCalculator();
            _huffmanTree = new HuffmanTree();
        }

        public byte[] Compress(string input)
        {
            var frequencies = _frequencyCalculator.GetFrequencies(input);

            _huffmanTree.Build(frequencies);

            var blob = new Blob();

            foreach (var character in input)
            {
                blob.Append(_huffmanTree.GetPath(character));
            }

            return blob.ToByteArray();
        }
    }
}