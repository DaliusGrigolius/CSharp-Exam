using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderProduct> OrderedProducts { get; set; }
        public decimal OrderTotalAmount { get; set; }

        public Order(int id, DateTime orderDate, List<OrderProduct> orderedProducts, decimal orderTotalAmount)
        {
            Id = id;
            OrderDate = orderDate;
            OrderedProducts = orderedProducts;
            OrderTotalAmount = orderTotalAmount;
        }
    }
}
