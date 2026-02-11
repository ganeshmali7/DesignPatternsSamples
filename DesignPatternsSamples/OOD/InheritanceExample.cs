using System;

namespace DesignPatternsSamples.OOD
{
    // InheritanceExample.cs
    // Tiny human story: factory has vehicles, some are cars, some are trucks.
    public static class InheritanceExample
    {
        public static void Run()
        {
            Console.WriteLine("Inheritance — factory vehicles (Car and Truck share Vehicle)");
            Console.WriteLine("-----------------------------------------------------------");

            Vehicle[] garage = new Vehicle[]
            {
                new Car { Make = "Honda", Model = "City", DoorCount = 4 },
                new Truck { Make = "Tata", Model = "407", PayloadKg = 1200 }
            };

            foreach (var v in garage)
            {
                Console.WriteLine(v.Describe());
            }

            Console.WriteLine();
            Console.WriteLine("Note: Car and Truck share the common Vehicle code, but add their own details.");
        }
    }

    // Base class with common properties and behavior
    public class Vehicle
    {
        public string Make;
        public string Model;

        public virtual string Describe() => $"Vehicle: {Make} {Model}";
    }

    // Derived class - Car
    public class Car : Vehicle
    {
        public int DoorCount;
        public override string Describe() => $"Car: {Make} {Model} - {DoorCount} doors";
    }

    // Derived class - Truck
    public class Truck : Vehicle
    {
        public int PayloadKg;
        public override string Describe() => $"Truck: {Make} {Model} - {PayloadKg} kg payload";
    }
}
