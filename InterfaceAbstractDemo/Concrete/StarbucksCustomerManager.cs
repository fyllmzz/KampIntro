using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager (ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);

            }
            else { throw new Exception("not a valid person"); }
           

         
        }
  
       
    }
}
