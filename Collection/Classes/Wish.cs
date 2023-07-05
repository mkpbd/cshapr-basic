using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class Wish
    {
        public string Name;
        public int Priority;
        public Wish(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }
    }
}