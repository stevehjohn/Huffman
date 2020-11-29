using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Huffman.Implementation
{
    public class PriorityQueue<T, TP> where TP : struct
    {
        private readonly List<T> _items;

        private readonly PropertyInfo _priorityProperty;
        private readonly PropertyInfo _sortProperty;

        public int Length => _items.Count;

        public PriorityQueue()
        {
            _items = new List<T>();

            _priorityProperty = typeof(T).GetProperties().Single(p => Attribute.IsDefined(p, typeof(PriorityAttribute)));
            _sortProperty = typeof(T).GetProperties().Single(p => Attribute.IsDefined(p, typeof(SecondarySortAttribute)));
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T PopMin()
        {
            var min = Convert.ChangeType(_items.Min(i => _priorityProperty.GetValue(i)), typeof(TP));

            var items = _items.Where(i => GetPriorityPropertyValue(i).Equals(min));

            var item = items.OrderBy(i => _sortProperty.GetValue(i)).First();

            _items.Remove(item);

            return item;
        }

        private TP GetPriorityPropertyValue(T input)
        {
            var value =_priorityProperty.GetValue(input);

            try
            {
                return (TP) value;
            }
            catch
            {
                throw new InvalidCastException($"Cannot cast priority property {_priorityProperty.Name} to {typeof(TP).Name}.");
            }
        }
    }
}