using ECommerce.Domain;
using System.Collections.Generic;

namespace ECommerce.Entities
{
    public class Customer : DbEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        // public int OrderCount { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
