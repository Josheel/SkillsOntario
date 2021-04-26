using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTMBank
{
    class AccountManager
    {
        private Account[] accounts;
        private int maxAccounts;
        private int numAccounts;

        public AccountManager(int max)
        {
            maxAccounts = max;
            numAccounts = 0;
            accounts = new Account[maxAccounts];
        }

        public bool addAccount(string accType, string owner, int id, double balance)
        {
            if (numAccounts < maxAccounts)
            {
                accounts[numAccounts] = new Account(accType, owner, id, balance);
                numAccounts++;
                return true;
            }
            return false;
        }

        public int search(int id)
        {
            for(int i = 0; i < numAccounts; i++)
            {
                if(accounts[i].getID() == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public string getAccountInfo(int id)
        {
            string output = "Account does not exist.";
            int result = search(id);

            if(result != -1)
            {
                return accounts[result].ToString();
            }
            return output;
        }

        public string getAccountsList()
        {
            string output = "ID  Name\t\tAccountType   Balance\r\n";
        
            for(int i = 0; i < numAccounts; i++){ 
                output += accounts[i].ToString();
            }

            return output;
        }

        public bool accountWithdraw(int id, double amount)
        {
            int acc = search(id);
            if(acc >= 0)
            {
                if ((accounts[acc].Balance - amount) > 0)
                {
                    accounts[acc].Balance = accounts[acc].Balance - amount;
                    return true;
                }
                else
                    return false;
            }

            return false;
        }

        public bool deposit(int id, double amount)
        {
            int acc = search(id);
            if (acc >= 0)
            {
                accounts[acc].Balance = accounts[acc].Balance + amount;
                return true;
            }

            return false;
        }

        public bool deleteAccount(int id)
        {
            int acc = search(id);
            if(search(id) >= 0)
            {
                for(int i = acc; i < (numAccounts - 1); i++)
                {
                    accounts[i] = accounts[i + 1];
                }
                numAccounts--;
                return true;
            }

            return false;
        }
    }
}
