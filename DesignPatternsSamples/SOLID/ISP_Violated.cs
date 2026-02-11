using System;

namespace DesignPatternsSamples.SOLID
{
    // ISP_Violated.cs
    // Fat interface forces implementer to provide methods it doesn't support.
    public static class ISP_Violated
    {
        public static void Run()
        {
            Console.WriteLine("ISP Violated — SimplePrinter forced to implement scan/fax");
            Console.WriteLine("--------------------------------------------------------");

            var p = new SimplePrinter();
            p.Print("receipt");
            try { p.Scan("doc"); } catch (NotImplementedException ex) { Console.WriteLine("Scan error: " + ex.Message); }

            Console.WriteLine();
            Console.WriteLine("Problem: clients are forced to depend on methods they don't need.");
        }

        private interface IMultiFunctionDevice { void Print(string doc); void Scan(string doc); void Fax(string doc); }

        private class SimplePrinter : IMultiFunctionDevice
        {
            public void Print(string doc) => Console.WriteLine("Printing: " + doc);
            public void Scan(string doc) => throw new NotImplementedException("SimplePrinter can't scan");
            public void Fax(string doc) => throw new NotImplementedException("SimplePrinter can't fax");
        }
    }
}
