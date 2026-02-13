using System;

namespace DesignPatternsSamples.SOLID
{
    // OCP Violated
    // In this example if i wants add new language in future then we violates the property of open-closed principle
    public static class OCP_Violated
    {
        public static void Run()
        {
            var g = new Greet();
            Console.WriteLine(g.greetings("marathi"));
        }

        public class Greet
        {
            public string greetings(string lang)
            {
                if (lang == "english") 
                    return "Hello";
                else if (lang == "marathi") 
                    return "Namaste";
                return "Hi";
            }
        }
            
    }
}
