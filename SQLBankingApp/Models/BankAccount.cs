using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBankingApp.Models
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string Name { get; private set; }
        private double Balance { get; set; }
        private string Password { get; set; }

        public BankAccount()
        {
            
        }

        public BankAccount(string accountNumber, string name, double balance, string password)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
            Password = password;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CheckBalance()
        {
            return Balance;
        }

        public bool VerifyPassword(string inputPassword)
        {
            return Password == inputPassword;
        }
    }
}
