using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Huffman.Console.Options;
using Huffman.Implementation;
using Huffman.Models;

namespace Huffman.Console.Handlers
{
    [ExcludeFromCodeCoverage]
    public class VisualisationHandler
    {
        private readonly VisualiseOptions _options;

        private string _visualisation;
        
        private const string NodeTemplate = "<li><a href='#'>{frequency}</a><ul>{left}{right}</ul></li>";

        private const string LeafTemplate = "<li><a href='#' class='leaf'>{frequency}<br/><span class='character'>{character}</span></a></li>";

        public VisualisationHandler(VisualiseOptions options)
        {
            _options = options;
        }

        public void Execute()
        {
            var file = "This is a simple text string to test things."; //File.ReadAllText(_options.FileName);

            var frequencyCalculator = new FrequencyCalculator();

            var frequencies = frequencyCalculator.GetFrequencies(file);

            var tree = new HuffmanTree();

            tree.Build(frequencies);

            _visualisation = File.ReadAllText("Supporting Files\\Template.html");

            _visualisation = _visualisation.Replace("{document}", Path.GetFileName(_options.FileName));

            _visualisation = _visualisation.Replace("{css}", File.ReadAllText("Supporting Files\\Styles.css"));

            _visualisation = _visualisation.Replace("{nodes}", $"<ul>{ProcessNode(tree.Root)}</ul>");

            var tempFile = Path.GetTempFileName().Replace(".tmp", ".html");

            File.WriteAllText(tempFile, _visualisation);

            Process.Start(new ProcessStartInfo
                          {
                              FileName = tempFile,
                              UseShellExecute = true
                          });
        }

        private static string ProcessNode(HuffmanNode node)
        {
            var innerHtml = node.Character == '\0'
                ? NodeTemplate.Replace("{frequency}", node.Frequency.ToString())
                : LeafTemplate.Replace("{frequency}", node.Frequency.ToString()).Replace("{character}", node.Character.ToString());

            innerHtml = innerHtml.Replace("{left}", node.Left != null 
                ? ProcessNode(node.Left) 
                : string.Empty);

            innerHtml = innerHtml.Replace("{right}", node.Right != null 
                ? ProcessNode(node.Right) 
                : string.Empty);
            
            return innerHtml;
        }
    }
}