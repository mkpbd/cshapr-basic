using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEFCore.Model
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        // Child navigation property, which must be of type ICollection<T>:
        public virtual List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
