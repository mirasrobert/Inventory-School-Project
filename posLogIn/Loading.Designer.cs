namespace posLogIn
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbp = new System.Windows.Forms.Label();
            this.lbs = new System.Windows.Forms.Label();
            this.lbo = new System.Windows.Forms.Label();
            this.system = new System.Windows.Forms.Label();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 43);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "LOADING........";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::posLogIn.Properties.Resources.IMG_33721;
            this.pictureBox1.Location = new System.Drawing.Point(309, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 15;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(30, 166);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar1.TabIndex = 3;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loading Please Wait.............";
            // 
            // lbp
            // 
            this.lbp.AutoSize = true;
            this.lbp.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbp.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbp.Location = new System.Drawing.Point(28, 46);
            this.lbp.Name = "lbp";
            this.lbp.Size = new System.Drawing.Size(0, 81);
            this.lbp.TabIndex = 5;
            // 
            // lbs
            // 
            this.lbs.AutoSize = true;
            this.lbs.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbs.ForeColor = System.Drawing.Color.Gold;
            this.lbs.Location = new System.Drawing.Point(186, 46);
            this.lbs.Name = "lbs";
            this.lbs.Size = new System.Drawing.Size(0, 81);
            this.lbs.TabIndex = 6;
            // 
            // lbo
            // 
            this.lbo.AutoSize = true;
            this.lbo.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbo.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbo.Location = new System.Drawing.Point(107, 46);
            this.lbo.Name = "lbo";
            this.lbo.Size = new System.Drawing.Size(0, 81);
            this.lbo.TabIndex = 7;
            // 
            // system
            // 
            this.system.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system.ForeColor = System.Drawing.Color.Crimson;
            this.system.Location = new System.Drawing.Point(99, 128);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(85, 23);
            this.system.TabIndex = 8;
            this.system.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer_loading
            // 
            this.timer_loading.Tick += new System.EventHandler(this.timer_loading_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 413);
            this.Controls.Add(this.system);
            this.Controls.Add(this.lbo);
            this.Controls.Add(this.lbs);
            this.Controls.Add(this.lbp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbp;
        private System.Windows.Forms.Label lbs;
        private System.Windows.Forms.Label lbo;
        private System.Windows.Forms.Label system;
        private System.Windows.Forms.Timer timer_loading;
    }
}