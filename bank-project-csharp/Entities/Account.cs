using System;
using System.Collections.Generic;
using System.Text;
using bank_project_csharp.Entities.Exceptions;
using System.Globalization;

namespace bank_project_csharp.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; } 

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            deposit(balance);
            WithDrawLimit = withDrawLimit;
        }

        public void deposit(double amount)
        {
            if(amount < 0.0)
            {
                throw new AccountExpection("The deposit amount cannot be less than or equal to zero.");
            }
            else
            {
                Balance += amount;
            }
        }

        public void withdraw(double amount)
        {
            if (amount > WithDrawLimit || amount < 0.0)
            {
                throw new AccountExpection("The amount exceeds withdraw limit or minus 0");
            }
            else if (amount > Balance)
            {
                throw new AccountExpection("Not enough balance");
            }
            else
            {
                Balance -= amount;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("New balance: " + Balance.ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
