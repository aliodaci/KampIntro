﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yasi = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" = "+kurs.Egitmen);
            }

            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi+" : "+kurslar[i].Egitmen);
            }

            Console.WriteLine("Hello World!");
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
