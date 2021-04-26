using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTMBank
{
    class Account
    {
        string accountType;
        string owner;
        int accID;
        double balance;

        public Account(string at, string own,int id,double bal)
        {
            accountType = at;
            owner = own;
            accID = id;
            balance = bal;
        }

        public int getID() { return accID; }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public override string ToString()
        {
            return accID + "  " + owner + " \t" + accountType + " \t\t" + balance + "\r\n";  
        }
    }
}
