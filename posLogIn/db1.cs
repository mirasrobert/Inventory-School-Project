using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace posLogIn
{
    public partial class db1 : UserControl
    {
        public db1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showTotalCategory();
            showTotalSales();
            showproductQty();
            showTotalbrand();
            //showRole();
        }

        private void showTotalSales()
        {//show total sales
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem");
            string query = "SELECT * FROM dashboardstat";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string sales = reader["totalSales"].ToString();
                    dashboardSale.Text = sales;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }
        private void showTotalCategory()
        {
            string query = "SELECT COUNT(*) FROM categories";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem");
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();

                int a = Convert.ToInt32(cmd.ExecuteScalar());
                totalCategory.Text = a.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showproductQty()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem");
            string query = "SELECT COUNT(*) FROM products";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;

            try
            {
                conn.Open();
                int a = Convert.ToInt32(commandDatabase.ExecuteScalar());
                soldPrdQty.Text = a.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }
     private void showTotalbrand()
        {
            string query = "SELECT COUNT(*) FROM brands";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem");
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();

                int a = Convert.ToInt32(cmd.ExecuteScalar());
                dashboardBrand.Text = a.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    /*    private void showRole()
        {//show total sales
            Dashboard db = new Dashboard();

            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem");
            //string query = "SELECT * FROM users WHERE userName = '" + db.avatarName.Text + "' ";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string sales = reader["userRole"].ToString();
                    db.label5.Text = sales;


                }
            }
      s      catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        } */

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void db1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
