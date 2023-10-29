using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Price = numericUpDown1.Value;
            int quality = (int)numericUpDown2.Value;
            decimal total;
            total = Price * quality;
            MessageBox.Show("Total price is : " + total);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
