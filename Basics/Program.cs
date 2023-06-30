using TypeBasics;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10);

int x = 3; // Comment about assigning 3 to x

UnitConverter feetToInchesConverter = new UnitConverter(12);
UnitConverter milesToFeetConverter = new UnitConverter(5280);
Console.WriteLine(feetToInchesConverter.Convert(30)); // 360
Console.WriteLine(feetToInchesConverter.Convert(100)); // 1200
Console.WriteLine(feetToInchesConverter.Convert(
milesToFeetConverter.Convert(1))); // 63360

Panda p1 = new Panda("Pan Dee");
Panda p2 = new Panda("Pan Dah");
Console.WriteLine(p1.Name); // Pan Dee
Console.WriteLine(p2.Name); // Pan Dah
Console.WriteLine(Panda.Population); // 2