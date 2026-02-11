using System;

namespace DesignPatternsSamples.SOLID
{
    // LSP_Violated.cs
    // Simple demonstration where Square inherits Rectangle and breaks expectations.
    public static class LSP_Violated
    {
        public static void Run()
        {
            Console.WriteLine("LSP Violated — Square inherits Rectangle but changes behavior");
            Console.WriteLine("------------------------------------------------------------");

            Rectangle r = new Square(); // client expects rectangle semantics
            r.Width = 5;
            r.Height = 10;
            Console.WriteLine($"Area (surprising): {r.Area()} (client expected 50)");

            Console.WriteLine();
            Console.WriteLine("Problem: substituting Square for Rectangle leads to unexpected behavior.");
        }

        private class Rectangle
        {
            public virtual double Width { get; set; }
            public virtual double Height { get; set; }
            public virtual double Area() => Width * Height;
        }

        private class Square : Rectangle
        {
            // forcing width == height -> breaks rectangle contract for callers
            public override double Width { get => base.Width; set { base.Width = value; base.Height = value; } }
            public override double Height { get => base.Height; set { base.Height = value; base.Width = value; } }
        }
    }
}
