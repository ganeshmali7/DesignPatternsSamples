using System;

namespace DesignPatternsSamples.SOLID
{
    // SRP_Violated.cs
    // Simple demo: one class does calculation + printing + saving (too many responsibilities).
    public static class SRP_Violated
    {
        public static void Run()
        {
            Console.WriteLine("SRP Violated — InvoiceManager does everything (calc, print, save)");
            Console.WriteLine("---------------------------------------------------------------");

            var inv = new Invoice { Id = 1, Amount = 100m };
            var mgr = new InvoiceManager();

            mgr.CalculateTotal(inv);
            mgr.Print(inv);
            mgr.Save(inv);

            Console.WriteLine();
            Console.WriteLine("Problem: InvoiceManager has many reasons to change (formatting, persistence, rules).");
        }

        // Nested types so names don't collide with other files
        private class Invoice { public int Id; public decimal Amount; }

        private class InvoiceManager
        {
            public void CalculateTotal(Invoice inv) { inv.Amount += 10m; } // business logic
            public void Print(Invoice inv) => Console.WriteLine($"Printing invoice #{inv.Id}, amount {inv.Amount}");
            public void Save(Invoice inv) => Console.WriteLine($"Saving invoice #{inv.Id} to DB (simulated)");
        }
    }
}
