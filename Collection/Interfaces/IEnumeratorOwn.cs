using System;


namespace Collection.Interfaces
{
    public interface IEnumeratorOwn
    {
        public bool MoveNext();
        public object Current { get; }
        public void Reset();
    }
}