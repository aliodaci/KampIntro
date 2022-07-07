using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(120, "Ali Odacı");
            ogrenci.Add(130, "Selin Odacı");
            ogrenci.Add(135, "Anıl Çelik");
            ogrenci.Add(133, "Mustafa Odacı");

            foreach (var item in ogrenci)
            {
                Console.WriteLine(item.Value);
            }

            bool containsKey = ogrenci.ContainsKey(138);
            //ContainsValue
            Console.WriteLine(containsKey);

            var elemanSayisi = ogrenci.Count;
            Console.WriteLine(elemanSayisi);

            bool silindiMi = ogrenci.Remove(135);
            Console.WriteLine(silindiMi);
            //-----------------------------------------
            Console.WriteLine("---------------------------------------");
            Dictionary<int, string>.KeyCollection AnahtarListesi = ogrenci.Keys;//ogrenci.Values
            foreach (var anahtar in AnahtarListesi)
            {
                Console.WriteLine(anahtar);
            }

            Console.WriteLine("------------------------------------------------");
            foreach (KeyValuePair<int, string> veri in ogrenci)
            {
                Console.WriteLine("Numara:{0} - İsim :{1}",veri.Key,veri.Value);
            }
        }
    }
}
