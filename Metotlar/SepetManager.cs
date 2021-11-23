using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention=doğru yazma teknikleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, sepete eklendi."+urun.Adi);
        }
        public void Ekle2(string urunAdi,double urunFiyati,string urunAciklama)
        {
            Console.WriteLine("tebrikler:"+urunAdi);
        }
    }
}
