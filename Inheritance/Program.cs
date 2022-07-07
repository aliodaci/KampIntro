using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Person[] persons =
            {
                new Customer{ FirstName="Engin"},
                new Student{ FirstName="Derin"},
                new Person{ FirstName="Ali"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
