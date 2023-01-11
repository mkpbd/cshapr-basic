using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Events
{
    // Delegate definition
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    public class Broadcaster
    {
        // Event declaration
        //public event PriceChangedHandler PriceChanged;

        PriceChangedHandler priceChanged; // private delegate

        public event PriceChangedHandler PriceChanged
        {
            add { priceChanged += value; }
            remove { priceChanged -= value; }
        }


    }
}
