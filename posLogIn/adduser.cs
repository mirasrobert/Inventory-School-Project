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
    public partial class adduser : Form
    {
        public adduser()
        {
            InitializeComponent();
        }

        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pos_data");
        MySqlCommand command;

        public void populateDatagrid()
        {
            string query = "SELECT * FROM user";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connect);
            adapter.Fill(table);
            Users us = new Users();
            us.datagridprd.DataSource = table;
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

        public void executeMyquery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connect);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("SUCCESS", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void btn_add_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO user(f_name,l_name,address,Email,Contact,Uname,Pass) VALUES('"+tb_Fname.Text+ "','" + tb_lname.Text + "','" + tb_addrs.Text + "','" + tb_em.Text + "','" + tb_contact.Text + "','" + tb_user.Text + "','" + tb_pass.Text + "')";
            executeMyquery(insert);
            populateDatagrid();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Dashboard.ActiveForm.Hide();
            Dashboard db = new Dashboard();
            db.Show();
            Users b = new Users();
            b.TopLevel = false;
            db.popup_panel.Controls.Add(b);
            b.Show();
            b.Refresh();
            this.Hide();
        }
    }
}