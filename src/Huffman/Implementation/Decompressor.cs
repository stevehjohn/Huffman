namespace Huffman.Implementation
{
    public class Decompressor
    {
        public string Decompress(byte[] input)
        {
            var data = new CompressedData();

            data.Load(input);

            return null;
        }
    }
}