using System;

namespace DesignPatternsSamples.SOLID
{
    // OCP_Followed.cs
    // Processor depends on abstraction IPaymentMethod; adding new methods means new classes only.
    public static class OCP_Followed
    {
        public static void Run()
        {
            Console.WriteLine("OCP Followed — add new payment classes without changing processor");
            Console.WriteLine("----------------------------------------------------------------");

            IPaymentMethod method = new PaypalPayment();
            var processor = new PaymentProcessorGood();
            processor.ProcessPayment(method, 49.95m);

            Console.WriteLine();
            Console.WriteLine("Good: PaymentProcessorGood is closed for modification, open for extension.");
        }

        // nested abstraction and implementations
        private interface IPaymentMethod { void Pay(decimal amount); }
        private class CreditCardPayment : IPaymentMethod { public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} by Credit Card"); }
        private class PaypalPayment : IPaymentMethod { public void Pay(decimal amount) => Console.WriteLine($"Paid {amount} via PayPal"); }

        private class PaymentProcessorGood { public void ProcessPayment(IPaymentMethod method, decimal amount) => method.Pay(amount); }
    }
}
