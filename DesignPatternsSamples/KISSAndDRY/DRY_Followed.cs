using System;

namespace DesignPatternsSamples.KISSAndDRY
{
    // DRY_Followed.cs
    // Human-friendly version: single helper method does the tax calculation.
    public static class DRY_Followed
    {
        public static void Run()
        {
            Console.WriteLine("DRY Followed — same cashier story, cleaner:");
            Console.WriteLine("-------------------------------------------");

            string customerA = "Alice";
            decimal priceA = 120m;
            Console.WriteLine($"{customerA} bought a backpack for {priceA} rupees.");
            Console.WriteLine($"Tax for {customerA}: {CalculateTax(priceA, 18m)} rupees");

            Console.WriteLine();

            string customerB = "Bob";
            decimal priceB = 250m;
            Console.WriteLine($"{customerB} bought a jacket for {priceB} rupees.");
            Console.WriteLine($"Tax for {customerB}: {CalculateTax(priceB, 18m)} rupees");

            Console.WriteLine();
            Console.WriteLine("Nice — tax logic is in one place (CalculateTax).");
            Console.WriteLine("To change rounding or formula, edit only that method.");
        }

        // Simple helper that returns tax amount.
        // Keep it tiny — change rounding or formula here if rules change.
        private static decimal CalculateTax(decimal amount, decimal ratePercent)
        {
            return amount * ratePercent / 100m;
        }
    }
}
