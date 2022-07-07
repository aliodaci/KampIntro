using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ali";
            customer.LastName = "Odacı";
            customer.IdentityNumber = "1234567890";


            Customer customer1 = new Customer();
            customer.Id = 2;
            customer1.FirstName = "Selin";
            customer1.LastName = "Odacı";
            customer1.IdentityNumber = "2345678910";

            Customer[] customers = new Customer[] { customer, customer1 };
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.IdentityNumber);
                Console.WriteLine("--------------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer1);
            Console.WriteLine("--------------------");
            customerManager.Listele(customer);
            customerManager.Listele(customer1);
            Console.WriteLine("---------------------");
            customerManager.Delete(customer);
            Console.WriteLine("------------------------");
            Console.WriteLine("Hello World!");
        }
    }
}
