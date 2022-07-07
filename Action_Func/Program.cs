using System;
using System.Threading;

namespace Action_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //try
            //{
            //    Find();
            //}
            //catch (RecordNotFoundException exception)
            //{

            //    Console.WriteLine(exception.Message);
            //}

            //HandleException(() =>
            //{

            //    Find();

            //});
            #endregion

            //Func<int, int, int> add = Topla;
            //Console.WriteLine(add(3,5));
           // Console.WriteLine(Topla(5,3));

            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);

            };
            Console.WriteLine(getRandomNumber());

            Thread.Sleep(1000);
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2);
        }

        private int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }

        private static void Find()
        {

        }
    }

}
