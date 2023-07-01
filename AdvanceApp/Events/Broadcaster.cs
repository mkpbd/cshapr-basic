using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceApp.Events
{
    // Delegate definition
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    public class Broadcaster
    {
        // Event declaration
        public event PriceChangedHandler PriceChanged;
    }
}