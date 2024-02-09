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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int number;
            number = 24;
            label1.Text = number.ToString();
            */

            /*
             int num1, num2, sum;
             num1 = 5;
             num2 = 10;
             sum=num1 + num2;
             label1.Text=sum.ToString();
            */


            //Program to calculate the area and perimeter of a square
            /*
             int edge, area, perimeter;
            edge = 5;
            area = edge*edge;
            perimeter = 4*edge;
            label1.Text="Area: "+area+ " " +"Perimeter: "+perimeter;
            */


            //Program to calculate the area and perimeter of a rectangle
            /*
            int shortEdge, longEdge, area, perimeter;
            shortEdge= 10;
            longEdge= 20;
            area= shortEdge*longEdge;
            perimeter= 2*(shortEdge+longEdge);
            label1.Text = "Alan : " + area + " " + "Perimeter : " + perimeter;
            */

            //Program that calculates the average of the student whose 3 exam scores are entered
            int exam1, exam2,exam3,average;
            exam1 = 10;
            exam2 = 40;
            exam3 = 100;
            average=(exam1+exam2+exam3)/3;
            label1.Text = "Average : " + average;
        }

    }
}
