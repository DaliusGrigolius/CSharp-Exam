﻿namespace Repository.Models
{
    public class Food : Product
    {
        public Food(string name, decimal currentPrice) : base(name, currentPrice)
        {
        }

        public override string ToString()
        {
            return $"{base.Name} - {base.CurrentPrice}";
        }
    }
}