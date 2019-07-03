using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClasses;

namespace AOneStoreBillingSystem
{
    public partial class BillingPage : Form
    {
        private Cashier cashier;
        private List<StockDetail> availableProducts;
        private int sId;
        public BillingPage()
        {
            InitializeComponent();
            cashier = new Cashier();
        }

        private void BillingPage_Load(object sender, EventArgs e)
        {
            BillDate_textBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            sId = 0;
        }

        private void Product_Search_Textbox_MouseClick(object sender, MouseEventArgs e)
        {
            availableProducts = cashier.GetAllProducts();    
        }

        private void Product_Search_Textbox_TextChanged(object sender, EventArgs e)
        {
            Product_Search_ListBox.Items.Clear();
            if (Product_Search_Textbox.Text.Length == 0)
            {
                HideResults();
                return;
            }

            foreach (StockDetail searchedProduct in availableProducts)
            {
                if (searchedProduct.ProductName.ToLower().StartsWith(Product_Search_Textbox.Text.ToLower()) || 
                    searchedProduct.ProductDescription.ToLower().Contains(Product_Search_Textbox.Text.ToLower()))
                {
                    Product_Search_ListBox.Items.Add(searchedProduct.ProductName);
                    Product_Search_ListBox.Visible = true;
                }
            }
        }

        void Product_Search_ListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Product_Search_Textbox.Text = Product_Search_ListBox.Items[Product_Search_ListBox.SelectedIndex].ToString();
            HideResults();
        }

        void Product_Search_ListBox_LostFocus(object sender, System.EventArgs e)
        {
            HideResults();
        }

        void HideResults()
        {
            Product_Search_ListBox.Visible = false;
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {

            foreach (StockDetail searchedProduct in availableProducts)
            {
                if (searchedProduct.ProductName.ToLower().Equals(Product_Search_Textbox.Text.ToLower()))
                {
                    ProductId_textBox.Text = searchedProduct.ProductId.ToString();
                    ProductName_textBox.Text = searchedProduct.ProductName.ToString();
                    Price_textBox.Text = searchedProduct.Price.ToString("#,##0.00");
                }
            }
            Product_Search_Textbox.Text = string.Empty;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem((sId + 1).ToString());
            item.SubItems.Add(ProductId_textBox.Text);
            item.SubItems.Add(ProductName_textBox.Text);
            item.SubItems.Add(Price_textBox.Text);
            item.SubItems.Add(Quantity.Text);
            item.SubItems.Add(Discount_textBox.Text);
            item.SubItems.Add(Quantity.Text);
            //Bill_ListView.Items.Add(CalculateTotalForItem);
            ProductId_textBox.Text = string.Empty;
            ProductName_textBox.Text = string.Empty;
            Price_textBox.Text = string.Empty;
            Quantity.Text = string.Empty;
            Discount_textBox.Text = string.Empty;



        }
        //private string CalculateTotalForItem()
        //{

        //}
          
    }
}
