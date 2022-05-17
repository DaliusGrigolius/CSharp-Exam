using System.Collections.Generic;

namespace Repository.Models
{
    public class TableOrder
    {
        public Table Table { get; set; }
        public List<Order> Orders { get; set; }
    }
}
