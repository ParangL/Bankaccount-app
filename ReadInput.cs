using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class ReadInput 
    {
        private string[] parameters;
        public void parsInput(string s)
        {          
             parameters = s.Split(';');
        }    
        
        public void assignCustomerData()
        {
            int id = int.Parse(parameters[0]);
            string org = parameters[1];
            string cname = parameters[2];
            string ad = parameters[3];
            string cty = parameters[4];
            string reg = parameters[5];
            string pcode = parameters[6];
            string ctry = parameters[7];
            string tele = parameters[8];
                  
            Customer customer = new Customer(id, org, cname, ad, cty, reg, pcode, ctry, tele);
                      
        }

        public void assignAccountData()
        {

        }

        
        


    }
}

