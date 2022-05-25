using System;

namespace RecordExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Records example");
            Car myCar = new Car()
            {
                Make = "Honda",
                Model = "Pilot",
                Color = "Blue"
            };

            Console.WriteLine("My car: ");
            DisplayCarStats(myCar);
            Console.WriteLine();
            //Use the custom constructor
            Car anotherMyCar = new Car("Honda", "Pilot", "Blue");
            Console.WriteLine("Another variable for my car: ");
            DisplayCarStats(anotherMyCar);
            // Error if init property is changed
            //myCar.Color = "Red";
            Console.WriteLine();
            Console.WriteLine("/*************** RECORDS *********************/");
            //Use object initialization
            CarRecord myCarRecord = new CarRecord
            {
                Make = "Honda",
                Model = "Pilot",
                Color = "Blue"
            };
            Console.WriteLine("My car: ");
            DisplayCarRecordStats(myCarRecord);
            Console.WriteLine();
            //Use the custom constructor
            CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
            Console.WriteLine("Another variable for my car: ");
            Console.WriteLine(anotherMyCarRecord.ToString());
            Console.WriteLine();
            //Compile error if property is changed
            //myCarRecord.Color = "Red";.
            Console.WriteLine($"Car same as another car?: {myCar == anotherMyCar}");
            Console.WriteLine($"Cars are the same reference? {ReferenceEquals(myCar, anotherMyCar)}");
            Console.WriteLine($"CarRecords are the same? {myCarRecord.Equals(anotherMyCarRecord)}");
            Console.WriteLine($"CarRecords are the same reference? {ReferenceEquals(myCarRecord, anotherMyCarRecord)}");
            Console.WriteLine($"CarRecords are the same? {myCarRecord == anotherMyCarRecord}");
            Console.WriteLine($"CarRecords are not the same? {myCarRecord != anotherMyCarRecord}");
        }

        static void DisplayCarStats(Car c)
        {
            Console.WriteLine("Car Make: {0}", c.Make);
            Console.WriteLine("Car Model: {0}", c.Model);
            Console.WriteLine("Car Color: {0}", c.Color);
        }

        static void DisplayCarRecordStats(CarRecord c)
        {
            Console.WriteLine("Car Make: {0}", c.Make);
            Console.WriteLine("Car Model: {0}", c.Model);
            Console.WriteLine("Car Color: {0}", c.Color);
        }
    }
}
