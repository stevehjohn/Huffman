using System.Diagnostics.CodeAnalysis;
using CommandLine;

namespace Huffman.Console.Options
{
    [ExcludeFromCodeCoverage]
    [Verb("benchmark", HelpText = "Output statistics to the console.")]
    public class BenchmarkOptions
    {
        [Option('f', "filename", Required = true, HelpText = "Filename of the document to visualise.")]
        public string FileName { get; set; }
    }
}