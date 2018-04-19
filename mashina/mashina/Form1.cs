using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mashina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }
        int position = 0;
        List<PictureBox> snimki = new List<PictureBox>();
        int Count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox pic1 = new PictureBox();
            pic1.Left = 710;
            pic1.Top = position;
            position += 100;
            if (position > 500)
            {
                position = 0;
            }
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.Image = Properties.Resources.download;
            this.Controls.Add(pic1);
            snimki.Add(pic1);
            
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < snimki.Count; i++)
            {
                
                snimki[i].Left = snimki[i].Left - 10;
                if (pictureBox1.Bounds.IntersectsWith(snimki[i].Bounds))
                {
                    label1.Visible = true;

                    for (int j = 0; j < snimki.Count; j++)
                    {
                        snimki[j].Visible = false;

                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Left -= 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Left += 10;
            }

        }
        
    }
}
