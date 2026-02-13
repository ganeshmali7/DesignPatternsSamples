using System;

namespace DesignPatternsSamples.SOLID
{
    // SRP Violated - Report class handling multiple tasks
    public static class SRP_Violated
    {
        public static void Run()
        {
            var r = new Report(); 
            r.Write("Hi"); 
            r.Print(); 
            r.Save();
        }

        public class Report
        {
            public string Text;
            public void Write(string t) 
            { 
                Text = t; 
            }
            public void Print() 
            { 
                Console.WriteLine(Text); 
            }
            public void Save() 
            { 
                Console.WriteLine("Saved"); 
            }
        }
    }
}
