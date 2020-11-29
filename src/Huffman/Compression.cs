using Huffman.Implementation;

namespace Huffman
{
    public static class Compression
    {
        public static byte[] Compress(string input)
        {
            var compressor = new Compressor();

            var result = compressor.Compress(input);

            return result;
        }

        public static string Decompress(byte[] input)
        {
            var decompressor = new Decompressor();

            var result = decompressor.Decompress(input);

            return result;
        }
    }
}