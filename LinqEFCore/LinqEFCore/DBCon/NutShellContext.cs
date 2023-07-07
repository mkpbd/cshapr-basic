using LinqEFCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEFCore.DBCon
{
    public class NutShellContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SERVER\MSSQLSERVER01;Database=NutshellDB;Trusted_Connection=True;");
        }

       
    }
}
