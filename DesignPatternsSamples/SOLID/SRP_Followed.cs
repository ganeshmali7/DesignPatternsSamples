using System;

namespace DesignPatternsSamples.SOLID
{
    // SRP_Followed.cs
    // Simple demo: responsibilities split into small focused classes.
    public static class SRP_Followed
    {
        public static void Run()
        {
            Console.WriteLine("SRP Followed — separate classes for calc, print, and save");
            Console.WriteLine("--------------------------------------------------------");

            var inv = new Invoice { Id = 2, Amount = 200m };
            var calc = new InvoiceCalculator();
            var printer = new InvoicePrinter();
            var repo = new InvoiceRepository();

            calc.ApplyTaxes(inv);
            printer.Print(inv);
            repo.Save(inv);

            Console.WriteLine();
            Console.WriteLine("Good: Each class has a single reason to change.");
        }

        // nested helper types
        private class Invoice { public int Id; public decimal Amount; }

        private class InvoiceCalculator { public void ApplyTaxes(Invoice i) => i.Amount += 10m; }
        private class InvoicePrinter { public void Print(Invoice i) => Console.WriteLine($"Invoice #{i.Id}: {i.Amount}"); }
        private class InvoiceRepository { public void Save(Invoice i) => Console.WriteLine($"Persisted invoice #{i.Id} (simulated)"); }
    }
}
