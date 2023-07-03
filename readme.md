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
