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
    public partial class addacc : Form
    {
        public addacc()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void addAcc()
        {

            string sql = "SELECT * FROM users WHERE userName = '" + usn.Text + "'";
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Username is already taken", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO users(firstName,lastName,userName,userPassword,userEmail,userRole,dateCreated) VALUES('" + fName.Text + "','" + lName.Text + "', '" + usn.Text + "','" + pwd.Text + "','" + email.Text + "','" + selectedRole.Text + "', NOW())";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (MessageBox.Show("Account Created!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        //
                        // Suppress finalization.
                        GC.SuppressFinalize(this);
                        //
                    }

                    conn.Close();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void addAccBtn_Click(object sender, EventArgs e)
        {
            if (fName.Text == "" || lName.Text == "" || email.Text == "" || usn.Text == "" || pwd.Text == "" || selectedRole.Text == "") 
            {
                MessageBox.Show("Please fill the required fields!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (fName.Text == "" || lName.Text == "" || email.Text == "" || usn.Text == "" || pwd.Text == "" && pwd.Text != repeatPwd.Text || selectedRole.Text == "")
            {
                MessageBox.Show("Check your password or input details!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (pwd.Text != repeatPwd.Text)
            {
                MessageBox.Show("Your password does not match!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                addAcc();
            }

        }
    }
}
