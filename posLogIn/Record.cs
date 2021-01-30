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

    public partial class Record : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;");
        public Record()
        {
            InitializeComponent();
        }
        
        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pos_data");
        
        private void Users_Load(object sender, EventArgs e)
        {
            timerOrder.Start();
            //orderDate.Text = DateTime.Now.ToShortDateString();
            showLogin();
            showProf();
            showSales();
            datagridlgn.Show();
            datagridlgn.BringToFront();
            //hide all grids
            salesGrid.Hide();
            profileGrid.Hide();            

        }

        public void showLogin()
        {
            string sql = "SELECT username, timeLogin FROM loginhistory";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            datagridlgn.DataSource = table;
            datagridlgn.Refresh();
        }

        public void showProf()
        {
            string sql = "SELECT firstName,lastName,userName,userEmail,userRole,dateCreated FROM users";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            profileGrid.DataSource = table;
        }

        private void showSales()
        {
            string sql = "SELECT customerName, productName, productPrice, qty, discount, total, paid, due, date FROM sales";
            MySqlConnection conns = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;Convert Zero Datetime=True");
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(sql, conns);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            salesGrid.DataSource = table;
        }
        private void popup_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {//login history btn
            timerOrder.Start();
            datagridlgn.Show();
            datagridlgn.BringToFront();
            salesGrid.Hide();
            profileGrid.Hide();
        }

        private void viewSaleBtn_Click(object sender, EventArgs e)
        {//view  sales
            timerOrder.Start();
            salesGrid.Show();
            salesGrid.BringToFront();
            datagridlgn.Hide();
            profileGrid.Hide();
        }

        private void updPasswordBtn_Click(object sender, EventArgs e)
        {//upd pwd
            timerOrder.Start();
            change c = new change();
            c.ShowDialog();
        }

        private void addAccBtn_Click(object sender, EventArgs e)
        {//add acc
            timerOrder.Start();
            addacc add = new addacc();
            add.ShowDialog();
        }

        private void accBtn_Click(object sender, EventArgs e)
        {//view profile
            timerOrder.Start();
            profileGrid.Show();
            profileGrid.BringToFront();
            datagridlgn.Hide();
            salesGrid.Hide();
        }

        private void profileGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timerOrder.Stop();
        }

        private void timerOrder_Tick(object sender, EventArgs e)
        {
            showLogin();
            showProf();
            showSales();
        }

        private void salesGrid_MouseHover(object sender, EventArgs e)
        {
            timerOrder.Stop();
        }

        private void salesGrid_Scroll(object sender, ScrollEventArgs e)
        {
            timerOrder.Stop();
        }

        private void salesGrid_MouseClick(object sender, MouseEventArgs e)
        {
            timerOrder.Stop();
        }

        private void salesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timerOrder.Stop();
        }

        private void profileGrid_MouseClick(object sender, MouseEventArgs e)
        {
            timerOrder.Stop();
        }

        private void profileGrid_Scroll(object sender, ScrollEventArgs e)
        {
            timerOrder.Stop();
        }

        private void profileGrid_MouseHover(object sender, EventArgs e)
        {
            timerOrder.Stop();
        }

        private void datagridlgn_MouseClick(object sender, MouseEventArgs e)
        {
            timerOrder.Stop();
        }

        private void datagridlgn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timerOrder.Stop();
        }

        private void datagridlgn_Scroll(object sender, ScrollEventArgs e)
        {
            timerOrder.Stop();
        }

        private void datagridlgn_MouseHover(object sender, EventArgs e)
        {
            timerOrder.Stop();
        }
    }
}
