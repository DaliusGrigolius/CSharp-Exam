using Repository.DataAccess;
using Repository.DataAccess.Interfaces;
using Xunit;

namespace XUnit_Tests.RepositoryDataAccessTests
{
    public class ProductRepoTest
    {
        IProductRepo repo = new ProductRepo();

        [Fact]
        public void RetrieveProducts_HasData_ReturnMoreThanZeroFoodObjects()
        {
            var foodListFilePath = @"..\..\..\..\DataFiles\food.csv";
            var foodList = repo.RetrieveProducts(foodListFilePath);

            Assert.NotNull(foodList);
        }

        [Fact]
        public void RetrieveProducts_HasData_ReturnMoreThanZeroDrinkObjects()
        {
            var drinksListFilePath = @"..\..\..\..\DataFiles\drinks.csv";
            var drinksList = repo.RetrieveProducts(drinksListFilePath, false);

            Assert.NotNull(drinksList);
        }
    }
}
