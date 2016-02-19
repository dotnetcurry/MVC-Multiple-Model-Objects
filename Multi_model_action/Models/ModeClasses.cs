using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Multi_model_action.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public ICollection<OrderItemDetails> OrderDetails { get; set; }
    }

    public class OrderItemDetails
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}