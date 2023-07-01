namespace Inheritance
{
    public class Stock : Asset // inherits from Asset
    {
        public long SharesOwned;
        public override decimal Liability => SharesOwned;

        // Override like a virtual method.
        public override decimal NetValue => CurrentPrice * SharesOwned;
        public static void Display(Asset asset)
        {
            System.Console.WriteLine(asset.Name);
        }
    }
}