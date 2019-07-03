using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClasses;
using DataAccessLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class Cashier
    {
        private CashierDataAccess cashierDataAccess;
        public Cashier()
        {
            cashierDataAccess = new CashierDataAccess();
        }

        public bool IsCashierAuthenticated(int cashierID, string cashierPassword)
        {
            EncryptionDecryption passwordEncryptionDecryption = new EncryptionDecryption();
            string EncryptedPassword = passwordEncryptionDecryption.Encryptdata(cashierPassword);
            List<CashierDetail> allCashierList = cashierDataAccess.GetAllCashiers();

            var cashierDetail = allCashierList.SingleOrDefault(obj => obj.CashierID.Equals(cashierID) && obj.Password.Equals(EncryptedPassword));

            if (cashierDetail != null)
                Task.Run(() => cashierDataAccess.AddLastLoggedInTimedForLoggedCashier(cashierID));

            return cashierDetail != null;
        }
        
        public List<StockDetail> GetAllProducts()
        {
            return cashierDataAccess.GetAllProducts();
        }

        public void QuantityReductionForSelectedProduct(string currentBillNumber, DataGridView purchasedProductsFromGridView)
        {
            List<SalesDetail> purchasedProducts = new List<SalesDetail>();
            if (purchasedProductsFromGridView.Rows.Count > 0)
            {
                for (int i = 0; i < purchasedProductsFromGridView.Rows.Count; i++)
                {
                    SalesDetail salesDetail = new SalesDetail();
                    salesDetail.BillNos = Convert.ToInt64(currentBillNumber);
                    salesDetail.ProductId = Convert.ToInt64(purchasedProductsFromGridView.Rows[i].Cells[1].Value);
                    salesDetail.ProductName = (string)purchasedProductsFromGridView.Rows[i].Cells[2].Value;
                    salesDetail.Quantity = Convert.ToInt64(purchasedProductsFromGridView.Rows[i].Cells[3].Value);
                    salesDetail.TotalPrice = Convert.ToDecimal(purchasedProductsFromGridView.Rows[i].Cells[6].Value);
                    salesDetail.SalesDate = DateTime.Today.ToString("dd-MM-yyyy");
                    purchasedProducts.Add(salesDetail);
                }
            }
            Task.Run(() => cashierDataAccess.AddSalesDetails(purchasedProducts));
            Task.Run(() => cashierDataAccess.QuantityReduction(purchasedProducts));
        }

        public string GetCurrentBillNumber()
        {
            List<SalesDetail> allSalesDetails = cashierDataAccess.RetrieveAllSalesDetails();
            if(allSalesDetails.Count > 0)
            {
                if(allSalesDetails[allSalesDetails.Count - 1].SalesDate != DateTime.Today.ToString("dd-MM-yyyy"))
                {
                    return "1";
                }
                else
                {
                    return (allSalesDetails.Where(obj => obj.SalesDate == DateTime.Today.ToString("dd-MM-yyyy")).Max(obj => obj.BillNos) + 1).ToString();
                }
            }
            else
            {
                return "1";
            }
        }

        public void AddCashierLastLogoutTime(int cashierId)
        {
            Task.Run(() => cashierDataAccess.AddCashierLastLogoutTime(cashierId));
        }
    }
}
