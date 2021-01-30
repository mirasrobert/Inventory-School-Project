namespace posLogIn
{
    partial class Users
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            //this.prd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.prdQty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.prdPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedBrand = new Guna.UI.WinForms.GunaComboBox();
            this.selectedCategory = new Guna.UI.WinForms.GunaComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridprd = new Guna.UI.WinForms.GunaDataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.prdDate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.prdID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.delprdBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updprdBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addprdBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridprd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 42);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(59, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Manage Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // prd
            // 
            this.prd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.prd.BorderColorFocused = System.Drawing.Color.Blue;
            this.prd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.prd.BorderThickness = 3;
            this.prd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prd.isPassword = false;
            this.prd.Location = new System.Drawing.Point(167, 79);
            this.prd.Margin = new System.Windows.Forms.Padding(4);
            this.prd.Name = "prd";
            this.prd.Size = new System.Drawing.Size(202, 26);
            this.prd.TabIndex = 23;
            this.prd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prdQty
            // 
            this.prdQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.prdQty.BorderColorFocused = System.Drawing.Color.Blue;
            this.prdQty.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdQty.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.prdQty.BorderThickness = 3;
            this.prdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prdQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prdQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdQty.isPassword = false;
            this.prdQty.Location = new System.Drawing.Point(390, 130);
            this.prdQty.Margin = new System.Windows.Forms.Padding(4);
            this.prdQty.Name = "prdQty";
            this.prdQty.Size = new System.Drawing.Size(202, 26);
            this.prdQty.TabIndex = 25;
            this.prdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prdQty.OnValueChanged += new System.EventHandler(this.prdQty_OnValueChanged);
            // 
            // prdPrice
            // 
            this.prdPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.prdPrice.BorderColorFocused = System.Drawing.Color.Blue;
            this.prdPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdPrice.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.prdPrice.BorderThickness = 3;
            this.prdPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prdPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prdPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdPrice.isPassword = false;
            this.prdPrice.Location = new System.Drawing.Point(390, 81);
            this.prdPrice.Margin = new System.Windows.Forms.Padding(4);
            this.prdPrice.Name = "prdPrice";
            this.prdPrice.Size = new System.Drawing.Size(202, 26);
            this.prdPrice.TabIndex = 26;
            this.prdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prdPrice.OnValueChanged += new System.EventHandler(this.prdPrice_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(169, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Product Name";
            // 
            // selectedBrand
            // 
            this.selectedBrand.BackColor = System.Drawing.Color.Transparent;
            this.selectedBrand.BaseColor = System.Drawing.Color.White;
            this.selectedBrand.BorderColor = System.Drawing.Color.Silver;
            this.selectedBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectedBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedBrand.FocusedColor = System.Drawing.Color.Empty;
            this.selectedBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectedBrand.ForeColor = System.Drawing.Color.Black;
            this.selectedBrand.FormattingEnabled = true;
            this.selectedBrand.ItemHeight = 20;
            this.selectedBrand.Location = new System.Drawing.Point(172, 176);
            this.selectedBrand.Name = "selectedBrand";
            this.selectedBrand.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(124)))), ((int)(((byte)(212)))));
            this.selectedBrand.OnHoverItemForeColor = System.Drawing.Color.White;
            this.selectedBrand.Size = new System.Drawing.Size(197, 26);
            this.selectedBrand.TabIndex = 39;
            this.selectedBrand.SelectedIndexChanged += new System.EventHandler(this.selectedBrand_SelectedIndexChanged);
            this.selectedBrand.Click += new System.EventHandler(this.selectedBrand_Click);
            // 
            // selectedCategory
            // 
            this.selectedCategory.BackColor = System.Drawing.Color.Transparent;
            this.selectedCategory.BaseColor = System.Drawing.Color.White;
            this.selectedCategory.BorderColor = System.Drawing.Color.Silver;
            this.selectedCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedCategory.FocusedColor = System.Drawing.Color.Empty;
            this.selectedCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectedCategory.ForeColor = System.Drawing.Color.Black;
            this.selectedCategory.FormattingEnabled = true;
            this.selectedCategory.ItemHeight = 20;
            this.selectedCategory.Location = new System.Drawing.Point(172, 130);
            this.selectedCategory.Name = "selectedCategory";
            this.selectedCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(124)))), ((int)(((byte)(212)))));
            this.selectedCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.selectedCategory.Size = new System.Drawing.Size(197, 26);
            this.selectedCategory.TabIndex = 40;
            this.selectedCategory.DropDown += new System.EventHandler(this.selectedCategory_DropDown);
            this.selectedCategory.SelectedIndexChanged += new System.EventHandler(this.selectedCategory_SelectedIndexChanged);
            this.selectedCategory.Click += new System.EventHandler(this.selectedCategory_Click);
            this.selectedCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectedCategory_MouseClick);
            this.selectedCategory.MouseEnter += new System.EventHandler(this.selectedCategory_MouseEnter);
            this.selectedCategory.MouseHover += new System.EventHandler(this.selectedCategory_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(169, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Brand";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(169, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Category";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(387, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(387, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Product Price";
            // 
            // datagridprd
            // 
            this.datagridprd.AllowUserToAddRows = false;
            this.datagridprd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridprd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridprd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridprd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridprd.BackgroundColor = System.Drawing.Color.White;
            this.datagridprd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridprd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridprd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridprd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridprd.ColumnHeadersHeight = 21;
            this.datagridprd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Category,
            this.Brand,
            this.Price,
            this.Stocks,
            this.AddedDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridprd.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridprd.EnableHeadersVisualStyles = false;
            this.datagridprd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridprd.Location = new System.Drawing.Point(1, 213);
            this.datagridprd.Name = "datagridprd";
            this.datagridprd.ReadOnly = true;
            this.datagridprd.RowHeadersVisible = false;
            this.datagridprd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridprd.Size = new System.Drawing.Size(948, 385);
            this.datagridprd.TabIndex = 43;
            this.datagridprd.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagridprd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridprd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridprd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridprd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridprd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridprd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridprd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridprd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridprd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridprd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridprd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridprd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridprd.ThemeStyle.HeaderStyle.Height = 21;
            this.datagridprd.ThemeStyle.ReadOnly = true;
            this.datagridprd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridprd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridprd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridprd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridprd.ThemeStyle.RowsStyle.Height = 22;
            this.datagridprd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridprd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridprd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridprd_CellClick);
            this.datagridprd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridprd_CellContentClick);
            this.datagridprd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridprd_CellMouseClick);
            this.datagridprd.Scroll += new System.Windows.Forms.ScrollEventHandler(this.datagridprd_Scroll);
            this.datagridprd.DoubleClick += new System.EventHandler(this.datagridprd_DoubleClick);
            this.datagridprd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagridprd_MouseClick);
            this.datagridprd.MouseHover += new System.EventHandler(this.datagridprd_MouseHover);
            // 
            // Product
            // 
            this.Product.DataPropertyName = "productName";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "productCategory";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "productBrand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "productPrice";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Stocks
            // 
            this.Stocks.DataPropertyName = "productStock";
            this.Stocks.HeaderText = "Stocks";
            this.Stocks.Name = "Stocks";
            this.Stocks.ReadOnly = true;
            // 
            // AddedDate
            // 
            this.AddedDate.DataPropertyName = "addedDate";
            this.AddedDate.HeaderText = "Added Date";
            this.AddedDate.Name = "AddedDate";
            this.AddedDate.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(387, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date";
            // 
            // prdDate
            // 
            this.prdDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.prdDate.BorderColorFocused = System.Drawing.Color.Blue;
            this.prdDate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdDate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.prdDate.BorderThickness = 3;
            this.prdDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prdDate.Enabled = false;
            this.prdDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prdDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdDate.isPassword = false;
            this.prdDate.Location = new System.Drawing.Point(390, 180);
            this.prdDate.Margin = new System.Windows.Forms.Padding(4);
            this.prdDate.Name = "prdDate";
            this.prdDate.Size = new System.Drawing.Size(202, 26);
            this.prdDate.TabIndex = 48;
            this.prdDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prdID
            // 
            this.prdID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.prdID.BorderColorFocused = System.Drawing.Color.Blue;
            this.prdID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.prdID.BorderThickness = 3;
            this.prdID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prdID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prdID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdID.isPassword = false;
            this.prdID.Location = new System.Drawing.Point(786, 174);
            this.prdID.Margin = new System.Windows.Forms.Padding(4);
            this.prdID.Name = "prdID";
            this.prdID.Size = new System.Drawing.Size(109, 26);
            this.prdID.TabIndex = 49;
            this.prdID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prdID.Visible = false;
            // 
            // delprdBtn
            // 
            this.delprdBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delprdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delprdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delprdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delprdBtn.BorderRadius = 0;
            this.delprdBtn.ButtonText = "Delete Product";
            this.delprdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delprdBtn.DisabledColor = System.Drawing.Color.Gray;
            this.delprdBtn.Enabled = false;
            this.delprdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delprdBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.delprdBtn.Iconimage = null;
            this.delprdBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("delprdBtn.Iconimage_right")));
            this.delprdBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("delprdBtn.Iconimage_right_Selected")));
            this.delprdBtn.Iconimage_Selected = null;
            this.delprdBtn.IconMarginLeft = 0;
            this.delprdBtn.IconMarginRight = 0;
            this.delprdBtn.IconRightVisible = true;
            this.delprdBtn.IconRightZoom = 0D;
            this.delprdBtn.IconVisible = true;
            this.delprdBtn.IconZoom = 80D;
            this.delprdBtn.IsTab = false;
            this.delprdBtn.Location = new System.Drawing.Point(621, 162);
            this.delprdBtn.Name = "delprdBtn";
            this.delprdBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delprdBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.delprdBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.delprdBtn.selected = false;
            this.delprdBtn.Size = new System.Drawing.Size(144, 38);
            this.delprdBtn.TabIndex = 46;
            this.delprdBtn.Text = "Delete Product";
            this.delprdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delprdBtn.Textcolor = System.Drawing.Color.White;
            this.delprdBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delprdBtn.Click += new System.EventHandler(this.delprdBtn_Click);
            // 
            // updprdBtn
            // 
            this.updprdBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updprdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updprdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updprdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updprdBtn.BorderRadius = 0;
            this.updprdBtn.ButtonText = "Update Product";
            this.updprdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updprdBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updprdBtn.Enabled = false;
            this.updprdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updprdBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updprdBtn.Iconimage = null;
            this.updprdBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("updprdBtn.Iconimage_right")));
            this.updprdBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("updprdBtn.Iconimage_right_Selected")));
            this.updprdBtn.Iconimage_Selected = null;
            this.updprdBtn.IconMarginLeft = 0;
            this.updprdBtn.IconMarginRight = 0;
            this.updprdBtn.IconRightVisible = true;
            this.updprdBtn.IconRightZoom = 0D;
            this.updprdBtn.IconVisible = true;
            this.updprdBtn.IconZoom = 80D;
            this.updprdBtn.IsTab = false;
            this.updprdBtn.Location = new System.Drawing.Point(621, 118);
            this.updprdBtn.Name = "updprdBtn";
            this.updprdBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updprdBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.updprdBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.updprdBtn.selected = false;
            this.updprdBtn.Size = new System.Drawing.Size(144, 38);
            this.updprdBtn.TabIndex = 45;
            this.updprdBtn.Text = "Update Product";
            this.updprdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updprdBtn.Textcolor = System.Drawing.Color.White;
            this.updprdBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updprdBtn.Click += new System.EventHandler(this.updprdBtn_Click);
            // 
            // addprdBtn
            // 
            this.addprdBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addprdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addprdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addprdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addprdBtn.BorderRadius = 0;
            this.addprdBtn.ButtonText = "Add Product";
            this.addprdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addprdBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addprdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addprdBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addprdBtn.Iconimage = null;
            this.addprdBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("addprdBtn.Iconimage_right")));
            this.addprdBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("addprdBtn.Iconimage_right_Selected")));
            this.addprdBtn.Iconimage_Selected = null;
            this.addprdBtn.IconMarginLeft = 0;
            this.addprdBtn.IconMarginRight = 0;
            this.addprdBtn.IconRightVisible = true;
            this.addprdBtn.IconRightZoom = 0D;
            this.addprdBtn.IconVisible = true;
            this.addprdBtn.IconZoom = 80D;
            this.addprdBtn.IsTab = false;
            this.addprdBtn.Location = new System.Drawing.Point(621, 74);
            this.addprdBtn.Name = "addprdBtn";
            this.addprdBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addprdBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.addprdBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.addprdBtn.selected = false;
            this.addprdBtn.Size = new System.Drawing.Size(144, 38);
            this.addprdBtn.TabIndex = 44;
            this.addprdBtn.Text = "Add Product";
            this.addprdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addprdBtn.Textcolor = System.Drawing.Color.White;
            this.addprdBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addprdBtn.Click += new System.EventHandler(this.addprdBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 601);
            this.Controls.Add(this.prdID);
            this.Controls.Add(this.prdDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delprdBtn);
            this.Controls.Add(this.updprdBtn);
            this.Controls.Add(this.addprdBtn);
            this.Controls.Add(this.datagridprd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedBrand);
            this.Controls.Add(this.selectedCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prdPrice);
            this.Controls.Add(this.prdQty);
            this.Controls.Add(this.prd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridprd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox prd;
        private Bunifu.Framework.UI.BunifuMetroTextbox prdQty;
        private Bunifu.Framework.UI.BunifuMetroTextbox prdPrice;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaComboBox selectedBrand;
        private Guna.UI.WinForms.GunaComboBox selectedCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaDataGridView datagridprd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedDate;
        private Bunifu.Framework.UI.BunifuFlatButton delprdBtn;
        private Bunifu.Framework.UI.BunifuFlatButton updprdBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addprdBtn;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox prdDate;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox prdID;
        private System.Windows.Forms.Timer timer1;
    }
}