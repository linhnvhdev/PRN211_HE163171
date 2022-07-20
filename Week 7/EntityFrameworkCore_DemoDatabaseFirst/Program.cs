using System;
using EntityFrameworkCore_DemoDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkCore_DemoDatabaseFirst
{
    internal class Program
    {
        static void demoDatabaseFirst()
        {
            MyStoreContext myStore = new MyStoreContext();
            var products = from p in myStore.Products select new { p.ProductName, p.CategoryId };
            foreach (var p in products)
            {
                Console.WriteLine($"ProductName: {p.ProductName}, CategoryID: {p.CategoryId}");
            }
            Console.WriteLine("-------------------------------------------------------------");
            IQueryable<Category> cats = myStore.Categories.Include(c => c.Products);
            foreach (Category c in cats)
            {
                Console.WriteLine($"CategoryID: {c.CategoryId} has {c.Products.Count} products");
            }
            Console.ReadLine();
        }

        static void FilteredIncludes()
        {
            using var db = new MyStoreContext();
            Console.Write("Enter a minimum for units in stock: ");
            string unitsInStock = Console.ReadLine();
            int stock = int.Parse(unitsInStock);
            IQueryable<Category> cats = db.Categories
                                        .Include(c => c.Products.Where(p => p.UnitInStock >= stock));
            foreach(Category c in cats)
            {
                Console.WriteLine($"{c.CategoryName} has {c.Products.Count} products");
                foreach(Product p in c.Products)
                {
                    Console.WriteLine($"--> {p.ProductName} has {p.UnitInStock} units in stock");
                }
            }
        }

        static void QueryingProducts()
        {
            using (var db = new MyStoreContext())
            {
                Console.WriteLine("Products that cost more than a price, highest at top");
                string input;
                decimal price;
                do
                {
                    Console.WriteLine("Enter a product price: ");
                    input = Console.ReadLine();

                } while (!decimal.TryParse(input, out price));
                IQueryable<Product> products = db.Products
                                               .Where(product => product.UnitPrice > price)
                                               .OrderByDescending(product => product.UnitPrice);
                foreach (Product p in products)
                {
                    Console.WriteLine($"Product Name: {p.ProductName} costs {p.UnitPrice: $#,##0.00} "
                        + $"and has {p.UnitInStock} in stock");
                }
            }
        }

        static void AggregateProduct()
        {
            using(var db = new MyStoreContext())
            {
                Console.WriteLine("{0,-25} {1,10}",arg0: "Product count:",arg1:db.Products.Count());
                Console.WriteLine("{0,-25} {1,10:$#,##0.00}", arg0: "Highest product Price:", arg1: db.Products.Max(p=>p.UnitPrice));
                Console.WriteLine("{0,-25} {1,10:N0}", arg0: "Sum of units in stock:", arg1: db.Products.Sum(p=>p.UnitInStock));
                Console.WriteLine("{0,-25} {1,10:$#,##0.00}", arg0: "Average Unit price:", arg1: db.Products.Average(p=>p.UnitPrice));
                Console.WriteLine("{0,-25} {1,10:$#,##0.00}", arg0: "Value of unit in stock:", arg1: db.Products.AsEnumerable().Sum(p=>p.UnitPrice*p.UnitInStock));
            }
        }

        static void Main(string[] args)
        {
            //demoDatabaseFirst();
            //FilteredIncludes();
            //QueryingProducts();
            AggregateProduct();
        }
    }
}
