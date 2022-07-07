using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(121, "Ali ODACI");
            myDictionary.Add(126, "Selin Çelik");
            myDictionary.Add(132, "Anıl ÇELİK");

            Console.WriteLine(myDictionary.Count);
            Console.WriteLine("------------------------------");
            foreach (var item in myDictionary.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            foreach (var key in myDictionary.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] tempKeyArray = keys;
            TValue[] tempValueArray = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i< tempValueArray.Length; i++)
            {
                values[i] = tempValueArray[i];
            }
            values[values.Length - 1] = value;
        }


        public int Count
        {
            get { return keys.Length; }
        }

        public TValue[] Values
        {
            get { return values; }
        }


        public TKey[] Keys
        {
            get { return keys; }
        }

    }
}
