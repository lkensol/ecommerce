using ECommerce.Domain;
using System;

namespace ECommerce.Entities
{
    public class Sale : DbEntity
    {
        public Guid SupplierId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
    }
}
