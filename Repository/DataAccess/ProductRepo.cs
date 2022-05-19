﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var dataFile = File.ReadAllLines(filePath)
                .Select(x => x.Split(','))
                .Select(x => new Food(
                    x[0],
                    decimal.Parse(x[1])
                    ))
                .ToList();
            
            if (isFood)
            {
                Food.AddRange(dataFile);
                return Food;
            }
            else
            {
                Drinks.AddRange(dataFile);
                return Drinks;
            }
        }
    }
}