using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SMTMBank
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Josheel\\source\\repos\\SMTMBank\\SMTMBank\\SMTMBank\\Accounts.mdf;Integrated Security=True";
            
            SystemCoordinator sc = new SystemCoordinator(10, connection);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(sc));
        }
    }
}
