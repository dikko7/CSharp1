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

namespace Task3WPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(textBox.Text);
            double b = double.Parse(textBox1.Text);
            double x = double.Parse(textBox2.Text);
            double y = 2.4 * (Math.Abs((x * x + b) / a)) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + (Math.Pow(10, -2)) * (x - b);
            label4.Content = "y = " + y;
        }
    }
}
