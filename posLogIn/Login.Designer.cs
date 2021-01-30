namespace posLogIn
{
    partial class pos_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pos_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_user = new Guna.UI.WinForms.GunaTextBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txt_pass = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI.WinForms.GunaButton();
            this.remember = new Guna.UI.WinForms.GunaCheckBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.userBox = new Guna.UI.WinForms.GunaCheckBox();
            this.adminBox = new Guna.UI.WinForms.GunaCheckBox();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 43);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(372, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.Transparent;
            this.txt_user.BaseColor = System.Drawing.Color.White;
            this.txt_user.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_user.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_user.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_user.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Gray;
            this.txt_user.Location = new System.Drawing.Point(86, 319);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.Radius = 5;
            this.txt_user.Size = new System.Drawing.Size(278, 43);
            this.txt_user.TabIndex = 12;
            this.txt_user.Text = "Enter Username";
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::posLogIn.Properties.Resources.avatar;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(34, 320);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(49, 42);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 13;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox2.Image = global::posLogIn.Properties.Resources.registration_registration2_512;
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(33, 388);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(50, 42);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox2.TabIndex = 15;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.BaseColor = System.Drawing.Color.White;
            this.txt_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Enabled = false;
            this.txt_pass.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_pass.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Gray;
            this.txt_pass.Location = new System.Drawing.Point(86, 387);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Radius = 5;
            this.txt_pass.Size = new System.Drawing.Size(277, 43);
            this.txt_pass.TabIndex = 14;
            this.txt_pass.Text = "Enter Password";
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(157, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN";
            // 
            // button1
            // 
            this.button1.AnimationHoverSpeed = 0.07F;
            this.button1.AnimationSpeed = 0.03F;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.button1.BorderSize = 2;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.FocusedColor = System.Drawing.Color.Empty;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = null;
            this.button1.ImageSize = new System.Drawing.Size(20, 20);
            this.button1.Location = new System.Drawing.Point(81, 500);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.button1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button1.OnHoverForeColor = System.Drawing.Color.White;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Radius = 20;
            this.button1.Size = new System.Drawing.Size(237, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "LOGIN";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // remember
            // 
            this.remember.BaseColor = System.Drawing.Color.White;
            this.remember.CheckedOffColor = System.Drawing.Color.Gray;
            this.remember.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.remember.FillColor = System.Drawing.Color.White;
            this.remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remember.ForeColor = System.Drawing.Color.DimGray;
            this.remember.Location = new System.Drawing.Point(98, 460);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(150, 24);
            this.remember.TabIndex = 18;
            this.remember.Text = "Remember Me";
            this.remember.CheckedChanged += new System.EventHandler(this.remember_CheckedChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // userBox
            // 
            this.userBox.BaseColor = System.Drawing.Color.White;
            this.userBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.userBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userBox.FillColor = System.Drawing.Color.White;
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.Color.DimGray;
            this.userBox.Location = new System.Drawing.Point(173, 436);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(59, 20);
            this.userBox.TabIndex = 20;
            this.userBox.Text = "User";
            this.userBox.CheckedChanged += new System.EventHandler(this.userBox_CheckedChanged);
            // 
            // adminBox
            // 
            this.adminBox.BaseColor = System.Drawing.Color.White;
            this.adminBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.adminBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.adminBox.FillColor = System.Drawing.Color.White;
            this.adminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBox.ForeColor = System.Drawing.Color.DimGray;
            this.adminBox.Location = new System.Drawing.Point(98, 436);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(69, 20);
            this.adminBox.TabIndex = 21;
            this.adminBox.Text = "Admin";
            this.adminBox.CheckedChanged += new System.EventHandler(this.adminBox_CheckedChanged);
            // 
            // roleBox
            // 
            this.roleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roleBox.Location = new System.Drawing.Point(244, 441);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(100, 13);
            this.roleBox.TabIndex = 22;
            this.roleBox.Visible = false;
            // 
            // pos_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 574);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.adminBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.remember);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaCirclePictureBox2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pos_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.pos_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaTextBox txt_user;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaTextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton button1;
        private Guna.UI.WinForms.GunaCheckBox remember;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI.WinForms.GunaCheckBox userBox;
        private Guna.UI.WinForms.GunaCheckBox adminBox;
        private System.Windows.Forms.TextBox roleBox;
    }
}

