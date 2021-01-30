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
    public partial class change : Form
    {
        public change()
        {
            InitializeComponent();
        }
        MySqlConnection databaseConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
        private void change_Load(object sender, EventArgs e)
        {
            
        }

        private void updPwd_Click(object sender, EventArgs e)
        {
            if (usn.Text == "" || old.Text == "" || neww.Text == "" || repeat.Text == "")
            {
                MessageBox.Show("Please input required fields!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT * FROM users WHERE userName = '" + usn.Text + "' AND userPassword = '" + old.Text + "'";

                // Prepare the connection

                MySqlDataAdapter myAdapter = new MySqlDataAdapter(query, databaseConnection);
                DataTable table = new DataTable();
                myAdapter.Fill(table);
                int a = table.Rows.Count;
                if (a > 0)
                {
                    if (repeat.Text != neww.Text)
                    {
                        MessageBox.Show("Password does not match!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sql = "UPDATE users SET userPassword = '" + neww.Text + "' WHERE userName = '" + usn.Text + "'";
                        MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
                        commandDatabase.CommandTimeout = 60;
                        MySqlDataReader reader;

                        try
                        {
                            databaseConnection.Open();
                            reader = commandDatabase.ExecuteReader();
                            MessageBox.Show("Password Updated!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        databaseConnection.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void old_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
