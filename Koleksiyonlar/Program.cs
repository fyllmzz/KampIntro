using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //toplu yorum satırı: ctr+k+c

            //string[] isimler = new string[] { "engin","murat","halil"};
            //Console.WriteLine(isimler[0]);

            //  isimler = new string[5]; //new yaptın 5 elemanlı boş array geldi. engin, murat, halilin bir önemi kalmadı.

            //  isimler[3] = "feyza";
            // Console.WriteLine(isimler[3]);//Hata alır.oluşturduğumuz array 3 elemanlı. 4.elemanı sonradan koyamayız
            //Oyüzden gerçek hayatta arraylar kullanılmaz. tanımlandığı zaman üzerine tekrar eleman eklenilmez

            List<string> isimler2 = new List<string> {"Feyza","yılmaz","asil","emin" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("harun");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
