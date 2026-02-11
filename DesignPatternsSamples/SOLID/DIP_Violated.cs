using System;

namespace DesignPatternsSamples.SOLID
{
    // DIP_Violated.cs
    // High-level module depends on low-level concrete implementation (tight coupling).
    public static class DIP_Violated
    {
        public static void Run()
        {
            Console.WriteLine("DIP Violated — PaymentService depends directly on concrete PayPalGateway");
            Console.WriteLine("------------------------------------------------------------------------");

            var service = new PaymentServiceBad();
            service.Checkout(19.99m);

            Console.WriteLine();
            Console.WriteLine("Problem: Can't easily switch gateway or unit test PaymentServiceBad.");
        }

        private class PayPalGateway
        {
            public void SendPayment(decimal amount) => Console.WriteLine($"PayPal charged {amount}");
        }

        private class PaymentServiceBad
        {
            private readonly PayPalGateway _gateway = new PayPalGateway(); // direct dependency
            public void Checkout(decimal amount) => _gateway.SendPayment(amount);
        }
    }
}
