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

namespace QuadEquationWPF
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
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int c = int.Parse(textBoxC.Text);
            double d = Math.Pow(b, 2) - 4 * a * c;
            textBoxD.Text = "" + d;
            double x1 = (-b + Math.Sqrt(d)) / 2 * a;
            double x2 = (-b - Math.Sqrt(d)) / 2 * a;
            if (d > 0)
            {
                textBoxX1.Text = "" + x1;
                textBoxX2.Text = "" + x2;
                textBoxX1.Visibility = Visibility.Visible;
                textBoxX2.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Visible;
                label6.Visibility = Visibility.Visible;
            }
            else
              if (d == 0)
            {
                textBoxX1.Text = "" + x1;
                label6.Visibility = Visibility.Hidden;
                textBoxX2.Visibility = Visibility.Hidden;
            }
            else
            {
                textBoxX1.Visibility = Visibility.Hidden;
                textBoxX2.Visibility = Visibility.Hidden;
                label5.Visibility = Visibility.Hidden;
                label6.Visibility = Visibility.Hidden;
                MessageBox.Show("Solution does not exist");
            }
        }
    }
}