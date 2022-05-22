namespace Repository.Models
{
    public class Food : Product
    {
        public Food(string name, decimal currentPrice)
        {
            Name = name;
            CurrentPrice = currentPrice;
        }
    }
}