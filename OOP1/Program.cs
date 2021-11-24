using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName = "Sandalye", UnitInStock = 45,
            UnitPrice=100};//bu şekilde de yazılır.


            //pascalcase: ilk harf büyük
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            int toplamaSonucu=productManager.Topla(2,8);
            Console.WriteLine(toplamaSonucu*3);//return edilensonucu 3 ile çarptık

        }
    }
}
