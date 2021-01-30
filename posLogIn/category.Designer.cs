namespace posLogIn
{
    partial class category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(category));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ctgName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridcategory = new Guna.UI.WinForms.GunaDataGridView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.ctgDate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.delctgBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updctgBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addctgBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcategory)).BeginInit();
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
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Manage Category";
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
            // ctg
            // 
            this.ctg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ctg.BorderColorFocused = System.Drawing.Color.Blue;
            this.ctg.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctg.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.ctg.BorderThickness = 3;
            this.ctg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctg.Enabled = false;
            this.ctg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ctg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctg.isPassword = false;
            this.ctg.Location = new System.Drawing.Point(251, 72);
            this.ctg.Margin = new System.Windows.Forms.Padding(4);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(202, 26);
            this.ctg.TabIndex = 23;
            this.ctg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ctgName
            // 
            this.ctgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ctgName.BorderColorFocused = System.Drawing.Color.Blue;
            this.ctgName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctgName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.ctgName.BorderThickness = 3;
            this.ctgName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctgName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ctgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctgName.isPassword = false;
            this.ctgName.Location = new System.Drawing.Point(251, 123);
            this.ctgName.Margin = new System.Windows.Forms.Padding(4);
            this.ctgName.Name = "ctgName";
            this.ctgName.Size = new System.Drawing.Size(202, 26);
            this.ctgName.TabIndex = 26;
            this.ctgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(257, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Category ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(257, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Category Name";
            // 
            // datagridcategory
            // 
            this.datagridcategory.AllowUserToAddRows = false;
            this.datagridcategory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridcategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridcategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridcategory.BackgroundColor = System.Drawing.Color.White;
            this.datagridcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridcategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridcategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridcategory.ColumnHeadersHeight = 21;
            this.datagridcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.brandName,
            this.addDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridcategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridcategory.EnableHeadersVisualStyles = false;
            this.datagridcategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridcategory.Location = new System.Drawing.Point(1, 213);
            this.datagridcategory.Name = "datagridcategory";
            this.datagridcategory.ReadOnly = true;
            this.datagridcategory.RowHeadersVisible = false;
            this.datagridcategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridcategory.Size = new System.Drawing.Size(948, 385);
            this.datagridcategory.TabIndex = 43;
            this.datagridcategory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagridcategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridcategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridcategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridcategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridcategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridcategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridcategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridcategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridcategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridcategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridcategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridcategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridcategory.ThemeStyle.HeaderStyle.Height = 21;
            this.datagridcategory.ThemeStyle.ReadOnly = true;
            this.datagridcategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridcategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridcategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridcategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridcategory.ThemeStyle.RowsStyle.Height = 22;
            this.datagridcategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridcategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridcategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcategory_CellClick);
            this.datagridcategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridcategory_CellContentClick);
            this.datagridcategory.Scroll += new System.Windows.Forms.ScrollEventHandler(this.datagridcategory_Scroll);
            this.datagridcategory.DoubleClick += new System.EventHandler(this.datagridcategory_DoubleClick);
            this.datagridcategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagridbrand_MouseClick);
            this.datagridcategory.MouseHover += new System.EventHandler(this.datagridcategory_MouseHover);
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "cid";
            this.Brand.HeaderText = "Category ID";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // brandName
            // 
            this.brandName.DataPropertyName = "categoryName";
            this.brandName.HeaderText = "Category Name";
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            // 
            // addDate
            // 
            this.addDate.DataPropertyName = "addedDate";
            this.addDate.HeaderText = "Added Date";
            this.addDate.Name = "addDate";
            this.addDate.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(257, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Date";
            // 
            // ctgDate
            // 
            this.ctgDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ctgDate.BorderColorFocused = System.Drawing.Color.Blue;
            this.ctgDate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctgDate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.ctgDate.BorderThickness = 3;
            this.ctgDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctgDate.Enabled = false;
            this.ctgDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ctgDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ctgDate.isPassword = false;
            this.ctgDate.Location = new System.Drawing.Point(251, 169);
            this.ctgDate.Margin = new System.Windows.Forms.Padding(4);
            this.ctgDate.Name = "ctgDate";
            this.ctgDate.Size = new System.Drawing.Size(202, 31);
            this.ctgDate.TabIndex = 48;
            this.ctgDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // delctgBtn
            // 
            this.delctgBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delctgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delctgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delctgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delctgBtn.BorderRadius = 0;
            this.delctgBtn.ButtonText = "Delete Category";
            this.delctgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delctgBtn.DisabledColor = System.Drawing.Color.Gray;
            this.delctgBtn.Enabled = false;
            this.delctgBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delctgBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.delctgBtn.Iconimage = null;
            this.delctgBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("delctgBtn.Iconimage_right")));
            this.delctgBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("delctgBtn.Iconimage_right_Selected")));
            this.delctgBtn.Iconimage_Selected = null;
            this.delctgBtn.IconMarginLeft = 0;
            this.delctgBtn.IconMarginRight = 0;
            this.delctgBtn.IconRightVisible = true;
            this.delctgBtn.IconRightZoom = 0D;
            this.delctgBtn.IconVisible = true;
            this.delctgBtn.IconZoom = 80D;
            this.delctgBtn.IsTab = false;
            this.delctgBtn.Location = new System.Drawing.Point(523, 155);
            this.delctgBtn.Name = "delctgBtn";
            this.delctgBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delctgBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.delctgBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.delctgBtn.selected = false;
            this.delctgBtn.Size = new System.Drawing.Size(152, 38);
            this.delctgBtn.TabIndex = 46;
            this.delctgBtn.Text = "Delete Category";
            this.delctgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delctgBtn.Textcolor = System.Drawing.Color.White;
            this.delctgBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delctgBtn.Click += new System.EventHandler(this.delctgBtn_Click);
            // 
            // updctgBtn
            // 
            this.updctgBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updctgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updctgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updctgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updctgBtn.BorderRadius = 0;
            this.updctgBtn.ButtonText = "Update Category";
            this.updctgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updctgBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updctgBtn.Enabled = false;
            this.updctgBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updctgBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updctgBtn.Iconimage = null;
            this.updctgBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("updctgBtn.Iconimage_right")));
            this.updctgBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("updctgBtn.Iconimage_right_Selected")));
            this.updctgBtn.Iconimage_Selected = null;
            this.updctgBtn.IconMarginLeft = 0;
            this.updctgBtn.IconMarginRight = 0;
            this.updctgBtn.IconRightVisible = true;
            this.updctgBtn.IconRightZoom = 0D;
            this.updctgBtn.IconVisible = true;
            this.updctgBtn.IconZoom = 80D;
            this.updctgBtn.IsTab = false;
            this.updctgBtn.Location = new System.Drawing.Point(523, 111);
            this.updctgBtn.Name = "updctgBtn";
            this.updctgBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updctgBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.updctgBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.updctgBtn.selected = false;
            this.updctgBtn.Size = new System.Drawing.Size(152, 38);
            this.updctgBtn.TabIndex = 45;
            this.updctgBtn.Text = "Update Category";
            this.updctgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updctgBtn.Textcolor = System.Drawing.Color.White;
            this.updctgBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updctgBtn.Click += new System.EventHandler(this.updctgBtn_Click);
            // 
            // addctgBtn
            // 
            this.addctgBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addctgBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addctgBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addctgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addctgBtn.BorderRadius = 0;
            this.addctgBtn.ButtonText = "Add Category";
            this.addctgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addctgBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addctgBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addctgBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addctgBtn.Iconimage = null;
            this.addctgBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("addctgBtn.Iconimage_right")));
            this.addctgBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("addctgBtn.Iconimage_right_Selected")));
            this.addctgBtn.Iconimage_Selected = null;
            this.addctgBtn.IconMarginLeft = 0;
            this.addctgBtn.IconMarginRight = 0;
            this.addctgBtn.IconRightVisible = true;
            this.addctgBtn.IconRightZoom = 0D;
            this.addctgBtn.IconVisible = true;
            this.addctgBtn.IconZoom = 80D;
            this.addctgBtn.IsTab = false;
            this.addctgBtn.Location = new System.Drawing.Point(523, 67);
            this.addctgBtn.Name = "addctgBtn";
            this.addctgBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addctgBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.addctgBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.addctgBtn.selected = false;
            this.addctgBtn.Size = new System.Drawing.Size(152, 38);
            this.addctgBtn.TabIndex = 44;
            this.addctgBtn.Text = "Add Category";
            this.addctgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addctgBtn.Textcolor = System.Drawing.Color.White;
            this.addctgBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addctgBtn.Click += new System.EventHandler(this.addctgBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 601);
            this.Controls.Add(this.ctgDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delctgBtn);
            this.Controls.Add(this.updctgBtn);
            this.Controls.Add(this.addctgBtn);
            this.Controls.Add(this.datagridcategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ctgName);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "category";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox ctg;
        private Bunifu.Framework.UI.BunifuMetroTextbox ctgName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaDataGridView datagridcategory;
        private Bunifu.Framework.UI.BunifuFlatButton delctgBtn;
        private Bunifu.Framework.UI.BunifuFlatButton updctgBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addctgBtn;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox ctgDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDate;
        private System.Windows.Forms.Timer timer1;
    }
}