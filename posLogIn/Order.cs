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

    public partial class Order : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=inventorysystem;");
        public Order()
        {
            InitializeComponent();
        }
        int attempt = 0;
        MySqlConnection connect = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pos_data");
        
        private void Users_Load(object sender, EventArgs e)
        {
            timerOrder.Stop();
            orderDate.Text = DateTime.Now.ToShortDateString();
            showProductItems();
            showProductInfo();
            orderNow.Enabled = false;
            qty.Enabled = false;
            showSales();
        }

        private void showProductItems()
        {
            string sql = "SELECT productName FROM products";
            MySqlCommand commandDatabase = new MySqlCommand(sql, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string prdName = reader["productName"].ToString();
                    selectedProduct.Items.Add(prdName);
                    timerOrder.Stop();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        private void showProductInfo()
        {
            string sql = "SELECT * FROM products WHERE productName = '" + selectedProduct.Text + "' ";
            MySqlCommand commandDatabase = new MySqlCommand(sql, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string prdQty = reader["productStock"].ToString();
                    string prdPrice = reader["productPrice"].ToString();
                    totalQty.Text = prdQty;
                    price.Text = prdPrice;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "showproductinfo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }


        private void purchaseOrder()
        {
            string sql = "UPDATE products SET productStock= '" + updStock.Text + "' WHERE productName = '" + selectedProduct.Text + "' ";
            MySqlCommand commandDatabase = new MySqlCommand(sql, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                if (MessageBox.Show("Ordered Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    printForm print = new printForm();
                    print.Show();

                    /////////////

                    print.txt_receipt.Clear();
                    print.txt_receipt.Text += "\n";
                    print.txt_receipt.Text += "\n";
                    print.txt_receipt.Text += "\n";
                    print.txt_receipt.Text += "\n";
                    print.txt_receipt.Text += "\n";
                    print.txt_receipt.Text += "\n";
                    print.txt_receipt.Text += "\n Date:" + orderDate.Text;
                    print.txt_receipt.Text += "\n";
                    print.txt_receipt.Text += "\n Costumer Name: " + customerName.Text;
                    print.txt_receipt.Text += "\n Item Name: " + selectedProduct.Text;
                    print.txt_receipt.Text += "\n Item Stock: " + totalQty.Text;
                    print.txt_receipt.Text += "\n Quantity: " + qty.Text;
                    print.txt_receipt.Text += "\n Product Price :" + price.Text;
                    print.txt_receipt.Text += "\n Discount: " + discountBox.Text;
                    print.txt_receipt.Text += "\n Paid: " + paidBox.Text;
                    print.txt_receipt.Text += "\n";
                    print.txt_receipt.Text += "\n Due: " + dueBox.Text;
                    print.txt_receipt.Text += "\n Total: " + totals.Text;

                    ///////////////////////////////////
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

        private void selectprd(object sender, EventArgs e)
        {
            if (selectedProduct.Text == "")
            {
                qty.Enabled = false;
            }
            else
            {
                qty.Enabled = true;
            }
            showProductInfo();
            showSales();
            qty.Text = "";
            paidBox.Text = "";

        }

        private void qty_OnValueChanged(object sender, EventArgs e)
        {
            if (qty.Text == "")
            {

                orderNow.Enabled = false;
                discountBox.Enabled = false;
                paidBox.Enabled = false;
                attempt = 0;

            }
            else
            {
                discountBox.Enabled = true;
                paidBox.Enabled = true;
            }
            ////////

            int num = 1;

            if (!int.TryParse(qty.Text, out num))
            {
                orderNow.Enabled = false;

            }
            else
            {
                if (Convert.ToInt32(qty.Text) > Convert.ToInt32(totalQty.Text))
                {
                    orderNow.Enabled = false;
                }
                else
                {
                    //calculate the remaining stocks
                    string total = totalQty.Text;
                    int a = Convert.ToInt32(total);
                    string Hm = qty.Text;
                    int b = Convert.ToInt32(Hm);
                    int resultStocks = (a - b);
                    updStock.Text = Convert.ToString(resultStocks);

                    //calculate the total 
                    string prc = price.Text;
                    int c = Convert.ToInt32(prc);
                    string Hm2 = qty.Text;
                    int d = Convert.ToInt32(Hm2);
                    int resultTotal = (c * d);
                    totals.Text = Convert.ToString(resultTotal);
                    dueBox.Text = totals.Text;


                    orderNow.Enabled = true;
                }

            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            int dis = Convert.ToInt32(discountBox.Text);
            if (attempt == 0 && dis < 101)
            {
                check.Enabled = true;
                //calculate the discount
                //convert the percentage discount to decimal
                double convertDisc = Convert.ToDouble(discountBox.Text);
                double calcDiscount = convertDisc / 100;
                //Multiply the original price by the decimal
                double convertTotal = Convert.ToDouble(totals.Text);
                double discounts = (convertTotal * calcDiscount);
                //Subtract the discount from the original price
                double totalDiscount = (convertTotal - discounts);

                totals.Text = Convert.ToString(totalDiscount);
                dueBox.Text = totals.Text;
                attempt++;
            }
            else
            {
                MessageBox.Show("Invalid Discount!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void discountBox_OnValueChanged(object sender, EventArgs e)
        {
            if (selectedProduct.Text == "" || totals.Text == "")
            {
                discountBox.Enabled = false;
                check.Enabled = false;
            }
            else
            {
                if (discountBox.Text == "")
                {
                    qty.Text = "";
                    check.Enabled = false;
                }
                else
                {
                    check.Enabled = true;
                }
            }

            if (attempt > 0)
            {
                check.Enabled = false;
            }
        }

        private void paidBox_OnValueChanged(object sender, EventArgs e)
        {
            // paid Boxs
            int num = 1;
            if (!int.TryParse(paidBox.Text, out num))
            {
                orderNow.Enabled = false;

            }
            else
            {
                if (qty.Text == "")
                {
                    paidBox.Enabled = false;
                }
                else
                {
                    //calculate due/paid
                    int convertPaid = Convert.ToInt32(paidBox.Text);
                    int convertDue = Convert.ToInt32(totals.Text);
                    int paidNow = (convertDue - convertPaid);

                    dueBox.Text = Convert.ToString(paidNow);

                    string up = updSales1.Text;
                    int s1 = Convert.ToInt32(up);
                    int calcSales = (Convert.ToInt32(paidBox.Text) + s1);
                    updSales2.Text = Convert.ToString(calcSales);


                    if (paidBox.Text == "")
                    {
                        orderNow.Enabled = false;
                    }
                    else if (convertPaid > convertDue)
                    {
                        MessageBox.Show("Your cash cannot be greater than the due total!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        orderNow.Enabled = false;
                    }
                    else
                    {
                        orderNow.Enabled = true;
                    }


                }

            }
        }

        public void showSales()
        {
            string sql = "SELECT totalSales FROM dashboardstat";
            MySqlCommand commandDatabase = new MySqlCommand(sql, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string ts = reader["totalSales"].ToString();
                    updSales1.Text = ts;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        public void addRecord()
        {
            string query = "INSERT INTO sales(customerName,productName,productPrice,qty,discount,total,paid,due,date) VALUES('" + customerName.Text + "', '" + selectedProduct.Text + "' , '" + price.Text + "', '" + qty.Text + "', '" + discountBox.Text + "', '" + totals.Text + "', '" + paidBox.Text + "', '" + dueBox.Text + "', NOW());";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        private void addSales()
        {//add total sales 

            string sql = "UPDATE dashboardstat SET totalSales= '" + updSales2.Text + "'";
            MySqlCommand commandDatabase = new MySqlCommand(sql, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void orderNow_Click(object sender, EventArgs e)
        {
            if (paidBox.Text == "" || customerName.Text == "")
            {
                MessageBox.Show("Please fill the required fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                orderNow.Enabled = true;
                purchaseOrder();
                addRecord();
                addSales();
                selectedProduct.Items.Clear();
                paidBox.Text = "";
                updSales2.Text = "";
                qty.Text = "";
                discountBox.Text = "";
                totals.Text = "";
                totalQty.Text = "";
                price.Text = "";
                this.Refresh();
                showProductItems();
                
            }
        }
    }
}
