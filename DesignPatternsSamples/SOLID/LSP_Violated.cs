using System;

namespace DesignPatternsSamples.SOLID
{
    // LSP Violated
    // Here Penguin not able to fly still need to override the Fly() method which violates the property of Liskov's Principle
    public static class LSP_Violated
    {
        public static void Run()
        {
            Bird b = new Penguin();
            b.Fly(); // throws exception which violates property of LSP
        }

        class Bird 
        {
            public virtual void Fly()
            {
                Console.WriteLine("flying");
            }
        }
        class Penguin : Bird
        {
            public override void Fly()
            {
                throw new InvalidOperationException("cant fly");
            }
        }
    }
}
