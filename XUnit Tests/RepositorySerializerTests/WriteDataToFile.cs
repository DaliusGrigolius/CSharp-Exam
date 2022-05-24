using Repository.Models;
using Repository.Serializer;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace XUnit_Tests.RepositorySerializerTests
{
    public class WriteDataToFile
    {
        ISerializer serializer = new Serializer();

        [Fact]
        public void WriteOrderDataToFile_CreatesFile_ReturnsTrueIfFileExsists()
        {
            var filePath = @$"..\..\..\..\DataFiles\Orders\testOrder.json";

            List<OrderProduct> orderProducts = new List<OrderProduct>
            {
                new OrderProduct(new Product(), 5)
            };

            List<Order> orders = new List<Order>
            {
                new Order(1, 5, orderProducts, 15.5m, DateTime.Now)
            };

            serializer.WriteOrderDataToFile(orders, filePath);

            Assert.True(File.Exists(filePath));
        }
    }
}
