namespace Inheritance
{
    public class House : Asset // inherits from Asset
    {
        public decimal Mortgage;
        public override decimal Liability => Mortgage;
        public static void Display(Asset asset)
        {
            System.Console.WriteLine(asset.Name);
        }

        public override House Clone() => new House
        {
            Name = Name,
            Mortgage = Mortgage
        };
    }
}