using System.Diagnostics.CodeAnalysis;
using System.IO;
using BenchmarkDotNet.Attributes;

namespace Huffman.Benchmarks.Benchmarks
{
    [ExcludeFromCodeCoverage]
    public class CompressionBenchmarks
    {
        private readonly string _lesMisérables;
        private readonly string _warOfTheWorlds;
        
        public CompressionBenchmarks()
        {
            _lesMisérables = File.ReadAllText("Test Files\\Les Misérables.txt");
            _warOfTheWorlds = File.ReadAllText("Test Files\\War of the Worlds.txt");
        }
        
        [Benchmark]
        public void Compress_Les_Misérables()
        {
            Compression.Compress(_lesMisérables);
        }

        [Benchmark]
        public void Compress_War_of_the_Worlds()
        {
            File.WriteAllBytes("C:\\Wow.huff", Compression.Compress(_warOfTheWorlds));
        }
    }
}