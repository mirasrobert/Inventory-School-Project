namespace posLogIn
{
    partial class Brands
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brands));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.brdName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridbrand = new Guna.UI.WinForms.GunaDataGridView();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.brdDate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.delbrdBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updbrdBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addbrdBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbrand)).BeginInit();
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
            this.label5.Size = new System.Drawing.Size(146, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Manage Brand";
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
            // brd
            // 
            this.brd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.brd.BorderColorFocused = System.Drawing.Color.Blue;
            this.brd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.brd.BorderThickness = 3;
            this.brd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brd.Enabled = false;
            this.brd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.brd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brd.isPassword = false;
            this.brd.Location = new System.Drawing.Point(251, 72);
            this.brd.Margin = new System.Windows.Forms.Padding(4);
            this.brd.Name = "brd";
            this.brd.Size = new System.Drawing.Size(202, 26);
            this.brd.TabIndex = 23;
            this.brd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.brd.OnValueChanged += new System.EventHandler(this.brd_OnValueChanged);
            // 
            // brdName
            // 
            this.brdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.brdName.BorderColorFocused = System.Drawing.Color.Blue;
            this.brdName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brdName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.brdName.BorderThickness = 3;
            this.brdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brdName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.brdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brdName.isPassword = false;
            this.brdName.Location = new System.Drawing.Point(251, 123);
            this.brdName.Margin = new System.Windows.Forms.Padding(4);
            this.brdName.Name = "brdName";
            this.brdName.Size = new System.Drawing.Size(202, 26);
            this.brdName.TabIndex = 26;
            this.brdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(257, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Brand ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(257, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Brand Name";
            // 
            // datagridbrand
            // 
            this.datagridbrand.AllowUserToAddRows = false;
            this.datagridbrand.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridbrand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridbrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridbrand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridbrand.BackgroundColor = System.Drawing.Color.White;
            this.datagridbrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridbrand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridbrand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridbrand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridbrand.ColumnHeadersHeight = 21;
            this.datagridbrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.datagridbrand.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridbrand.EnableHeadersVisualStyles = false;
            this.datagridbrand.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridbrand.Location = new System.Drawing.Point(1, 213);
            this.datagridbrand.Name = "datagridbrand";
            this.datagridbrand.ReadOnly = true;
            this.datagridbrand.RowHeadersVisible = false;
            this.datagridbrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridbrand.Size = new System.Drawing.Size(948, 385);
            this.datagridbrand.TabIndex = 43;
            this.datagridbrand.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.datagridbrand.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridbrand.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridbrand.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridbrand.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridbrand.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridbrand.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridbrand.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridbrand.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridbrand.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridbrand.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridbrand.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridbrand.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridbrand.ThemeStyle.HeaderStyle.Height = 21;
            this.datagridbrand.ThemeStyle.ReadOnly = true;
            this.datagridbrand.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridbrand.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridbrand.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridbrand.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridbrand.ThemeStyle.RowsStyle.Height = 22;
            this.datagridbrand.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridbrand.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridbrand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridbrand_CellClick);
            this.datagridbrand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridbrand_CellContentClick);
            this.datagridbrand.Scroll += new System.Windows.Forms.ScrollEventHandler(this.datagridbrand_Scroll);
            this.datagridbrand.DoubleClick += new System.EventHandler(this.datagridbrand_DoubleClick);
            this.datagridbrand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.datagridbrand_MouseClick);
            this.datagridbrand.MouseHover += new System.EventHandler(this.datagridbrand_MouseHover);
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "bid";
            this.Brand.HeaderText = "Brand ID";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // brandName
            // 
            this.brandName.DataPropertyName = "brandName";
            this.brandName.HeaderText = "Brand Name";
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
            // brdDate
            // 
            this.brdDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.brdDate.BorderColorFocused = System.Drawing.Color.Blue;
            this.brdDate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brdDate.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.brdDate.BorderThickness = 3;
            this.brdDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brdDate.Enabled = false;
            this.brdDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.brdDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brdDate.isPassword = false;
            this.brdDate.Location = new System.Drawing.Point(251, 169);
            this.brdDate.Margin = new System.Windows.Forms.Padding(4);
            this.brdDate.Name = "brdDate";
            this.brdDate.Size = new System.Drawing.Size(202, 31);
            this.brdDate.TabIndex = 48;
            this.brdDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.brdDate.OnValueChanged += new System.EventHandler(this.brdDate_OnValueChanged);
            // 
            // delbrdBtn
            // 
            this.delbrdBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delbrdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delbrdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delbrdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delbrdBtn.BorderRadius = 0;
            this.delbrdBtn.ButtonText = "Delete Brand";
            this.delbrdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delbrdBtn.DisabledColor = System.Drawing.Color.Gray;
            this.delbrdBtn.Enabled = false;
            this.delbrdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delbrdBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.delbrdBtn.Iconimage = null;
            this.delbrdBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("delbrdBtn.Iconimage_right")));
            this.delbrdBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("delbrdBtn.Iconimage_right_Selected")));
            this.delbrdBtn.Iconimage_Selected = null;
            this.delbrdBtn.IconMarginLeft = 0;
            this.delbrdBtn.IconMarginRight = 0;
            this.delbrdBtn.IconRightVisible = true;
            this.delbrdBtn.IconRightZoom = 0D;
            this.delbrdBtn.IconVisible = true;
            this.delbrdBtn.IconZoom = 80D;
            this.delbrdBtn.IsTab = false;
            this.delbrdBtn.Location = new System.Drawing.Point(523, 155);
            this.delbrdBtn.Name = "delbrdBtn";
            this.delbrdBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.delbrdBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.delbrdBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.delbrdBtn.selected = false;
            this.delbrdBtn.Size = new System.Drawing.Size(144, 38);
            this.delbrdBtn.TabIndex = 46;
            this.delbrdBtn.Text = "Delete Brand";
            this.delbrdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delbrdBtn.Textcolor = System.Drawing.Color.White;
            this.delbrdBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbrdBtn.Click += new System.EventHandler(this.delbrdBtn_Click);
            // 
            // updbrdBtn
            // 
            this.updbrdBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updbrdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updbrdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updbrdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updbrdBtn.BorderRadius = 0;
            this.updbrdBtn.ButtonText = "Update Brand";
            this.updbrdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updbrdBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updbrdBtn.Enabled = false;
            this.updbrdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updbrdBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updbrdBtn.Iconimage = null;
            this.updbrdBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("updbrdBtn.Iconimage_right")));
            this.updbrdBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("updbrdBtn.Iconimage_right_Selected")));
            this.updbrdBtn.Iconimage_Selected = null;
            this.updbrdBtn.IconMarginLeft = 0;
            this.updbrdBtn.IconMarginRight = 0;
            this.updbrdBtn.IconRightVisible = true;
            this.updbrdBtn.IconRightZoom = 0D;
            this.updbrdBtn.IconVisible = true;
            this.updbrdBtn.IconZoom = 80D;
            this.updbrdBtn.IsTab = false;
            this.updbrdBtn.Location = new System.Drawing.Point(523, 111);
            this.updbrdBtn.Name = "updbrdBtn";
            this.updbrdBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.updbrdBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.updbrdBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.updbrdBtn.selected = false;
            this.updbrdBtn.Size = new System.Drawing.Size(144, 38);
            this.updbrdBtn.TabIndex = 45;
            this.updbrdBtn.Text = "Update Brand";
            this.updbrdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updbrdBtn.Textcolor = System.Drawing.Color.White;
            this.updbrdBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updbrdBtn.Click += new System.EventHandler(this.updbrdBtn_Click);
            // 
            // addbrdBtn
            // 
            this.addbrdBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addbrdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbrdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addbrdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbrdBtn.BorderRadius = 0;
            this.addbrdBtn.ButtonText = "Add Brand";
            this.addbrdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbrdBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addbrdBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addbrdBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addbrdBtn.Iconimage = null;
            this.addbrdBtn.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("addbrdBtn.Iconimage_right")));
            this.addbrdBtn.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("addbrdBtn.Iconimage_right_Selected")));
            this.addbrdBtn.Iconimage_Selected = null;
            this.addbrdBtn.IconMarginLeft = 0;
            this.addbrdBtn.IconMarginRight = 0;
            this.addbrdBtn.IconRightVisible = true;
            this.addbrdBtn.IconRightZoom = 0D;
            this.addbrdBtn.IconVisible = true;
            this.addbrdBtn.IconZoom = 80D;
            this.addbrdBtn.IsTab = false;
            this.addbrdBtn.Location = new System.Drawing.Point(523, 67);
            this.addbrdBtn.Name = "addbrdBtn";
            this.addbrdBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.addbrdBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.addbrdBtn.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.addbrdBtn.selected = false;
            this.addbrdBtn.Size = new System.Drawing.Size(144, 38);
            this.addbrdBtn.TabIndex = 44;
            this.addbrdBtn.Text = "Add Brand";
            this.addbrdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbrdBtn.Textcolor = System.Drawing.Color.White;
            this.addbrdBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbrdBtn.Click += new System.EventHandler(this.addbrdBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 601);
            this.Controls.Add(this.brdDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delbrdBtn);
            this.Controls.Add(this.updbrdBtn);
            this.Controls.Add(this.addbrdBtn);
            this.Controls.Add(this.datagridbrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.brdName);
            this.Controls.Add(this.brd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Brands";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridbrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox brd;
        private Bunifu.Framework.UI.BunifuMetroTextbox brdName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaDataGridView datagridbrand;
        private Bunifu.Framework.UI.BunifuFlatButton delbrdBtn;
        private Bunifu.Framework.UI.BunifuFlatButton updbrdBtn;
        private Bunifu.Framework.UI.BunifuFlatButton addbrdBtn;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox brdDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDate;
        private System.Windows.Forms.Timer timer1;
    }
}