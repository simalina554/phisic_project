using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e){}

        private void label12_Click(object sender, EventArgs e){}

        private void Form1_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            double R1 = double.Parse(textBox1.Text);
            double R2 = double.Parse(textBox3.Text);
            double E = double.Parse(textBox2.Text);
            double r = double.Parse(textBox4.Text);

            double q = R1 + R2;

            double I = E / (q + r);
            double U1 = I * q;
            double U2 = I * r;
            double U = U1 + U2;
            double P1 = E * I;
            double P2 = Math.Pow(I, 2) * (r + R1 + R2);

            textBox5.Text = I.ToString("F3");
            textBox6.Text = U1.ToString("F3");
            textBox7.Text = U2.ToString("F3");
            textBox8.Text = U.ToString("F3");
            textBox9.Text = P1.ToString("F3");
            textBox10.Text = P2.ToString("F3");
        }
    }
}
