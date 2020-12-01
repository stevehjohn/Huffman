using System.Collections.Generic;
using System.IO;
using Huffman.Implementation;
using Huffman.Models;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Huffman.Tests.Implementation
{
    public class HuffmanTreeTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly HuffmanTree _tree;

        public HuffmanTreeTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;

            _tree = new HuffmanTree();

            var frequencies = GetFrequencies();

            _tree.Build(frequencies);
        }

        [Fact]
        public void Build_creates_expected_tree()
        {

            Assert.Equal('\0', _tree.Root.Character);
            Assert.Equal('\0', _tree.Root.Left.Character);
            Assert.Equal('\0', _tree.Root.Left.Left.Character);
            Assert.Equal('\0', _tree.Root.Left.Left.Left.Character);
            Assert.Equal('\0', _tree.Root.Left.Left.Left.Left.Character);
            Assert.Equal('l', _tree.Root.Left.Left.Left.Left.Left.Character);
            Assert.Equal(1, _tree.Root.Left.Left.Left.Left.Left.Frequency);
            
            Assert.Equal('o', _tree.Root.Left.Left.Left.Left.Right.Character);
            Assert.Equal(1, _tree.Root.Left.Left.Left.Left.Right.Frequency);
            
            Assert.Equal('i', _tree.Root.Left.Right.Left.Left.Character);
            Assert.Equal(2, _tree.Root.Left.Right.Left.Left.Frequency);
            
            Assert.Equal('m', _tree.Root.Left.Right.Left.Right.Character);
            Assert.Equal(2, _tree.Root.Left.Right.Left.Right.Frequency);
        }

        [Theory]
        [InlineData('l', "00000")]
        [InlineData('o', "00001")]
        [InlineData('p', "00010")]
        [InlineData('r', "00011")]
        [InlineData('i', "0100")]
        public void GetPath_returns_expected_path(char character, string expected)
        {
            Assert.Equal(expected, _tree.GetPath(character));
        }

        [Theory]
        [InlineData("A Tale of Two Cities.txt")]
        [InlineData("Frankenstein or the Modern Prometheus.txt")]
        [InlineData("Great Expectations.txt")]
        [InlineData("Les Misérables.txt")]
        [InlineData("Pride and Prejudice.txt")]
        [InlineData("War of the Worlds.txt")]
        public void Visualise_tree(string filename)
        {
            var data = File.ReadAllText($"Test Files\\{filename}");

            var frequencyCalculator = new FrequencyCalculator();

            var frequencies = frequencyCalculator.GetFrequencies(data);

            var tree = new HuffmanTree();

            tree.Build(frequencies);

            _testOutputHelper.WriteLine(tree.ToString());
        }

        private IEnumerable<CharacterFrequency> GetFrequencies()
        {
            return new[]
                   {
                       new CharacterFrequency { Frequency = 4, Character = 'e' },
                       new CharacterFrequency { Frequency = 4, Character = 'a' },
                       new CharacterFrequency { Frequency = 7, Character = ' ' },
                       new CharacterFrequency { Frequency = 2, Character = 'n' },
                       new CharacterFrequency { Frequency = 2, Character = 't' },
                       new CharacterFrequency { Frequency = 2, Character = 'm' },
                       new CharacterFrequency { Frequency = 2, Character = 'i' },
                       new CharacterFrequency { Frequency = 2, Character = 'h' },
                       new CharacterFrequency { Frequency = 2, Character = 's' },
                       new CharacterFrequency { Frequency = 3, Character = 'f' },
                       new CharacterFrequency { Frequency = 1, Character = 'o' },
                       new CharacterFrequency { Frequency = 1, Character = 'u' },
                       new CharacterFrequency { Frequency = 1, Character = 'x' },
                       new CharacterFrequency { Frequency = 1, Character = 'p' },
                       new CharacterFrequency { Frequency = 1, Character = 'r' },
                       new CharacterFrequency { Frequency = 1, Character = 'l' }
                   };
        }
    }
}