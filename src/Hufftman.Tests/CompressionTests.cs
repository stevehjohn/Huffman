using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Huffman.Tests
{
    public class CompressionTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public CompressionTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void File_compresses_and_decompresses()
        {
            var file = File.ReadAllText("Test Files\\War of the Worlds.txt");

            _testOutputHelper.WriteLine($"Original size: {file.Length}");

            var compressed = Compression.Compress(file);

            _testOutputHelper.WriteLine($"Compressed size: {compressed.Length}");

            var decompressed = Compression.Decompress(compressed);

            Assert.Equal(file, decompressed);
        }
    }
}