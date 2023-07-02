using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Events
{
    public delegate void PriceChangedHandlerDel(decimal oldPrice, decimal newPrice);

    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) => this.symbol = symbol;
        public event EventHandler<PriceChangedEventArgs> PriceChangedEvArg;
        public event PriceChangedHandlerDel PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            if (PriceChanged != null) PriceChangedEvArg(this, e);
        }
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