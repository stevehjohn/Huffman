using System.Diagnostics.CodeAnalysis;
using CommandLine;
using Huffman.Console.Handlers;
using Huffman.Console.Options;

namespace Huffman.Console.Infrastructure
{
    [ExcludeFromCodeCoverage]
    public static class EntryPoint
    {
        public static void Main(string[] arguments)
        {
            Parser.Default.ParseArguments<VisualiseOptions>(arguments)
                  .WithParsed(o => new VisualisationHandler(o).Execute());
        }
    }
}