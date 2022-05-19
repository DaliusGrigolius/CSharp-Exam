namespace Repository.Models
{
    public class Drink : Product
    {
        public Drink(string name, decimal currentPrice) : base(name, currentPrice)
        {
        }

        public override string ToString()
        {
            return $"{base.Name} - {base.CurrentPrice}";
        }
    }
}
