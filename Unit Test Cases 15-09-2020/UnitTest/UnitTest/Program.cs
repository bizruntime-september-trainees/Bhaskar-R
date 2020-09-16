using System;

namespace UnitTest
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("insufficient funds");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("debited amount  should be greater than 1");
            }

            m_balance -= amount;
           // m_balance += amount; 
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("credited amountshould be greater than 1");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}

