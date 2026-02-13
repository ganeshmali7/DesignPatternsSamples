using System;

namespace DesignPatternsSamples.KISSAndDRY
{
    // KISS Violated
    // In this example: No need to create the intrefaces and classes to do simple conversion
    public static class KISS_Violated
    {
        public static void Run()
        {
            double inputF = 86;
            IConverter conv = Converter.Get("F2C");
            double result = conv.Convert(inputF);

            Console.WriteLine(inputF+"F is equal to "+result+"C");
        }
    }

    public interface IConverter 
    {
        double Convert(double value); 
    }

    public class FahrenheitToCelsius : IConverter
    {
        public double Convert(double f)
        {
            return (f - 32) * 5.0 / 9.0;
        } 
    }

    public class CelsiusToFahrenheit : IConverter
    {
        public double Convert(double c)
        { 
            return (c * 9.0 / 5.0) + 32;
        } 
    }

    public static class Converter
    {
        public static IConverter Get(string key)
        {
            if (key == "F2C") 
                return new FahrenheitToCelsius();
            else
                return new CelsiusToFahrenheit();
        }
    }
}
