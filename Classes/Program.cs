using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Update();
            productManager.Add();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.City = "Ankara";

            Customer customer2 = new Customer {
                City = "Ankara",
                Id=2,
                FirstName="Derin",
                LastName="Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
}
