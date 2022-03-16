using System;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(61,"Trabzon");
            cities.Add(35, "İzmir");
            cities.Add(34, "İstanbul");
            cities.Add(16, "Bursa");
            cities.Add(06, "Ankara");
            cities.Add(21, "Diyarbakır");

            Console.WriteLine("Tüm Şehirler ;");
            cities.ShowAll();
        }
    }
}
