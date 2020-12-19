using System.Diagnostics.CodeAnalysis;
using System.IO;
using BenchmarkDotNet.Attributes;

namespace Huffman.Benchmarks.Benchmarks
{
    [ExcludeFromCodeCoverage]
    public class DecompressionBenchmarks
    {
        [Benchmark]
        public void Decompress_Les_Misérables()
        {
            var file = File.ReadAllBytes("Test Files\\Les Misérables.huff");

            Compression.Decompress(file);
        }

        [Benchmark]
        public void Decompress_War_of_the_Worlds()
        {
            var file = File.ReadAllBytes("Test Files\\War of the Worlds.huff");

            Compression.Decompress(file);
        }
    }
}