using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(7,"feyza");
            myDictionary.Add(10, "yılmaz");
            myDictionary.Add(12, "asil");
            Console.WriteLine(myDictionary.Length);

        }
    }
}
