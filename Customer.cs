using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Customer
    {
        private int customerID { get; set; }
        private string organisationNumber;
        private string companyName;        
        private string adress;
        private string city;
        private string region;
        private string postcode;
        private string country;
        private string tel;

        public Customer(int id, string org, string cname, string ad,
            string cty, string reg, string pcode, string ctry, string tele)
        {
            customerID = id;
            organisationNumber = org;
            companyName = cname;
            adress = ad;
            city = cty;
            region = reg;
            postcode = pcode;
            country = ctry;
            tel = tele;
    }

        public void Account()
        {
            string companyName = Console.ReadLine();
        }
    }

}
