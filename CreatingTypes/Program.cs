using Method;
using Objects;
using Inheritance;
using ImplementInterface;
using Interfaces;

var rect = new Rectangle(3, 4);
(float width, float height) = rect; // Deconstruction
Console.WriteLine(width + " " + height); // 3 4

// Note parameterless constructors can omit empty parentheses
Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };


// StocksManager msft = new StocksManager();
// msft.CurrentPrice = 30;
// msft.CurrentPrice -= 3;
// Console.WriteLine(msft.CurrentPrice);

Sentence s = new Sentence();
Console.WriteLine(s[3]); // fox
s[3] = "kangaroo";
Console.WriteLine(s[3]); // kangaroo



Stock msft = new Stock
{
    Name = "MSFT",
    SharesOwned = 1000
};
Console.WriteLine(msft.Name); // MSFT
Console.WriteLine(msft.SharesOwned); // 1000
House mansion = new House
{
    Name = "Mansion",
    Mortgage = 250000
};
Console.WriteLine(mansion.Name); // Mansion
Console.WriteLine(mansion.Mortgage); // 250000


House mansion1 = new House { Name = "McMansion", Mortgage = 250000 };
Asset a = mansion1;
Console.WriteLine(mansion.Liability); // 250000
Console.WriteLine(a.Liability); // 250000


Overrider over = new Overrider();
BaseClass b11 = over;
over.Foo(); // Overrider.Foo
b11.Foo(); // Overrider.Foo
Hider h = new Hider();
BaseClass b21 = h;
h.Foo(); // Hider.Foo
b21.Foo(); // BaseClass.Foo

IEnumeratorByOwn e = new Countdown();
while (e.MoveNext())
    Console.Write(e.Current); // 109876543210