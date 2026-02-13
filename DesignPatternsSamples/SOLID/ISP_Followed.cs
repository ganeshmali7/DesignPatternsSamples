using System;

namespace DesignPatternsSamples.SOLID
{
    // ISP Followed
    // here we created seperate interfaces
    public static class ISP_Followed
    {
        public static void Run()
        { 
            IPrinter rp = new ReceiptPrinter();
            rp.Print("receipt");
        }

        private interface IPrinter 
        { 
            void Print(string doc); 
        }
        private interface IScanner 
        { 
            void Scan(string doc); 
        }
        private interface IFax 
        { 
            void Fax(string doc); 
        }

        private class LaserAllInOne : IPrinter, IScanner, IFax
        {
            public void Print(string doc)
            {
                Console.WriteLine("Laser printing: " + doc);
            }
            public void Scan(string doc)
            {
                Console.WriteLine("Laser scanning: " + doc);
            }
            public void Fax(string doc)
            {
                Console.WriteLine("Laser faxing: " + doc);
            }
        }

        private class ReceiptPrinter : IPrinter 
        {
            public void Print(string doc)
            {
                Console.WriteLine("Receipt printed: " + doc);
            }
        }
    }
}
