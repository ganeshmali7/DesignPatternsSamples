using System;

namespace DesignPatternsSamples.KISSAndDRY
{
    // KISS_Followed.cs
    // Human-friendly: simple functions that do one clear job. Easy to read and use.
    public static class KISS_Followed
    {
        public static void Run()
        {
            Console.WriteLine("KISS Followed — simple converter:");
            Console.WriteLine("-------------------------------");

            string user = "Sam";
            double inputF = 86;

            Console.WriteLine($"{user} asks: \"What's {inputF}°F in Celsius?\"");
            double celsius = ToCelsius(inputF);
            Console.WriteLine($"Result: {celsius}°C");

            Console.WriteLine();
            Console.WriteLine("Nice — one tiny function, one tiny job. Easy to test and present.");
        }

        // A straightforward single-purpose function
        private static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
    }
}
