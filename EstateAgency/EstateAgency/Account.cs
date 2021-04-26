using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
   
    class Account
    {
        private int accountID;
        private string name;
        private string address;
        private string accountType;

        public Account(string nm, string addr, string type, int id)
        {
            name = nm;
            address = addr;
            accountType = type;
            accountID = id;
        }

        public int getID(){ return accountID; }
        public string getName() { return name; }
        public string getAccountType() { return accountType; }
        public string getAddress() { return address; }
        public string toString()
        {
            string str = accountID + "\t " + name + "\t " + address + "\t " + getAccountType(); 
            return str;
        }
    }
}
