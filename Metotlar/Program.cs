using System;

namespace Metotlar
    
    
    //tekrar tekrar kullanılabilirliği sağlayan ortam sunar
{
    //Don't repeat yourself
    class Program

    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 21;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuz";

           
            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type safe=tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi+" "+urun.Aciklama+" "+urun.Fiyati);

            }


            Console.WriteLine("----------metotlar-----------");


            //Encapculation=kapsülleme
            //ayrı ayrı yazacağın şeyi bir class içine sokup kapsüllüyorsun.
            SepetManager sepetekle = new SepetManager();
            sepetekle.Ekle(urun1);//bu kullanışlı yönetem.
            sepetekle.Ekle(urun1);


            sepetekle.Ekle2("armut",12,"amasya");//bunu kullanma. kullanışsız.her sayfada değiştirmen gerekir.
            sepetekle.Ekle2("armut", 12, "amasya");
            sepetekle.Ekle2("armut", 12, "amasya");
            sepetekle.Ekle2("armut", 12, "amasya");
        }
    }
}
