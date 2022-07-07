using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();
        }
    }

    //interface de yarım operasyon herşey tamamlanmamış kısımdır.
    //
    class CustomerManager
    {
        public void Add() { }
        public void Delete() { }
    }

    //abstract hem tamamlanmış hem tamamlanmamış operasyon içeren class'dır.
    //Sınıf yapısına sahiptir.
    //ortak olan operasyonlar ve ortak olmayan operasyomlar olabilir.
    //ortak olmayan operasyonlar imza şeklinde yazılır. abstractlar da
    //abstract sınıflar new'lenemez
    //bir sınıf tek bir sınıfı inherit edebilir. bir sınıf sadece bir abstract sınıfı inherit edebilir. Başka hiç bir sınıfı inherit edemez.
    //constructer bloğu içerebilir.
    //protected olması gerekir. İnherit edildiği yerde çalıştırıldığı için daha doğru yazımdır.
    //

    abstract class MevzuatBase
    {
        protected MevzuatBase()
        {

        }
        public abstract void Degerlendir();

        public void Kaydet() { }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatı ile değerlendirildi");
        }
    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B Mevzuat ile değerlendirildi.");
        }
    }
}
