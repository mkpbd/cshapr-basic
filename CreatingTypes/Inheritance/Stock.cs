namespace Inheritance
{
    public class Stock : Asset // inherits from Asset
    {
        public long SharesOwned;
        public static void Display(Asset asset)
        {
            System.Console.WriteLine(asset.Name);
        }
    }
}