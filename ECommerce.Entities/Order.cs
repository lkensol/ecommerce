using ECommerce.Domain;
using System;
using System.Collections.Generic;

namespace ECommerce.Entities
{
    public class Order : DbEntity
    {
        public string ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }        
        //public DateTime OrderDate { get; set; }
        //public decimal? TotalDue { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public Guid EmployeeId { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public byte[] LastUpdate { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }
        public Employee Employee { get; set; }
    }
}