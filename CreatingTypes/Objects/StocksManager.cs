namespace Objects
{
    public class StocksManager
    {
        decimal currentPrice; // The private "backing" field
        public decimal CurrentPrice // The public property
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }
        decimal sharesOwned;
        public decimal Worth
        {
            get { return currentPrice * sharesOwned; }
            set => sharesOwned = value / currentPrice;
        }
        public decimal CurrentPrice1 { get; set; }
        public decimal CurrentPrice2 { get; set; } = 123;
        public int Maximum { get; } = 999;
        private decimal x;
        public decimal X
        {
            get { return x; }
            private set { x = Math.Round(value, 2); }
        }
    }
}