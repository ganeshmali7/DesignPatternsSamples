using System;

namespace DesignPatternsSamples.SOLID
{
    // OCP Followed
    public static class OCP_Followed
    {
        public static void Run()
        {
            var list = new List<IGreet> { new English(), new Hindi() };
            Console.WriteLine(Greet("marathi", list));
        }

        public interface IGreet 
        { 
            string Code 
            { 
                get; 
            } 
            string Say(); 
        }
        public class English : IGreet 
        { 
            public string Code => "english";
            public string Say()
            {
                return "Hello";
            }
        }
        public class Hindi : IGreet 
        { 
            public string Code => "marathi";
            public string Say()
            {
                return "Namaste";
            }
        }

        public static string Greet(string lang, IEnumerable<IGreet> st)
        {
            foreach (var s in st) 
                if (s.Code == lang) 
                    return s.Say();
            return "Hi";
        }
    }
}
