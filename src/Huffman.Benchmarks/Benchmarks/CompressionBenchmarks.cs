using System.Diagnostics.CodeAnalysis;
using System.IO;
using BenchmarkDotNet.Attributes;

namespace Huffman.Benchmarks.Benchmarks
{
    [ExcludeFromCodeCoverage]
    public class CompressionBenchmarks
    {
        [Benchmark]
        public void Compress_Les_Misérables()
        {
            var file = File.ReadAllText("Test Files\\Les Misérables.txt");

            Compression.Compress(file);
        }

        [Benchmark]
        public void Compress_War_of_the_Worlds()
        {
            var file = File.ReadAllText("Test Files\\War of the Worlds.txt");

            File.WriteAllBytes("C:\\Wow.huff", Compression.Compress(file));
        }
    }
}