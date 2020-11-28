using Huffman.Infrastructure;
using Xunit;

namespace Huffman.Tests.Infrastructure
{
    public class PriorityQueueTests
    {
        [Fact]
        public void Blah()
        {
            var queue = new PriorityQueue<TestNode>();

            queue.Add(new TestNode { Priority = 5, Description = "Five" });
            queue.Add(new TestNode { Priority = 4, Description = "Four" });
            queue.Add(new TestNode { Priority = 6, Description = "Six" });

            Assert.Equal("Four", queue.PopMin().Description);
            Assert.Equal("Five", queue.PopMin().Description);
            Assert.Equal("Six", queue.PopMin().Description);
        }
    }

    internal class TestNode
    {
        [Priority] 
        public int Priority { get; set; }

        public string Description { get; set; }
    }
}