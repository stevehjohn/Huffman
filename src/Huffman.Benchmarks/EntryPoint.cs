using System.Diagnostics.CodeAnalysis;
using BenchmarkDotNet.Running;
using Huffman.Benchmarks.Benchmarks;

namespace Huffman.Benchmarks;

[ExcludeFromCodeCoverage]
public static class EntryPoint
{
    public static void Main()
    {
        BenchmarkRunner.Run<CompressionBenchmarks>();

        BenchmarkRunner.Run<DecompressionBenchmarks>();
    }
}