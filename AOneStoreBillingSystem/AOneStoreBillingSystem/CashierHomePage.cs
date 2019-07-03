using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOneStoreBillingSystem
{
    public partial class CashierHomePage : Form
    {
        private string loggedInCashierId;
        public CashierHomePage(string loggedInCashierId)
        {
            this.loggedInCashierId = loggedInCashierId;
            InitializeComponent();
        }

        private void CashierHomePage_Load(object sender, EventArgs e)
        {

        }

        private void Bill_MenuStrip_Click(object sender, EventArgs e)
        {
            CloseOpenedChildForm();
            EnableDisbaledMenuStripItem();
            BillPage billingPage = new BillPage();
            billingPage.MdiParent = this;
            billingPage.StartPosition = FormStartPosition.CenterScreen;
            billingPage.Show();
            Bill_MenuStrip.Enabled = false;
        }

        private void LogOut_Cashier_MenuStrip_Click(object sender, EventArgs e)
        {
            BusinessLayer.Cashier cashierLogout = new BusinessLayer.Cashier();
            cashierLogout.AddCashierLastLogoutTime(Convert.ToInt32(loggedInCashierId));
            this.Close();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void CloseOpenedChildForm()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        private void EnableDisbaledMenuStripItem()
        {
            for (int i = 0; i < Cashier_HomePage_MenuStrip.Items.Count; i++)
            {
                if (!Cashier_HomePage_MenuStrip.Items[i].Enabled)
                {
                    Cashier_HomePage_MenuStrip.Items[i].Enabled = true;
                }
            }
        }
    }
}
