using System;

namespace DesignPatternsSamples.KISSAndDRY
{
    // KISS Followed
    // In this example: used simple method that convert the F to C
    public static class KISS_Followed
    {
        public static void Run()
        {
            double inputF = 86;
            double celsius = ToCelsius(inputF);

            Console.WriteLine($"{inputF}F is equal to {celsius}C");
        }

        // Simple method used to convert the F to C
        private static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
    }
}
