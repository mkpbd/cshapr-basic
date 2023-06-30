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


Point p11 = new Point();
p11.X = 7;
Point p21 = p11; // Assignment causes copy
Console.WriteLine(p11.X); // 7
Console.WriteLine(p21.X); // 7
p11.X = 9; // Change p1.X
Console.WriteLine(p11.X); // 9
Console.WriteLine(p21.X); // 7