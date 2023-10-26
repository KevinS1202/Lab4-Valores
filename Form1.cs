using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            Double[] x = new double[11];
            double dx = 0, s = 0;
            

            if (string.IsNullOrEmpty(textBox1.Text)==false && string.IsNullOrEmpty(textBox2.Text)==false)
            {
                x[0] = Convert.ToDouble(textBox1.Text);
                dx = Convert.ToDouble(textBox2.Text);
                for (int i = 1; i < 11; i++)
                {
                    x[i] = x[i-1] + dx;
                    s += Math.Pow(x[i], 3) + 8.5;
                }
                textBox3.Text += s;
                s = 0;
            }
            else textBox3.Text += "Error";


        } 
    } 
}
