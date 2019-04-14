using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Transaction
    {
        protected double deposit;
        protected double withdrawal;

        public double Withdrawal
        {
            get { return this.withdrawal; }
            set { this.withdrawal = value; }
        }


        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }
    }
}
