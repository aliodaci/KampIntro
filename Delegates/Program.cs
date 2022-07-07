using System;

namespace Delegates
{
    public delegate void MyDelegated();//delegate: herhangi bir dönüş değeri olmayan (void) methodları ve parametre almayan operasyonlara delegate'lik yapıyor
    public delegate void MyDelegated2(string text);//parametre alarak delegate
    public delegate int MyDelegated3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
           // customerManager.SendMessage();
           // customerManager.ShowAlert();

            MyDelegated myDelegated = customerManager.SendMessage;
            myDelegated += customerManager.ShowAlert;
            myDelegated -= customerManager.SendMessage;
            //myDelegated();

            MyDelegated2 myDelegated2 = customerManager.SendMessage2;
            myDelegated2 += customerManager.ShowAlert2;
           // myDelegated2("Hello");

            Matematik matematik = new Matematik();
            MyDelegated3 myDelegated3 = matematik.Topla;
            myDelegated3 += matematik.Carp;
            var sonuc=myDelegated3(6, 9);
            Console.WriteLine(sonuc);
            

        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine("Be Careful!");
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }

}
