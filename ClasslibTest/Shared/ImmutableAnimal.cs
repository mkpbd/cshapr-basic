﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasslibTest.Shared
{
    public record ImmutableAnimal
    {
        public string Name { get; init; }
        public string Species { get; init; }
        public ImmutableAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void Deconstruct(out string name, out string species)
        {
            name = Name;
            species = Species;
        }
    }
}
