using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace wpfone1
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private int i = 1;
        public static int count;
        public static int right;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            duti();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Clacuter clacuter = new Clacuter(textBox2.Text);
                int B = clacuter.Calculation(int.Parse(textBox1.Text), int.Parse(textBox3.Text));
                if (textBox4.Text == B.ToString())
                {

                    MessageBox.Show("回答正确！");
                    right++;

                }

                else
                {

                    MessageBox.Show("回答错误！");

                }
                count++;
                textBox4.Clear();
                duti();

            }

        }
        public void duti()
        {
            string[] line = File.ReadAllLines("one");
            if (i < line.Length)
            {
                textBox1.Text = line[i];
                string[] lines = File.ReadAllLines("tow");
                textBox3.Text = lines[i];
                string[] lin = File.ReadAllLines("fuhao");
                textBox2.Text = lin[i];

            }
            i++;
            if (i == line.Length + 1)
            {
                MessageBox.Show("你的题做完了，可以去休息一下了！");
                Window3 win3 = new Window3();
                win3.ShowDialog();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Window3 win3 = new Window3();
            win3.ShowDialog();

        }
    }
}

