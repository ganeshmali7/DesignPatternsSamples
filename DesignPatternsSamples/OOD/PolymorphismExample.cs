using System;

namespace DesignPatternsSamples.OOD
{
    // Polymorphism
    public static class PolymorphismExample
    {
        public static void Run()
        {
            Notification email = new EmailNotification();
            email.Send("ganesh.mali@microlise.com", "Hi, How are yuo.");
            Notification sms = new SmsNotification();
            sms.Send("9021817579", "Hi, How are yuo.");
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
            Console.WriteLine("Email To: "+to+"\nMessage:"+message);
        }
    }

    public class SmsNotification : Notification
    {
        public override void Send(string to, string message)
        {
            Console.WriteLine("SMS To: "+to+"\nMessage:"+message);
        }
    }
}
