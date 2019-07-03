using BusinessLayer;
using CommonClasses;
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
    public partial class AddStockPage : Form
    {
        private Admin admin;
        private string selectedProductId;
        private BackgroundWorker backgroundWorkerForStock;
        private List<ListViewItem> productDetails;
        private string adminLoggedIn;
        private string selectedProductPrice;
        private string selectedProductQty;

        public AddStockPage(string adminId)
        {
            InitializeComponent();
            admin = new Admin();
            adminLoggedIn = adminId;
        }

        private void AddProduct_button_Click(object sender, EventArgs e)
        {
            bool isProductDetailsSaved = false;
            int number;
            decimal productPrice;
            if (!string.IsNullOrWhiteSpace(ProductId_textBox.Text) && !string.IsNullOrWhiteSpace(ProductName_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Description_textbox.Text) && !string.IsNullOrWhiteSpace(ProductPrice_textBox.Text) && !string.IsNullOrWhiteSpace(Quantity_textBox.Text))
            {
                if (!int.TryParse(ProductId_textBox.Text, out number))
                {
                    MessageBox.Show(Constants.ENTER_VALID_PRODUCT_ID);
                }
                else if (int.TryParse(ProductName_textBox.Text, out number))
                {
                    MessageBox.Show(Constants.ENTER_VALID_PRODUCT_NAME);
                }
                else if (int.TryParse(Description_textbox.Text, out number))
                {
                    MessageBox.Show(Constants.ENTER_VALID_DESCRIPTON_FOR_PRODUCT);
                }
                else if (!decimal.TryParse(ProductPrice_textBox.Text, out productPrice))
                {
                    MessageBox.Show(Constants.ENTER_VALID_PRICE_FOR_PRODUCT);
                }
                else if(!int.TryParse(Quantity_textBox.Text, out number))
                {
                    MessageBox.Show(Constants.ENTER_VALID_QUANTITY_NUMBER);
                }
                else
                {
                    bool isProductIdUsedAlready = admin.IsProductIdAvailable(Convert.ToInt32(ProductId_textBox.Text));

                    if(!isProductIdUsedAlready)
                    {
                        isProductDetailsSaved = admin.SaveProductDetails(Convert.ToInt32(ProductId_textBox.Text), ProductName_textBox.Text, Convert.ToDecimal(ProductPrice_textBox.Text), Description_textbox.Text, Convert.ToInt32(Quantity_textBox.Text), adminLoggedIn);
                    }
                    else
                    {
                        MessageBox.Show(Constants.PRODUCT_ID_AVAILABLE_MESSAGE);
                    }

                   
                }
            }
            else
            {
                MessageBox.Show(Constants.ENTER_ALL_TEXTFIELD_MESSAGE);
            }

            if (isProductDetailsSaved)
            {
                MessageBox.Show(Constants.PRODUCT_ADDED_MESSAGE);
                ListViewItem listView = new ListViewItem((AllProduct_ListView.Items.Count > 0 ? (Convert.ToInt32(AllProduct_ListView.Items[AllProduct_ListView.Items.Count - 1].SubItems[0].Text) + 1).ToString() : "1"));
                listView.SubItems.Add(ProductId_textBox.Text);
                listView.SubItems.Add(ProductName_textBox.Text);
                listView.SubItems.Add(Convert.ToDecimal(ProductPrice_textBox.Text).ToString("#,##0.00"));
                listView.SubItems.Add(Quantity_textBox.Text);
                AllProduct_ListView.Items.Add(listView);
                ProductName_textBox.Text = ProductId_textBox.Text = Description_textbox.Text = ProductPrice_textBox.Text = Quantity_textBox.Text = string.Empty;
            }
        }

        private void AddStockPage_Load(object sender, EventArgs e)
        {
            backgroundWorkerForStock = new BackgroundWorker();
            backgroundWorkerForStock.DoWork += LoadAllProductDetails;
            backgroundWorkerForStock.RunWorkerCompleted += AddProductDetailsToListView;
            backgroundWorkerForStock.RunWorkerAsync();
        }

        private void LoadAllProductDetails(object sender, DoWorkEventArgs e)
        {
            productDetails = new List<ListViewItem>();
            List<StockDetail> allStockDetails = admin.GetAllStockDetails();

            if (allStockDetails.Count > 0)
            {
                for (int i = 0; i < allStockDetails.Count; i++)
                {
                    ListViewItem listView = new ListViewItem((i + 1).ToString());
                    listView.SubItems.Add(allStockDetails[i].ProductId.ToString());
                    listView.SubItems.Add(allStockDetails[i].ProductName);
                    listView.SubItems.Add(allStockDetails[i].Price.ToString());
                    listView.SubItems.Add(allStockDetails[i].QuantityAvailable.ToString());
                    productDetails.Add(listView);
                }
            }
        }

        private void AddProductDetailsToListView(object sender, RunWorkerCompletedEventArgs e)
        {
            AllProduct_ListView.Items.AddRange((productDetails.ToArray()));
        }

        private void AllProduct_ListView_Click(object sender, EventArgs e)
        {
            AddProduct_button.Enabled = false;
            UpdateProduct_button.Enabled = true;
            DeleteProduct_button.Enabled = true;
            ProductId_textBox.ReadOnly = true;
            ProductName_textBox.ReadOnly = true;
            Description_textbox.ReadOnly = true;
            var selectedProduct = AllProduct_ListView.SelectedItems;
            selectedProductId = selectedProduct[0].SubItems[1].Text;

            if (!backgroundWorkerForStock.IsBusy)
            {
                backgroundWorkerForStock = new BackgroundWorker();
                backgroundWorkerForStock.DoWork += GetSelecetdProductDetails;
                backgroundWorkerForStock.RunWorkerCompleted += LoadDataIntoTextBoxesForSelectedProduct;
                backgroundWorkerForStock.RunWorkerAsync();
            }
            else
            {
                backgroundWorkerForStock.CancelAsync();
                backgroundWorkerForStock.RunWorkerAsync();
            }
        }

        private void GetSelecetdProductDetails(object sender, DoWorkEventArgs e)
        {
            StockDetail selectedCashierDetails = admin.GetSelectedProductDetails(int.Parse(selectedProductId));
            e.Result = selectedCashierDetails;
        }

        private void LoadDataIntoTextBoxesForSelectedProduct(object sender, RunWorkerCompletedEventArgs e)
        {
            StockDetail selectedProductDetails = (StockDetail)e.Result;
            ProductId_textBox.Text = selectedProductDetails.ProductId.ToString();
            ProductName_textBox.Text = selectedProductDetails.ProductName;
            selectedProductPrice = ProductPrice_textBox.Text = selectedProductDetails.Price.ToString();
            Description_textbox.Text = selectedProductDetails.ProductDescription;
            selectedProductQty = Quantity_textBox.Text = selectedProductDetails.QuantityAvailable.ToString();
        }

        private void UpdateProduct_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProductPrice_textBox.Text) && !string.IsNullOrWhiteSpace(Quantity_textBox.Text))
            {
                if (!selectedProductQty.Equals(Quantity_textBox.Text) || !selectedProductPrice.Equals(ProductPrice_textBox.Text))
                {
                    BackgroundWorker backgroundWorker = new BackgroundWorker();
                    backgroundWorker.DoWork += UpdateProductDetails;
                    backgroundWorker.RunWorkerCompleted += UpdateProcductDetailsCompleted;
                    backgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(Constants.PRODUCT_DETAILS_NOT_EDITED);
                }
            }
            else
            {
                MessageBox.Show(Constants.ENTER_ALL_TEXTFIELD_MESSAGE);
            }
        }

        private void UpdateProductDetails(object sender, DoWorkEventArgs e)
        {
            e.Result = admin.UpdateProductDetails(int.Parse(ProductId_textBox.Text), Convert.ToDecimal(ProductPrice_textBox.Text), int.Parse(Quantity_textBox.Text));
        }

        private void UpdateProcductDetailsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isCashierUpdatedConformation = (bool)e.Result;
            if (isCashierUpdatedConformation)
            {
                MessageBox.Show(Constants.PRODUCT_DETAILS_UPDATED);
                AllProduct_ListView.Items.Clear();
                LoadAllProductDetails(sender, null);
                AddProductDetailsToListView(sender, e);
                EnableDisableFormControls();
            }
            else
            {
                MessageBox.Show(Constants.PRODUCT_DETAILS_UPDATE_ERROR_MESSAGE);
            }
        }

        private void DeleteProduct_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Constants.DELETE_PRODUCT_CONFORMATION_MESSAGE, Constants.DELETE_PRODUCT_MESSAGE_BOX_CAPTION, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                BackgroundWorker backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += DeleteSelectedProductFromListView;
                backgroundWorker.RunWorkerCompleted += LoadProductDetailaAfterDeletion;
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void DeleteSelectedProductFromListView(object sender, DoWorkEventArgs e)
        {
            e.Result = admin.DeletedSelectedProduct(int.Parse(ProductId_textBox.Text));
            LoadAllProductDetails(sender, e);
        }

        private void LoadProductDetailaAfterDeletion(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isProductDeleted = (bool)e.Result;
            if (isProductDeleted)
            {
                MessageBox.Show(Constants.PRODUCT_DELETED_CONFORMATION_MESSAGE);
                AllProduct_ListView.Items.Clear();
                AddProductDetailsToListView(sender, e);
                EnableDisableFormControls();
            }
            else
            {
                MessageBox.Show(Constants.PRODUCT_NOT_DELETED_MESSAGE);
            }
        }

        private void ClearAllFields_button_Click(object sender, EventArgs e)
        {
            EnableDisableFormControls();
        }

        private void EnableDisableFormControls()
        {
            AddProduct_button.Enabled = true;
            UpdateProduct_button.Enabled = false;
            DeleteProduct_button.Enabled = false;
            ProductId_textBox.ReadOnly = false;
            ProductName_textBox.ReadOnly = false;
            Description_textbox.ReadOnly = false;
            ProductId_textBox.Text = string.Empty;
            ProductName_textBox.Text = string.Empty;
            ProductPrice_textBox.Text = string.Empty;
            Description_textbox.Text = string.Empty;
            Quantity_textBox.Text = string.Empty;
        }
    }
}

