using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using CommonClasses;
using System.Text.RegularExpressions;

namespace AOneStoreBillingSystem
{
    public partial class AddCashierPage : Form
    {
        public Admin admin;
        private BackgroundWorker backgroundWorker;
        public List<ListViewItem> cashierDetails;
        private string selectedCashierId;
        private string selectedCashierName;
        private string selectedCashierMobileNumber;
        private string selectedCashierPassword;
        private string lastCashierIdCreated;
        private bool isCashierDeleted;
        public AddCashierPage()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void AddCashierPage_Load(object sender, EventArgs e)
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += LoadAllCashierDetails;
            backgroundWorker.RunWorkerCompleted += AddCashierDetailsToListView;
            backgroundWorker.RunWorkerAsync();
        }

        private void AddCashier_button_Click(object sender, EventArgs e)
        {
            bool isCashierDetailsSaved = false;
            double number;
            if (!string.IsNullOrWhiteSpace(CashierName_textBox.Text) && !string.IsNullOrWhiteSpace(CashierNumber_textBox.Text) &&
                !string.IsNullOrWhiteSpace(CashierPassword_textBox.Text) && !string.IsNullOrWhiteSpace(CashierConformPassword_textBox.Text))
            {
                if (!Regex.IsMatch(CashierName_textBox.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show(Constants.ENTER_VALID_PERSON_NAME);
                }
                else if (!double.TryParse(CashierNumber_textBox.Text, out number))
                {
                    MessageBox.Show(Constants.ENTER_VALID_PHONE_NUMBER);
                }
                else if (!CashierPassword_textBox.Text.Equals(CashierConformPassword_textBox.Text))
                {
                    MessageBox.Show(Constants.PASSWORD_ERROR_MESSAGE);
                }
                else
                {
                    isCashierDetailsSaved = admin.SaveCashierDetails(CashierName_textBox.Text, Convert.ToInt32(CashierId_textBox.Text), CashierPassword_textBox.Text, CashierNumber_textBox.Text);
                }
            }
            else
            {
                MessageBox.Show(Constants.ENTER_ALL_TEXTFIELD_MESSAGE);
            }

            if (isCashierDetailsSaved)
            {
                MessageBox.Show(Constants.CASHIER_ADDED_MESSAGE);
                ListViewItem listView = new ListViewItem((AllCashier_ListView.Items.Count > 0 ? (Convert.ToInt32(AllCashier_ListView.Items[AllCashier_ListView.Items.Count - 1].SubItems[0].Text) + 1).ToString() : "1"));
                listView.SubItems.Add(CashierName_textBox.Text);
                listView.SubItems.Add(CashierId_textBox.Text);
                listView.SubItems.Add(CashierNumber_textBox.Text);
                AllCashier_ListView.Items.Add(listView);
                lastCashierIdCreated = CashierId_textBox.Text = (int.Parse(CashierId_textBox.Text) + 1).ToString();
                CashierName_textBox.Text = CashierNumber_textBox.Text = CashierPassword_textBox.Text = CashierConformPassword_textBox.Text = string.Empty;
            }
        }

        private void AllCashier_ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = AllCashier_ListView.Columns[e.ColumnIndex].Width;
        }

        private void CashierPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            CashierPassword_textBox.UseSystemPasswordChar = true;
        }

        private void AllCashier_ListView_Click(object sender, EventArgs e)
        {
            AddCashier_button.Enabled = false;
            UpdateCashier_button.Enabled = true;
            DeleteCashier_button.Enabled = true;
            var selectedCashier = AllCashier_ListView.SelectedItems;
            selectedCashierId = selectedCashier[0].SubItems[2].Text;
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += GetSelecetdCashierDetails;
                backgroundWorker.RunWorkerCompleted += LoadDataIntoTextBoxesForSelectedCashier;
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                backgroundWorker.CancelAsync();
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void LoadAllCashierDetails(object sender, DoWorkEventArgs e)
        {
            cashierDetails = new List<ListViewItem>();
            List<CashierDetail> allCashierDetails = admin.GetAllCashierDetails();

            if (allCashierDetails.Count > 0)
            {
                for (int i = 0; i < allCashierDetails.Count; i++)
                {
                    ListViewItem listView = new ListViewItem((i + 1).ToString());
                    listView.SubItems.Add(allCashierDetails[i].CashierName);
                    listView.SubItems.Add(allCashierDetails[i].CashierID.ToString());
                    listView.SubItems.Add(allCashierDetails[i].MobileNumber);
                    cashierDetails.Add(listView);
                }
            }
            if (e != null)
            {
                e.Result = allCashierDetails;
            }
        }
        private void AddCashierDetailsToListView(object sender, RunWorkerCompletedEventArgs e)
        {
            AllCashier_ListView.Items.AddRange((cashierDetails.ToArray()));
            if (e.Result.GetType() != typeof(bool))
            {
                List<CashierDetail> cashiers = (List<CashierDetail>)e.Result;
                if (cashiers != null && cashiers.Count > 0)
                {
                    lastCashierIdCreated = CashierId_textBox.Text = (cashiers.Max(obj => obj.CashierID) + 1).ToString();
                }
                else
                {
                    CashierId_textBox.Text = Constants.DEFAULT_STARTING_CASHIER_ID;
                }
            }
        }

        private void GetSelecetdCashierDetails(object sender, DoWorkEventArgs e)
        {
            CashierDetail selectedCashierDetails = admin.GetSelectedCashierDetails(int.Parse(selectedCashierId));
            e.Result = selectedCashierDetails;
        }

        private void LoadDataIntoTextBoxesForSelectedCashier(object sender, RunWorkerCompletedEventArgs e)
        {
            CashierDetail selectedCashierDetails = (CashierDetail)e.Result;
            CashierId_textBox.Text = selectedCashierDetails.CashierID.ToString();
            selectedCashierName = CashierName_textBox.Text = selectedCashierDetails.CashierName;
            selectedCashierMobileNumber = CashierNumber_textBox.Text = selectedCashierDetails.MobileNumber;
            selectedCashierPassword = CashierPassword_textBox.Text = new EncryptionDecryption().Decryptdata(selectedCashierDetails.Password);
        }

        private void ClearAllFields_button_Click(object sender, EventArgs e)
        {
            AddCashier_button.Enabled = true;
            UpdateCashier_button.Enabled = false;
            DeleteCashier_button.Enabled = false;
            CashierId_textBox.Text = lastCashierIdCreated;
            CashierName_textBox.Text = string.Empty;
            CashierNumber_textBox.Text = string.Empty;
            CashierPassword_textBox.Text = string.Empty;
            CashierConformPassword_textBox.Text = string.Empty;

        }

        private void UpdateCashier_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CashierName_textBox.Text) && !string.IsNullOrWhiteSpace(CashierNumber_textBox.Text) &&
                !string.IsNullOrWhiteSpace(CashierPassword_textBox.Text) && !string.IsNullOrWhiteSpace(CashierConformPassword_textBox.Text))
            {
                if (CashierPassword_textBox.Text.Equals(CashierConformPassword_textBox.Text))
                {
                    if (!selectedCashierName.Equals(CashierName_textBox.Text) || !selectedCashierMobileNumber.Equals(CashierNumber_textBox.Text) ||
                        !selectedCashierPassword.Equals(CashierPassword_textBox.Text))
                    {
                        BackgroundWorker backgroundWorker = new BackgroundWorker();
                        backgroundWorker.DoWork += UpdateCashierDetails;
                        backgroundWorker.RunWorkerCompleted += UpdateCashierDetailsCompleted;
                        backgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show(Constants.CASHIER_DETAILS_NOT_EDITED);
                    }
                }
                else
                {
                    MessageBox.Show(Constants.PASSWORD_ERROR_MESSAGE);
                }
            }
            else
            {
                MessageBox.Show(Constants.ENTER_ALL_TEXTFIELD_MESSAGE);
            }
        }

        private void UpdateCashierDetails(object sender, DoWorkEventArgs e)
        {
            CashierDetail updateCashier = new CashierDetail();
            updateCashier.CashierID = int.Parse(CashierId_textBox.Text);
            updateCashier.CashierName = CashierName_textBox.Text;
            updateCashier.MobileNumber = CashierNumber_textBox.Text;
            updateCashier.Password = new EncryptionDecryption().Encryptdata(CashierPassword_textBox.Text);
            e.Result = admin.UpdateCashierDetails(updateCashier);
        }

        private void UpdateCashierDetailsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isCashierUpdatedConformation = (bool)e.Result;
            if (isCashierUpdatedConformation)
            {
                MessageBox.Show(Constants.CASHIER_DETAILS_UPDATED);
                AllCashier_ListView.Items.Clear();
                LoadAllCashierDetails(sender, null);
                AddCashierDetailsToListView(sender, e);
                AddCashier_button.Enabled = true;
                UpdateCashier_button.Enabled = false;
                DeleteCashier_button.Enabled = false;
                CashierId_textBox.Text = lastCashierIdCreated;
                CashierName_textBox.Text = string.Empty;
                CashierNumber_textBox.Text = string.Empty;
                CashierPassword_textBox.Text = string.Empty;
                CashierConformPassword_textBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(Constants.CASHIER_DETAILS_UPDATE_ERROR_MESSAGE);
            }
        }

        private void DeleteCashier_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Constants.DELETE_CASHIER_CONFORMATION_MESSAGE, Constants.DELETE_CASHIER_MESSAGE_BOX_CAPTION, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BackgroundWorker backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += DeleteSelectedCashierFromListView;
                backgroundWorker.RunWorkerCompleted += LoadCashierDetailaAfterDeletion;
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void DeleteSelectedCashierFromListView(object sender, DoWorkEventArgs e)
        {
            isCashierDeleted = admin.DeletedSelectedCashier(int.Parse(CashierId_textBox.Text));
            LoadAllCashierDetails(sender, e);
        }

        private void LoadCashierDetailaAfterDeletion(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isCashierDeleted)
            {
                MessageBox.Show(Constants.CASHIER_DELETED_CONFORMATION_MESSAGE);
                AllCashier_ListView.Items.Clear();
                AddCashierDetailsToListView(sender, e);
                AddCashier_button.Enabled = true;
                UpdateCashier_button.Enabled = false;
                DeleteCashier_button.Enabled = false;
                CashierName_textBox.Text = string.Empty;
                CashierNumber_textBox.Text = string.Empty;
                CashierPassword_textBox.Text = string.Empty;
                CashierConformPassword_textBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(Constants.CASHIER_NOT_DELETED_MESSAGE);
            }
        }

    }
}
