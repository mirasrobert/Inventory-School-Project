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
    public partial class brand : Form
    {
        public brand()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pos_data");
        private void brand_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM product_brand ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            datagridBrand.DataSource = table;
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            addbrand ab = new addbrand();
            ab.Show();
        }
    }
}
