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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DB db = new DB();
        
        private void button1_Click(object sender, EventArgs e)
        {
            string inter = "insert into Ti(number1,operation,number2) values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "')";
            db.dbinser(inter);
            textBox1.Clear();
            textBox2.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sltstr = @"truncate table Ti";//清除表中数据
            db.del(sltstr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fa = new Form2();
            fa.ShowDialog();
        }

       
    }
}
