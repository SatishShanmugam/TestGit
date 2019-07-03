namespace AOneStoreBillingSystem
{
    partial class AddStockPage
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
            this.Quantity_lable = new System.Windows.Forms.Label();
            this.ProductName_label = new System.Windows.Forms.Label();
            this.ProductId_label = new System.Windows.Forms.Label();
            this.ProductTitlelabel = new System.Windows.Forms.Label();
            this.ProductId_textBox = new System.Windows.Forms.TextBox();
            this.ProductName_textBox = new System.Windows.Forms.TextBox();
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.AddProduct_button = new System.Windows.Forms.Button();
            this.UpdateProduct_button = new System.Windows.Forms.Button();
            this.DeleteProduct_button = new System.Windows.Forms.Button();
            this.ClearAllFields = new System.Windows.Forms.Button();
            this.AllProduct_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_label = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.Description_textbox = new System.Windows.Forms.TextBox();
            this.ProductPrice_textBox = new System.Windows.Forms.TextBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Quantity_lable
            // 
            this.Quantity_lable.AutoSize = true;
            this.Quantity_lable.Location = new System.Drawing.Point(28, 291);
            this.Quantity_lable.Name = "Quantity_lable";
            this.Quantity_lable.Size = new System.Drawing.Size(46, 13);
            this.Quantity_lable.TabIndex = 33;
            this.Quantity_lable.Text = "Quantity";
            // 
            // ProductName_label
            // 
            this.ProductName_label.AutoSize = true;
            this.ProductName_label.Location = new System.Drawing.Point(28, 162);
            this.ProductName_label.Name = "ProductName_label";
            this.ProductName_label.Size = new System.Drawing.Size(75, 13);
            this.ProductName_label.TabIndex = 36;
            this.ProductName_label.Text = "Product Name";
            // 
            // ProductId_label
            // 
            this.ProductId_label.AutoSize = true;
            this.ProductId_label.Location = new System.Drawing.Point(28, 119);
            this.ProductId_label.Name = "ProductId_label";
            this.ProductId_label.Size = new System.Drawing.Size(58, 13);
            this.ProductId_label.TabIndex = 25;
            this.ProductId_label.Text = "Product ID";
            // 
            // ProductTitlelabel
            // 
            this.ProductTitlelabel.AutoSize = true;
            this.ProductTitlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTitlelabel.Location = new System.Drawing.Point(65, 61);
            this.ProductTitlelabel.Name = "ProductTitlelabel";
            this.ProductTitlelabel.Size = new System.Drawing.Size(195, 20);
            this.ProductTitlelabel.TabIndex = 20;
            this.ProductTitlelabel.Text = "Add Stock Product Details";
            // 
            // ProductId_textBox
            // 
            this.ProductId_textBox.Location = new System.Drawing.Point(152, 112);
            this.ProductId_textBox.Name = "ProductId_textBox";
            this.ProductId_textBox.Size = new System.Drawing.Size(216, 20);
            this.ProductId_textBox.TabIndex = 38;
            // 
            // ProductName_textBox
            // 
            this.ProductName_textBox.Location = new System.Drawing.Point(152, 157);
            this.ProductName_textBox.Name = "ProductName_textBox";
            this.ProductName_textBox.Size = new System.Drawing.Size(216, 20);
            this.ProductName_textBox.TabIndex = 39;
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(152, 292);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(216, 20);
            this.Quantity_textBox.TabIndex = 42;
            // 
            // AddProduct_button
            // 
            this.AddProduct_button.Location = new System.Drawing.Point(31, 397);
            this.AddProduct_button.Name = "AddProduct_button";
            this.AddProduct_button.Size = new System.Drawing.Size(92, 29);
            this.AddProduct_button.TabIndex = 43;
            this.AddProduct_button.Text = "Add New";
            this.AddProduct_button.UseVisualStyleBackColor = true;
            this.AddProduct_button.Click += new System.EventHandler(this.AddProduct_button_Click);
            // 
            // UpdateProduct_button
            // 
            this.UpdateProduct_button.Enabled = false;
            this.UpdateProduct_button.Location = new System.Drawing.Point(152, 397);
            this.UpdateProduct_button.Name = "UpdateProduct_button";
            this.UpdateProduct_button.Size = new System.Drawing.Size(92, 29);
            this.UpdateProduct_button.TabIndex = 44;
            this.UpdateProduct_button.Text = "Update";
            this.UpdateProduct_button.UseVisualStyleBackColor = true;
            this.UpdateProduct_button.Click += new System.EventHandler(this.UpdateProduct_button_Click);
            // 
            // DeleteProduct_button
            // 
            this.DeleteProduct_button.Enabled = false;
            this.DeleteProduct_button.Location = new System.Drawing.Point(276, 397);
            this.DeleteProduct_button.Name = "DeleteProduct_button";
            this.DeleteProduct_button.Size = new System.Drawing.Size(92, 29);
            this.DeleteProduct_button.TabIndex = 45;
            this.DeleteProduct_button.Text = "Delete";
            this.DeleteProduct_button.UseVisualStyleBackColor = true;
            this.DeleteProduct_button.Click += new System.EventHandler(this.DeleteProduct_button_Click);
            // 
            // ClearAllFields
            // 
            this.ClearAllFields.Location = new System.Drawing.Point(31, 452);
            this.ClearAllFields.Name = "ClearAllFields";
            this.ClearAllFields.Size = new System.Drawing.Size(337, 32);
            this.ClearAllFields.TabIndex = 46;
            this.ClearAllFields.Text = "Clear All Fields";
            this.ClearAllFields.UseVisualStyleBackColor = true;
            this.ClearAllFields.Click += new System.EventHandler(this.ClearAllFields_button_Click);
            // 
            // AllProduct_ListView
            // 
            this.AllProduct_ListView.AutoArrange = false;
            this.AllProduct_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllProduct_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.AllProduct_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProduct_ListView.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AllProduct_ListView.FullRowSelect = true;
            this.AllProduct_ListView.GridLines = true;
            this.AllProduct_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AllProduct_ListView.HideSelection = false;
            this.AllProduct_ListView.LabelWrap = false;
            this.AllProduct_ListView.Location = new System.Drawing.Point(488, 61);
            this.AllProduct_ListView.Name = "AllProduct_ListView";
            this.AllProduct_ListView.Scrollable = false;
            this.AllProduct_ListView.Size = new System.Drawing.Size(593, 423);
            this.AllProduct_ListView.TabIndex = 47;
            this.AllProduct_ListView.UseCompatibleStateImageBehavior = false;
            this.AllProduct_ListView.View = System.Windows.Forms.View.Details;
            this.AllProduct_ListView.Click += new System.EventHandler(this.AllProduct_ListView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SI.No";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Id";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 201;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 121;
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(28, 205);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(60, 13);
            this.Price_label.TabIndex = 27;
            this.Price_label.Text = "Description";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(28, 248);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(31, 13);
            this.Description_label.TabIndex = 28;
            this.Description_label.Text = "Price";
            // 
            // Description_textbox
            // 
            this.Description_textbox.Location = new System.Drawing.Point(152, 202);
            this.Description_textbox.Name = "Description_textbox";
            this.Description_textbox.Size = new System.Drawing.Size(216, 20);
            this.Description_textbox.TabIndex = 40;
            // 
            // ProductPrice_textBox
            // 
            this.ProductPrice_textBox.Location = new System.Drawing.Point(152, 247);
            this.ProductPrice_textBox.Name = "ProductPrice_textBox";
            this.ProductPrice_textBox.Size = new System.Drawing.Size(216, 20);
            this.ProductPrice_textBox.TabIndex = 41;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity Available";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 146;
            // 
            // AddStockPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 555);
            this.Controls.Add(this.AllProduct_ListView);
            this.Controls.Add(this.ClearAllFields);
            this.Controls.Add(this.DeleteProduct_button);
            this.Controls.Add(this.UpdateProduct_button);
            this.Controls.Add(this.AddProduct_button);
            this.Controls.Add(this.Quantity_textBox);
            this.Controls.Add(this.ProductPrice_textBox);
            this.Controls.Add(this.Description_textbox);
            this.Controls.Add(this.ProductName_textBox);
            this.Controls.Add(this.ProductId_textBox);
            this.Controls.Add(this.Quantity_lable);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.ProductName_label);
            this.Controls.Add(this.ProductId_label);
            this.Controls.Add(this.ProductTitlelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStockPage";
            this.Text = "AddStockPage";
            this.Load += new System.EventHandler(this.AddStockPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Quantity_lable;
        private System.Windows.Forms.Label ProductName_label;
        private System.Windows.Forms.Label ProductId_label;
        private System.Windows.Forms.Label ProductTitlelabel;
        private System.Windows.Forms.TextBox ProductId_textBox;
        private System.Windows.Forms.TextBox ProductName_textBox;
        private System.Windows.Forms.TextBox Quantity_textBox;
        private System.Windows.Forms.Button AddProduct_button;
        private System.Windows.Forms.Button UpdateProduct_button;
        private System.Windows.Forms.Button DeleteProduct_button;
        private System.Windows.Forms.Button ClearAllFields;
        private System.Windows.Forms.ListView AllProduct_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.TextBox Description_textbox;
        private System.Windows.Forms.TextBox ProductPrice_textBox;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}