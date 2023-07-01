namespace Inheritance
{
    public class House : Asset // inherits from Asset
    {
        public decimal Mortgage;
        public override decimal Liability => Mortgage;

        public override decimal NetValue { get; }

        // public override decimal Liability1 => base.Liability + Mortgage;
        public static void Display(Asset asset)
        {
            System.Console.WriteLine(asset.Name);
        }

        // public override House Clone() => new House
        // {
        //     Name = Name,
        //     Mortgage = Mortgage
        // };

        public House Clone() => new House
        {
            Name = Name,
            Mortgage = Mortgage
        };
    }
}