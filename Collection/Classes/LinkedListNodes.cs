using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public abstract class LinkedListNodes<T>
    {
        public LinkedList<T> List { get; }
        public LinkedListNode<T> Next { get; }
        public LinkedListNode<T> Previous { get; }
        public T Value { get; set; }
        public abstract void AddFirst(LinkedListNode<T> node);
        public abstract LinkedListNode<T> AddFirst(T value);
        public abstract void AddLast(LinkedListNode<T> node);
        public abstract LinkedListNode<T> AddLast(T value);
        public abstract void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode);
        public abstract LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value);
        public abstract void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode);
        public abstract LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value);
        public abstract void Clear();
        public abstract void RemoveFirst();
        public abstract void RemoveLast();
        public abstract bool Remove(T value);
        public abstract void Remove(LinkedListNode<T> node);
    }
}