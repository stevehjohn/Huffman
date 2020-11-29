using System;
using Huffman.Implementation;
using Xunit;

namespace Huffman.Tests.Implementation
{
    public class PriorityQueueTests
    {
        [Fact]
        public void PopMin_returns_items_in_the_correct_order()
        {
            var queue = new PriorityQueue<TestNode, int>();

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

        [Fact]
        public void PopMin_throws_exception_when_unable_to_cast_priority_property()
        {
            var queue = new PriorityQueue<TestNode, bool>();

            queue.Add(new TestNode { Priority = 5, Description = "Five" });

            Assert.Throws<InvalidCastException>(() => queue.PopMin());
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