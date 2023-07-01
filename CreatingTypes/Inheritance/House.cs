namespace Inheritance
{
    public class House : Asset // inherits from Asset
    {
        public decimal Mortgage;
        public static void Display(Asset asset)
        {
            System.Console.WriteLine(asset.Name);
        }
    }
}