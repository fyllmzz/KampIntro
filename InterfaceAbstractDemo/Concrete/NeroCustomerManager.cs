using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
   public class NeroCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);

            }
            else { throw new Exception("not a valid person"); }

        }
        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public NeroCustomerManager()
        {
        }
    }
}
