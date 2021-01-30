using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posLogIn
{
    public partial class printForm : Form
    {
        public printForm()
        {
            InitializeComponent();
        }

        private void printForm_Load(object sender, EventArgs e)
        {//load
            
        }

        private void orderNow_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
