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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            admin_data ad = new admin_data();

            string username = admin_user.Text;
            string password = admin_pass.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin_db` WHERE `admin_user` = @adminuser and `admin_pass` = @adminpass", ad.getConnection());

            command.Parameters.Add("@adminuser", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@adminpass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Dashboard db = new Dashboard();
                db.Enabled = true;
                //db.avatarName.Text = admin_user.Text;
                db.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void admin_user_Enter_1(object sender, EventArgs e)
        {
            if (admin_user.Text == "Enter Username")
            {
                admin_user.Text = "";
                admin_pass.Enabled = true;
            }
        }

        private void admin_user_Leave_1(object sender, EventArgs e)
        {
            if (admin_user.Text == "")
            {
                admin_user.Text = "Enter Username";
            }
            else
            {
                admin_user.Text = admin_user.Text;
            }
        }

        private void admin_pass_Enter_1(object sender, EventArgs e)
        {
            if (admin_pass.Text == "Enter Password")
            {
                admin_pass.Text = "";
                admin_pass.UseSystemPasswordChar = true;
            }
        }

        private void admin_pass_Leave(object sender, EventArgs e)
        {
            if (admin_pass.Text == "")
            {
                admin_pass.Text = "Enter Password";
                admin_pass.UseSystemPasswordChar = false;
            }
            else
            {
                admin_pass.Text = admin_pass.Text;
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
