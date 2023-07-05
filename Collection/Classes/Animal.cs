using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class Animal
    {
        public string Name;
        public Zoo Zoo { get; internal set; }
        public int Popularity;
        public Animal(string name, int popularity)
        {
            Name = name; Popularity = popularity;
        }
    }
}