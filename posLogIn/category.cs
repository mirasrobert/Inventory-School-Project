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
    
    public partial class category : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;");
        public category()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pos_data");
        
        private void Users_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            ctgDate.Text = DateTime.Now.ToShortDateString();
            showCategory();
        }
        public void showCategory()
        {
            string sql = "SELECT * FROM categories";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            datagridcategory.DataSource = table;
            datagridcategory.Refresh();
        }
        private void addctgBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ctgName.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                addCategory();
            }
        }
             public void addCategory()
        {

            string sql = "SELECT * FROM categories WHERE categoryName = '" + ctgName.Text + "'";
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Category Name: '" + ctgName.Text + "' already exist", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO categories(categoryName,addedDate) VALUES('" + ctgName.Text + "',NOW());";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    conn.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (MessageBox.Show("Brand Updated Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        //
                        // Suppress finalization.
                        GC.SuppressFinalize(this);
                        //
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void datagridbrand_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            updctgBtn.Enabled = true;
            delctgBtn.Enabled = true;
            ctg.Text = datagridcategory.CurrentRow.Cells[0].Value.ToString();
            ctgName.Text = datagridcategory.CurrentRow.Cells[1].Value.ToString();
            ctgDate.Text = datagridcategory.CurrentRow.Cells[2].Value.ToString();
        }

        private void updctgBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ctgName.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                updateCategory();
            }
        }
            public void updateCategory()
        {
            string query = "UPDATE categories SET categoryName = '" + ctgName.Text + "' WHERE cid = '" + ctg.Text + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                if (MessageBox.Show("Category Updated Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //
                    // Suppress finalization.
                    GC.SuppressFinalize(this);
                    //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        private void delctgBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delCategory();
                ctgName.Text = "";
                this.datagridcategory.Refresh();
            }
        }
        public void delCategory()
        {
            string query = "DELETE FROM categories WHERE cid = '" + ctg.Text + "' AND categoryName = '" + ctgName.Text + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                if (MessageBox.Show("Category Deleted Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //
                    // Suppress finalization.
                    GC.SuppressFinalize(this);
                    //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showCategory();
        }

        private void datagridcategory_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void datagridcategory_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Stop();
        }

        private void datagridcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
        }

        private void datagridcategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
        }

        private void datagridcategory_DoubleClick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
