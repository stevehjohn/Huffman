using Huffman.Implementation;

namespace Huffman.Models;

public class HuffmanNode
{
    [SecondarySort]
    public char Character { get; set; }

    [Priority]
    public int Frequency { get; set; }

    public HuffmanNode Left { get; set; }

    public HuffmanNode Right { get; set; }

    public HuffmanNode Parent { get; set; }
}