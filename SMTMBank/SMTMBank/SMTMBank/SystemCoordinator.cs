using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SMTMBank
{
    public class SystemCoordinator
    {
        AccountManager accMan;
        DatabaseManager dataMan; 
        public SystemCoordinator(int max, string con)
        {
            accMan = new AccountManager(max);
            dataMan = new DatabaseManager(con);
        }

        public bool addAccount(string accType, string owner, int id, double balance)
        {
            return accMan.addAccount(accType, owner, id, balance);
        }

        public string getAccountInfo(int id)
        {
            return accMan.getAccountInfo(id);
        }

        public string getAccountsList()
        {
            return accMan.getAccountsList();
        }

        public bool withdraw(int id, double amount)
        {
            return accMan.accountWithdraw(id, amount);
        }

        public bool deposit(int id, double amount)
        {
            return accMan.deposit(id, amount);
        }

        public bool deleteAccount(int id)
        {
            return accMan.deleteAccount(id);
        }

        public bool addDB(int id, string name, string accType, double balance)
        {
            return dataMan.addAccount(id,name,accType,balance);
        }

        public DataTable getAccounts()
        {
            return dataMan.getAccounts();
        }

        public bool withdrawDB(int id, double amount)
        {
            return dataMan.withdraw(id, amount);
        }

        public bool depositDB(int id, double amount)
        {
            return dataMan.deposit(id, amount);
        }

        public bool deleteDB(int id)
        {
            return dataMan.deleteAccount(id);
        }
    }
}
