namespace Repository.Models
{
    public class OrderProduct
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public OrderProduct(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
