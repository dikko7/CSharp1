using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3WinForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double x = double.Parse(textBox3.Text);
            double y = 2.4 * (Math.Abs((x * x + b) / a)) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + (Math.Pow(10, -2)) * (x - b);
            label5.Text = "y = " + y;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
