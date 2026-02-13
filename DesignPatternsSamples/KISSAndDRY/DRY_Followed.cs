using System;

namespace DesignPatternsSamples.KISSAndDRY
{
    // DRY Followed
    // In this example: TAX CALCULATION done in seperate method
    // we calls that method which followes the property of Don't Repeat Yoorself
    public static class DRY_Followed
    {
        public static void Run()
        {
            string customerA = "Ganesh Mali";
            int priceA = 120;
            Console.WriteLine(customerA + " bought a notebook for " + priceA + " rs.");
            Console.WriteLine("Tax for "+customerA+": "+CalculateTax(priceA, 18)+" rs");

            Console.WriteLine();

            string customerB = "Nishidh Kanojiya";
            int priceB = 250;
            Console.WriteLine(customerA + " bought a watch for " + priceA + " rs.");
            Console.WriteLine("Tax for " + customerA + ": " + CalculateTax(priceB, 18) + " rs");
        }

        // Simple helper method that returns tax amount.
        public static double CalculateTax(int amount, int rate)
        {
            return (double)amount * rate / 100;
        }
    }
}
