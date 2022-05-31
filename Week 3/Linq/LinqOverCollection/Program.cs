using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverCollection
{
    class Car
    {
        public string PetName { get; set; } = "";
        public string Color { get; set; } = "";
        public int Speed { get; set; }
        public string Make { get; set; } = "";
    }

    internal class Program
    {

        static void LinqOverGenericCollections()
        {
            Console.WriteLine("***** LINQ over Generic Collections *****\n");
            // Make a List<> of Car objects.
            List<Car> myCars = new List<Car>() {
                 new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                 new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                 new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                 new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                 new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
            };
            var fastCar = from car in myCars where car.Speed >= 50 || car.Make == "Yugo"
                          orderby car.Speed descending select car;
            foreach(var car in fastCar)
            {
                Console.WriteLine($"Petname: {car.PetName}, Color: {car.Color}, Speed: {car.Speed}, Make: {car.Make}");
            }
        }

        static void LINQOverArrayList()
        {
            Console.WriteLine("***** LINQ over ArrayList *****");
            ArrayList myCars = new ArrayList() {
                 new Car{ PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW"},
                 new Car{ PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW"},
                 new Car{ PetName = "Mary", Color = "Black", Speed = 55, Make = "VW"},
                 new Car{ PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo"},
                 new Car{ PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford"}
             };
            var myCarEnum = myCars.OfType<Car>();
            var fastCar = from car in myCarEnum
                          where car.Speed >= 50 || car.Make == "Yugo"
                          orderby car.Speed descending
                          select car;
            foreach (var car in fastCar)
            {
                Console.WriteLine($"Petname: {car.PetName}, Color: {car.Color}, Speed: {car.Speed}, Make: {car.Make}");
            }
        }

        static void OfTypeAsFilter()
        {
            // Extract the ints from the ArrayList.
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(){ PetName = "my car" },new Car(){ PetName = "his car" }, "string data" });
            var myInts = myStuff.OfType<Car>();
            // Prints out 10, 400, and 8.
            foreach (Car i in myInts)
            {
                Console.WriteLine("Car value: {0}", i.PetName);
            }
        }

        static void Main(string[] args)
        {
            //LinqOverGenericCollections();    
            //LINQOverArrayList();
            OfTypeAsFilter();
        }
    }
}
