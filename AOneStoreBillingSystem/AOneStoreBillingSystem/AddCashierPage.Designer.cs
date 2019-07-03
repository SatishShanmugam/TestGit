namespace AOneStoreBillingSystem
{
    partial class AddCashierPage
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
            this.CashierTitlelabel = new System.Windows.Forms.Label();
            this.CashierId_textBox = new System.Windows.Forms.TextBox();
            this.CashierName_textBox = new System.Windows.Forms.TextBox();
            this.CashierNumber_textBox = new System.Windows.Forms.TextBox();
            this.CashierPassword_textBox = new System.Windows.Forms.TextBox();
            this.CahierId_label = new System.Windows.Forms.Label();
            this.CashierName_label = new System.Windows.Forms.Label();
            this.MobileNumber_label = new System.Windows.Forms.Label();
            this.CashierPassword_label = new System.Windows.Forms.Label();
            this.AddCashier_button = new System.Windows.Forms.Button();
            this.UpdateCashier_button = new System.Windows.Forms.Button();
            this.DeleteCashier_button = new System.Windows.Forms.Button();
            this.AllCashier_ListView = new System.Windows.Forms.ListView();
            this.SerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CashierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MobileNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConformPassword = new System.Windows.Forms.Label();
            this.CashierConformPassword_textBox = new System.Windows.Forms.TextBox();
            this.ClearAllFields_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CashierTitlelabel
            // 
            this.CashierTitlelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CashierTitlelabel.AutoSize = true;
            this.CashierTitlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierTitlelabel.Location = new System.Drawing.Point(73, 28);
            this.CashierTitlelabel.Name = "CashierTitlelabel";
            this.CashierTitlelabel.Size = new System.Drawing.Size(149, 20);
            this.CashierTitlelabel.TabIndex = 0;
            this.CashierTitlelabel.Text = "Add Cashier Details";
            // 
            // CashierId_textBox
            // 
            this.CashierId_textBox.Location = new System.Drawing.Point(141, 80);
            this.CashierId_textBox.Name = "CashierId_textBox";
            this.CashierId_textBox.ReadOnly = true;
            this.CashierId_textBox.Size = new System.Drawing.Size(235, 20);
            this.CashierId_textBox.TabIndex = 1;
            // 
            // CashierName_textBox
            // 
            this.CashierName_textBox.Location = new System.Drawing.Point(141, 125);
            this.CashierName_textBox.Name = "CashierName_textBox";
            this.CashierName_textBox.Size = new System.Drawing.Size(235, 20);
            this.CashierName_textBox.TabIndex = 2;
            // 
            // CashierNumber_textBox
            // 
            this.CashierNumber_textBox.Location = new System.Drawing.Point(141, 168);
            this.CashierNumber_textBox.Name = "CashierNumber_textBox";
            this.CashierNumber_textBox.Size = new System.Drawing.Size(235, 20);
            this.CashierNumber_textBox.TabIndex = 3;
            // 
            // CashierPassword_textBox
            // 
            this.CashierPassword_textBox.Location = new System.Drawing.Point(141, 212);
            this.CashierPassword_textBox.Name = "CashierPassword_textBox";
            this.CashierPassword_textBox.Size = new System.Drawing.Size(235, 20);
            this.CashierPassword_textBox.TabIndex = 5;
            this.CashierPassword_textBox.TextChanged += new System.EventHandler(this.CashierPassword_textBox_TextChanged);
            // 
            // CahierId_label
            // 
            this.CahierId_label.AutoSize = true;
            this.CahierId_label.Location = new System.Drawing.Point(36, 86);
            this.CahierId_label.Name = "CahierId_label";
            this.CahierId_label.Size = new System.Drawing.Size(56, 13);
            this.CahierId_label.TabIndex = 6;
            this.CahierId_label.Text = "Cashier ID";
            // 
            // CashierName_label
            // 
            this.CashierName_label.AutoSize = true;
            this.CashierName_label.Location = new System.Drawing.Point(36, 128);
            this.CashierName_label.Name = "CashierName_label";
            this.CashierName_label.Size = new System.Drawing.Size(73, 13);
            this.CashierName_label.TabIndex = 7;
            this.CashierName_label.Text = "Cashier Name";
            // 
            // MobileNumber_label
            // 
            this.MobileNumber_label.AutoSize = true;
            this.MobileNumber_label.Location = new System.Drawing.Point(36, 175);
            this.MobileNumber_label.Name = "MobileNumber_label";
            this.MobileNumber_label.Size = new System.Drawing.Size(78, 13);
            this.MobileNumber_label.TabIndex = 8;
            this.MobileNumber_label.Text = "Mobile Number";
            // 
            // CashierPassword_label
            // 
            this.CashierPassword_label.AutoSize = true;
            this.CashierPassword_label.Location = new System.Drawing.Point(36, 215);
            this.CashierPassword_label.Name = "CashierPassword_label";
            this.CashierPassword_label.Size = new System.Drawing.Size(53, 13);
            this.CashierPassword_label.TabIndex = 10;
            this.CashierPassword_label.Text = "Password";
            // 
            // AddCashier_button
            // 
            this.AddCashier_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddCashier_button.Location = new System.Drawing.Point(39, 364);
            this.AddCashier_button.Name = "AddCashier_button";
            this.AddCashier_button.Size = new System.Drawing.Size(92, 29);
            this.AddCashier_button.TabIndex = 12;
            this.AddCashier_button.Text = "Add New";
            this.AddCashier_button.UseVisualStyleBackColor = true;
            this.AddCashier_button.Click += new System.EventHandler(this.AddCashier_button_Click);
            // 
            // UpdateCashier_button
            // 
            this.UpdateCashier_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateCashier_button.Enabled = false;
            this.UpdateCashier_button.Location = new System.Drawing.Point(160, 364);
            this.UpdateCashier_button.Name = "UpdateCashier_button";
            this.UpdateCashier_button.Size = new System.Drawing.Size(92, 29);
            this.UpdateCashier_button.TabIndex = 13;
            this.UpdateCashier_button.Text = "Update";
            this.UpdateCashier_button.UseVisualStyleBackColor = true;
            this.UpdateCashier_button.Click += new System.EventHandler(this.UpdateCashier_button_Click);
            // 
            // DeleteCashier_button
            // 
            this.DeleteCashier_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteCashier_button.Enabled = false;
            this.DeleteCashier_button.Location = new System.Drawing.Point(284, 364);
            this.DeleteCashier_button.Name = "DeleteCashier_button";
            this.DeleteCashier_button.Size = new System.Drawing.Size(92, 29);
            this.DeleteCashier_button.TabIndex = 14;
            this.DeleteCashier_button.Text = "Delete";
            this.DeleteCashier_button.UseVisualStyleBackColor = true;
            this.DeleteCashier_button.Click += new System.EventHandler(this.DeleteCashier_button_Click);
            // 
            // AllCashier_ListView
            // 
            this.AllCashier_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllCashier_ListView.AutoArrange = false;
            this.AllCashier_ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllCashier_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerialNumber,
            this.CashierName,
            this.CashierID,
            this.MobileNumber});
            this.AllCashier_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCashier_ListView.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AllCashier_ListView.FullRowSelect = true;
            this.AllCashier_ListView.GridLines = true;
            this.AllCashier_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AllCashier_ListView.HideSelection = false;
            this.AllCashier_ListView.LabelWrap = false;
            this.AllCashier_ListView.Location = new System.Drawing.Point(432, 28);
            this.AllCashier_ListView.Name = "AllCashier_ListView";
            this.AllCashier_ListView.Scrollable = false;
            this.AllCashier_ListView.Size = new System.Drawing.Size(525, 423);
            this.AllCashier_ListView.TabIndex = 15;
            this.AllCashier_ListView.UseCompatibleStateImageBehavior = false;
            this.AllCashier_ListView.View = System.Windows.Forms.View.Details;
            this.AllCashier_ListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.AllCashier_ListView_ColumnWidthChanging);
            this.AllCashier_ListView.Click += new System.EventHandler(this.AllCashier_ListView_Click);
            // 
            // SerialNumber
            // 
            this.SerialNumber.Text = "SI.No";
            this.SerialNumber.Width = 42;
            // 
            // CashierName
            // 
            this.CashierName.Text = "Cashier Name";
            this.CashierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashierName.Width = 210;
            // 
            // CashierID
            // 
            this.CashierID.Text = "Cashier ID";
            this.CashierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashierID.Width = 90;
            // 
            // MobileNumber
            // 
            this.MobileNumber.Text = "Mobile Number";
            this.MobileNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MobileNumber.Width = 180;
            // 
            // ConformPassword
            // 
            this.ConformPassword.AutoSize = true;
            this.ConformPassword.Location = new System.Drawing.Point(36, 261);
            this.ConformPassword.Name = "ConformPassword";
            this.ConformPassword.Size = new System.Drawing.Size(95, 13);
            this.ConformPassword.TabIndex = 16;
            this.ConformPassword.Text = "Conform Password";
            // 
            // CashierConformPassword_textBox
            // 
            this.CashierConformPassword_textBox.Location = new System.Drawing.Point(141, 261);
            this.CashierConformPassword_textBox.Name = "CashierConformPassword_textBox";
            this.CashierConformPassword_textBox.Size = new System.Drawing.Size(235, 20);
            this.CashierConformPassword_textBox.TabIndex = 17;
            // 
            // ClearAllFields_button
            // 
            this.ClearAllFields_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearAllFields_button.Location = new System.Drawing.Point(39, 429);
            this.ClearAllFields_button.Name = "ClearAllFields_button";
            this.ClearAllFields_button.Size = new System.Drawing.Size(337, 32);
            this.ClearAllFields_button.TabIndex = 19;
            this.ClearAllFields_button.Text = "Clear All Fields";
            this.ClearAllFields_button.UseVisualStyleBackColor = true;
            this.ClearAllFields_button.Click += new System.EventHandler(this.ClearAllFields_button_Click);
            // 
            // AddCashierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 492);
            this.ControlBox = false;
            this.Controls.Add(this.ClearAllFields_button);
            this.Controls.Add(this.CashierConformPassword_textBox);
            this.Controls.Add(this.ConformPassword);
            this.Controls.Add(this.AllCashier_ListView);
            this.Controls.Add(this.DeleteCashier_button);
            this.Controls.Add(this.UpdateCashier_button);
            this.Controls.Add(this.AddCashier_button);
            this.Controls.Add(this.CashierPassword_label);
            this.Controls.Add(this.MobileNumber_label);
            this.Controls.Add(this.CashierName_label);
            this.Controls.Add(this.CahierId_label);
            this.Controls.Add(this.CashierPassword_textBox);
            this.Controls.Add(this.CashierNumber_textBox);
            this.Controls.Add(this.CashierName_textBox);
            this.Controls.Add(this.CashierId_textBox);
            this.Controls.Add(this.CashierTitlelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCashierPage";
            this.Text = "AddCashierPage";
            this.Load += new System.EventHandler(this.AddCashierPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CashierTitlelabel;
        private System.Windows.Forms.TextBox CashierId_textBox;
        private System.Windows.Forms.TextBox CashierName_textBox;
        private System.Windows.Forms.TextBox CashierNumber_textBox;
        private System.Windows.Forms.TextBox CashierPassword_textBox;
        private System.Windows.Forms.Label CahierId_label;
        private System.Windows.Forms.Label CashierName_label;
        private System.Windows.Forms.Label MobileNumber_label;
        private System.Windows.Forms.Label CashierPassword_label;
        private System.Windows.Forms.Button AddCashier_button;
        private System.Windows.Forms.Button UpdateCashier_button;
        private System.Windows.Forms.Button DeleteCashier_button;
        private System.Windows.Forms.ListView AllCashier_ListView;
        private System.Windows.Forms.ColumnHeader SerialNumber;
        private System.Windows.Forms.ColumnHeader CashierName;
        private System.Windows.Forms.ColumnHeader CashierID;
        private System.Windows.Forms.ColumnHeader MobileNumber;
        private System.Windows.Forms.Label ConformPassword;
        private System.Windows.Forms.TextBox CashierConformPassword_textBox;
        private System.Windows.Forms.Button ClearAllFields_button;
    }
}