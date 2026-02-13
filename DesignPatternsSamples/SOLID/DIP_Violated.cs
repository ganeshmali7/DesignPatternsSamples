using System;

namespace DesignPatternsSamples.SOLID
{
    // DIP Violated
    // High level module should not tighly coupled with Low level module
    public static class DIP_Violated
    {
        public static void Run()
        {
            var order = new OrderProcessor();
            order.Process();
        }
        class EmailSender
        {
            public void Send(string m)
            {
                Console.WriteLine("email:" + m);
            }
        }
        class OrderProcessor
        {
            EmailSender sender = new EmailSender(); // tight coupling
            public void Process() 
            { 
                sender.Send("order done"); 
            }
        }
    }
}
