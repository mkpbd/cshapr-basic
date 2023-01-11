using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Events
{
    public delegate void PriceChangedHandlers(decimal oldPrice, decimal newPrice);
    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) => this.symbol = symbol;
        public event PriceChangedHandler PriceChanged;

        public event EventHandler<PriceChangedEventArgs> PriceChangeds;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            //if (PriceChanged != null) PriceChanged(this, e);
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
