using AdvanceCshapr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCshapr.Classes
{
    public class Foo : IFoo
    {
        public event EventHandler ev;

        event EventHandler IFoo.Ev
        {
            add { ev += value; }
            remove { ev -= value; }
        }

       
    }
}
