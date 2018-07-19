using ECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities
{
    public class Product: DbEntity
    {
        public string ProductName { get; set; }
        public Guid SupplierId { get; set; }
        public decimal? Price { get; set; }

        public Supplier Supplier { get; set; }
    }
}
