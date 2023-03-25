using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodi
{
    internal class BankAccount
    {
        private int id;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private double balance;

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Whitdraw(double amount)
        {
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {this.id}, balance {this.balance}";
        }
    }
}
