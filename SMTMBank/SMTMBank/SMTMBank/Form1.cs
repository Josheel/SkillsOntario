using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SMTMBank
{
    
    public partial class Form1 : Form
    {
        SystemCoordinator sc;
        public Form1(SystemCoordinator symCon)
        {
            InitializeComponent();
            sc = symCon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAccBalance.Hide();
            txtAccID.Hide();
            txtAccName.Hide();
            txtAccType.Hide();
            lblAccBalance.Hide();
            lblAccID.Hide();
            lblAccName.Hide();
            lblAccType.Hide();
            btnAddAccount.Hide();
            btnDelete.Hide();
            dataAccountInfo.DataSource = sc.getAccounts();
            dataAccountInfo.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAccBalance.Hide();
            txtAccID.Hide();
            txtAccName.Hide();
            txtAccType.Hide();
            lblAccBalance.Hide();
            lblAccID.Hide();
            lblAccName.Hide();
            lblAccType.Hide();
            btnAddAccount.Hide();
            btnDelete.Hide();
            lblStatus.Text = "";

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            txtAccIDTransaction.Show();
            txtAmountTransaction.Show();
            btnWithdraw.Show();
            btnDeposit.Show();
            dataAccountInfo.DataSource = sc.getAccounts();
            dataAccountInfo.Show();

            txtAccID.Clear();
            txtAccName.Clear();
            txtAccType.Clear();
            txtAccBalance.Clear();
        }

        private void addAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            dataAccountInfo.Hide();
            label3.Hide();
            label4.Hide();
            txtAccIDTransaction.Hide();
            txtAmountTransaction.Hide();
            btnWithdraw.Hide();
            btnDeposit.Hide();
            btnDelete.Hide();

            txtAccBalance.Show();
            txtAccID.Show();
            txtAccName.Show();
            txtAccType.Show();
            lblAccBalance.Show();
            lblAccID.Show();
            lblAccName.Show();
            lblAccType.Show();
            btnAddAccount.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {          
            int id = Convert.ToInt32(txtAccID.Text);
            string name = txtAccName.Text;
            string type = txtAccType.Text;
            double balance = Convert.ToDouble(txtAccBalance.Text);
            sc.addDB(id,name,type,balance);
            if (sc.addAccount(type, name, id, balance)){
                lblStatus.Text = "Acount added successfully";
                txtAccID.Clear();
                txtAccName.Clear();
                txtAccType.Clear();
                txtAccBalance.Clear();
            }
            else
            {
                lblStatus.Text = "Coult not add account";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAccIDTransaction.Text);
            double amount = Convert.ToDouble(txtAmountTransaction.Text);

            if (sc.withdrawDB(id, amount))
            {
                lblStatus.Text = "Amount withdrawn";
            }
            else
            {
                lblStatus.Text = "Cannot withdraw amount";
            }

            dataAccountInfo.DataSource = sc.getAccounts();
            dataAccountInfo.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAccIDTransaction.Text);
            double amount = Convert.ToDouble(txtAmountTransaction.Text);

            if (sc.depositDB(id, amount))
            {
                lblStatus.Text = "Amount deposited";
            }
            else
            {
                lblStatus.Text = "Cannot deposit amount";
            }

            dataAccountInfo.DataSource = sc.getAccounts();
            dataAccountInfo.Show();
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            txtAccIDTransaction.Hide();
            txtAmountTransaction.Hide();
            btnWithdraw.Hide();
            btnDeposit.Hide();
            txtAccBalance.Hide();
            txtAccName.Hide();
            txtAccType.Hide();
            lblAccBalance.Hide();         
            lblAccName.Hide();
            lblAccType.Hide();
            btnAddAccount.Hide();
            lblStatus.Text = "";

            lblAccID.Show();
            txtAccID.Show();
            btnDelete.Show();
            dataAccountInfo.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAccID.Text);

            if (sc.deleteDB(id))
            {
                lblStatus.Text = "Account Deleted";
            }
            else
            {
                lblStatus.Text = "Cannot Delete Account";
            }
            dataAccountInfo.DataSource = sc.getAccounts();
            dataAccountInfo.Show();
        }

        private void dataAccountInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
