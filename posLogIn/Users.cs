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
    
    public partial class Users : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;");
        public Users()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pos_data");
        MySqlCommand command;
        private void Users_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            prdDate.Text = DateTime.Now.ToShortDateString();
//load combobox
            showItemCategory();
            showItemBrand();
            showProducts();

        }

        public void showProducts()
        {
            MySqlConnection conns = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
            string sql = "SELECT productName,productCategory,productBrand,productPrice,productStock,addedDate FROM products";
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conns);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            datagridprd.DataSource = table;
            
        }
        public void showID()
        {
            MySqlConnection conns = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
            string sql = "SELECT pid FROM products WHERE prdName = '"+prd.Text+"'";
            MySqlCommand commandDatabase = new MySqlCommand(sql, conns);
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string ids = reader["pid"].ToString();
                    prdID.Text = ids;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();

        }

        public void showItemCategory()
        {
            string query = "SELECT * FROM categories";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string categ = reader["categoryName"].ToString();
                    selectedCategory.Items.Add(categ);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }
        public void showItemBrand()
        {
            string query = "SELECT * FROM brands";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string brd = reader["brandName"].ToString();
                    selectedBrand.Items.Add(brd);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        private void datagridUsers_MouseClick(object sender, MouseEventArgs e)
        {
            // mula datagrid papuntang text box
            
        }
        public void openConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
        }

        public void closeConnection()
        {
            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            adduser au = new adduser();
            au.Show();
        }


        public void executeMyquery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query,connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("SUCCESS","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }



        private void btn_update_Click(object sender, EventArgs e)
        {/*
            string updateQuery = "UPDATE user SET f_name='"+ tb_Fname.Text + "', l_name='" + tb_lname.Text + "', address='" + tb_addrs.Text + "',Email='" + tb_em.Text + "',Contact='" + tb_contact.Text + "',Uname='" + tb_user.Text + "',Pass='" + tb_pass.Text + "' WHERE id =" + int.Parse(tb_UserId.Text);
            executeMyquery(updateQuery);
            populateDatagrid();
            */
        }

        private void tb_UserId_Enter(object sender, EventArgs e)
        {
           
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            //string deleteItems = "DELETE FROM `user` WHERE id = "+ int.Parse(tb_UserId.Text);
            //executeMyquery(deleteItems);
            //populateDatagrid();
        }

        private void btn_add_MouseEnter(object sender, EventArgs e)
        {
            

        }

        private void btn_add_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void datagridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_UserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void datagridprd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
        }

        private void datagridprd_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            updprdBtn.Enabled = true;
            delprdBtn.Enabled = true;
            prd.Text = datagridprd.CurrentRow.Cells[0].Value.ToString();
            selectedCategory.Text = datagridprd.CurrentRow.Cells[1].Value.ToString();
            selectedBrand.Text = datagridprd.CurrentRow.Cells[2].Value.ToString();
            prdPrice.Text = datagridprd.CurrentRow.Cells[3].Value.ToString();
            prdQty.Text = datagridprd.CurrentRow.Cells[4].Value.ToString();
            prdID.Text = datagridprd.CurrentRow.Cells[0].Value.ToString();
        }
        public void addProduct()
        {
            string sql = "SELECT * FROM products WHERE productName = '" + prd.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Product Name: '" + prd.Text + "' already exist", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO products(productName, productCategory, productBrand, productPrice, productStock, addedDate) VALUES('" + prd.Text + "', '" + selectedCategory.Text + "', '" + selectedBrand.Text + "', '" + prdPrice.Text + "', '" + prdQty.Text + "', NOW());";
                MySqlCommand commandDatabase = new MySqlCommand(query, conn);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    conn.Open();
                    reader = commandDatabase.ExecuteReader();
                    if (MessageBox.Show("New Product Added Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        //
                        // Suppress finalization.
                        GC.SuppressFinalize(this);
                        //

                    }

                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void addprdBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (prd.Text == "" || selectedCategory.Text == "" || selectedBrand.Text == "" || prdPrice.Text == "" || prdQty.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                addProduct();
                //refresh
                prd.Text = "";
                prdPrice.Text = "";
                prdQty.Text = "";
                selectedBrand.Items.Clear();
                selectedCategory.Items.Clear();
                this.Refresh();
                showItemCategory();
                showItemBrand();
                conn.Close();
            }
        }

        private void prdPrice_OnValueChanged(object sender, EventArgs e)
        {
            int num = 1;

            if (!int.TryParse(prdPrice.Text, out num) || !int.TryParse(prdQty.Text, out num))
            {
                
                addprdBtn.Enabled = false;

            }
            else
            {
                addprdBtn.Enabled = true;

            }
        }

        private void prdQty_OnValueChanged(object sender, EventArgs e)
        {
            int num = 1;

            if (!int.TryParse(prdQty.Text, out num) || !int.TryParse(prdPrice.Text, out num))
            {
                addprdBtn.Enabled = false;

            }
            else
            {
                addprdBtn.Enabled = true;

            }
        }

        private void delprdBtn_Click(object sender, EventArgs e)
        {//del
            timer1.Start();
            if (MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delProduct();
                prd.Text = "";
                prdPrice.Text = "";
                prdQty.Text = "";
                selectedBrand.Items.Clear();
                selectedCategory.Items.Clear();
                this.Refresh();
                showItemCategory();
                showItemBrand();
            }

        }

        public void delProduct()
        {
            timer1.Start();
            string query = "DELETE FROM products WHERE productName = '" + prd.Text + "' AND productCategory = '" + selectedCategory.Text + "' AND productBrand = '" + selectedBrand.Text + "' ";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                if(MessageBox.Show("Product Deleted Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //
                    // Suppress finalization.
                    GC.SuppressFinalize(this);
                    //
                }


                reader.Close();
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void updprdBtn_Click(object sender, EventArgs e)
        {//upd
            timer1.Start();
            if (prd.Text == "" || selectedCategory.Text == "" || selectedBrand.Text == "" || prdPrice.Text == "" || prdQty.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    updateProduct();
                    prd.Text = "";
                    prdPrice.Text = "";
                    prdQty.Text = "";
                    selectedBrand.Items.Clear();
                    selectedCategory.Items.Clear();
                    this.Refresh();
                    showItemCategory();
                    showItemBrand();
                }          
            }
        }

        public void updateProduct()
        {
            string query = "UPDATE products SET productName = '" + prd.Text + "', productCategory = '" + selectedCategory.Text + "', productBrand = '" + selectedBrand.Text + "', productPrice = '" + prdPrice.Text + "', productStock = '" + prdQty.Text + "' WHERE productName = '"+prdID.Text+"' ";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                if (MessageBox.Show("Product Updated Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
            showProducts();
            //showItemCategory();
            //showItemBrand();
            //timer1.Stop();
        }

        private void datagridprd_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Stop();
        }

        private void datagridprd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            timer1.Stop();
        }

        private void selectedCategory_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void selectedBrand_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void selectedCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void selectedBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            //timer1.Stop();
        }

        private void selectedCategory_MouseClick(object sender, MouseEventArgs e)
        {
            //mer1.Stop();
        }

        private void selectedCategory_DropDown(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void selectedCategory_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void selectedCategory_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            showProducts();
        }

        private void datagridprd_DoubleClick(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void datagridprd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
        }

        private void datagridprd_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
