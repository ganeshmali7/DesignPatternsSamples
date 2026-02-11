using System;

namespace DesignPatternsSamples.OOD
{
    // PolymorphismExample.cs
    // Tiny human story: system sends different notifications but uses the same code to call them.
    public static class PolymorphismExample
    {
        public static void Run()
        {
            Console.WriteLine("Polymorphism — send notifications (Email & SMS)");
            Console.WriteLine("-----------------------------------------------");

            Notification[] notifiers = new Notification[]
            {
                new EmailNotification(),
                new SmsNotification()
            };

            foreach (var n in notifiers)
            {
                n.Send("user@example.com", "Hello! This is a polymorphism demo.");
            }

            Console.WriteLine();
            Console.WriteLine("Note: Code treats different notification types the same way — that's polymorphism.");
        }
    }

    public abstract class Notification
    {
        public abstract void Send(string to, string message);
    }

    public class EmailNotification : Notification
    {
        public override void Send(string to, string message)
        {
            Console.WriteLine($"[Email] To: {to}  Message: {message}");
        }
    }

    public class SmsNotification : Notification
    {
        public override void Send(string to, string message)
        {
            Console.WriteLine($"[SMS]   To: {to}  Message: {message}");
        }
    }
}
