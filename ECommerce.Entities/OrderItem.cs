using ECommerce.Domain;

namespace ECommerce.Entities
{
    public class OrderItem : DbEntity
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
