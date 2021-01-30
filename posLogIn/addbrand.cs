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
    public partial class addbrand : Form
    {
        public addbrand()
        {
            InitializeComponent();
        }

        private void addbrand_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            /// ADD USER's
            brand_data bdata = new brand_data();
            MySqlCommand command = new MySqlCommand("INSERT INTO `product_brand`(`brand`) VALUES (@brand)", bdata.getConnection());

            command.Parameters.Add("@brand", MySqlDbType.VarChar).Value = txt_brand.Text;

            bdata.openConnection();

            if (!textboxValues())
            {
                // tingnan kung meron na bang kaparehong username
                if (checkBrandname())
                {
                    MessageBox.Show("This username already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Brand was added", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Dashboard dashb = new Dashboard();
                        dashb.Show();
                        brand b = new brand();
                        b.TopLevel = false;
                        dashb.popup_panel.Controls.Add(b);
                        b.Show();
                        b.Refresh();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill the textboxes first", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bdata.closeConnection();
        }

        public Boolean checkBrandname()
        {
            brand_data bd = new brand_data();

            string username = txt_brand.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `product_brand` WHERE `brand` = @brand", bd.getConnection());

            command.Parameters.Add("@brand", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // tingnan kung nafillupan ba lahat nang textboxes
        public Boolean textboxValues()
        {
            string bname= txt_brand.Text;


            if (bname.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Dashboard dashb = new Dashboard();
            dashb.Show();
            brand b = new brand();
            b.TopLevel = false;
            dashb.popup_panel.Controls.Add(b);
            b.Show();
            b.Refresh();
            this.Hide();
        }
    }
}
