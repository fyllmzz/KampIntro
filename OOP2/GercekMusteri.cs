using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //ınduvidual=gerçek
    class GercekMusteri:Musteri//inheritance:kalıtım
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string Tc { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
        
    }
}
