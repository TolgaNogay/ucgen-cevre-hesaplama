using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeni_proje_301020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UcgeninAlani_Click(object sender, EventArgs e)
        {
            double a, h, alan;
            a = Convert.ToDouble(textBoxA);
            h = Convert.ToDouble(textBoxH);
            alan = (a * h) / 2;
            LabelAlan.Text = alan.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UcgeninCevresi_Click(object sender, EventArgs e)
        {
            double a, b, c,cevre;
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            c = Convert.ToDouble(textBoxC.Text);
            cevre = a + b + c;
            LabelCevresi.Text = cevre.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, h, alan;
            a = Convert.ToDouble(textBoxA.Text);
            h = Convert.ToDouble(textBoxH.Text);
            alan = (a * h) / 2;
            LabelAlan.Text = alan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, cevre;
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            c = Convert.ToDouble(textBoxC.Text);
            cevre = a + b + c;
            LabelCevresi.Text = cevre.ToString();

        }
    }
}
