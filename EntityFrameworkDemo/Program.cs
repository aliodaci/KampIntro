using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        //ADO.NET
        //Entity Framework -- Bir ORM - Object relational mapping
        //NHibernate
        //Dapper

        static void Main(string[] args)
        {
            //GetAll();
            //GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            foreach (var item in context.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }
        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext context = new NorthwindContext();
            var result = context.Products.Where(p => p.CategoryId == categoryId);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
