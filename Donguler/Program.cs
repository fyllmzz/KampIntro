using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
           // string kurs1 = "Yazılım geliştirme";
            //string kurs2 = "Temel c++";
           // string kurs3 = "Java programlama";
            //liste formatında aynı tipte tekrar eden değişkenleri göstermek için array=dizilerde tut
            //array=dizi
            string[] kurslar = new string[] { "Yazılım geliştirme" , "Temel c++", "Java programlama","Html" ,
            "Python"
            };//dinamik yaptık
                                                                                                       //tek tek tanımlamak yerine bir listede tuttuk.

            //kurslar.Length dinamikleştir.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)//dizi temelli yapıları tek tek dönmeye yarar
            {
                Console.WriteLine(kurs);

            }
           
        }
    }
}
