using LinqEFCore.DBCon;
using LinqEFCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEFCore.LinqQuery
{
    public class DatabaseQuery
    {
        public readonly NutShellContext _db;

        public void SavaData(Customer entity)
        {
            //DB.DbSet<T>(entity);
            //  DB?.SavingChanges();
            //NutShellContext db = new NutShellContext();
            //db.SavingChanges();
            //_db.Set<T>().Add(entity);

            using (var db = new NutShellContext())
            {
                db.Customers.Add(entity);
                //  db.SavingChanges();
            }


        }


        public void GetDataOrderBy()
        {
            using (var dbContext = new NutShellContext())
            {
                Customer a = dbContext.Customers.OrderBy(c => c.Name).First();
                Customer b = dbContext.Customers.OrderBy(c => c.ID).First();

                Console.WriteLine("Name " + a.Name + " Id " + b.ID);
            }

        }

        public void SaveDataBaseOnCutomerTableInPurchase()
        {
            using (var dbContext = new NutShellContext())
            {
                Customer cust = dbContext.Customers.FirstOrDefault(c => c.ID == 1);
                Purchase p1 = new Purchase { Description = "Bike", Price = 500 };
                Purchase p2 = new Purchase { Description = "Tools", Price = 100 };
                cust?.Purchases.Add(p1);
                cust?.Purchases.Add(p2);
                dbContext.SaveChanges();
            }
        }
    }
}
