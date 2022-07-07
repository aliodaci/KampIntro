using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        //Concrete - somut, elle tutulur
        //Abstract - soyut, soyutlamak
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{ FirstName = "Ali", LastName = "Odacı", DateOfBirth = 1991, IdentityNumber = 25633864928});
        
        }
    }
}
