using System;
using System.Reflection;

namespace Reflection
{
    //reflection :çalışma anında nesneler hakkında bilgi almak ve istersek bu nesneleri çalıştırabilmek
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(22,23);
            //Console.WriteLine(dortIslem.Topla2()); 
            //Console.WriteLine(dortIslem.Topla(5,6));

            var tip = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);//-- obje döndürür.
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 5);
            // Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine( methodInfo.Invoke(instance, null));

            var methodlar = tip.GetMethods();
            foreach (var info in methodlar)
            {
                Console.WriteLine("Method adı: {0}", info.Name);
                foreach (var parametreInfo in info.GetParameters())
                {
                    Console.WriteLine("PArametre : {0}",info.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }

        }
    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}
