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
    
    public partial class Brands : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;");
        public Brands()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pos_data");
        
        private void Users_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            brdDate.Text = DateTime.Now.ToShortDateString();
            showBrand();
        }
        public void showBrand()
        {
            string sql = "SELECT * FROM brands";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            datagridbrand.DataSource = table;
            datagridbrand.Refresh();
        }

        private void datagridbrand_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            updbrdBtn.Enabled = true;
            delbrdBtn.Enabled = true;
            brd.Text = datagridbrand.CurrentRow.Cells[0].Value.ToString();
            brdName.Text = datagridbrand.CurrentRow.Cells[1].Value.ToString();
            brdDate.Text = datagridbrand.CurrentRow.Cells[2].Value.ToString();
        }

        private void addbrdBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (brdName.Text == "" || brdDate.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                addBrand();
                //refresh

                conn.Close();
            }
        }

        public void addBrand()
        {

            string sql = "SELECT * FROM brands WHERE brandName = '" + brdName.Text + "'";
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            myAdapter.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Brand Name: '" + brdName.Text + "' already exist", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO brands(brandName,addedDate) VALUES('" + brdName.Text + "',NOW())";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (MessageBox.Show("New Brand Added Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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

        private void updbrdBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (brdName.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                updateBrands();
                
            }
        }

        public void updateBrands()
        {
            string query = "UPDATE brands SET brandName = '" + brdName.Text + "' WHERE bid = '" + brd.Text + "'";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        private void delbrdBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (MessageBox.Show("Are you sure you want to delete this brand?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delBrand();
                brdName.Text = "";
                this.datagridbrand.Refresh();
            }
        }
        public void delBrand()
        {
            string query = "DELETE FROM brands WHERE bid = '" + brd.Text + "' AND brandName = '" + brdName.Text + "' ";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                if (MessageBox.Show("Brand Deleted Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            Brands us = new Brands();
            us.TopLevel = false;
            db.popup_panel.Controls.Add(us);
            us.Show();
            this.Hide(); ;
            


        }

        private void brd_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void brdDate_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void datagridbrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showBrand();
        }

        private void datagridbrand_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Stop();
        }

        private void datagridbrand_DoubleClick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void datagridbrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
        }

        private void datagridbrand_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
