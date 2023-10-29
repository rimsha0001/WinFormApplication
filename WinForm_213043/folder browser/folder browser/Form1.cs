using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(string.Empty))
            {
                if (Directory.GetFiles(textBox1.Text).Length > 0)
                {
                    foreach (string file in Directory.GetFiles(textBox1.Text))
                    {
                        listBox1.Items.Add(file);
                    }
                }
                else
                {
                    listBox1.Items.Add(string.Format("No files found at location: {0}", textBox1.Text));

                }
            }
        }
    }
}

