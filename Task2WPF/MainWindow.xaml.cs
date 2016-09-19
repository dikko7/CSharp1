using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double m = double.Parse(textBox.Text);
            double n = double.Parse(textBox1.Text);
            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
            label3.Content = "z1 = " + z1;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double m = double.Parse(textBox.Text);
            double n = double.Parse(textBox1.Text);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            label4.Content = "z2 = " + z2;
        }
    }
}
