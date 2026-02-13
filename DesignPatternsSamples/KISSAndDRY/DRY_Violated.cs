using System;

namespace DesignPatternsSamples.KISSAndDRY
{
    // DRY Violated
    // In this example: TAX CALCULATION was repeated which violates the property of Don't Repeat Yoorself
    public static class DRY_Violated
    {
        public static void Run()
        {
            string customerA = "Ganesh Mali";
            int priceA = 120;
            Console.WriteLine(customerA+" bought a notebook for "+priceA+" rs.");
            // TAX CALCULATION
            double taxA = (double)priceA * 18 / 100;
            Console.WriteLine("Tax for "+customerA+": "+taxA+" rs");

            Console.WriteLine();

            string customerB = "Nishidh Kanojiya";
            int priceB = 250;
            Console.WriteLine(customerB + " bought a watch for " + priceB + " rs.");
            // TAX CALCULATION (same formula copy again)
            double taxB = (double)priceB * 18 / 100;
            Console.WriteLine("Tax for " + customerB + ": " + taxB + " rs");
        }
    }
}
