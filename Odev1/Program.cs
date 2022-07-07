using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Kırmızı Gömlek";

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Pantolan";

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "Casper Notebook";

            Product product4 = new Product();
            product4.Id = 1;
            product4.ProductName = "Apple Telefon";

            Product[] products = new Product[] { product1, product2, product3, product4 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id + " = " + products[i].ProductName);
            }
            Console.WriteLine("---------------------------------------");
            foreach (var product in products)
            {
                Console.WriteLine(product.Id+" : "+product.ProductName);
            }
            Console.WriteLine("----------------------------------------");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].Id+" : "+products[j].ProductName);
                j++;
            }
            Console.WriteLine("Hello World!");
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
