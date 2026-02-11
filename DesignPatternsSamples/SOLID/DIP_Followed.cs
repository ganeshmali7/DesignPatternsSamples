using System;

namespace DesignPatternsSamples.SOLID
{
    // DIP_Followed.cs
    // High-level module depends on abstraction; concrete implementations are injected (DI).
    public static class DIP_Followed
    {
        public static void Run()
        {
            Console.WriteLine("DIP Followed — PaymentService depends on IPaymentGateway abstraction");
            Console.WriteLine("------------------------------------------------------------------");

            IPaymentGateway gateway = new StripeGateway();
            var paymentService = new PaymentService(gateway);
            paymentService.Checkout(79.95m);

            Console.WriteLine();
            Console.WriteLine("Also demonstrating simple role-based DI: CEO -> Manager -> Developer");
            IDeveloper dev = new Developer();
            IManager mgr = new Manager();
            var ceo = new CEO(mgr);
            ceo.RunCompany(dev);
        }

        private interface IPaymentGateway { void SendPayment(decimal amount); }
        private class PayPalGateway : IPaymentGateway { public void SendPayment(decimal amount) => Console.WriteLine($"PayPal charged {amount}"); }
        private class StripeGateway : IPaymentGateway { public void SendPayment(decimal amount) => Console.WriteLine($"Stripe charged {amount}"); }

        private class PaymentService
        {
            private readonly IPaymentGateway _gateway;
            public PaymentService(IPaymentGateway gateway) => _gateway = gateway;
            public void Checkout(decimal amount) => _gateway.SendPayment(amount);
        }

        // Organizational example using abstractions
        private interface IDeveloper { void WriteCode(); }
        private class Developer : IDeveloper { public void WriteCode() => Console.WriteLine("Developer writing code"); }
        private interface IManager { void Assign(IDeveloper dev); }
        private class Manager : IManager { public void Assign(IDeveloper dev) { Console.WriteLine("Manager assigns task"); dev.WriteCode(); } }
        private class CEO { private readonly IManager _manager; public CEO(IManager manager) => _manager = manager; public void RunCompany(IDeveloper dev) { Console.WriteLine("CEO instructs manager"); _manager.Assign(dev); } }
    }
}
