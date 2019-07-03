namespace AOneStoreBillingSystem
{
    partial class CashierHomePage
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
            this.Cashier_HomePage_MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Bill_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Product_Information_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut_Cashier_MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Cashier_HomePage_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cashier_HomePage_MenuStrip
            // 
            this.Cashier_HomePage_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bill_MenuStrip,
            this.Product_Information_MenuStrip,
            this.LogOut_Cashier_MenuStrip});
            this.Cashier_HomePage_MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.Cashier_HomePage_MenuStrip.Name = "Cashier_HomePage_MenuStrip";
            this.Cashier_HomePage_MenuStrip.Size = new System.Drawing.Size(1370, 29);
            this.Cashier_HomePage_MenuStrip.TabIndex = 7;
            this.Cashier_HomePage_MenuStrip.Text = "menuStrip1";
            // 
            // Bill_MenuStrip
            // 
            this.Bill_MenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Bill_MenuStrip.Name = "Bill_MenuStrip";
            this.Bill_MenuStrip.Size = new System.Drawing.Size(43, 25);
            this.Bill_MenuStrip.Text = "Bill";
            this.Bill_MenuStrip.Click += new System.EventHandler(this.Bill_MenuStrip_Click);
            // 
            // Product_Information_MenuStrip
            // 
            this.Product_Information_MenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Product_Information_MenuStrip.Name = "Product_Information_MenuStrip";
            this.Product_Information_MenuStrip.Size = new System.Drawing.Size(162, 25);
            this.Product_Information_MenuStrip.Text = "Product Information";
            // 
            // LogOut_Cashier_MenuStrip
            // 
            this.LogOut_Cashier_MenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LogOut_Cashier_MenuStrip.Name = "LogOut_Cashier_MenuStrip";
            this.LogOut_Cashier_MenuStrip.Size = new System.Drawing.Size(78, 25);
            this.LogOut_Cashier_MenuStrip.Text = "Log Out";
            this.LogOut_Cashier_MenuStrip.Click += new System.EventHandler(this.LogOut_Cashier_MenuStrip_Click);
            // 
            // CashierHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Cashier_HomePage_MenuStrip);
            this.IsMdiContainer = true;
            this.Name = "CashierHomePage";
            this.Text = "CashierHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierHomePage_Load);
            this.Cashier_HomePage_MenuStrip.ResumeLayout(false);
            this.Cashier_HomePage_MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Cashier_HomePage_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Bill_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Product_Information_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem LogOut_Cashier_MenuStrip;
    }
}