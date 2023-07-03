using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Evn
{
    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) => this.symbol = symbol;
        public event PriceChangedHandler PriceChanged;
        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return; // Exit if nothing has changed
                decimal oldPrice = price;
                price = value;
                if (PriceChanged != null) // If invocation list not
                    PriceChanged(oldPrice, price); // empty, fire event.
            }
        }
    }
}