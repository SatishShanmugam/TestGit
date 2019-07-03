namespace AOneStoreBillingSystem
{
    partial class BillingPage
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
            this.BillTitile_label = new System.Windows.Forms.Label();
            this.BillDate_label = new System.Windows.Forms.Label();
            this.BillDate_textBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BillNos_label = new System.Windows.Forms.Label();
            this.ProductName_textBox = new System.Windows.Forms.TextBox();
            this.ProductName_label = new System.Windows.Forms.Label();
            this.ProductId_textBox = new System.Windows.Forms.TextBox();
            this.ProductId_label = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.Discount_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Total_textBox = new System.Windows.Forms.TextBox();
            this.Total_label = new System.Windows.Forms.Label();
            this.Print_button = new System.Windows.Forms.Button();
            this.CalculateTotal_button = new System.Windows.Forms.Button();
            this.Bill_ListView = new System.Windows.Forms.ListView();
            this.SSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product_Search_Textbox = new System.Windows.Forms.TextBox();
            this.Product_Search_ListBox = new System.Windows.Forms.ListBox();
            this.Search_label = new System.Windows.Forms.Label();
            this.Ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BillTitile_label
            // 
            this.BillTitile_label.AutoSize = true;
            this.BillTitile_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillTitile_label.Location = new System.Drawing.Point(602, 9);
            this.BillTitile_label.Name = "BillTitile_label";
            this.BillTitile_label.Size = new System.Drawing.Size(56, 25);
            this.BillTitile_label.TabIndex = 0;
            this.BillTitile_label.Text = "BILL";
            // 
            // BillDate_label
            // 
            this.BillDate_label.AutoSize = true;
            this.BillDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDate_label.Location = new System.Drawing.Point(37, 64);
            this.BillDate_label.Name = "BillDate_label";
            this.BillDate_label.Size = new System.Drawing.Size(69, 17);
            this.BillDate_label.TabIndex = 1;
            this.BillDate_label.Text = "Bill Date";
            // 
            // BillDate_textBox
            // 
            this.BillDate_textBox.Location = new System.Drawing.Point(151, 64);
            this.BillDate_textBox.Name = "BillDate_textBox";
            this.BillDate_textBox.ReadOnly = true;
            this.BillDate_textBox.Size = new System.Drawing.Size(163, 20);
            this.BillDate_textBox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 4;
            // 
            // BillNos_label
            // 
            this.BillNos_label.AutoSize = true;
            this.BillNos_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNos_label.Location = new System.Drawing.Point(37, 112);
            this.BillNos_label.Name = "BillNos_label";
            this.BillNos_label.Size = new System.Drawing.Size(91, 17);
            this.BillNos_label.TabIndex = 3;
            this.BillNos_label.Text = "Bill Number";
            // 
            // ProductName_textBox
            // 
            this.ProductName_textBox.Location = new System.Drawing.Point(225, 223);
            this.ProductName_textBox.Name = "ProductName_textBox";
            this.ProductName_textBox.Size = new System.Drawing.Size(163, 20);
            this.ProductName_textBox.TabIndex = 8;
            // 
            // ProductName_label
            // 
            this.ProductName_label.AutoSize = true;
            this.ProductName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName_label.Location = new System.Drawing.Point(86, 226);
            this.ProductName_label.Name = "ProductName_label";
            this.ProductName_label.Size = new System.Drawing.Size(110, 17);
            this.ProductName_label.TabIndex = 7;
            this.ProductName_label.Text = "Product Name";
            // 
            // ProductId_textBox
            // 
            this.ProductId_textBox.Location = new System.Drawing.Point(225, 178);
            this.ProductId_textBox.Name = "ProductId_textBox";
            this.ProductId_textBox.Size = new System.Drawing.Size(163, 20);
            this.ProductId_textBox.TabIndex = 6;
            // 
            // ProductId_label
            // 
            this.ProductId_label.AutoSize = true;
            this.ProductId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductId_label.Location = new System.Drawing.Point(86, 178);
            this.ProductId_label.Name = "ProductId_label";
            this.ProductId_label.Size = new System.Drawing.Size(84, 17);
            this.ProductId_label.TabIndex = 5;
            this.ProductId_label.Text = "Product ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(225, 320);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 20);
            this.textBox4.TabIndex = 12;
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_label.Location = new System.Drawing.Point(86, 320);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(69, 17);
            this.Quantity_label.TabIndex = 11;
            this.Quantity_label.Text = "Quantity";
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(225, 272);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(163, 20);
            this.Price_textBox.TabIndex = 10;
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.Location = new System.Drawing.Point(86, 272);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(45, 17);
            this.Price_label.TabIndex = 9;
            this.Price_label.Text = "Price";
            // 
            // Discount_textBox
            // 
            this.Discount_textBox.Location = new System.Drawing.Point(225, 372);
            this.Discount_textBox.Name = "Discount_textBox";
            this.Discount_textBox.Size = new System.Drawing.Size(163, 20);
            this.Discount_textBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Discount %";
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_button.Location = new System.Drawing.Point(151, 482);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(90, 40);
            this.Add_button.TabIndex = 15;
            this.Add_button.Text = "ADD";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_button.Location = new System.Drawing.Point(298, 482);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(90, 40);
            this.Reset_button.TabIndex = 16;
            this.Reset_button.Text = "RESET";
            this.Reset_button.UseVisualStyleBackColor = true;
            // 
            // Total_textBox
            // 
            this.Total_textBox.Location = new System.Drawing.Point(861, 556);
            this.Total_textBox.Name = "Total_textBox";
            this.Total_textBox.Size = new System.Drawing.Size(163, 20);
            this.Total_textBox.TabIndex = 18;
            // 
            // Total_label
            // 
            this.Total_label.AutoSize = true;
            this.Total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_label.Location = new System.Drawing.Point(764, 559);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(45, 17);
            this.Total_label.TabIndex = 17;
            this.Total_label.Text = "Total";
            // 
            // Print_button
            // 
            this.Print_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_button.Location = new System.Drawing.Point(1054, 627);
            this.Print_button.Name = "Print_button";
            this.Print_button.Size = new System.Drawing.Size(90, 40);
            this.Print_button.TabIndex = 20;
            this.Print_button.Text = "PRINT";
            this.Print_button.UseVisualStyleBackColor = true;
            // 
            // CalculateTotal_button
            // 
            this.CalculateTotal_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateTotal_button.Location = new System.Drawing.Point(436, 536);
            this.CalculateTotal_button.Name = "CalculateTotal_button";
            this.CalculateTotal_button.Size = new System.Drawing.Size(184, 40);
            this.CalculateTotal_button.TabIndex = 19;
            this.CalculateTotal_button.Text = "CALCULATE TOTAL";
            this.CalculateTotal_button.UseVisualStyleBackColor = true;
            // 
            // Bill_ListView
            // 
            this.Bill_ListView.AutoArrange = false;
            this.Bill_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bill_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SSID,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.Price,
            this.Discount,
            this.Total});
            this.Bill_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_ListView.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Bill_ListView.FullRowSelect = true;
            this.Bill_ListView.GridLines = true;
            this.Bill_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Bill_ListView.HideSelection = false;
            this.Bill_ListView.LabelWrap = false;
            this.Bill_ListView.Location = new System.Drawing.Point(466, 99);
            this.Bill_ListView.Name = "Bill_ListView";
            this.Bill_ListView.Scrollable = false;
            this.Bill_ListView.Size = new System.Drawing.Size(764, 413);
            this.Bill_ListView.TabIndex = 48;
            this.Bill_ListView.UseCompatibleStateImageBehavior = false;
            this.Bill_ListView.View = System.Windows.Forms.View.Details;
            // 
            // SSID
            // 
            this.SSID.Text = "SI.No";
            this.SSID.Width = 42;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Product Id";
            this.ProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductID.Width = 140;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductName.Width = 201;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 90;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 98;
            // 
            // Discount
            // 
            this.Discount.Text = "Discount";
            this.Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Discount.Width = 87;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.Width = 105;
            // 
            // Product_Search_Textbox
            // 
            this.Product_Search_Textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Product_Search_Textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Product_Search_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Product_Search_Textbox.Location = new System.Drawing.Point(466, 50);
            this.Product_Search_Textbox.Multiline = true;
            this.Product_Search_Textbox.Name = "Product_Search_Textbox";
            this.Product_Search_Textbox.Size = new System.Drawing.Size(237, 20);
            this.Product_Search_Textbox.TabIndex = 49;
            this.Product_Search_Textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Search_Textbox_MouseClick);
            this.Product_Search_Textbox.TextChanged += new System.EventHandler(this.Product_Search_Textbox_TextChanged);
            // 
            // Product_Search_ListBox
            // 
            this.Product_Search_ListBox.FormattingEnabled = true;
            this.Product_Search_ListBox.Location = new System.Drawing.Point(887, 12);
            this.Product_Search_ListBox.Name = "Product_Search_ListBox";
            this.Product_Search_ListBox.Size = new System.Drawing.Size(237, 82);
            this.Product_Search_ListBox.TabIndex = 50;
            this.Product_Search_ListBox.Visible = false;
            this.Product_Search_ListBox.SelectedIndexChanged += new System.EventHandler(this.Product_Search_ListBox_SelectedIndexChanged);
            // 
            // Search_label
            // 
            this.Search_label.AutoSize = true;
            this.Search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_label.Location = new System.Drawing.Point(368, 53);
            this.Search_label.Name = "Search_label";
            this.Search_label.Size = new System.Drawing.Size(59, 17);
            this.Search_label.TabIndex = 51;
            this.Search_label.Text = "Search";
            // 
            // Ok_button
            // 
            this.Ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_button.Location = new System.Drawing.Point(739, 50);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(70, 26);
            this.Ok_button.TabIndex = 52;
            this.Ok_button.Text = "OK";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // BillingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 698);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Search_label);
            this.Controls.Add(this.Product_Search_ListBox);
            this.Controls.Add(this.Product_Search_Textbox);
            this.Controls.Add(this.Bill_ListView);
            this.Controls.Add(this.Print_button);
            this.Controls.Add(this.CalculateTotal_button);
            this.Controls.Add(this.Total_textBox);
            this.Controls.Add(this.Total_label);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Discount_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Quantity_label);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.ProductName_textBox);
            this.Controls.Add(this.ProductName_label);
            this.Controls.Add(this.ProductId_textBox);
            this.Controls.Add(this.ProductId_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BillNos_label);
            this.Controls.Add(this.BillDate_textBox);
            this.Controls.Add(this.BillDate_label);
            this.Controls.Add(this.BillTitile_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingPage";
            this.Text = "BillingPage";
            this.Load += new System.EventHandler(this.BillingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BillTitile_label;
        private System.Windows.Forms.Label BillDate_label;
        private System.Windows.Forms.TextBox BillDate_textBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label BillNos_label;
        private System.Windows.Forms.TextBox ProductName_textBox;
        private System.Windows.Forms.Label ProductName_label;
        private System.Windows.Forms.TextBox ProductId_textBox;
        private System.Windows.Forms.Label ProductId_label;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Quantity_label;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.TextBox Discount_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.TextBox Total_textBox;
        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.Button Print_button;
        private System.Windows.Forms.Button CalculateTotal_button;
        private System.Windows.Forms.ListView Bill_ListView;
        private System.Windows.Forms.ColumnHeader SSID;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Discount;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.TextBox Product_Search_Textbox;
        private System.Windows.Forms.ListBox Product_Search_ListBox;
        private System.Windows.Forms.Label Search_label;
        private System.Windows.Forms.Button Ok_button;
    }
}