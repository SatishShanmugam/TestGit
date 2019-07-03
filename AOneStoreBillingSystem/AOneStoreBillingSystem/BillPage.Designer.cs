namespace AOneStoreBillingSystem
{
    partial class BillPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BillNo = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.BilledProducts_GridView = new System.Windows.Forms.DataGridView();
            this.SI_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.Bill_Number_textBox = new System.Windows.Forms.TextBox();
            this.BillDate_textBox = new System.Windows.Forms.TextBox();
            this.Product_Search_Textbox = new System.Windows.Forms.TextBox();
            this.ProductId_textBox = new System.Windows.Forms.TextBox();
            this.ProductName_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.Discount_textBox = new System.Windows.Forms.TextBox();
            this.TotalBill_Amount_textBox = new System.Windows.Forms.TextBox();
            this.Product_Search_ListBox = new System.Windows.Forms.ListBox();
            this.Remove_Btn = new System.Windows.Forms.Button();
            this.Print_Bill_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add_Product_Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Error_Message_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BilledProducts_GridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillNo
            // 
            this.BillNo.AutoSize = true;
            this.BillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNo.Location = new System.Drawing.Point(0, 9);
            this.BillNo.Name = "BillNo";
            this.BillNo.Size = new System.Drawing.Size(44, 13);
            this.BillNo.TabIndex = 0;
            this.BillNo.Text = "Bill No";
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductId.Location = new System.Drawing.Point(252, 16);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(66, 13);
            this.ProductId.TabIndex = 1;
            this.ProductId.Text = "Product Id";
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(704, 9);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(34, 13);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(467, 13);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(87, 13);
            this.ProductName.TabIndex = 3;
            this.ProductName.Text = "Product Name";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(285, 67);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(36, 13);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(470, 64);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(54, 13);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "Quantity";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(665, 64);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(70, 13);
            this.Discount.TabIndex = 6;
            this.Discount.Text = "Discount %";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(2, 16);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(47, 13);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            // 
            // BilledProducts_GridView
            // 
            this.BilledProducts_GridView.AllowUserToAddRows = false;
            this.BilledProducts_GridView.AllowUserToDeleteRows = false;
            this.BilledProducts_GridView.AllowUserToResizeColumns = false;
            this.BilledProducts_GridView.AllowUserToResizeRows = false;
            this.BilledProducts_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BilledProducts_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BilledProducts_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BilledProducts_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BilledProducts_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SI_No,
            this.Product_Id,
            this.Product_Name,
            this.Product_Quantity,
            this.Product_Price,
            this.Product_Discount,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BilledProducts_GridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BilledProducts_GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BilledProducts_GridView.Location = new System.Drawing.Point(15, 229);
            this.BilledProducts_GridView.MultiSelect = false;
            this.BilledProducts_GridView.Name = "BilledProducts_GridView";
            this.BilledProducts_GridView.ReadOnly = true;
            this.BilledProducts_GridView.RowHeadersVisible = false;
            this.BilledProducts_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.BilledProducts_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BilledProducts_GridView.Size = new System.Drawing.Size(857, 263);
            this.BilledProducts_GridView.TabIndex = 8;
            this.BilledProducts_GridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BilledProducts_GridView_CellMouseClick);
            // 
            // SI_No
            // 
            this.SI_No.FillWeight = 53.29952F;
            this.SI_No.HeaderText = "SI.No";
            this.SI_No.Name = "SI_No";
            this.SI_No.ReadOnly = true;
            this.SI_No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SI_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Id
            // 
            this.Product_Id.FillWeight = 68.74908F;
            this.Product_Id.HeaderText = "Product Id";
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            this.Product_Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Name
            // 
            this.Product_Name.FillWeight = 197.9955F;
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.FillWeight = 94.98905F;
            this.Product_Quantity.HeaderText = "Quantity";
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.ReadOnly = true;
            this.Product_Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Price
            // 
            this.Product_Price.FillWeight = 94.98905F;
            this.Product_Price.HeaderText = "Price";
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.ReadOnly = true;
            this.Product_Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Discount
            // 
            this.Product_Discount.FillWeight = 94.98905F;
            this.Product_Discount.HeaderText = "Discount Percentage";
            this.Product_Discount.Name = "Product_Discount";
            this.Product_Discount.ReadOnly = true;
            this.Product_Discount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            this.Total.FillWeight = 94.98905F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(640, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bill Amount";
            // 
            // Bill_Number_textBox
            // 
            this.Bill_Number_textBox.Location = new System.Drawing.Point(50, 6);
            this.Bill_Number_textBox.Name = "Bill_Number_textBox";
            this.Bill_Number_textBox.Size = new System.Drawing.Size(100, 20);
            this.Bill_Number_textBox.TabIndex = 11;
            // 
            // BillDate_textBox
            // 
            this.BillDate_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BillDate_textBox.Location = new System.Drawing.Point(754, 6);
            this.BillDate_textBox.Name = "BillDate_textBox";
            this.BillDate_textBox.Size = new System.Drawing.Size(100, 20);
            this.BillDate_textBox.TabIndex = 12;
            // 
            // Product_Search_Textbox
            // 
            this.Product_Search_Textbox.Location = new System.Drawing.Point(50, 11);
            this.Product_Search_Textbox.Name = "Product_Search_Textbox";
            this.Product_Search_Textbox.Size = new System.Drawing.Size(152, 20);
            this.Product_Search_Textbox.TabIndex = 13;
            this.Product_Search_Textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Search_Textbox_MouseClick);
            this.Product_Search_Textbox.TextChanged += new System.EventHandler(this.Product_Search_Textbox_TextChanged);
            // 
            // ProductId_textBox
            // 
            this.ProductId_textBox.Location = new System.Drawing.Point(337, 10);
            this.ProductId_textBox.Name = "ProductId_textBox";
            this.ProductId_textBox.ReadOnly = true;
            this.ProductId_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProductId_textBox.TabIndex = 14;
            // 
            // ProductName_textBox
            // 
            this.ProductName_textBox.Location = new System.Drawing.Point(581, 10);
            this.ProductName_textBox.Name = "ProductName_textBox";
            this.ProductName_textBox.ReadOnly = true;
            this.ProductName_textBox.Size = new System.Drawing.Size(184, 20);
            this.ProductName_textBox.TabIndex = 15;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(337, 64);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.ReadOnly = true;
            this.Price_textBox.Size = new System.Drawing.Size(100, 20);
            this.Price_textBox.TabIndex = 16;
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(547, 61);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(100, 20);
            this.Quantity_textBox.TabIndex = 17;
            // 
            // Discount_textBox
            // 
            this.Discount_textBox.Location = new System.Drawing.Point(754, 61);
            this.Discount_textBox.Name = "Discount_textBox";
            this.Discount_textBox.Size = new System.Drawing.Size(85, 20);
            this.Discount_textBox.TabIndex = 18;
            // 
            // TotalBill_Amount_textBox
            // 
            this.TotalBill_Amount_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalBill_Amount_textBox.Location = new System.Drawing.Point(733, 21);
            this.TotalBill_Amount_textBox.Name = "TotalBill_Amount_textBox";
            this.TotalBill_Amount_textBox.ReadOnly = true;
            this.TotalBill_Amount_textBox.Size = new System.Drawing.Size(121, 20);
            this.TotalBill_Amount_textBox.TabIndex = 20;
            // 
            // Product_Search_ListBox
            // 
            this.Product_Search_ListBox.FormattingEnabled = true;
            this.Product_Search_ListBox.Location = new System.Drawing.Point(50, 37);
            this.Product_Search_ListBox.Name = "Product_Search_ListBox";
            this.Product_Search_ListBox.Size = new System.Drawing.Size(152, 134);
            this.Product_Search_ListBox.TabIndex = 21;
            this.Product_Search_ListBox.Visible = false;
            this.Product_Search_ListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Product_Search_ListBox_MouseClick);
            //this.Product_Search_ListBox.SelectedIndexChanged += new System.EventHandler(this.Product_Search_ListBox_SelectedIndexChanged);
            // 
            // Remove_Btn
            // 
            this.Remove_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Btn.Location = new System.Drawing.Point(754, 106);
            this.Remove_Btn.Name = "Remove_Btn";
            this.Remove_Btn.Size = new System.Drawing.Size(82, 38);
            this.Remove_Btn.TabIndex = 23;
            this.Remove_Btn.Text = "Remove";
            this.Remove_Btn.UseVisualStyleBackColor = true;
            this.Remove_Btn.Click += new System.EventHandler(this.Remove_Btn_Click);
            // 
            // Print_Bill_Btn
            // 
            this.Print_Bill_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_Bill_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Bill_Btn.Location = new System.Drawing.Point(733, 65);
            this.Print_Bill_Btn.Name = "Print_Bill_Btn";
            this.Print_Bill_Btn.Size = new System.Drawing.Size(121, 40);
            this.Print_Bill_Btn.TabIndex = 24;
            this.Print_Bill_Btn.Text = "Print Bill";
            this.Print_Bill_Btn.UseVisualStyleBackColor = true;
            this.Print_Bill_Btn.Click += new System.EventHandler(this.Print_Bill_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.Bill_Number_textBox);
            this.panel1.Controls.Add(this.BillNo);
            this.panel1.Controls.Add(this.BillDate_textBox);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 44);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.Product_Search_Textbox);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.Product_Search_ListBox);
            this.panel2.Controls.Add(this.Remove_Btn);
            this.panel2.Controls.Add(this.ProductId_textBox);
            this.panel2.Controls.Add(this.Add_Product_Btn);
            this.panel2.Controls.Add(this.ProductId);
            this.panel2.Controls.Add(this.ProductName_textBox);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Controls.Add(this.Discount_textBox);
            this.panel2.Controls.Add(this.Price_textBox);
            this.panel2.Controls.Add(this.Quantity_textBox);
            this.panel2.Controls.Add(this.Price);
            this.panel2.Controls.Add(this.Discount);
            this.panel2.Controls.Add(this.Quantity);
            this.panel2.Location = new System.Drawing.Point(15, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 174);
            this.panel2.TabIndex = 26;
            // 
            // Add_Product_Btn
            // 
            this.Add_Product_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product_Btn.Location = new System.Drawing.Point(544, 106);
            this.Add_Product_Btn.Name = "Add_Product_Btn";
            this.Add_Product_Btn.Size = new System.Drawing.Size(100, 38);
            this.Add_Product_Btn.TabIndex = 22;
            this.Add_Product_Btn.Text = "Add";
            this.Add_Product_Btn.UseVisualStyleBackColor = true;
            this.Add_Product_Btn.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.Error_Message_Label);
            this.panel3.Controls.Add(this.Print_Bill_Btn);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.TotalBill_Amount_textBox);
            this.panel3.Location = new System.Drawing.Point(15, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 108);
            this.panel3.TabIndex = 27;
            // 
            // Error_Message_Label
            // 
            this.Error_Message_Label.AutoSize = true;
            this.Error_Message_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Message_Label.ForeColor = System.Drawing.Color.Red;
            this.Error_Message_Label.Location = new System.Drawing.Point(334, 28);
            this.Error_Message_Label.Name = "Error_Message_Label";
            this.Error_Message_Label.Size = new System.Drawing.Size(0, 16);
            this.Error_Message_Label.TabIndex = 25;
            // 
            // BillPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 612);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BilledProducts_GridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BillPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BillPage";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BillPage_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BillPage_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BilledProducts_GridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BillNo;
        private System.Windows.Forms.Label ProductId;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DataGridView BilledProducts_GridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Bill_Number_textBox;
        private System.Windows.Forms.TextBox BillDate_textBox;
        private System.Windows.Forms.TextBox Product_Search_Textbox;
        private System.Windows.Forms.TextBox ProductId_textBox;
        private System.Windows.Forms.TextBox ProductName_textBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.TextBox Quantity_textBox;
        private System.Windows.Forms.TextBox Discount_textBox;
        private System.Windows.Forms.TextBox TotalBill_Amount_textBox;
        private System.Windows.Forms.ListBox Product_Search_ListBox;
        private System.Windows.Forms.Button Remove_Btn;
        private System.Windows.Forms.Button Print_Bill_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Add_Product_Btn;
        private System.Windows.Forms.Label Error_Message_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn SI_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}