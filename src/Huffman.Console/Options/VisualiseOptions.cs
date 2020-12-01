using System.Diagnostics.CodeAnalysis;
using CommandLine;

namespace Huffman.Console.Options
{
    [ExcludeFromCodeCoverage]
    [Verb("visualise", HelpText = "Create a HTML page visualising the Huffman tree for a document.")]
    public class VisualiseOptions
    {
        [Option('f', "filename", Required = true, HelpText = "Filename of the document to visualise.")]
        public string FileName { get; set; }
    }
}