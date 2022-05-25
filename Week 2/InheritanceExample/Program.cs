using System;

namespace InheritanceExample
{
    public record MotorCycle(string Make, string Model);
    public record Scooter(string Make, string Model) : MotorCycle(Make, Model);

    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Honda", "Pilot", "Blue");
            MiniVan m = new MiniVan("Honda", "Pilot", "Blue", 10);
            Console.WriteLine($"Checking MiniVan is-a Car:{m is Car}");
            MotorCycle mc = new MotorCycle("Harley", "Lowrider");
            Scooter sc = new Scooter("Harley", "Lowrider");
            Console.WriteLine($"MotorCycle and Scooter are equal: {Equals(mc, sc)}");
        }
    }
}
