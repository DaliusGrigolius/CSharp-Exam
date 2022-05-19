namespace Repository.Models
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal CurrentPrice { get; set; }

        public Product(string name, decimal currentPrice)
        {
            Name = name;
            CurrentPrice = currentPrice;
        }

        public override string ToString()
        {
            return " ";
        }
    }
}
