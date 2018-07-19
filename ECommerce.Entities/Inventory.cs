using ECommerce.Domain;
using System;

namespace ECommerce.Entities
{
    public class Inventory : DbEntity
    {
        public Guid ProductId { get; set; } 
        public string Status { get; set; }
        public decimal Quantity { get; set; }

        public Product Product { get; set; }
    }
}
