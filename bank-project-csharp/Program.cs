using bank_project_csharp.Entities;
using bank_project_csharp.Entities.Exceptions;
using System;
using System.Globalization; 
using System.Reflection.Metadata;
namespace BankProjectCharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
                Console.WriteLine("Enter account data");
                Console.Write("Number:");
                int number = int.Parse(Console.ReadLine());
                //8021
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                // Bob Brown
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //500.00
                Console.Write("Withdraw limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //300.00
                Account account = new Account(number, holder, balance, withDrawLimit);
                Console.Write("Enter amount for withdraw: "); 
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.withdraw(amount); 
                //Enter amount for withdraw: 100.00
                //New balance: 400.00
            
                Console.WriteLine(account);
            }
            catch (AccountExpection e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }



        }
    }
}
