using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class Zoo // The class that will expose AnimalCollection.
    { // This would typically have additional members.
        public readonly AnimalCollection Animals;
        public Zoo() { Animals = new AnimalCollection(this); }
    }
}