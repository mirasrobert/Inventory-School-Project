namespace posLogIn
{
    partial class addbrand
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 43);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Brand";
            // 
            // txt_brand
            // 
            this.txt_brand.Location = new System.Drawing.Point(31, 126);
            this.txt_brand.Multiline = true;
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(406, 27);
            this.txt_brand.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "BRAND NAME";
            // 
            // add
            // 
            this.add.AnimationHoverSpeed = 0.07F;
            this.add.AnimationSpeed = 0.03F;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BaseColor = System.Drawing.Color.Transparent;
            this.add.BorderColor = System.Drawing.Color.Green;
            this.add.BorderSize = 1;
            this.add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add.FocusedColor = System.Drawing.Color.Empty;
            this.add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Image = null;
            this.add.ImageSize = new System.Drawing.Size(20, 20);
            this.add.Location = new System.Drawing.Point(177, 192);
            this.add.Name = "add";
            this.add.OnHoverBaseColor = System.Drawing.Color.Green;
            this.add.OnHoverBorderColor = System.Drawing.Color.Green;
            this.add.OnHoverForeColor = System.Drawing.Color.White;
            this.add.OnHoverImage = null;
            this.add.OnPressedColor = System.Drawing.Color.Black;
            this.add.Radius = 20;
            this.add.Size = new System.Drawing.Size(122, 44);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Red;
            this.gunaButton1.BorderSize = 1;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(315, 192);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Red;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(122, 44);
            this.gunaButton1.TabIndex = 38;
            this.gunaButton1.Text = "Close";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // addbrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(477, 261);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addbrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addbrand";
            this.Load += new System.EventHandler(this.addbrand_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton add;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}