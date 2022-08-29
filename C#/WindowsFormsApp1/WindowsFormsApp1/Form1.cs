using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            double amount = 0;
            double.TryParse(amttextBox.Text, out amount);
            this.BackColor = SystemColors.Control;
            if (amount > 500) ;
            this.BackColor= Color.Red;
            feetextBox.Text = (amount * 0.03).ToString("c2");
            Clear();
 
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void Clear()
        {
            nametextBox.Clear();
            ziptextBox.Clear();
            cctextBox.Clear();
            amttextBox.Clear();
            exptextBox.Clear();
        }

        private void feetextBox_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
