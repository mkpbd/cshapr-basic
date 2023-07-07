using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEFCore.Model
{
    public class Purchase
    {
        [Key]
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CustomerID { get; set; } // Foreign key field
        public Customer Customer { get; set; } // Parent navigation property
    }
}
