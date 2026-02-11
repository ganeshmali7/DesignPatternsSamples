using System;

namespace DesignPatternsSamples.KISSAndDRY
{
    // DRY_Violated.cs
    // Very simple, human-friendly demo: the tax calculation is copied twice.
    public static class DRY_Violated
    {
        public static void Run()
        {
            Console.WriteLine("DRY Violated — cashier story:");
            Console.WriteLine("-----------------------------");

            // Two customers buying different items
            string customerA = "Alice";
            decimal priceA = 120m;
            Console.WriteLine($"{customerA} bought a backpack for {priceA} rupees.");
            // TAX CALCULATION #1 (duplicated)
            decimal taxA = priceA * 18m / 100m;
            Console.WriteLine($"Tax for {customerA}: {taxA} rupees");

            Console.WriteLine();

            string customerB = "Bob";
            decimal priceB = 250m;
            Console.WriteLine($"{customerB} bought a jacket for {priceB} rupees.");
            // TAX CALCULATION #2 (the same formula copied again)
            decimal taxB = priceB * 18m / 100m;
            Console.WriteLine($"Tax for {customerB}: {taxB} rupees");

            Console.WriteLine();
            Console.WriteLine("Notice: the tax formula was written in two places.");
            Console.WriteLine("If tax rules change we must update every place where it's copied — easy to forget.");
        }
    }
}
