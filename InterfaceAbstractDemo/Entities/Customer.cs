using System;

namespace InterfaceAbstractDemo.Entities
{
  public  class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBird { get; set; }
        public string NationalityId { get; set; }
    }
}
