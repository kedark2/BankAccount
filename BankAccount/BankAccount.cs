using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class BankAccount
    {
        private String owner;
        private double interestRate;
        private decimal balance;
        public BankAccount (String own, decimal bal, double inter) {
            interestRate = inter;
            owner = own;
            balance = bal;
        }
        public decimal Balance() {
            
             return balance; 
            
        }
        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        public virtual void AddInterests()
        {
            balance += balance * (Decimal)interestRate;
        }
     
    }
}
