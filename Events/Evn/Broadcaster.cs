using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Evn
{
    public class Broadcaster
    {
        private dynamic priceChanged = 0;
        // Event declaration
        public event PriceChangedHandler PriceChanged;
        public event PriceChangedHandler PriceChanged1
        {
            add { priceChanged += value; }
            remove { priceChanged -= value; }
        }

        public event EventHandler<PriceChangedEventArgs> PriceChanged3;
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            if (PriceChanged3 != null) PriceChanged3(this, e);
        }
    }
}