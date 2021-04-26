using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using Oracle.VsDevTools;

namespace SMTMBank
{
    class DatabaseManager
    {
        string connection;
        SqlConnection con;
        public DatabaseManager(string conStr)
        {
            connection = conStr;
            con = new SqlConnection(connection);
        }

        public bool addAccount(int id, string name, string accType, double balance)
        {
            executeQuery("Insert into tbl_Accounts (id,name,type,balance) values (" + id + ",'" + name + "','" + accType + "'," + balance + ");");
            return true;
        }

        public bool deleteAccount(int id)
        {
            executeQuery("Delete from tbl_Accounts where id="+id);
            return true;
        }

        

        public DataTable getAccounts()
        {
            string getAcc = "Select * from tbl_Accounts";
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = getAcc;
            command.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(command);
            dAdapter.Fill(dTable);
            con.Close();
            return dTable;
        }

        public bool withdraw(int id, double amount)
        {
            executeQuery("update tbl_Accounts set balance = balance - " + amount + " where id = " + id);
            return true;
        }

        public bool deposit(int id, double amount)
        {
            executeQuery("update tbl_Accounts set balance = balance + " + amount + " where id = " + id);
            return true;
        }

        public void executeQuery(string str)
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = str;
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
