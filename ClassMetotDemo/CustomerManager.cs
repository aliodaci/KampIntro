using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) { Console.WriteLine("Müşteri eklendi :"+customer.FirstName+" "+customer.LastName); }

        public void Listele(Customer customer) { Console.WriteLine(customer.FirstName+" "+customer.LastName+" müşteriler listelendi"); }
        public void Delete(Customer customer) { Console.WriteLine("Müşteri Silindi :"+customer.IdentityNumber); }
    }
}
