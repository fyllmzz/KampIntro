using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" "+musteri.Ad+" "+musteri.Soyad+" "+"Müşteri Eklendi..");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + "Müşteri Silindi..");

        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + "Müşteri Listelendi..");
        }
    }
}
