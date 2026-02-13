using System;

namespace DesignPatternsSamples.OOD
{
    // Inheritance
    public static class InheritanceExample
    {
        public static void Run()
        {
            Vehicle car = new Car(4, "Honda", "102");
            Vehicle truck = new Truck(4500, "TATA", "504");

            Console.WriteLine(car.Describe());
            Console.WriteLine(truck.Describe());
        }
    }

    // Base class
    public class Vehicle
    {
        public string Make;
        public string Model;

        public virtual string Describe()
        {
            return "Vehicle- Make: "+Make+" Model: "+Model;
        }
    }

    // Derived class - Car
    public class Car : Vehicle
    {
        public int DoorCount;
        public Car(int DoorCount, string Make, string Model)
        {
            this.DoorCount = DoorCount;
            this.Make = Make;
            this.Model = Model;
        }
        public override string Describe()
        {
            return "Car- Make: "+Make+" Model: "+Model +"Door:"+ DoorCount;
        }
    }

    // Derived class - Truck
    public class Truck : Vehicle
    {
        public int PayloadKg;

        public Truck(int PayloadKg, string Make, string Model)
        {
            this.PayloadKg = PayloadKg;
            this.Make = Make;
            this.Model = Model;
        }
        public override string Describe()
        {
            return "Truck- Make: "+Make+" Model: "+Model +"Payload"+PayloadKg;
        }
    }
}
