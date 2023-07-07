
using LinqEFCore.DBCon;
using LinqEFCore.LinqQuery;
using LinqEFCore.Model;

namespace LinqEFCore
{
    internal class Program
    {


        static void Main(string[] args)
        {

              DatabaseQuery databaseQuery = new DatabaseQuery();
            //databaseQuery.GetDataOrderBy();
            databaseQuery.SaveDataBaseOnCutomerTableInPurchase();

            Console.Read();
        }
    }
}