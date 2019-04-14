using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            //displays online banking menu            
            string companyName = Console.ReadLine() ;

            //client info            
            Console.WriteLine("Account Holder: " + companyName);

            Console.WriteLine("Fake US Bank Inc.\nWelcome to your online bank account, " + companyName);
            Console.WriteLine("Please choose from the options below:\n1.View Client Info\n2.View Account Balance:");
            Console.WriteLine("     2A.Checking\n     2B.Reserve\n     2C.Savings");
            Console.WriteLine("3.Deposit Funds:\n     3A.Checking\n     3B.Reserve\n     3C.Savings");
            Console.WriteLine("4.Withdraw Funds:\n     4A.Checking\n     4B.Reserve\n     4C.Savings");
            Console.WriteLine("5.Exit");
           

           
           

            Console.ReadKey();
        }
    
    }
}
