using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAsk2WinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = double.Parse(textBox1.Text);
            double n = double.Parse(textBox2.Text);
            double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
            label4.Text = "z1 = " + z1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double m = double.Parse(textBox1.Text);
            double n = double.Parse(textBox2.Text);
            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            label5.Text = "z2 = " + z2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
