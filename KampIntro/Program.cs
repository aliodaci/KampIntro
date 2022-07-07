using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip gücenliği
            //do not repeat yourselft - kendini tekrarlama
            //değişken tutucu -alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 3200;
            double faizOranİ = 1.45;
            bool sistemGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir.");
            }

            if (sistemGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
