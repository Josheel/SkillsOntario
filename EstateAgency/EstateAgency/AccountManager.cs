using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class AccountManager
    {
        List<Account> accounts;
        int numAccounts;

        public AccountManager()
        {
            accounts = new List<Account>();
            numAccounts = 0;
        }

        public Boolean addBuyer(string name, string address)
        {
            accounts.Add(new Buyer(name, address, "buyer", numAccounts));
            numAccounts++;
            return true;
        }

        public Boolean addSeller(string name, string address)
        {
            accounts.Add(new Seller(name, address, "seller", numAccounts));
            numAccounts++;
            return true;
        }

        public Account getAccount(int id)
        {
            foreach (Account account in accounts)
            {
                if(account.getID() == id)
                    return account;
            }

            return null;
        }

        public string getAccountList()
        {
            String str = "ID Name\t Address\t Account Type\n";
            foreach (Account account in accounts)
            {
                str += account.toString() + "\n";
            }
            return str;
        }
    }
}
