using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public class Order
    {
        public int TableId { get; set; }
        public int TableSeating { get; set; }
        public List<OrderProduct> OrderedProducts { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }

        public Order(int tableId, int tableSeating, List<OrderProduct> orderedProducts, decimal totalAmount, DateTime createdAt)
        {
            TableId = tableId;
            TableSeating = tableSeating;
            OrderedProducts = orderedProducts;
            TotalAmount = totalAmount;
            CreatedAt = createdAt;
        }
    }
}
