## Collections

.NET provides a standard set of types for storing and managing collections of objects. These include resizable lists, linked lists, sorted and unsorted dictionaries, and arrays.

 Of these, only arrays form part of the C# language; the remaining collections are just classes you instantiate like any other.

1. Interfaces that define standard collection protocols
2. Ready-to-use collection classes (lists, dictionaries, etc.)
3. Base classes for writing application-specific collections

![1688395828072](image/readme/1688395828072.png)

**Enumeration**

In computing, there are many different kinds of collections, ranging from simple data structures, such as arrays or linked lists, to more complex ones, such as red/black trees and hashtables.

Although the internal implementation and external characteristics of these data structures vary widely, the ability to traverse the contents of the collection is an almost universal need. The .NET
BCL supports this need via a pair of interfaces (IEnumerable, IEnumerator, and their generic counterparts) that allow different data structures to expose a common traversal API. These are part of a larger set of
collection interfaces illustrated

![1688395935836](image/readme/1688395935836.png)

**IEnumerable and IEnumerator**

The IEnumerator interface defines the basic low-level protocol by which elements in a collection are traversed—or enumerated—in a forward-only manner.

```csharp
public interface IEnumerator
{
bool MoveNext();
object Current { get; }
void Reset();
}
```

**IEnumerable `<T>` and IDisposable**

IEnumerator `<T>` inherits from IDisposable. This allows enumerators to hold references to resources such as database connections—and ensure that those resources are released when enumeration is complete.

**The ICollection and IList Interfaces**

Although the enumeration interfaces provide a protocol for forward-only iteration over a collection, they don’t provide a mechanism to determine the size of the collection, access a member by index, search, or modify the collection. For such functionality, .NET defines the ICollection, IList, and IDictionary interfaces. Each comes in both generic and nongeneric versions; however, the nongeneric versions exist mostly for legacy support.

**IEnumerable `<T>` (and IEnumerable)**Provides minimum functionality (enumeration only)
**ICollection `<T>` (and ICollection)** Provides medium functionality (e.g., the Count property)
**IList `<T>`/IDictionary<K,V>** and their nongeneric versions Provide maximum functionality (including “random” access by index/key)

**ICollection `<T>` and ICollection**

ICollection `<T>` is the standard interface for countable collections of objects. It provides the ability to determine the size of a collection (Count), determine whether an item exists in the collection (Contains), copy the collection into an array (ToArray), and determine whether the collection is read-only (IsReadOnly). For writable collections, you can also Add, Remove, and Clear items from the collection. And because it extends IEnumerable `<T>`, it can also be traversed via the foreach statement:

```csharp
public interface ICollection<T> : IEnumerable<T>, IEnumerable
{
int Count { get; }
bool Contains (T item);
void CopyTo (T[] array, int arrayIndex);
bool IsReadOnly { get; }
void Add(T item);
bool Remove (T item);
void Clear();
}
```

**IList `<T>` and IList**

IList `<T>` is the standard interface for collections indexable by position. In addition to the functionality inherited from ICollection `<T>` and IEnumerable `<T>`, it provides the ability to read or write an element by position (via an indexer) and insert/remove by position:

```csharp
public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
T this [int index] { get; set; }
int IndexOf (T item);
void Insert (int index, T item);
void RemoveAt (int index);
}
```

```csharp
public interface IList : ICollection, IEnumerable
{
object this [int index] { get; set }
bool IsFixedSize { get; }
bool IsReadOnly { get; }
int Add (object value);
void Clear();
bool Contains (object value);
int IndexOf (object value);
void Insert (int index, object value);
void Remove (object value);
void RemoveAt (int index);
}
```

**IReadOnlyCollection `<T>` and IReadOnlyList `<T>`**

.NET also defines collection and list interfaces that expose just the members required for read-only operations:

```csharp
public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable
{
    int Count { get; }
}
public interface IReadOnlyList<out T> : IReadOnlyCollection<T>,
IEnumerable<T>, IEnumerable
{
   T this[int index] { get; }
}
```

Because the type parameter for these interfaces is used only in output positions, it’s marked as covariant. This allows a list of cats, for instance, to be treated as a read-only list of animals. In contrast, T is not marked as covariant with ICollection `<T>` and IList `<T>`, because T is used in both input and output positions.

*These interfaces represent a read-only view of a collection or list; the underlying implementation
might still be writable. Most of the writable (mutable) collections implement both the read-only and read/write interfaces*
