namespace posLogIn
{
    partial class addacc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addacc));
            this.selectedRole = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.repeatPwd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addAccBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pwd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedRole
            // 
            this.selectedRole.BackColor = System.Drawing.Color.Transparent;
            this.selectedRole.BaseColor = System.Drawing.Color.White;
            this.selectedRole.BorderColor = System.Drawing.Color.Silver;
            this.selectedRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectedRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedRole.FocusedColor = System.Drawing.Color.Empty;
            this.selectedRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectedRole.ForeColor = System.Drawing.Color.Black;
            this.selectedRole.FormattingEnabled = true;
            this.selectedRole.ItemHeight = 30;
            this.selectedRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.selectedRole.Location = new System.Drawing.Point(13, 387);
            this.selectedRole.Name = "selectedRole";
            this.selectedRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(124)))), ((int)(((byte)(212)))));
            this.selectedRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.selectedRole.Size = new System.Drawing.Size(350, 36);
            this.selectedRole.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(14, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "User Role";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(13, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 97;
            this.label8.Text = "Repeat Password";
            // 
            // repeatPwd
            // 
            this.repeatPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repeatPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.repeatPwd.ForeColor = System.Drawing.Color.Black;
            this.repeatPwd.HintForeColor = System.Drawing.Color.Empty;
            this.repeatPwd.HintText = "";
            this.repeatPwd.isPassword = true;
            this.repeatPwd.LineFocusedColor = System.Drawing.Color.Blue;
            this.repeatPwd.LineIdleColor = System.Drawing.Color.Black;
            this.repeatPwd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.repeatPwd.LineThickness = 3;
            this.repeatPwd.Location = new System.Drawing.Point(13, 313);
            this.repeatPwd.Margin = new System.Windows.Forms.Padding(4);
            this.repeatPwd.Name = "repeatPwd";
            this.repeatPwd.Size = new System.Drawing.Size(355, 43);
            this.repeatPwd.TabIndex = 96;
            this.repeatPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(13, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 95;
            this.label7.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(124, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 85;
            this.label1.Text = "Add Account";
            // 
            // addAccBtn
            // 
            this.addAccBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addAccBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addAccBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addAccBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addAccBtn.BorderRadius = 0;
            this.addAccBtn.ButtonText = "Sign Up";
            this.addAccBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAccBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addAccBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addAccBtn.Iconimage = null;
            this.addAccBtn.Iconimage_right = null;
            this.addAccBtn.Iconimage_right_Selected = null;
            this.addAccBtn.Iconimage_Selected = null;
            this.addAccBtn.IconMarginLeft = 0;
            this.addAccBtn.IconMarginRight = 0;
            this.addAccBtn.IconRightVisible = true;
            this.addAccBtn.IconRightZoom = 0D;
            this.addAccBtn.IconVisible = true;
            this.addAccBtn.IconZoom = 90D;
            this.addAccBtn.IsTab = false;
            this.addAccBtn.Location = new System.Drawing.Point(102, 464);
            this.addAccBtn.Name = "addAccBtn";
            this.addAccBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addAccBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addAccBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addAccBtn.selected = false;
            this.addAccBtn.Size = new System.Drawing.Size(156, 43);
            this.addAccBtn.TabIndex = 84;
            this.addAccBtn.Text = "Sign Up";
            this.addAccBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addAccBtn.Textcolor = System.Drawing.Color.White;
            this.addAccBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccBtn.Click += new System.EventHandler(this.addAccBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(13, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(13, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 93;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(185, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 92;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "First Name";
            // 
            // lName
            // 
            this.lName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lName.ForeColor = System.Drawing.Color.Black;
            this.lName.HintForeColor = System.Drawing.Color.Empty;
            this.lName.HintText = "";
            this.lName.isPassword = false;
            this.lName.LineFocusedColor = System.Drawing.Color.Blue;
            this.lName.LineIdleColor = System.Drawing.Color.Black;
            this.lName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lName.LineThickness = 3;
            this.lName.Location = new System.Drawing.Point(186, 105);
            this.lName.Margin = new System.Windows.Forms.Padding(4);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(182, 43);
            this.lName.TabIndex = 87;
            this.lName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HintForeColor = System.Drawing.Color.Empty;
            this.email.HintText = "";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Blue;
            this.email.LineIdleColor = System.Drawing.Color.Black;
            this.email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(13, 160);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(355, 43);
            this.email.TabIndex = 90;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pwd
            // 
            this.pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pwd.ForeColor = System.Drawing.Color.Black;
            this.pwd.HintForeColor = System.Drawing.Color.Empty;
            this.pwd.HintText = "";
            this.pwd.isPassword = true;
            this.pwd.LineFocusedColor = System.Drawing.Color.Blue;
            this.pwd.LineIdleColor = System.Drawing.Color.Black;
            this.pwd.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pwd.LineThickness = 3;
            this.pwd.Location = new System.Drawing.Point(14, 262);
            this.pwd.Margin = new System.Windows.Forms.Padding(4);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(355, 43);
            this.pwd.TabIndex = 89;
            this.pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // usn
            // 
            this.usn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usn.ForeColor = System.Drawing.Color.Black;
            this.usn.HintForeColor = System.Drawing.Color.Empty;
            this.usn.HintText = "";
            this.usn.isPassword = false;
            this.usn.LineFocusedColor = System.Drawing.Color.Blue;
            this.usn.LineIdleColor = System.Drawing.Color.Black;
            this.usn.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usn.LineThickness = 3;
            this.usn.Location = new System.Drawing.Point(16, 211);
            this.usn.Margin = new System.Windows.Forms.Padding(4);
            this.usn.Name = "usn";
            this.usn.Size = new System.Drawing.Size(355, 43);
            this.usn.TabIndex = 88;
            this.usn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fName
            // 
            this.fName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fName.ForeColor = System.Drawing.Color.Black;
            this.fName.HintForeColor = System.Drawing.Color.Empty;
            this.fName.HintText = "";
            this.fName.isPassword = false;
            this.fName.LineFocusedColor = System.Drawing.Color.Blue;
            this.fName.LineIdleColor = System.Drawing.Color.Black;
            this.fName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fName.LineThickness = 3;
            this.fName.Location = new System.Drawing.Point(13, 105);
            this.fName.Margin = new System.Windows.Forms.Padding(4);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(165, 43);
            this.fName.TabIndex = 86;
            this.fName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectedRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.repeatPwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAccBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.usn);
            this.Controls.Add(this.fName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addacc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addacc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox selectedRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox repeatPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton addAccBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pwd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}