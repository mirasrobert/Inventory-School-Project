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
    public partial class pos_Login : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
        public pos_Login()
        {
            InitializeComponent();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "Enter Username";
                txt_pass.Enabled = false;
            }
            else
            {
                txt_user.Text = txt_user.Text;
            }
        }
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Enter Password")
            {
                txt_pass.Text = "";
                txt_pass.UseSystemPasswordChar = true;
            }
            
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Enter Password";
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.Text = txt_pass.Text;
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Enter Username")
            {
                txt_user.Text = "";
                txt_pass.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            isLogin();
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            //
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //
            // Suppress finalization.
            GC.SuppressFinalize(this);
           
        }
        private void isLogin()
        {
            if (txt_user.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT * FROM users WHERE userName = '" + txt_user.Text + "' AND userPassword = '" + txt_pass.Text + "' AND userRole='"+roleBox.Text+"'";
                // Prepare the connection
                MySqlConnection databaseConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(query, databaseConnection);
                DataTable table = new DataTable();
                myAdapter.Fill(table);
                int a = table.Rows.Count;

                // Let's do it !
                try
                {
                    // Open the database
                    databaseConnection.Open();
                    if (a > 0)
                    {
                        if (roleBox.Text == "Admin")
                        {
                            string sql = "INSERT INTO loginhistory(username,timeLogin) VALUES('" + txt_user.Text + "',NOW())";
                            MySqlCommand cmd = new MySqlCommand(sql, databaseConnection);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            change c = new change();
                            Dashboard db = new Dashboard();
                            //Users u = new Users();
                            //Brands b = new Brands();
                            //category ct = new category();
                            //Record r = new Record();
                            //db.avatarName.Text = txt_user.Text;
                            c.usn.Text = txt_user.Text;
                            db.Show();
                            //
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            //
                            // Suppress finalization.
                            GC.SuppressFinalize(this);
                            //
                            this.Hide();
                            

                            db1 d1 = new db1();
                            d1.BringToFront();
                            db.popup_panel.Controls.Add(d1);
                            d1.Show();
                            this.Hide();
                        }
                        else if(roleBox.Text == "User")
                        {
                            string sql = "INSERT INTO loginhistory(username,timeLogin) VALUES('" + txt_user.Text + "',NOW())";
                            MySqlCommand cmd = new MySqlCommand(sql, databaseConnection);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            change c = new change();
                            DashboardUser db = new DashboardUser();
                            //Users u = new Users();
                            //Brands b = new Brands();
                            //category ct = new category();
                            //Record r = new Record();
                            //db.avatarName.Text = txt_user.Text;
                            c.usn.Text = txt_user.Text;
                            db.Show();
                            //
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            //
                            // Suppress finalization.
                            GC.SuppressFinalize(this);
                            //
                            this.Hide();


                            db1 d1 = new db1();
                            d1.BringToFront();
                            db.popup_panel.Controls.Add(d1);
                            d1.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        /*InvalidInfo error = new InvalidInfo();
                        error.Show(); */
                    }
                    // Execute the query


                    // All succesfully executed, now do something

                    // IMPORTANT : 
                    // If your query returns result, use the following processor :


                    // Finally close the connection
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void pos_Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.pass!=string.Empty)
            {
                txt_pass.Text = Properties.Settings.Default.pass;
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void remember_CheckedChanged(object sender, EventArgs e)
        {
            if (remember.Checked)
            {
                Properties.Settings.Default.pass = txt_pass.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void adminBox_CheckedChanged(object sender, EventArgs e)
        {
            if (adminBox.Checked)
            {
                roleBox.Text = "Admin";
                userBox.Checked = false;
            }
           
        }

        private void userBox_CheckedChanged(object sender, EventArgs e)
        {
            if (userBox.Checked)
            {
                roleBox.Text = "User";
                adminBox.Checked = false;
            }
        }
    }
}