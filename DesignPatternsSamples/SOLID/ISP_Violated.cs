using System;

namespace DesignPatternsSamples.SOLID
{
    // ISP Violated - here i created interface of Multifunction in that
    // there are some methods which not possible to inherit each class.
    public static class ISP_Violated
    {
        public static void Run()
        {
            var p = new SimplePrinter();
            p.Print("receipt");
            try 
            { 
                p.Scan("doc"); 
            } 
            catch (NotImplementedException ex) 
            { 
                Console.WriteLine("Scan error: " + ex.Message); 
            }
        }

        private interface IMultiFunctionDevice 
        { 
            void Print(string doc); 
            void Scan(string doc); 
            void Fax(string doc); 
        }

        private class SimplePrinter : IMultiFunctionDevice
        {
            public void Print(string doc)
            {
                Console.WriteLine("Printing: " + doc);
            }
            public void Scan(string doc)
            {
                throw new NotImplementedException("SimplePrinter cant scan");
            }
            public void Fax(string doc)
            {
                throw new NotImplementedException("SimplePrinter cant fax");
            }
        }
    }
}
