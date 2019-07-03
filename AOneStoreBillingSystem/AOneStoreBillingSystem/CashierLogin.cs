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

namespace AOneStoreBillingSystem
{
    public partial class CashierLogin : Form
    {
        private Cashier cashier;
        private BackgroundWorker backgroundWorker;

        public CashierLogin()
        {
            InitializeComponent();
            cashier = new Cashier();
        }

        private void Showpassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            cashierPassword_textBox.UseSystemPasswordChar = !Showpassword_checkBox.Checked;
        }

        private void adminPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            cashierPassword_textBox.UseSystemPasswordChar = true;
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            int cashierId;
            Loginbutton.Enabled = false;
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += AuthenticateAdmin;
            backgroundWorker.RunWorkerCompleted += ShowAdminHomePage;
            if (!string.IsNullOrWhiteSpace(cashierUserId_textBox.Text) && !string.IsNullOrWhiteSpace(cashierPassword_textBox.Text))
            {
                if(int.TryParse(cashierUserId_textBox.Text, out cashierId))
                {
                    backgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Cashier ID Not In valid Format");
                    Loginbutton.Enabled = true;
                }
                
            }
            else
            {
                MessageBox.Show("Cashier_FillAllFields");
                Loginbutton.Enabled = true;
            }
        }

        private void AuthenticateAdmin(object sender, DoWorkEventArgs e)
        {
            e.Result = cashier.IsCashierAuthenticated(int.Parse(cashierUserId_textBox.Text), cashierPassword_textBox.Text);
        }

        private void ShowAdminHomePage(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isAuthenticated = (bool)e.Result;
            if (isAuthenticated)
            {
                CashierHomePage cashierHomePage = new CashierHomePage(cashierUserId_textBox.Text);
                this.Close();
                cashierHomePage.Show();
            }
            else
            {
                MessageBox.Show("Cashier_InvalidUserNamePassword");
            }
            Loginbutton.Enabled = true;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
