using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace posLogIn
{
    public partial class DashboardUser : Form
    {
        
        public DashboardUser()
        {
            InitializeComponent();
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           //string name =  avatarName.Text;
            //name.ToUpper();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ////string name = avatarName.Text;
            //name.ToUpper();
            timer1.Start();
            
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            Users user = new Users();
            user.TopLevel = false;
            db.popup_panel.Controls.Add(user);
            user.Show();
            this.Hide();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            brand b = new brand();
            b.TopLevel = false;
            db.popup_panel.Controls.Add(b);
            b.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            Users user = new Users();
            user.TopLevel = false;
            db.popup_panel.Controls.Add(user);
            user.Show();
            this.Hide();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            RecordUser user = new RecordUser();
            user.TopLevel = false;
            db.popup_panel.Controls.Add(user);
            user.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Environment.Exit(0);

            }
        }

        private void orderBtns_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            Order user = new Order();
            user.TopLevel = false;
            db.popup_panel.Controls.Add(user);
            user.Show();
            this.Hide();
        }

        private void brandBtn_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            Brands user = new Brands();
            user.TopLevel = false;
            db.popup_panel.Controls.Add(user);
            user.Show();
            this.Hide();
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            category user = new category();
            user.TopLevel = false;
            db.popup_panel.Controls.Add(user);
            user.Show();
            this.Hide();
        }

        private void popup_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab1_Click(object sender, EventArgs e)
        {//clicked dashboard

            Dashboard d = new Dashboard();
            d.Show();
            db1 d1 = new db1();
            d1.BringToFront();
            d.popup_panel.Controls.Add(d1);
            d1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
            //label7.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
