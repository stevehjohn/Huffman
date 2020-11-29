using System.Diagnostics;
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

            _testOutputHelper.WriteLine($"Original size: {file.Length:N0} bytes");

            var timer = new Stopwatch();

            timer.Start();

            var compressed = Compression.Compress(file);

            timer.Stop();

            _testOutputHelper.WriteLine($"Compressed size: {compressed.Length:N0} bytes");

            _testOutputHelper.WriteLine($"Ratio: {(float) compressed.Length / file.Length *100:N2}%");
            
            _testOutputHelper.WriteLine($"Time taken to compress: {timer.ElapsedMilliseconds:N0} ms");

            timer.Reset();
            timer.Start();

            var decompressed = Compression.Decompress(compressed);

            timer.Stop();

            _testOutputHelper.WriteLine($"Decompressed size: {decompressed.Length}");

            _testOutputHelper.WriteLine($"Time taken to decompress: {timer.ElapsedMilliseconds:N0} ms");

            Assert.Equal(file, decompressed);
        }
    }
}