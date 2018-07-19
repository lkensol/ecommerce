using ECommerce.Domain;
using System.Collections.Generic;

namespace ECommerce.Entities
{
    public class Employee : DbEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public virtual ICollection<Order> Order { get; set; }
    }
}
