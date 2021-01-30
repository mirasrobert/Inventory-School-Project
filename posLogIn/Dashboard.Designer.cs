namespace posLogIn
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderBtns = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.categoryBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.brandBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.productBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.popup_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 43);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.orderBtns);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.settingsBtn);
            this.panel2.Controls.Add(this.categoryBtn);
            this.panel2.Controls.Add(this.brandBtn);
            this.panel2.Controls.Add(this.productBtn);
            this.panel2.Controls.Add(this.tab1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 721);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // orderBtns
            // 
            this.orderBtns.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.orderBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderBtns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderBtns.BorderRadius = 0;
            this.orderBtns.ButtonText = "Orders";
            this.orderBtns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderBtns.DisabledColor = System.Drawing.Color.Gray;
            this.orderBtns.Iconcolor = System.Drawing.Color.Transparent;
            this.orderBtns.Iconimage = ((System.Drawing.Image)(resources.GetObject("orderBtns.Iconimage")));
            this.orderBtns.Iconimage_right = null;
            this.orderBtns.Iconimage_right_Selected = null;
            this.orderBtns.Iconimage_Selected = null;
            this.orderBtns.IconMarginLeft = 0;
            this.orderBtns.IconMarginRight = 0;
            this.orderBtns.IconRightVisible = true;
            this.orderBtns.IconRightZoom = 0D;
            this.orderBtns.IconVisible = true;
            this.orderBtns.IconZoom = 90D;
            this.orderBtns.IsTab = false;
            this.orderBtns.Location = new System.Drawing.Point(-2, 414);
            this.orderBtns.Name = "orderBtns";
            this.orderBtns.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.orderBtns.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.orderBtns.OnHoverTextColor = System.Drawing.Color.White;
            this.orderBtns.selected = false;
            this.orderBtns.Size = new System.Drawing.Size(314, 56);
            this.orderBtns.TabIndex = 7;
            this.orderBtns.Text = "Orders";
            this.orderBtns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderBtns.Textcolor = System.Drawing.Color.Black;
            this.orderBtns.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtns.Click += new System.EventHandler(this.orderBtns_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.BorderRadius = 0;
            this.logoutBtn.ButtonText = "Logout";
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.logoutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Iconimage")));
            this.logoutBtn.Iconimage_right = null;
            this.logoutBtn.Iconimage_right_Selected = null;
            this.logoutBtn.Iconimage_Selected = null;
            this.logoutBtn.IconMarginLeft = 0;
            this.logoutBtn.IconMarginRight = 0;
            this.logoutBtn.IconRightVisible = true;
            this.logoutBtn.IconRightZoom = 0D;
            this.logoutBtn.IconVisible = true;
            this.logoutBtn.IconZoom = 90D;
            this.logoutBtn.IsTab = false;
            this.logoutBtn.Location = new System.Drawing.Point(-2, 538);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.logoutBtn.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.logoutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutBtn.selected = false;
            this.logoutBtn.Size = new System.Drawing.Size(314, 56);
            this.logoutBtn.TabIndex = 16;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutBtn.Textcolor = System.Drawing.Color.Black;
            this.logoutBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.BorderRadius = 0;
            this.settingsBtn.ButtonText = "Record";
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.settingsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Iconimage")));
            this.settingsBtn.Iconimage_right = null;
            this.settingsBtn.Iconimage_right_Selected = null;
            this.settingsBtn.Iconimage_Selected = null;
            this.settingsBtn.IconMarginLeft = 0;
            this.settingsBtn.IconMarginRight = 0;
            this.settingsBtn.IconRightVisible = true;
            this.settingsBtn.IconRightZoom = 0D;
            this.settingsBtn.IconVisible = true;
            this.settingsBtn.IconZoom = 90D;
            this.settingsBtn.IsTab = false;
            this.settingsBtn.Location = new System.Drawing.Point(0, 478);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.settingsBtn.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.settingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.settingsBtn.selected = false;
            this.settingsBtn.Size = new System.Drawing.Size(314, 56);
            this.settingsBtn.TabIndex = 15;
            this.settingsBtn.Text = "Record";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsBtn.Textcolor = System.Drawing.Color.Black;
            this.settingsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.categoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.categoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn.BorderRadius = 0;
            this.categoryBtn.ButtonText = "Category";
            this.categoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryBtn.DisabledColor = System.Drawing.Color.Gray;
            this.categoryBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.categoryBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("categoryBtn.Iconimage")));
            this.categoryBtn.Iconimage_right = null;
            this.categoryBtn.Iconimage_right_Selected = null;
            this.categoryBtn.Iconimage_Selected = null;
            this.categoryBtn.IconMarginLeft = 0;
            this.categoryBtn.IconMarginRight = 0;
            this.categoryBtn.IconRightVisible = true;
            this.categoryBtn.IconRightZoom = 0D;
            this.categoryBtn.IconVisible = true;
            this.categoryBtn.IconZoom = 90D;
            this.categoryBtn.IsTab = false;
            this.categoryBtn.Location = new System.Drawing.Point(-2, 359);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.categoryBtn.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.categoryBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.categoryBtn.selected = false;
            this.categoryBtn.Size = new System.Drawing.Size(314, 56);
            this.categoryBtn.TabIndex = 13;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoryBtn.Textcolor = System.Drawing.Color.Black;
            this.categoryBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // brandBtn
            // 
            this.brandBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.brandBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.brandBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brandBtn.BorderRadius = 0;
            this.brandBtn.ButtonText = "Brands";
            this.brandBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brandBtn.DisabledColor = System.Drawing.Color.Gray;
            this.brandBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.brandBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("brandBtn.Iconimage")));
            this.brandBtn.Iconimage_right = null;
            this.brandBtn.Iconimage_right_Selected = null;
            this.brandBtn.Iconimage_Selected = null;
            this.brandBtn.IconMarginLeft = 0;
            this.brandBtn.IconMarginRight = 0;
            this.brandBtn.IconRightVisible = true;
            this.brandBtn.IconRightZoom = 0D;
            this.brandBtn.IconVisible = true;
            this.brandBtn.IconZoom = 90D;
            this.brandBtn.IsTab = false;
            this.brandBtn.Location = new System.Drawing.Point(-2, 304);
            this.brandBtn.Name = "brandBtn";
            this.brandBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.brandBtn.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.brandBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.brandBtn.selected = false;
            this.brandBtn.Size = new System.Drawing.Size(314, 56);
            this.brandBtn.TabIndex = 12;
            this.brandBtn.Text = "Brands";
            this.brandBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brandBtn.Textcolor = System.Drawing.Color.Black;
            this.brandBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandBtn.Click += new System.EventHandler(this.brandBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.productBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.productBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productBtn.BorderRadius = 0;
            this.productBtn.ButtonText = "Product";
            this.productBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productBtn.DisabledColor = System.Drawing.Color.Gray;
            this.productBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.productBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("productBtn.Iconimage")));
            this.productBtn.Iconimage_right = null;
            this.productBtn.Iconimage_right_Selected = null;
            this.productBtn.Iconimage_Selected = null;
            this.productBtn.IconMarginLeft = 0;
            this.productBtn.IconMarginRight = 0;
            this.productBtn.IconRightVisible = true;
            this.productBtn.IconRightZoom = 0D;
            this.productBtn.IconVisible = true;
            this.productBtn.IconZoom = 90D;
            this.productBtn.IsTab = false;
            this.productBtn.Location = new System.Drawing.Point(-2, 249);
            this.productBtn.Name = "productBtn";
            this.productBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.productBtn.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.productBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.productBtn.selected = false;
            this.productBtn.Size = new System.Drawing.Size(314, 56);
            this.productBtn.TabIndex = 11;
            this.productBtn.Text = "Product";
            this.productBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productBtn.Textcolor = System.Drawing.Color.Black;
            this.productBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // tab1
            // 
            this.tab1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab1.BorderRadius = 0;
            this.tab1.ButtonText = "Dashboard";
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab1.DisabledColor = System.Drawing.Color.Gray;
            this.tab1.ForeColor = System.Drawing.Color.Black;
            this.tab1.Iconcolor = System.Drawing.Color.Transparent;
            this.tab1.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab1.Iconimage")));
            this.tab1.Iconimage_right = null;
            this.tab1.Iconimage_right_Selected = null;
            this.tab1.Iconimage_Selected = null;
            this.tab1.IconMarginLeft = 0;
            this.tab1.IconMarginRight = 0;
            this.tab1.IconRightVisible = true;
            this.tab1.IconRightZoom = 0D;
            this.tab1.IconVisible = true;
            this.tab1.IconZoom = 90D;
            this.tab1.IsTab = false;
            this.tab1.Location = new System.Drawing.Point(-1, 199);
            this.tab1.Name = "tab1";
            this.tab1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.tab1.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.tab1.OnHoverTextColor = System.Drawing.Color.White;
            this.tab1.selected = false;
            this.tab1.Size = new System.Drawing.Size(314, 56);
            this.tab1.TabIndex = 4;
            this.tab1.Text = "Dashboard";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tab1.Textcolor = System.Drawing.Color.Black;
            this.tab1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::posLogIn.Properties.Resources.LoginIconAppl;
            this.pictureBox4.Location = new System.Drawing.Point(99, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 101);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // popup_panel
            // 
            this.popup_panel.Location = new System.Drawing.Point(373, 108);
            this.popup_panel.Name = "popup_panel";
            this.popup_panel.Size = new System.Drawing.Size(949, 601);
            this.popup_panel.TabIndex = 4;
            this.popup_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.popup_panel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(24, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 59);
            this.panel3.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "DATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(78, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "DATE";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.popup_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Panel popup_panel;
        private Bunifu.Framework.UI.BunifuFlatButton tab1;
        private Bunifu.Framework.UI.BunifuFlatButton brandBtn;
        private Bunifu.Framework.UI.BunifuFlatButton productBtn;
        private Bunifu.Framework.UI.BunifuFlatButton categoryBtn;
        private Bunifu.Framework.UI.BunifuFlatButton settingsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton logoutBtn;
        private Bunifu.Framework.UI.BunifuFlatButton orderBtns;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
    }
}