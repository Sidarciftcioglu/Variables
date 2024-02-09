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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             char character = 'S';
             label1.Text=character.ToString();
            */

            char lesson = Convert.ToChar(textBox1.Text);
            label1.Text= lesson.ToString();
            
        }
    }
}
