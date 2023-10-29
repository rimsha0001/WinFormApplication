using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBO_BOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if(comboBox1.SelectedItem.ToString() == "Pakistan")
            {
                comboBox2.Items.Add("Mutaln");
                comboBox2.Items.Add("Karachi");
                comboBox2.Items.Add("Lahore");

            }
            if (comboBox1.SelectedItem.ToString() == "India")
            {
                comboBox2.Items.Add("Dehli");
                comboBox2.Items.Add("Mumbai");
                comboBox2.Items.Add("Chennai");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = { "Pakistan", "India" };
            foreach(string n in names)
            {
                comboBox1.Items.Add(n);
            }
        }
    }
}
