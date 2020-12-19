using System.Diagnostics.CodeAnalysis;
using System.IO;
using BenchmarkDotNet.Attributes;

namespace Huffman.Benchmarks.Benchmarks
{
    [ExcludeFromCodeCoverage]
    public class DecompressionBenchmarks
    {
        private readonly byte[] _lesMisérables;
        private readonly byte[] _warOfTheWorlds;
        
        public DecompressionBenchmarks()
        {
            _lesMisérables = File.ReadAllBytes("Test Files\\Les Misérables.huff");
            _warOfTheWorlds = File.ReadAllBytes("Test Files\\War of the Worlds.huff");
        }
        
        [Benchmark]
        public void Decompress_Les_Misérables()
        {
            Compression.Decompress(_lesMisérables);
        }

        [Benchmark]
        public void Decompress_War_of_the_Worlds()
        {
            Compression.Decompress(_warOfTheWorlds);
        }
    }
}