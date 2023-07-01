using Method;
using Objects;


var rect = new Rectangle(3, 4);
(float width, float height) = rect; // Deconstruction
Console.WriteLine(width + " " + height); // 3 4

// Note parameterless constructors can omit empty parentheses
Bunny b1 = new Bunny { Name = "Bo", LikesCarrots = true, LikesHumans = false };
Bunny b2 = new Bunny("Bo") { LikesCarrots = true, LikesHumans = false };


Stock msft = new Stock();
msft.CurrentPrice = 30;
msft.CurrentPrice -= 3;
Console.WriteLine(msft.CurrentPrice);

Sentence s = new Sentence();
Console.WriteLine(s[3]); // fox
s[3] = "kangaroo";
Console.WriteLine(s[3]); // kangaroo