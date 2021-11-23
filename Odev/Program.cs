using System;

namespace Odev
{
    class program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Year = "2020/2021";
            urun1.Name = "Ataturk Kultur Merkezi";
            urun1.Position = "Design Architect";
            urun1.Company = "Sembol Construction";

            Urun urun2 = new Urun();
            urun2.Year = "2020/2019";
            urun2.Name = "Portonovi Middle Village ";
            urun2.Position = "Design Architect";
            urun2.Company = "Alp Yapi";


            Urun urun3 = new Urun();
            urun3.Year = "2019/2018";
            urun3.Name = "Istanbul Airport State Guest House ";
            urun3.Position = "Architect";
            urun3.Company = "Alp Yapi";


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Year + " - " + urun.Name + " " + urun.Position + " " + urun.Company);

            }

        }


    }

    class Urun
    {
        public string Year { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
    }



}
