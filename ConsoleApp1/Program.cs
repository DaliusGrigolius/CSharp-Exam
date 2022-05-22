using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deserializer deserializer = new Deserializer();
            var smt = deserializer.DeserializeOrders(@"..\..\..\..\DataFiles\Orders\allOrders.json");
            Console.WriteLine(smt);
        }
    }
}
