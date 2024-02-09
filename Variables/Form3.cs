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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int num1;
            num1= Convert.ToInt32(textBox1.Text);
            label2.Text = num1.ToString();
            */

            /*
            int num1,cube;
            num1 = Convert.ToInt32(textBox1.Text);
            cube=num1*num1*num1;
            label2.Text = cube.ToString();
            */

            int num1, num2, sum, multiply, subtract, divide;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            sum = num1 + num2;
            multiply = num1 * num2;
            subtract = num1 - num2;
            divide = num1 / num2;

            MessageBox.Show("Sum : " + sum +"\n"+ "Multiply : " + multiply + "\n" + "Subtract : " + subtract+ "\n" + "Divide : " + divide);


            
        }

      
    }
}
