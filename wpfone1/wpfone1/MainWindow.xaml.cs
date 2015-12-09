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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfone1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)//写入题
        {
            Writes writ = new Writes();
            string fnm = @"one";
            string text1 = this.textBox1.Text;
            writ.inscribe(fnm, text1);
            string fnmm = @"tow";
            string text2 = this.textBox2.Text;
            writ.inscribe(fnmm, text2);
            string fnm1 = @"fuhao";
            string text3 = this.comboBox1.Text;
            writ.inscribe(fnm1, text3);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string a = @"tow";
            string b = @"one";
            string c = @"fuhao";
            Writes clean = new Writes();
            clean.cleanup(a, b, c);
        }

        private void button3_Click(object sender, RoutedEventArgs e)//开始做题
        {
            Window2 wind = new Window2();
            wind.ShowDialog();

        }
    }
}
