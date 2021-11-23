using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety:tip güvenliği
            //Do not repeat yourself: Kendini tekrarlama
            string kategoriEtiketi = "Kategoriler"; //kategoriEtiketi: değer tutucu
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;//ondalıklı sayılar
            bool sistemeGirisYapıldiMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine(  "azalış");

            }
            else if(dolarDun<dolarBugun)
            { Console.WriteLine("artış"); }
            else { Console.WriteLine("değişmedi"); }



            if (sistemeGirisYapıldiMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        
        }
    }
}
