using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace arkanoid
{
    public partial class Form1 : Form
    {
        private Random aleatorio = new Random();
        private int velocidadX = 0;
        private int velocidadY = 0;
        public Form1()
        {
            InitializeComponent();
            velocidadX = 2;
            velocidadY = 2;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // txtPosition.Text = e.X.ToString() + ":" + e.Y.ToString();
            if (e.X >= 40 && e.X <= 244)
            {
                this.tabla.Location = new System.Drawing.Point(e.X - tabla.Width / 2, 238);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            bola.Location = new System.Drawing.Point(bola.Location.X + velocidadX, bola.Location.Y + velocidadY);
            if (bola.Location.X >= tabla.Location.X && bola.Location.X <= tabla.Location.X + tabla.Width - tabla.Width / 4 && bola.Location.Y == 218) 
                velocidadY = -2;
            else if (bola.Location.X >= 257) velocidadX = -2;
            else if (bola.Location.X <= 1) velocidadX = 2;
            else if (bola.Location.Y <= 27) velocidadY = 2;
            else if (bola.Location.Y >= 238) velocidadY = -2;

        }
        private void tabla_LocationChanged(object sender, EventArgs e)
        {
            txtposition.Text = tabla.Location.X + ":" + tabla.Location.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
