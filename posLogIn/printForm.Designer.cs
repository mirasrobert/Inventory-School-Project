namespace posLogIn
{
    partial class printForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printForm));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txt_receipt = new System.Windows.Forms.RichTextBox();
            this.orderNow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // txt_receipt
            // 
            this.txt_receipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_receipt.Enabled = false;
            this.txt_receipt.Location = new System.Drawing.Point(38, 37);
            this.txt_receipt.Name = "txt_receipt";
            this.txt_receipt.Size = new System.Drawing.Size(416, 469);
            this.txt_receipt.TabIndex = 0;
            this.txt_receipt.Text = "";
            // 
            // orderNow
            // 
            this.orderNow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.orderNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.orderNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderNow.BorderRadius = 0;
            this.orderNow.ButtonText = "Print";
            this.orderNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderNow.DisabledColor = System.Drawing.Color.Gray;
            this.orderNow.Iconcolor = System.Drawing.Color.Transparent;
            this.orderNow.Iconimage = ((System.Drawing.Image)(resources.GetObject("orderNow.Iconimage")));
            this.orderNow.Iconimage_right = null;
            this.orderNow.Iconimage_right_Selected = null;
            this.orderNow.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("orderNow.Iconimage_Selected")));
            this.orderNow.IconMarginLeft = 0;
            this.orderNow.IconMarginRight = 0;
            this.orderNow.IconRightVisible = true;
            this.orderNow.IconRightZoom = 0D;
            this.orderNow.IconVisible = true;
            this.orderNow.IconZoom = 90D;
            this.orderNow.IsTab = false;
            this.orderNow.Location = new System.Drawing.Point(166, 458);
            this.orderNow.Name = "orderNow";
            this.orderNow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.orderNow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.orderNow.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.orderNow.selected = false;
            this.orderNow.Size = new System.Drawing.Size(165, 48);
            this.orderNow.TabIndex = 27;
            this.orderNow.Text = "Print";
            this.orderNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderNow.Textcolor = System.Drawing.Color.White;
            this.orderNow.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNow.Click += new System.EventHandler(this.orderNow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(210, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "ORDER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // printForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderNow);
            this.Controls.Add(this.txt_receipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "printForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "printForm";
            this.Load += new System.EventHandler(this.printForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Bunifu.Framework.UI.BunifuFlatButton orderNow;
        public System.Windows.Forms.RichTextBox txt_receipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}