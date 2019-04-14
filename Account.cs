using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account          
        {
        protected double deposit;
        protected double withdrawal;
        private double accountNumber;
        protected string accountType;
        protected double balance;
        private int customerID { get; set; }

        public string AccountType
        { get { return this.accountType; } }


        public double AcctNumber
        { get { return this.accountNumber; } }



        public double Bal
        { get { return this.balance; } }

        public virtual double AccountNumb()
        {
            Random rand = new Random();
            this.accountNumber = rand.Next(100000000, 1000000000);
            return accountNumber;
        }

        public virtual double Balance()
        {
            balance = balance + deposit - withdrawal;
            deposit = 0;
            withdrawal = 0;
            return balance;
        }

        //Computers Balance when withdrawal equals zero
        public virtual double DepositBalance(double input)
        {
            deposit = input;
            withdrawal = 0;
            balance = balance + deposit - withdrawal;
            return balance;
        }



        //Computers balance when deposit equals zero
        public virtual double WithBalance(double input)
        {
            withdrawal = input;
            deposit = 0;
            balance = balance + deposit - withdrawal;
            return balance;
        }

    }

}  


