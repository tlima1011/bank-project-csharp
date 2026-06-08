using System;
using System.Collections.Generic;
using System.Text;

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

            }
        }


    }
}
