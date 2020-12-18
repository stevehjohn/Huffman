using System.Diagnostics.CodeAnalysis;
using System.IO;
using BenchmarkDotNet.Attributes;

namespace Huffman.Benchmarks.Benchmarks
{
    [ExcludeFromCodeCoverage]
    public class CompressionBenchmarks
    {
        [Benchmark]
        public void Les_Misérables()
        {
            var file = File.ReadAllText("Test Files\\Les Misérables.txt");

            Compression.Compress(file);
        }
    }
}