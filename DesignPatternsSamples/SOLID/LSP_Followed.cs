using System;

namespace DesignPatternsSamples.SOLID
{
    // LSP Followed
    public static class LSP_Followed
    {
        public static void Run()
        {
            IFly f = new Sparrow(); 
            f.Fly();
            var p = new Penguin(); 
            p.Swim();
        }

        interface IFly 
        { 
            void Fly(); 
        }
        class Sparrow : IFly 
        {
            public void Fly()
            {
                Console.WriteLine("fly");
            }
        }
        class Penguin 
        {
            public void Swim()
            {
                Console.WriteLine("swimming");
            }
        }
    }
}
