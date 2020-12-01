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

        public VisualisationHandler(VisualiseOptions options)
        {
            _options = options;
        }

        public void Execute()
        {
            var file = File.ReadAllText(_options.FileName);

            var frequencyCalculator = new FrequencyCalculator();

            var frequencies = frequencyCalculator.GetFrequencies(file);

            var tree = new HuffmanTree();

            tree.Build(frequencies);

            _visualisation = File.ReadAllText("Supporting Files\\Template.html");

            _visualisation = _visualisation.Replace("{css}", File.ReadAllText("Supporting Files\\Styles.css"));

            _visualisation = _visualisation.Replace("{nodes}", ProcessNode(tree.Root));

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
            var innerHtml = NodeTemplate.Replace("{content}", node.Frequency.ToString());

            if (node.Left != null)
            {
                innerHtml = innerHtml.Replace("{left}", ProcessNode(node.Left));
            }

            if (node.Right != null)
            {
                innerHtml = innerHtml.Replace("{right}", ProcessNode(node.Right));
            }

            return innerHtml;
        }

        private const string NodeTemplate = "<ul><li><a href='#'>{content}</a>{left}{right}</li></ul>";
    }
}