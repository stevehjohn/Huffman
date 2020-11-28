using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Huffman.Infrastructure
{
    public class PriorityQueue<T>
    {
        private readonly List<T> _items;

        private readonly PropertyInfo _priorityProperty;

        public int Length => _items.Count;

        public PriorityQueue()
        {
            _items = new List<T>();

            _priorityProperty = typeof(T).GetProperties().Single(p => Attribute.IsDefined(p, typeof(PriorityAttribute)));
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T PopMin()
        {
            // TODO: This works, but I don't like it. (int) should be a variant type.
            var item = _items.First(i => (int) _priorityProperty.GetValue(i) == (int) _items.Min(x => _priorityProperty.GetValue(x)));

            _items.Remove(item);

            return item;
        }
    }
}