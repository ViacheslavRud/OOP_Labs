using System.Collections.Generic;

namespace Lab6
{
    public interface ILinkedList<T> : IEnumerable<T>
    {
        void AddLast(T item);
        void AddFirst(T item);
        void AddAfter(T item, int afterItem);
        T this[int index] { get; set; }
    }
}