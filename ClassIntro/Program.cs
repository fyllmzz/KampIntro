﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yapay Zeka";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 479;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c#";
            kurs2.Egitmen = "berkay ";
            kurs2.İzlenmeOrani = 52;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "c++";
            kurs3.Egitmen = "murat";
            kurs3.İzlenmeOrani = 47;

            // Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                //Console.WriteLine(kurs.KursAdi);//sadece kurs adlarını yazdırdık
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }//özellik
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }



}
