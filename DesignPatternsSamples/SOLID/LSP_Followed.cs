using System;

namespace DesignPatternsSamples.SOLID
{
    // LSP_Followed.cs
    // Use a common interface IShape; Square and Rectangle do not inherit from each other.
    public static class LSP_Followed
    {
        public static void Run()
        {
            Console.WriteLine("LSP Followed — shapes implement IShape (no surprises)");
            Console.WriteLine("----------------------------------------------------");

            IShape[] shapes = new IShape[] {
                new Rectangle2{ Width = 5, Height = 10 },
                new Square2{ Side = 7 }
            };
            Console.WriteLine($"Total area: {TotalArea(shapes)}");

            Console.WriteLine();
            Console.WriteLine("Good: substituting one shape doesn't break others.");
        }

        private interface IShape { double Area(); }
        private class Rectangle2 : IShape { public double Width; public double Height; public double Area() => Width * Height; }
        private class Square2 : IShape { public double Side; public double Area() => Side * Side; }

        private static double TotalArea(IShape[] shapes)
        {
            double total = 0;
            foreach (var s in shapes) total += s.Area();
            return total;
        }
    }
}
