using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Введите a, b, c для решения квдратного уравнения");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            double d = Math.Pow(b, 2) - 4 * a * c;
            textBox4.Text = "" + d;
            double x1 = (-b + Math.Sqrt(d)) / 2 * a;
            double x2 = (-b - Math.Sqrt(d)) / 2 * a;
            if (d > 0)
            {
                textBox5.Text = "" + x1;
                textBox6.Text = "" + x2;
                textBox5.Visible = true;
                textBox6.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            else
              if (d == 0)
            {
                textBox5.Text = "" + x1;
                label6.Visible = false;
                textBox6.Visible = false;
            }
            else
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                MessageBox.Show("Solution does not exist");
            }
        }
    }
}
