namespace posLogIn
{
    partial class RecordUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timerOrder = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.datagridlgn = new Guna.UI.WinForms.GunaDataGridView();
            this.userNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeLogins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popup_panel = new System.Windows.Forms.Panel();
            this.salesGrid = new Guna.UI.WinForms.GunaDataGridView();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileGrid = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datecreates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lgnBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.viewSaleBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updPasswordBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.accBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridlgn)).BeginInit();
            this.popup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(55, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Record";
            // 
            // timerOrder
            // 
            this.timerOrder.Tick += new System.EventHandler(this.timerOrder_Tick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this;
            // 
            // datagridlgn
            // 
            this.datagridlgn.AllowUserToAddRows = false;
            this.datagridlgn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.datagridlgn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.datagridlgn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridlgn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridlgn.BackgroundColor = System.Drawing.Color.White;
            this.datagridlgn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridlgn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridlgn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridlgn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datagridlgn.ColumnHeadersHeight = 21;
            this.datagridlgn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNames,
            this.timeLogins});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridlgn.DefaultCellStyle = dataGridViewCellStyle9;
            this.datagridlgn.EnableHeadersVisualStyles = false;
            this.datagridlgn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridlgn.Location = new System.Drawing.Point(-2, -2);
            this.datagridlgn.Name = "datagridlgn";
            this.datagridlgn.ReadOnly = true;
            this.datagridlgn.RowHeadersVisible = false;
            this.datagridlgn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridlgn.Size = new System.Drawing.Size(823, 333);
            this.datagridlgn.TabIndex = 36;
            this.datagridlgn.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagridlgn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridlgn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridlgn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridlgn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridlgn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridlgn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridlgn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridlgn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridlgn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridlgn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridlgn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridlgn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridlgn.ThemeStyle.HeaderStyle.Height = 21;
            this.datagridlgn.ThemeStyle.ReadOnly = true;
            this.datagridlgn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridlgn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridlgn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridlgn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridlgn.ThemeStyle.RowsStyle.Height = 22;
            this.datagridlgn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridlgn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridlgn.Visible = false;
            this.datagridlgn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridlgn_CellContentClick);
            this.datagridlgn.Scroll += new System.Windows.Forms.ScrollEventHandler(this.datagridlgn_Scroll);
            this.datagridlgn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagridlgn_MouseClick);
            this.datagridlgn.MouseHover += new System.EventHandler(this.datagridlgn_MouseHover);
            // 
            // userNames
            // 
            this.userNames.DataPropertyName = "username";
            this.userNames.HeaderText = "Username";
            this.userNames.Name = "userNames";
            this.userNames.ReadOnly = true;
            // 
            // timeLogins
            // 
            this.timeLogins.DataPropertyName = "timeLogin";
            this.timeLogins.HeaderText = "Time Login";
            this.timeLogins.Name = "timeLogins";
            this.timeLogins.ReadOnly = true;
            // 
            // popup_panel
            // 
            this.popup_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.popup_panel.Controls.Add(this.salesGrid);
            this.popup_panel.Controls.Add(this.profileGrid);
            this.popup_panel.Controls.Add(this.datagridlgn);
            this.popup_panel.Location = new System.Drawing.Point(59, 151);
            this.popup_panel.Name = "popup_panel";
            this.popup_panel.Size = new System.Drawing.Size(823, 333);
            this.popup_panel.TabIndex = 37;
            this.popup_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.popup_panel_Paint);
            // 
            // salesGrid
            // 
            this.salesGrid.AllowUserToAddRows = false;
            this.salesGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.salesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.salesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesGrid.BackgroundColor = System.Drawing.Color.White;
            this.salesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.salesGrid.ColumnHeadersHeight = 21;
            this.salesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer,
            this.Products,
            this.Prices,
            this.Qtys,
            this.Discounts,
            this.Totals,
            this.Paids,
            this.Dues,
            this.Dates});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.salesGrid.EnableHeadersVisualStyles = false;
            this.salesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesGrid.Location = new System.Drawing.Point(-2, -2);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.ReadOnly = true;
            this.salesGrid.RowHeadersVisible = false;
            this.salesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesGrid.Size = new System.Drawing.Size(823, 333);
            this.salesGrid.TabIndex = 44;
            this.salesGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.salesGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.salesGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.salesGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.salesGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.salesGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.salesGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.salesGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.salesGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.salesGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salesGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.salesGrid.ThemeStyle.HeaderStyle.Height = 21;
            this.salesGrid.ThemeStyle.ReadOnly = true;
            this.salesGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.salesGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.salesGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.salesGrid.ThemeStyle.RowsStyle.Height = 22;
            this.salesGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.salesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesGrid_CellContentClick);
            this.salesGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.salesGrid_Scroll);
            this.salesGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.salesGrid_MouseClick);
            this.salesGrid.MouseHover += new System.EventHandler(this.salesGrid_MouseHover);
            // 
            // customer
            // 
            this.customer.DataPropertyName = "customerName";
            this.customer.HeaderText = "Customer Name";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // Products
            // 
            this.Products.DataPropertyName = "productName";
            this.Products.HeaderText = "Product";
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            // 
            // Prices
            // 
            this.Prices.DataPropertyName = "productPrice";
            this.Prices.HeaderText = "Price";
            this.Prices.Name = "Prices";
            this.Prices.ReadOnly = true;
            // 
            // Qtys
            // 
            this.Qtys.DataPropertyName = "qty";
            this.Qtys.HeaderText = "Quantity";
            this.Qtys.Name = "Qtys";
            this.Qtys.ReadOnly = true;
            // 
            // Discounts
            // 
            this.Discounts.DataPropertyName = "discount";
            this.Discounts.HeaderText = "Discount";
            this.Discounts.Name = "Discounts";
            this.Discounts.ReadOnly = true;
            // 
            // Totals
            // 
            this.Totals.DataPropertyName = "total";
            this.Totals.HeaderText = "Total";
            this.Totals.Name = "Totals";
            this.Totals.ReadOnly = true;
            // 
            // Paids
            // 
            this.Paids.DataPropertyName = "paid";
            this.Paids.HeaderText = "Paid";
            this.Paids.Name = "Paids";
            this.Paids.ReadOnly = true;
            // 
            // Dues
            // 
            this.Dues.DataPropertyName = "due";
            this.Dues.HeaderText = "Due";
            this.Dues.Name = "Dues";
            this.Dues.ReadOnly = true;
            // 
            // Dates
            // 
            this.Dates.DataPropertyName = "date";
            this.Dates.HeaderText = "Date";
            this.Dates.Name = "Dates";
            this.Dates.ReadOnly = true;
            // 
            // profileGrid
            // 
            this.profileGrid.AllowUserToAddRows = false;
            this.profileGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.profileGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.profileGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.profileGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profileGrid.BackgroundColor = System.Drawing.Color.White;
            this.profileGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profileGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.profileGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.profileGrid.ColumnHeadersHeight = 21;
            this.profileGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.emails,
            this.Roles,
            this.Datecreates});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profileGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.profileGrid.EnableHeadersVisualStyles = false;
            this.profileGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.profileGrid.Location = new System.Drawing.Point(-2, -2);
            this.profileGrid.Name = "profileGrid";
            this.profileGrid.ReadOnly = true;
            this.profileGrid.RowHeadersVisible = false;
            this.profileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profileGrid.Size = new System.Drawing.Size(823, 333);
            this.profileGrid.TabIndex = 40;
            this.profileGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.profileGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.profileGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.profileGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.profileGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.profileGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.profileGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.profileGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.profileGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.profileGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.profileGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.profileGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.profileGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.profileGrid.ThemeStyle.HeaderStyle.Height = 21;
            this.profileGrid.ThemeStyle.ReadOnly = true;
            this.profileGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.profileGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.profileGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.profileGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.profileGrid.ThemeStyle.RowsStyle.Height = 22;
            this.profileGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.profileGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.profileGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.profileGrid_CellContentClick);
            this.profileGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.profileGrid_Scroll);
            this.profileGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.profileGrid_MouseClick);
            this.profileGrid.MouseHover += new System.EventHandler(this.profileGrid_MouseHover);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "firstName";
            this.dataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "lastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn3.HeaderText = "Username";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // emails
            // 
            this.emails.DataPropertyName = "userEmail";
            this.emails.HeaderText = "Email";
            this.emails.Name = "emails";
            this.emails.ReadOnly = true;
            // 
            // Roles
            // 
            this.Roles.DataPropertyName = "userRole";
            this.Roles.HeaderText = "Role";
            this.Roles.Name = "Roles";
            this.Roles.ReadOnly = true;
            // 
            // Datecreates
            // 
            this.Datecreates.DataPropertyName = "dateCreated";
            this.Datecreates.HeaderText = "Date Created";
            this.Datecreates.Name = "Datecreates";
            this.Datecreates.ReadOnly = true;
            // 
            // lgnBtn
            // 
            this.lgnBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lgnBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lgnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lgnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lgnBtn.BorderRadius = 0;
            this.lgnBtn.ButtonText = "View Login History";
            this.lgnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lgnBtn.DisabledColor = System.Drawing.Color.Gray;
            this.lgnBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lgnBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.lgnBtn.Iconimage = null;
            this.lgnBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("lgnBtn.Iconimage_right")));
            this.lgnBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("lgnBtn.Iconimage_right_Selected")));
            this.lgnBtn.Iconimage_Selected = null;
            this.lgnBtn.IconMarginLeft = 0;
            this.lgnBtn.IconMarginRight = 0;
            this.lgnBtn.IconRightVisible = true;
            this.lgnBtn.IconRightZoom = 0D;
            this.lgnBtn.IconVisible = true;
            this.lgnBtn.IconZoom = 80D;
            this.lgnBtn.IsTab = false;
            this.lgnBtn.Location = new System.Drawing.Point(59, 72);
            this.lgnBtn.Name = "lgnBtn";
            this.lgnBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lgnBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lgnBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.lgnBtn.selected = false;
            this.lgnBtn.Size = new System.Drawing.Size(167, 44);
            this.lgnBtn.TabIndex = 38;
            this.lgnBtn.Text = "View Login History";
            this.lgnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lgnBtn.Textcolor = System.Drawing.Color.White;
            this.lgnBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgnBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // viewSaleBtn
            // 
            this.viewSaleBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.viewSaleBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.viewSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.viewSaleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewSaleBtn.BorderRadius = 0;
            this.viewSaleBtn.ButtonText = "View Sales";
            this.viewSaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSaleBtn.DisabledColor = System.Drawing.Color.Gray;
            this.viewSaleBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.viewSaleBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.viewSaleBtn.Iconimage = null;
            this.viewSaleBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("viewSaleBtn.Iconimage_right")));
            this.viewSaleBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("viewSaleBtn.Iconimage_right_Selected")));
            this.viewSaleBtn.Iconimage_Selected = null;
            this.viewSaleBtn.IconMarginLeft = 0;
            this.viewSaleBtn.IconMarginRight = 0;
            this.viewSaleBtn.IconRightVisible = true;
            this.viewSaleBtn.IconRightZoom = 0D;
            this.viewSaleBtn.IconVisible = true;
            this.viewSaleBtn.IconZoom = 80D;
            this.viewSaleBtn.IsTab = false;
            this.viewSaleBtn.Location = new System.Drawing.Point(397, 72);
            this.viewSaleBtn.Name = "viewSaleBtn";
            this.viewSaleBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.viewSaleBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.viewSaleBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.viewSaleBtn.selected = false;
            this.viewSaleBtn.Size = new System.Drawing.Size(159, 44);
            this.viewSaleBtn.TabIndex = 35;
            this.viewSaleBtn.Text = "View Sales";
            this.viewSaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewSaleBtn.Textcolor = System.Drawing.Color.White;
            this.viewSaleBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSaleBtn.Click += new System.EventHandler(this.viewSaleBtn_Click);
            // 
            // updPasswordBtn
            // 
            this.updPasswordBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updPasswordBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updPasswordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updPasswordBtn.BorderRadius = 0;
            this.updPasswordBtn.ButtonText = "Update Password";
            this.updPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updPasswordBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updPasswordBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updPasswordBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updPasswordBtn.Iconimage = null;
            this.updPasswordBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("updPasswordBtn.Iconimage_right")));
            this.updPasswordBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("updPasswordBtn.Iconimage_right_Selected")));
            this.updPasswordBtn.Iconimage_Selected = null;
            this.updPasswordBtn.IconMarginLeft = 0;
            this.updPasswordBtn.IconMarginRight = 0;
            this.updPasswordBtn.IconRightVisible = true;
            this.updPasswordBtn.IconRightZoom = 0D;
            this.updPasswordBtn.IconVisible = true;
            this.updPasswordBtn.IconZoom = 80D;
            this.updPasswordBtn.IsTab = false;
            this.updPasswordBtn.Location = new System.Drawing.Point(562, 72);
            this.updPasswordBtn.Name = "updPasswordBtn";
            this.updPasswordBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updPasswordBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.updPasswordBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.updPasswordBtn.selected = false;
            this.updPasswordBtn.Size = new System.Drawing.Size(159, 44);
            this.updPasswordBtn.TabIndex = 33;
            this.updPasswordBtn.Text = "Update Password";
            this.updPasswordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updPasswordBtn.Textcolor = System.Drawing.Color.White;
            this.updPasswordBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updPasswordBtn.Click += new System.EventHandler(this.updPasswordBtn_Click);
            // 
            // accBtn
            // 
            this.accBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.accBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.accBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accBtn.BorderRadius = 0;
            this.accBtn.ButtonText = "View Profiles";
            this.accBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accBtn.DisabledColor = System.Drawing.Color.Gray;
            this.accBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.accBtn.Iconimage = null;
            this.accBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("accBtn.Iconimage_right")));
            this.accBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("accBtn.Iconimage_right_Selected")));
            this.accBtn.Iconimage_Selected = null;
            this.accBtn.IconMarginLeft = 0;
            this.accBtn.IconMarginRight = 0;
            this.accBtn.IconRightVisible = true;
            this.accBtn.IconRightZoom = 0D;
            this.accBtn.IconVisible = true;
            this.accBtn.IconZoom = 80D;
            this.accBtn.IsTab = false;
            this.accBtn.Location = new System.Drawing.Point(232, 72);
            this.accBtn.Name = "accBtn";
            this.accBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.accBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.accBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.accBtn.selected = false;
            this.accBtn.Size = new System.Drawing.Size(159, 44);
            this.accBtn.TabIndex = 32;
            this.accBtn.Text = "View Profiles";
            this.accBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accBtn.Textcolor = System.Drawing.Color.White;
            this.accBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // RecordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 601);
            this.Controls.Add(this.lgnBtn);
            this.Controls.Add(this.viewSaleBtn);
            this.Controls.Add(this.updPasswordBtn);
            this.Controls.Add(this.accBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.popup_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordUser";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridlgn)).EndInit();
            this.popup_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerOrder;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Guna.UI.WinForms.GunaDataGridView datagridlgn;
        private Bunifu.Framework.UI.BunifuFlatButton viewSaleBtn;
        private Bunifu.Framework.UI.BunifuFlatButton updPasswordBtn;
        private Bunifu.Framework.UI.BunifuFlatButton accBtn;
        public System.Windows.Forms.Panel popup_panel;
        private Bunifu.Framework.UI.BunifuFlatButton lgnBtn;
        private Guna.UI.WinForms.GunaDataGridView profileGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn emails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datecreates;
        private Guna.UI.WinForms.GunaDataGridView salesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dues;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeLogins;
    }
}