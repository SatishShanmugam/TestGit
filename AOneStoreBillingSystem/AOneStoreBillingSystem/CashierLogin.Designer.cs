namespace AOneStoreBillingSystem
{
    partial class CashierLogin
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
            this.cashierUserId_textBox = new System.Windows.Forms.TextBox();
            this.cashierPassword_textBox = new System.Windows.Forms.TextBox();
            this.UserId_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Showpassword_checkBox = new System.Windows.Forms.CheckBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashierUserId_textBox
            // 
            this.cashierUserId_textBox.Location = new System.Drawing.Point(81, 55);
            this.cashierUserId_textBox.Name = "cashierUserId_textBox";
            this.cashierUserId_textBox.Size = new System.Drawing.Size(133, 20);
            this.cashierUserId_textBox.TabIndex = 0;
            // 
            // cashierPassword_textBox
            // 
            this.cashierPassword_textBox.Location = new System.Drawing.Point(81, 92);
            this.cashierPassword_textBox.Name = "cashierPassword_textBox";
            this.cashierPassword_textBox.Size = new System.Drawing.Size(133, 20);
            this.cashierPassword_textBox.TabIndex = 1;
            this.cashierPassword_textBox.TextChanged += new System.EventHandler(this.adminPassword_textBox_TextChanged);
            // 
            // UserId_label
            // 
            this.UserId_label.AutoSize = true;
            this.UserId_label.Location = new System.Drawing.Point(13, 55);
            this.UserId_label.Name = "UserId_label";
            this.UserId_label.Size = new System.Drawing.Size(41, 13);
            this.UserId_label.TabIndex = 2;
            this.UserId_label.Text = "User Id";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(13, 99);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Password";
            // 
            // Showpassword_checkBox
            // 
            this.Showpassword_checkBox.AutoSize = true;
            this.Showpassword_checkBox.Location = new System.Drawing.Point(81, 131);
            this.Showpassword_checkBox.Name = "Showpassword_checkBox";
            this.Showpassword_checkBox.Size = new System.Drawing.Size(102, 17);
            this.Showpassword_checkBox.TabIndex = 4;
            this.Showpassword_checkBox.Text = "Show Password";
            this.Showpassword_checkBox.UseVisualStyleBackColor = true;
            this.Showpassword_checkBox.CheckedChanged += new System.EventHandler(this.Showpassword_checkBox_CheckedChanged);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(81, 170);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(177, 170);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 7;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // CashierLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Showpassword_checkBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserId_label);
            this.Controls.Add(this.cashierPassword_textBox);
            this.Controls.Add(this.cashierUserId_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CashierLogin";
            this.Text = "CashierLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cashierUserId_textBox;
        private System.Windows.Forms.TextBox cashierPassword_textBox;
        private System.Windows.Forms.Label UserId_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.CheckBox Showpassword_checkBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}