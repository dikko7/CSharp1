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

namespace Task1WPF
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
            int a = int.Parse(textBox.Text);
            int b = int.Parse(textBox1.Text);
            int s = a * b;
            label4.Content = "S = " + s;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(textBox.Text);
            int b = int.Parse(textBox1.Text);
            int p = (a + b) * 2;
            label5.Content = "P = " + p;
        }
    }
}
