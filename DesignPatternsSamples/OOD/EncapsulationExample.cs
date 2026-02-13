using System;

namespace DesignPatternsSamples.OOD
{
    // Encapsulation
    public static class EncapsulationExample
    {
        public static void Run()
        {
            var account = new BankAccount(500);
            Console.WriteLine("Initial balance: "+account.GetBalance()+" rs");

            account.Deposit(200);
            Console.WriteLine("Balance after deposit: "+account.GetBalance()+" rs");

            bool ok = account.Withdraw(800);
            Console.WriteLine(ok ? "Withdrawal successful." : "Withdraw fail (insufficient balance).");
            Console.WriteLine("Final balance: "+account.GetBalance()+" rs");

        }
    }

    public class BankAccount
    {
        private int _balance;

        public BankAccount(int initialBalance)
        {
            if (initialBalance < 0) initialBalance = 0;
            _balance = initialBalance;
        }

        public void Deposit(int amount)
        {
            if (amount <= 0) return;
            _balance += amount;
        }

        public bool Withdraw(int amount)
        {
            if (amount > _balance) return false;
            _balance -= amount;
            return true;
        }

        public decimal GetBalance() => _balance;
    }
}
