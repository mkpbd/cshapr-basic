## Events

Create   Constole  project

 dotnet new console -g projectName

run dotnet application

dotnet run project name OR dotnet run build .csproj

When using delegates, two emergent roles commonly appear: broadcaster and subscriber.
The broadcaster is a type that contains a delegate field. The broadcaster decides when to broadcast, by invoking the delegate.

The subscribers are the method target recipients. A subscriber decides when to start and stop listening by calling += and -= on the broadcaster's delegate.  A subscriber does not know about, or interfere with, other subscribers.

The easiest way to declare an event is to put the event keyword in front of a delegate member:

```csharp
// Delegate definition
public delegate void PriceChangedHandler (decimal oldPrice, decimal newPrice);
public class Broadcaster
{
string symbol;
decimal price;
// Event declaration
public event PriceChangedHandler PriceChanged;
public decimal Price
{
  get => price;
  set
   {
     if (price == value) return; // Exit if nothing has changed
     decimal oldPrice = price;
     price = value;
     if (PriceChanged != null) // If invocation list not
      PriceChanged (oldPrice, price); // empty, fire event.
     }
   }
}
```

Code within the Broadcaster type has full access to PriceChanged and can treat it as a delegate. Code outside of Broadcaster can perform only += and -= operations on the PriceChanged event.

Replace other subscribers by reassigning PriceChanged (instead of using the += operator).

Clear all subscribers (by setting **PriceChanged** to **null**).

Broadcast to other subscribers by invoking the delegate.
