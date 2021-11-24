using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //prop tab tab: snippet
    class Product//Entity Varlık
    {
        //özellikler var.
        public int Id { get; set; }
        
        public int CategoryId { get; set; }//Foreing Key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int MyProperty { get; set; }
        public int UnitInStock { get; set; }//stok adedi


        //crud operasyonları.
    }
}
