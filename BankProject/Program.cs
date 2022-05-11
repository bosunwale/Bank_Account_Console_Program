using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            
            BankOperation bankOperationObj = new BankOperation();
            Console.WriteLine(bankOperationObj.createAccount());
            Console.WriteLine(bankOperationObj.ChooseOperation());
            

            /*
            for(; ; )
            {
                Console.WriteLine("Guess the correct number");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input == 3)
                {
                    Console.WriteLine("Congratulations");
                    break;
                }else if(input == 1)
                {
                    Console.WriteLine("Try again");
                }else if (input == 2)
                {
                    Console.WriteLine("Try again");
                }
            }*/
        }
        
    }
}
