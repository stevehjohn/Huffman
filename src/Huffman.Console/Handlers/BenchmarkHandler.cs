using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Huffman.Console.Options;
using static System.Console;

namespace Huffman.Console.Handlers
{
    [ExcludeFromCodeCoverage]
    public class BenchmarkHandler
    {
        private readonly BenchmarkOptions _options;

        public BenchmarkHandler(BenchmarkOptions options)
        {
            _options = options;
        }

        public void Execute()
        {
            WriteLine($"Filename: {Path.GetFileNameWithoutExtension(_options.FileName)}");

            var file = File.ReadAllText(_options.FileName);

            WriteLine($"Uncompressed file size: {file.Length:N0} bytes.");

            var timer = new Stopwatch();
            
            timer.Start();

            var compressed = Compression.Compress(file);

            timer.Stop();

            WriteLine($"Compressed file size: {compressed.Length:N0} bytes.");

            WriteLine($"Ratio: {(float) compressed.Length / file.Length *100:N2}%");

            WriteLine($"Time taken to compress: {timer.ElapsedMilliseconds:N0} ms.");

            timer.Reset();

            timer.Start();

            var decompressed = Compression.Decompress(compressed);

            timer.Stop();

            WriteLine($"Decompressed file size: {decompressed.Length:N0} bytes.");

            WriteLine($"Time taken to decompress: {timer.ElapsedMilliseconds:N0} ms.");
        }
    }
}