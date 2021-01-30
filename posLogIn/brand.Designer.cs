namespace posLogIn
{
    partial class brand
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridBrand = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del = new Guna.UI.WinForms.GunaButton();
            this.btn_add = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 43);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::posLogIn.Properties.Resources.icons8_bag_brand_50;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(53, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manage Brand";
            // 
            // datagridBrand
            // 
            this.datagridBrand.AllowUserToAddRows = false;
            this.datagridBrand.AllowUserToDeleteRows = false;
            this.datagridBrand.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.datagridBrand.Location = new System.Drawing.Point(0, 43);
            this.datagridBrand.Name = "datagridBrand";
            this.datagridBrand.ReadOnly = true;
            this.datagridBrand.RowHeadersVisible = false;
            this.datagridBrand.Size = new System.Drawing.Size(950, 348);
            this.datagridBrand.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Id";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "brand";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "BRAND";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 908;
            // 
            // btn_del
            // 
            this.btn_del.AnimationHoverSpeed = 0.07F;
            this.btn_del.AnimationSpeed = 0.03F;
            this.btn_del.BackColor = System.Drawing.Color.Transparent;
            this.btn_del.BaseColor = System.Drawing.Color.Transparent;
            this.btn_del.BorderColor = System.Drawing.Color.Red;
            this.btn_del.BorderSize = 1;
            this.btn_del.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_del.FocusedColor = System.Drawing.Color.Empty;
            this.btn_del.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Image = null;
            this.btn_del.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_del.Location = new System.Drawing.Point(800, 409);
            this.btn_del.Name = "btn_del";
            this.btn_del.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btn_del.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btn_del.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_del.OnHoverImage = null;
            this.btn_del.OnPressedColor = System.Drawing.Color.Black;
            this.btn_del.Radius = 20;
            this.btn_del.Size = new System.Drawing.Size(122, 44);
            this.btn_del.TabIndex = 7;
            this.btn_del.Text = "Delete";
            this.btn_del.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.AnimationHoverSpeed = 0.07F;
            this.btn_add.AnimationSpeed = 0.03F;
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BaseColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderColor = System.Drawing.Color.Green;
            this.btn_add.BorderSize = 1;
            this.btn_add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = null;
            this.btn_add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_add.Location = new System.Drawing.Point(654, 409);
            this.btn_add.Name = "btn_add";
            this.btn_add.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btn_add.OnHoverBorderColor = System.Drawing.Color.Green;
            this.btn_add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_add.OnHoverImage = null;
            this.btn_add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_add.Radius = 20;
            this.btn_add.Size = new System.Drawing.Size(122, 44);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(949, 469);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.datagridBrand);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "brand";
            this.Text = "brand";
            this.Load += new System.EventHandler(this.brand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridBrand;
        private Guna.UI.WinForms.GunaButton btn_del;
        private Guna.UI.WinForms.GunaButton btn_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}