namespace Repository.Models
{
    public class Drink : Product
    {
        public Drink(string name, decimal currentPrice)
        {
            Name = name;
            CurrentPrice = currentPrice;
        }
    }
}
