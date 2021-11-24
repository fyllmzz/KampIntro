using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Feyza";
            musteri1.Soyad = "Yımaz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Kübra";
            musteri2.Soyad = "Demirci";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriListele(musteri2);

            
        }
    }
}
