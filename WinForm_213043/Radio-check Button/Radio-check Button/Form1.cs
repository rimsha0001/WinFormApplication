using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Radio_check_Button
{
    public partial class Form1 : Form
    {
        string Text1 = " ";
        string Text2 = " ";
        string Text3 = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("you select: " + Text1 + " " + Text2 + " " + Text3);
            //else if(checkBox2.Checked== true) 
            //{
            //    MessageBox.Show(checkBox2.Text);
            //    //groupBox1.BackColor = Color.Green;

            //}
            //else if(checkBox3.Checked==true)
            //{
            //    MessageBox.Show(checkBox3.Text);
            //    //groupBox1.BackColor = Color.Blue;
            //}
            //else
            //{
            //    MessageBox.Show("Select anyone!");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                MessageBox.Show(radioButton1.Text);
                
            }
            else if(radioButton2.Checked == true)
            {
                MessageBox.Show(radioButton2.Text);
                
            }
            else
            {
                MessageBox.Show("Select AnyOne :)");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //MessageBox.Show(checkBox1.Text);
                //groupBox1.BackColor = Color.Red;
                Text1 = checkBox1.Text;

            }
            else
            {
                Text1 = " ";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Text2 = checkBox2.Text;
            }
            else
            {
                 Text2 = " ";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true) 
            {
                Text3 = checkBox3.Text;
            }
            else
            {
                Text3 = " ";    
            }
        }
    }
}
