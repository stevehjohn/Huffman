using System;
using System.Collections.Generic;
using System.Linq;

namespace Huffman.Implementation
{
    public class PriorityQueue<T, TP, TS> where TP : struct
    {
        private readonly List<T> _items;

        private static readonly Func<T, TP> _priorityPropertyDelegate = (Func<T, TP>) Delegate.CreateDelegate(typeof(Func<T, TP>), typeof(T).GetProperties().Single(p => Attribute.IsDefined(p, typeof(PriorityAttribute))).GetGetMethod());
        private static readonly Func<T, TS> _sortPropertyDelegate = (Func<T, TS>) Delegate.CreateDelegate(typeof(Func<T, TS>), typeof(T).GetProperties().Single(p => Attribute.IsDefined(p, typeof(SecondarySortAttribute))).GetGetMethod());

        public int Length => _items.Count;

        public PriorityQueue()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T PopMin()
        {
            var item = _items.MinBy(i => (_priorityPropertyDelegate(i), _sortPropertyDelegate(i)));

            _items.Remove(item);

            return item;
        }
    }
}