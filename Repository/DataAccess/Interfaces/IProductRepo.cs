using Repository.Models;
using System.Collections.Generic;

namespace Repository.DataAccess.Interfaces
{
    public interface IProductRepo
    {
        List<Product> RetrieveProducts(string filePath, bool isFood = true);
    }
}