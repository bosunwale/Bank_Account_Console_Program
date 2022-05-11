using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class BankOperation:Account
    {
        public string ChooseOperation()
        {
            //int input;
            while(true)
            {
                Console.WriteLine("Choose an operation\n1. DEPOSIT\n2. WITHDRAW\n3. CHECK BALANCE\n4. EXIT");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 4)
                {
                    break;
                }
                else if (input == 1)
                {
                     Deposit();
                }
                else if (input == 2)
                {
                    Withdrawal();
                }
                else if(input == 3)
                {
                    CheckBalance();
                }
            }
            return "Thank you for banking with us";
        }
    }
}
