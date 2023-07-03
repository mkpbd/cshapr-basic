using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Records
{
    public record Person(string Name)
    {
        string _name = Name;
        public string Name
        {
            get => _name;
            init => _name = value ?? throw new ArgumentNullException("Name");
        }
    }
}