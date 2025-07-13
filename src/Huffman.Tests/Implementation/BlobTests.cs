using Huffman.Implementation;
using Xunit;

namespace Huffman.Tests.Implementation;

public class BlobTests
{
    [Fact]
    public void Append_correctly_adds_variable_length_items()
    {
        var blob = new Blob();

        blob.Append("10010");

        Assert.Equal(144, blob.ToByteArray()[0]);
        Assert.Single(blob.ToByteArray());

        blob.Append("111");

        Assert.Equal(151, blob.ToByteArray()[0]);
        Assert.Single(blob.ToByteArray());

        blob.Append("01");

        Assert.Equal(151, blob.ToByteArray()[0]);
        Assert.Equal(64, blob.ToByteArray()[1]);
        Assert.Equal(2, blob.ToByteArray().Length);

        blob.Append("000001");

        Assert.Equal(151, blob.ToByteArray()[0]);
        Assert.Equal(65, blob.ToByteArray()[1]);
        Assert.Equal(2, blob.ToByteArray().Length);
    }
}