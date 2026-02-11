using System;

namespace DesignPatternsSamples.SOLID
{
    // OCP_Violated.cs
    // Processor uses branching by type -> any new payment requires changing this class.
    public static class OCP_Violated
    {
        public static void Run()
        {
            Console.WriteLine("OCP Violated — PaymentProcessor uses type checks");
            Console.WriteLine("-----------------------------------------------");

            var processor = new PaymentProcessorBad();
            processor.Process(PaymentType.Paypal, 99.99m);

            Console.WriteLine();
            Console.WriteLine("Problem: to add a new method we must edit PaymentProcessorBad.");
        }

        private enum PaymentType { CreditCard, Paypal }

        private class PaymentProcessorBad
        {
            public void Process(PaymentType type, decimal amount)
            {
                if (type == PaymentType.CreditCard) Console.WriteLine($"Charging {amount} to credit card.");
                else if (type == PaymentType.Paypal) Console.WriteLine($"Charging {amount} via PayPal.");
            }
        }
    }
}
