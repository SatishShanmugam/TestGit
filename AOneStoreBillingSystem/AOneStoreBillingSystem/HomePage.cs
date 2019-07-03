using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using CommonClasses;

namespace AOneStoreBillingSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
             new Admin().CheckDbConnection();
        }

        private void Admin_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminLogin adminPage = new AdminLogin();
            adminPage.Show();
        }

        private void Cashier_Btn_Click(object sender, EventArgs e)
        {
            Hide();
            CashierLogin cashierLoginPage = new CashierLogin();
            cashierLoginPage.Show();
        }
    }
}
