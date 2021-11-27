using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1998, 6, 4),
                FirstName = "Feyza",
                LastName = "YILMAZ",
                NationalityId="1234567899"
            }) ;
            Console.ReadLine();
        }

    }
}
