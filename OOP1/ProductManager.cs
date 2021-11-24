using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapculation
        public void Add(Product product)
        {
            Console.WriteLine(  product.ProductName+" "+ "eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " " + "güncellendi.");

        }

        public int Topla(int s1,int s2)//toplamın sonucunda çıkan değere ihtiyacın varsa return yap.
        {
            int toplam = s1 + s2;
            return toplam;
        }
    }
}
