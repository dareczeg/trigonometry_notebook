using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programgraficzny
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point p = Point.Empty;
        private Pen pioro;
        

          public Form1()
        {
            InitializeComponent();
        imgObrazek.Image = new Bitmap(458, 206);
        g = Graphics.FromImage(imgObrazek.Image);
        pioro = new Pen(Color.Black, 2);


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void imgObrazek_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pioro, p, e.Location);
                p = e.Location;
                imgObrazek.Refresh();
            }
        }

        private void imgObrazek_Click(object sender, EventArgs e)
        {

        }

        private void imgObrazek_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                p = e.Location;
        }


       

      

     

       


        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Graphics taken from: matma4u.pl & matemaks.pl, program written by Dariusz Ghaemi. (2017)");
        }
      
    }
}
