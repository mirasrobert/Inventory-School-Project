namespace inv
{
    partial class changepwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changepwd));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.old = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.updPwd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.neww = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.repeat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Change Password";
            // 
            // old
            // 
            this.old.BorderColorFocused = System.Drawing.Color.Blue;
            this.old.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.old.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.old.BorderThickness = 3;
            this.old.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.old.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.old.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.old.isPassword = false;
            this.old.Location = new System.Drawing.Point(12, 84);
            this.old.Margin = new System.Windows.Forms.Padding(4);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(350, 40);
            this.old.TabIndex = 35;
            this.old.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Current Password";
            // 
            // updPwd
            // 
            this.updPwd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updPwd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updPwd.BorderRadius = 0;
            this.updPwd.ButtonText = "Confirm";
            this.updPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updPwd.DisabledColor = System.Drawing.Color.Gray;
            this.updPwd.Iconcolor = System.Drawing.Color.Transparent;
            this.updPwd.Iconimage = null;
            this.updPwd.Iconimage_right = null;
            this.updPwd.Iconimage_right_Selected = null;
            this.updPwd.Iconimage_Selected = null;
            this.updPwd.IconMarginLeft = 0;
            this.updPwd.IconMarginRight = 0;
            this.updPwd.IconRightVisible = true;
            this.updPwd.IconRightZoom = 0D;
            this.updPwd.IconVisible = true;
            this.updPwd.IconZoom = 90D;
            this.updPwd.IsTab = false;
            this.updPwd.Location = new System.Drawing.Point(16, 308);
            this.updPwd.Name = "updPwd";
            this.updPwd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updPwd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.updPwd.OnHoverTextColor = System.Drawing.Color.White;
            this.updPwd.selected = false;
            this.updPwd.Size = new System.Drawing.Size(136, 41);
            this.updPwd.TabIndex = 39;
            this.updPwd.Text = "Confirm";
            this.updPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updPwd.Textcolor = System.Drawing.Color.White;
            this.updPwd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updPwd.Click += new System.EventHandler(this.addnewBrand_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // neww
            // 
            this.neww.BorderColorFocused = System.Drawing.Color.Blue;
            this.neww.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.neww.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.neww.BorderThickness = 3;
            this.neww.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.neww.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.neww.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.neww.isPassword = false;
            this.neww.Location = new System.Drawing.Point(10, 175);
            this.neww.Margin = new System.Windows.Forms.Padding(4);
            this.neww.Name = "neww";
            this.neww.Size = new System.Drawing.Size(350, 40);
            this.neww.TabIndex = 42;
            this.neww.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(11, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "New Password";
            // 
            // repeat
            // 
            this.repeat.BorderColorFocused = System.Drawing.Color.Blue;
            this.repeat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.repeat.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.repeat.BorderThickness = 3;
            this.repeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repeat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.repeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.repeat.isPassword = false;
            this.repeat.Location = new System.Drawing.Point(7, 246);
            this.repeat.Margin = new System.Windows.Forms.Padding(4);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(350, 40);
            this.repeat.TabIndex = 44;
            this.repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(8, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Repeat Password";
            // 
            // changepwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 374);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.neww);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updPwd);
            this.Controls.Add(this.old);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "changepwd";
            this.Text = "a";
            this.Load += new System.EventHandler(this.changepwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox old;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton updPwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox repeat;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox neww;
        private System.Windows.Forms.Label label1;
    }
}