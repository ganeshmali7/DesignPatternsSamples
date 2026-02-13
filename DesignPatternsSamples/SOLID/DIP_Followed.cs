using System;

namespace DesignPatternsSamples.SOLID
{
    // DIP Followed
    public static class DIP_Followed
    {
        public static void Run()
        {
            var proc = new OrderProcessor(new EmailSender());
            proc.Process();
        }

        interface INotifier 
        { 
            void Send(string m); 
        }
        class EmailSender : INotifier 
        {
            public void Send(string m)
            {
                Console.WriteLine("email:" + m);
            }
        }
        class OrderProcessor
        {
            private INotifier notifier;
            public OrderProcessor(INotifier n) 
            { 
                notifier = n; 
            }
            public void Process() 
            { 
                notifier.Send("order done"); 
            }
        }
    }
}
