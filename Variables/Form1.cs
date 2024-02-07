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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string nameLastname,profession;

             nameLastname ="Sidar Çiftçioğlu";
             profession = "Software Engineer";

             label1.Text = nameLastname;
             label2.Text=profession;*/

            /* string city;
             city = textBox1.Text;
             label1.Text = city;*/

            string name, lastname, profession, age, gender;

            name = textBox1.Text;
            lastname = textBox2.Text;
            profession = textBox3.Text;
            gender = textBox4.Text;
            age = maskedTextBox1.Text;

            listBox1.Items.Add(name+" " + lastname + " "+ profession + " "+ age + " "+gender);
        }
    }
}
