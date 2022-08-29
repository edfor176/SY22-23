using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currecy_converter
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amt;
            double.TryParse(amttextBox.Text, out amt);
            freetextBox2.Text = (amt * 0.050).ToString("c2");
            freetextBox4.Text = (amt * 0.15).ToString("c2");
            freetextBox6.Text = (amt * 0.013).ToString("c2");
            freetextBox8.Text = (amt * 1.00).ToString("c2");
            freetextBox10.Text = (amt * 0.85).ToString("c2");
            freetextBox12.Text = (amt * 7.44).ToString("c2");



        }
    }
}
