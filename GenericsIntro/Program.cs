using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Feyza");
            Console.WriteLine(isimler.Length);
            isimler.Add("Yılmaz");
            Console.WriteLine(isimler.Length);
        }
    }
}
