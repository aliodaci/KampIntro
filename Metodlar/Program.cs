using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do not repeat yourself -DRY -Clean code /Best practice

            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "starking kırmızı elma";

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Detail = "Kırmızı Elma";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 30;
            product2.Detail = "Diyarbakır karpuzu harika";

            Product[] products = new Product[] {product1,product2};

            //type -safe - güvenli tip
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Detail);
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("---------------MEtodlar----------------");
            //instance - örnek
            //encapsulation

            SepetManager sepet = new SepetManager();
            sepet.Ekle(product1);
            sepet.Ekle(product2);
        }
    }
}
