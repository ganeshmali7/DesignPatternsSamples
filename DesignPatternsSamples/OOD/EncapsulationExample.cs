using System;

namespace DesignPatternsSamples.OOD
{
    // EncapsulationExample.cs
    // Tiny human story: Raj opens a bank account and uses deposit/withdraw safely.
    public static class EncapsulationExample
    {
        public static void Run()
        {
            Console.WriteLine("Encapsulation — Raj's bank account (safe access)");
            Console.WriteLine("------------------------------------------------");

            var account = new BankAccount(500m); // starting balance
            Console.WriteLine($"Starting balance: {account.GetBalance()} rupees");

            Console.WriteLine("Raj deposits 200 rupees...");
            account.Deposit(200m);
            Console.WriteLine($"Balance now: {account.GetBalance()} rupees");

            Console.WriteLine("Raj tries to withdraw 800 rupees...");
            bool ok = account.Withdraw(800m);
            Console.WriteLine(ok ? "Withdrawal succeeded." : "Withdrawal failed (insufficient funds).");
            Console.WriteLine($"Final balance: {account.GetBalance()} rupees");

            Console.WriteLine();
            Console.WriteLine("Note: Balance is private and can only be changed via Deposit/Withdraw — that's encapsulation.");
        }
    }

    // Simple bank account: internal state is private and protected by methods.
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal initialBalance = 0m)
        {
            if (initialBalance < 0) initialBalance = 0;
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) return;
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0) return false;
            if (amount > _balance) return false;
            _balance -= amount;
            return true;
        }

        public decimal GetBalance() => _balance;
    }
}
