using System.Diagnostics.CodeAnalysis;
using CommandLine;

namespace Huffman.Console.Options;

[ExcludeFromCodeCoverage]
[Verb("benchmark", HelpText = "Output statistics to the console.")]
public class BenchmarkOptions
{
    [Option('f', "filename", Required = true, HelpText = "Filename of the document to visualise.")]
    public string FileName { get; set; }

    [Option('c', "cycles", Required = false, HelpText = "How many cycles to run to get average time taken.", Default = 1)]
    public int Cycles { get; set; }

    [Option('q', "quiet", Required = false, HelpText = "Suppress intermediate output and just display summaries.")]
    public bool Quiet { get; set; }
}