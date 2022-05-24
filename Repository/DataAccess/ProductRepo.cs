using Repository.DataAccess.Interfaces;
using Repository.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository.DataAccess
{
    public class ProductRepo : IProductRepo
    {
        private List<Product> Food { get; }
        private List<Product> Drinks { get; }


        public ProductRepo()
        {
            Food = new List<Product>();
            Drinks = new List<Product>();
        }

        public List<Product> RetrieveProducts(string filePath, bool isFood = true)
        {
            if (isFood)
            {
                var dataFile = File.ReadAllLines(filePath)
                .Select(x => x.Split(','))
                .Select(x => new Food(
                    x[0],
                    decimal.Parse(x[1])
                    ))
                .ToList();

                Food.AddRange(dataFile);

                return Food;
            }
            else
            {
                var dataFile = File.ReadAllLines(filePath)
                .Select(x => x.Split(','))
                .Select(x => new Drink(
                    x[0],
                    decimal.Parse(x[1])
                    ))
                .ToList();

                Drinks.AddRange(dataFile);

                return Drinks;
            }
        }
    }
}
