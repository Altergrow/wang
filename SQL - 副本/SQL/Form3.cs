using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.right.ToString();
            textBox2.Text = (Form2.count - Form2.right).ToString();
            textBox3.Text = ((Form2.right / (double)(Form2.count)) * 100).ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
