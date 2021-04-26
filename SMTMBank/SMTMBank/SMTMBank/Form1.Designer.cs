
namespace SMTMBank
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccID = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.txtAccBalance = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccIDTransaction = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountTransaction = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataAccountInfo = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.addAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addAccountToolStripMenuItem.Text = "Add Account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "SMTM Bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(288, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Give Us Your Money";
            // 
            // lblAccID
            // 
            this.lblAccID.AutoSize = true;
            this.lblAccID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccID.Location = new System.Drawing.Point(253, 96);
            this.lblAccID.Name = "lblAccID";
            this.lblAccID.Size = new System.Drawing.Size(37, 24);
            this.lblAccID.TabIndex = 5;
            this.lblAccID.Text = "ID: ";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccName.Location = new System.Drawing.Point(253, 152);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(71, 24);
            this.lblAccName.TabIndex = 6;
            this.lblAccName.Text = "Name: ";
            // 
            // lblAccType
            // 
            this.lblAccType.AutoSize = true;
            this.lblAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccType.Location = new System.Drawing.Point(253, 215);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(68, 24);
            this.lblAccType.TabIndex = 7;
            this.lblAccType.Text = "Type:  ";
            // 
            // lblAccBalance
            // 
            this.lblAccBalance.AutoSize = true;
            this.lblAccBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccBalance.Location = new System.Drawing.Point(253, 270);
            this.lblAccBalance.Name = "lblAccBalance";
            this.lblAccBalance.Size = new System.Drawing.Size(88, 24);
            this.lblAccBalance.TabIndex = 8;
            this.lblAccBalance.Text = "Balance: ";
            // 
            // txtAccID
            // 
            this.txtAccID.Location = new System.Drawing.Point(392, 101);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(128, 20);
            this.txtAccID.TabIndex = 9;
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(392, 152);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Size = new System.Drawing.Size(128, 20);
            this.txtAccName.TabIndex = 10;
            // 
            // txtAccType
            // 
            this.txtAccType.Location = new System.Drawing.Point(392, 215);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.Size = new System.Drawing.Size(128, 20);
            this.txtAccType.TabIndex = 11;
            // 
            // txtAccBalance
            // 
            this.txtAccBalance.Location = new System.Drawing.Point(392, 275);
            this.txtAccBalance.Name = "txtAccBalance";
            this.txtAccBalance.Size = new System.Drawing.Size(128, 20);
            this.txtAccBalance.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStatus.Location = new System.Drawing.Point(503, 395);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 13;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(344, 316);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(122, 25);
            this.btnAddAccount.TabIndex = 14;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(30, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Account ID: ";
            // 
            // txtAccIDTransaction
            // 
            this.txtAccIDTransaction.Location = new System.Drawing.Point(172, 378);
            this.txtAccIDTransaction.Name = "txtAccIDTransaction";
            this.txtAccIDTransaction.Size = new System.Drawing.Size(100, 20);
            this.txtAccIDTransaction.TabIndex = 17;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(310, 375);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 18;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(310, 416);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 19;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(30, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Amount:";
            // 
            // txtAmountTransaction
            // 
            this.txtAmountTransaction.Location = new System.Drawing.Point(172, 419);
            this.txtAmountTransaction.Name = "txtAmountTransaction";
            this.txtAmountTransaction.Size = new System.Drawing.Size(100, 20);
            this.txtAmountTransaction.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(592, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataAccountInfo
            // 
            this.dataAccountInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccountInfo.Location = new System.Drawing.Point(172, 130);
            this.dataAccountInfo.Name = "dataAccountInfo";
            this.dataAccountInfo.Size = new System.Drawing.Size(443, 242);
            this.dataAccountInfo.TabIndex = 23;
            this.dataAccountInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAccountInfo_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAmountTransaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtAccIDTransaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtAccBalance);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtAccID);
            this.Controls.Add(this.lblAccBalance);
            this.Controls.Add(this.lblAccType);
            this.Controls.Add(this.lblAccName);
            this.Controls.Add(this.lblAccID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataAccountInfo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccountInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAccID;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.Label lblAccBalance;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.TextBox txtAccName;
        private System.Windows.Forms.TextBox txtAccType;
        private System.Windows.Forms.TextBox txtAccBalance;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccIDTransaction;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmountTransaction;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataAccountInfo;
    }
}

