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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int right;
        public static int count;
        DB db = new DB();
        private void button1_Click(object sender, EventArgs e)
        {
            duti();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Factory1 factory = new Factory1(label1.Text);
                int answer = factory.claations(a, b);
                if (textBox3.Text == answer.ToString())
                {
                    MessageBox.Show("回答正确!");
                    right++;
                }
                else
                {
                    MessageBox.Show("回答错误！");
                }
                count++;
                textBox3.Clear();
                duti();
             
            }                     

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fds = new Form3();
            fds.ShowDialog();
        }
        private void duti()
        {
            string sltstr = @"select number1,operation,number2 from Ti";
            db.Reader(sltstr);
            textBox1.Text = db.number1;
            textBox2.Text = db.number2;
            label1.Text = db.operation;
        }
    }
}
