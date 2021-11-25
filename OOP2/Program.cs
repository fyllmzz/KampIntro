using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyad = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.Tc =" 123456789";
            //musteri1.MusteriNo = "12";
            //musteri1.SirketAdi = "????";//alakasız olur.
            //Gerçek müş-tüzel müş


            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123";
            musteri1.Adi = "f";
            musteri1.Soyad = "y";
            musteri1.Tc = "12345689";
            

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1234";
            musteri2.SirketAdi = "adı";
            musteri2.VergiNo = "3582";



            //SOLID
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);








        }
    }
}
