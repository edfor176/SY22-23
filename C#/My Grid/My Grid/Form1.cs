using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private PictureBox CreatePicture(PictureBox pb, int row, int col)
        {
            PictureBox p = new PictureBox();
            p.Location = new Point(10 * row, 10 * col);
            p.Size = pictureBox1.Size;
            p.Size = pb.Size;
            p.BackColor = pb.BackColor;
            p.BorderStyle = pb.BorderStyle;
            p.Top = p.Location.Y;
            p.Left = p.Location.X;
            p.Width = pb.Width;
            p.Height = pb.Height;
            p.BackColor = pb.BackColor;
            p.SizeMode = pb.SizeMode;
            if (!(pb.Image == null))
                p.Image = pb.Image;
            p.Name = "Grid-" + row + "-" + col;
            Controls.Add(p);
            return p;
        }
        public PictureBox GetPicture(int row, int col)
        {
            if (col <= 40 && row <= 40)
                return (PictureBox)Controls["Grid-" + col + "-" + row];
            return pictureBox1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    CreatePicture(pictureBox1, i, j);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    GetPicture(i, j).BackColor = Color.Red;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    GetPicture(i, j).BackColor = Color.Red;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    GetPicture(i, j).BackColor = Color.Black;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 40; i++)
            {
                for (int j = 20; j < 40; j++)
                {
                    GetPicture(i, j).BackColor = Color.Green;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    GetPicture(i, j).BackColor = Color.Blue;
                }
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        GetPicture(i, j).BackColor = Color.Black;
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 20; i < 40; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    GetPicture(i, j).BackColor = Color.Blue;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}