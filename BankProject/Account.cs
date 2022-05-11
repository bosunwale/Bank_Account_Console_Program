using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{ 
    internal class Account
    {
      
        private double totalAmount;
        private double chequingAccountBalance;
        private double savingsAccountBalance;

        private string firstName;
        private string lastName;
        private string password;

        public string createAccount()
        {
            Console.WriteLine("Please Enter your FirstName");
            firstName = Console.ReadLine();
            Console.WriteLine("Please Enter your LastName");
            lastName = Console.ReadLine();
            Console.WriteLine("Please Enter your password");
            password = Console.ReadLine();
            return $"Account succesffuly created!!!";
        }

        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public double TotalAmount
        {
            get { return totalAmount; }
        }

        public void Deposit()
        {
            Console.WriteLine("Choose account to deposit into.");
            Console.WriteLine("Enter amount to deposit");
            double input = Convert.ToDouble(Console.ReadLine());
            totalAmount += input;
            Console.WriteLine($"{input:C} successfully deposited");
        }

        public void Withdrawal()
        {
            Console.WriteLine("Choose account to withdraw from.");
            Console.WriteLine("Enter amount to withdraw");
            double input = Convert.ToDouble(Console.ReadLine());
            totalAmount -= input;
            Console.WriteLine($"{input:C} successfully withdrawed");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Account Name:{FirstName +" "+ LastName}\nBalance:{TotalAmount}");
        }
        
    }
}
