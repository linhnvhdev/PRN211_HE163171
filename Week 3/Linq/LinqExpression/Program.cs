using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqExpression
{

    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;
        public override string ToString()
        => $"Name={Name}, Description={Description}, Number in Stock={NumberInStock}";
    }

    internal class Program
    {
        static ProductInfo[] itemsInStock = new[] {
                 new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
                 new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
                 new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
                 new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness",
                NumberInStock = 2},
                 new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet",
                NumberInStock = 100},
                 new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone lovespizza!", NumberInStock = 73 }
            };

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");
            ListProductName(itemsInStock);
            GetNamesAndDescriptions(itemsInStock);
            DisplayDiff();
            DisplayIntersection();
            AggregateOps();
        }

        static void ListProductName(ProductInfo[] products)
        {
            Console.WriteLine("Only Product name:");
            var productName = from product in products select product.Name;
            int count = productName.Count();
            Console.WriteLine("number of name: "+ count);
            foreach(var name in productName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("     Reverse name list:");
            var reverseName = productName.Reverse();
            foreach(var name in reverseName)
            {
                Console.WriteLine(name);
            }
        }

        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            var nameDesc =
            from p
            in products
            select new { p.Name, p.Description };
            foreach (var item in nameDesc)
            {
                // Could also use Name and Description properties
                // directly.
                Console.WriteLine(item.ToString());
            }
        }

        static void DisplayDiff()
        {
            List<string> myCars =
            new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars =
            new List<String> { "BMW", "Saab", "Aztec" };
            var carDiff =
            (from c in myCars select c)
            .Except(from c2 in yourCars select c2);
            Console.WriteLine("Here is what you don't have, but I do:");
            foreach (string s in carDiff)
            {
                Console.WriteLine(s); // Prints Yugo.
            }
        }

        static void DisplayIntersection()
        {
            List<string> myCars =
            new List<String> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars =
            new List<String> { "BMW", "Saab", "Aztec" };
            var carDiff =
            (from c in myCars select c)
            .Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what we both have:");
            foreach (string s in carDiff)
            {
                Console.WriteLine(s);
            }
        }

        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };
            // Various aggregation examples.
            Console.WriteLine("Max temp: {0}",
            (from t in winterTemps select t).Max());
            Console.WriteLine("Min temp: {0}",
            (from t in winterTemps select t).Min());
            Console.WriteLine("Average temp: {0}",
            (from t in winterTemps select t).Average());
            Console.WriteLine("Sum of all temps: {0}",
            (from t in winterTemps select t).Sum());
        }
    }
}
