using Huffman.Implementation;
using Xunit;

namespace Huffman.Tests.Implementation
{
    public class PriorityQueueTests
    {
        [Fact]
        public void Blah()
        {
            var queue = new PriorityQueue<TestNode>();

            queue.Add(new TestNode { Priority = 5, Description = "Five" });
            queue.Add(new TestNode { Priority = 4, Description = "1-Four" });
            queue.Add(new TestNode { Priority = 4, Description = "3-Four" });
            queue.Add(new TestNode { Priority = 4, Description = "2-Four" });
            queue.Add(new TestNode { Priority = 6, Description = "Six" });

            Assert.Equal("1-Four", queue.PopMin().Description);
            Assert.Equal("2-Four", queue.PopMin().Description);
            Assert.Equal("3-Four", queue.PopMin().Description);
            Assert.Equal("Five", queue.PopMin().Description);
            Assert.Equal("Six", queue.PopMin().Description);
        }
    }

    internal class TestNode
    {
        [Priority] 
        public int Priority { get; set; }

        [SecondarySort]
        public string Description { get; set; }
    }
}