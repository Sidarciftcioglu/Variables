using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            double num1;
            num1 = 15.25;
            label1.Text=Convert.ToString(num1);
            */

            /*
            double num1, num2, num3,average;
            num1 = 45.50;
            num2 = 50.65;
            num3 = 98.45;
            average = (num1 + num2 + num3) / 3;
            label1.Text = average.ToString("0.00");
            */

            double num1 = Convert.ToDouble(textBox1.Text); 
            label1.Text = num1.ToString();




        }

        
    }
}
