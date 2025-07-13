using Huffman.Implementation;
using Xunit;

namespace Huffman.Tests.Implementation;

public class BitReaderTests
{
    [Fact]
    public void Read_returns_bits_in_expected_order()
    {
        var reader = new BitReader(new byte [] { 235, 226, 190, 56 });

        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.False(reader.Read());
        Assert.True(reader.Read());
        Assert.False(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());

        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.False(reader.Read());
        Assert.False(reader.Read());
        Assert.False(reader.Read());
        Assert.True(reader.Read());

        Assert.False(reader.Read());
        Assert.True(reader.Read());
        Assert.False(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());

        Assert.False(reader.Read());
        Assert.False(reader.Read());
        Assert.False(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.True(reader.Read());
        Assert.False(reader.Read());
        Assert.False(reader.Read());
    }
}