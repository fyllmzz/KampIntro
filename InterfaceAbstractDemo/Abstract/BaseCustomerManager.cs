using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    //Temel class
    public abstract class  BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)//virtual dersek ben bu metodu ezebilirim. 
        {
            Console.WriteLine("Save to db :"+customer.FirstName);
        }
    }
}
