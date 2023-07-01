namespace Inheritance
{

    public abstract class Asset
    {
        public string Name;
        public virtual decimal Liability => 0; // Expression-bodied property

        // Note empty implementation
        public abstract decimal NetValue { get; }

    }
}