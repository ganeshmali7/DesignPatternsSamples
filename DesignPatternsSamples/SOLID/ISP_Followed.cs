using System;

namespace DesignPatternsSamples.SOLID
{
    // ISP_Followed.cs
    // Split fat interface into small focused ones so implementers only depend on what they use.
    public static class ISP_Followed
    {
        public static void Run()
        {
            Console.WriteLine("ISP Followed — small interfaces (IPrinter, IScanner, IFax)");
            Console.WriteLine("---------------------------------------------------------");

            IPrinter rp = new ReceiptPrinter();
            rp.Print("Sale#123");

            Console.WriteLine();
            Console.WriteLine("Good: ReceiptPrinter implements only what it needs.");
        }

        private interface IPrinter { void Print(string doc); }
        private interface IScanner { void Scan(string doc); }
        private interface IFax { void Fax(string doc); }

        private class LaserAllInOne : IPrinter, IScanner, IFax
        {
            public void Print(string doc) => Console.WriteLine("Laser printing: " + doc);
            public void Scan(string doc) => Console.WriteLine("Laser scanning: " + doc);
            public void Fax(string doc) => Console.WriteLine("Laser faxing: " + doc);
        }

        private class ReceiptPrinter : IPrinter { public void Print(string doc) => Console.WriteLine("Receipt printed: " + doc); }
    }
}
