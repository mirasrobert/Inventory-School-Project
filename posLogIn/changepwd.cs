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

namespace inv
{
    public partial class changepwd : Form
    {
        public changepwd()
        {
            InitializeComponent();
        }

        private void addnewBrand_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE userName = '" + old.Text + "' AND userPassword = '" + old.Text + "'";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(query, databaseConnection);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            int a = table.Rows.Count;
            if (a > 0)
            {
                /*changepwd2 change = new changepwd2();
                change.username.Text = usname.Text;
                this.Hide();
                change.ShowDialog(); */
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void changepwd_Load(object sender, EventArgs e)
        {

        }
    }
}
