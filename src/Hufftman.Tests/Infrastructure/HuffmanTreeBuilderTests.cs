using System.Collections.Generic;
using Huffman.Infrastructure;
using Huffman.Models;
using Xunit;

namespace Huffman.Tests.Infrastructure
{
    public class HuffmanTreeBuilderTests
    {
        [Fact]
        public void Builds_tree_as_expected()
        {
            var items = new List<CharacterFrequency>
                        {
                            new CharacterFrequency
                            {
                                Frequency = 4,
                                Character = 'e'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 4,
                                Character = 'a'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 7,
                                Character = ' '
                            },
                            new CharacterFrequency
                            {
                                Frequency = 2,
                                Character = 'n'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 2,
                                Character = 't'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 2,
                                Character = 'm'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 2,
                                Character = 'i'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 2,
                                Character = 'h'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 2,
                                Character = 's'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 3,
                                Character = 'f'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 1,
                                Character = 'o'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 1,
                                Character = 'u'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 1,
                                Character = 'x'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 1,
                                Character = 'p'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 1,
                                Character = 'r'
                            },
                            new CharacterFrequency
                            {
                                Frequency = 1,
                                Character = 'l'
                            },
                        };

            var result = HuffmanTreeBuilder.BuildHuffmanTree(items);
        }
    }
}