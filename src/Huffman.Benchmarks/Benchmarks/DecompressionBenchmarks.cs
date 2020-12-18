using System.Diagnostics.CodeAnalysis;
using System.IO;
using BenchmarkDotNet.Attributes;

namespace Huffman.Benchmarks.Benchmarks
{
    [ExcludeFromCodeCoverage]
    public class DecompressionBenchmarks
    {
        [Benchmark]
        public void Les_Misérables()
        {
            var file = File.ReadAllBytes("Test Files\\Les Misérables.huff");

            Compression.Decompress(file);
        }
    }
}