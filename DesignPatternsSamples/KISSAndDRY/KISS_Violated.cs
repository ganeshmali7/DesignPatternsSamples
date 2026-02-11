using System;

namespace DesignPatternsSamples.KISSAndDRY
{
    // KISS_Violated.cs
    // Human-friendly: over-engineered temperature conversion using interfaces + factory for a single formula.
    public static class KISS_Violated
    {
        public static void Run()
        {
            Console.WriteLine("KISS Violated — over-engineered converter:");
            Console.WriteLine("-----------------------------------------");

            // A tiny story: Sam just wants Celsius for the weather app.
            string user = "Sam";
            double inputF = 86; // Fahrenheit

            Console.WriteLine($"{user} asks: \"What's {inputF}°F in Celsius?\"");
            // Overkill: build converter via factory and interface
            IConverter conv = ConverterFactory.Get("F2C");
            double result = conv.Convert(inputF);

            Console.WriteLine($"Result (using factory & interface): {result}°C");
            Console.WriteLine();
            Console.WriteLine("Note: This is too many parts for one simple formula.");
            Console.WriteLine("KISS says: prefer simple functions for simple tasks.");
        }
    }

    // Over-designed converter pieces
    public interface IConverter { double Convert(double value); }

    public class FahrenheitToCelsius : IConverter
    {
        public double Convert(double f) => (f - 32) * 5.0 / 9.0;
    }

    public class CelsiusToFahrenheit : IConverter
    {
        public double Convert(double c) => (c * 9.0 / 5.0) + 32;
    }

    public static class ConverterFactory
    {
        // very small factory that decides converter by key
        public static IConverter Get(string key)
        {
            if (key == "F2C") return new FahrenheitToCelsius();
            return new CelsiusToFahrenheit();
        }
    }
}
