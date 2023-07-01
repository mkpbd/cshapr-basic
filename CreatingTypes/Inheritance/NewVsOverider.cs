namespace Inheritance
{
    public class BaseClass
    {
        public virtual void Foo() { Console.WriteLine("BaseClass.Foo"); }
    }
    public class Overrider : BaseClass
    {
        public override void Foo() { Console.WriteLine("Overrider.Foo"); }
    }
    public class Hider : BaseClass
    {
        public new void Foo() { Console.WriteLine("Hider.Foo"); }
    }
}