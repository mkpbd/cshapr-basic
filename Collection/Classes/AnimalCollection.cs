using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Collection.Classes
{
    public class AnimalCollection : Collection<Animal>
    {
        // AnimalCollection is already a fully functioning list of animals.
        // No extra code is required.
        Zoo zoo;
        public AnimalCollection(Zoo zoo) { this.zoo = zoo; }
        protected override void InsertItem(int index, Animal item)
        {
            base.InsertItem(index, item);
            item.Zoo = zoo;
        }
        protected override void SetItem(int index, Animal item)
        {
            base.SetItem(index, item);
            item.Zoo = zoo;
        }
        protected override void RemoveItem(int index)
        {
            this[index].Zoo = null;
            base.RemoveItem(index);
        }
        protected override void ClearItems()
        {
            foreach (Animal a in this) a.Zoo = null;
            base.ClearItems();
        }
    }
}