using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            Individual individual1 = new Individual();
            individual1.Id = 1;
            individual1.FirstName = "Engin";
            individual1.LastName = "Demiroğ";
            individual1.IdentityNumber = "1234567910";
            individual1.CustomerNumber = "12345";

            //Tüzel Kişi - kodlama.io
            Coorporate coorporate1 = new Coorporate();
            coorporate1.Id = 2;
            coorporate1.CompanyName = "kodlama.io";
            coorporate1.CustomerNumber = "54321";
            coorporate1.TaxId = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Customer custumor3 = new Individual();//Bellekteki referans nosu
            Customer customer4 = new Coorporate();
        }
    }
}
