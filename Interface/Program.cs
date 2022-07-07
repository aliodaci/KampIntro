using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //İNTERFACELER NEW LENEMEZ
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Adress = "Ankara" };

            Student student = new Student() { Id = 2, FirstName = "Derin", LastName = "Demiroğ", Depermant = "Computer Sciences" };
            personManager.Add(customer);
            personManager.Add(student);

            
        }
    }
}
