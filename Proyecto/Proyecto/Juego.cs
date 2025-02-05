using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Juego : Form
    {
        private int x1, x2, x;
        public int puntos;       
        private Button[] obstaculos = new Button[5];
        private Rectangle recJugador;
        private Rectangle recO1;
        private Rectangle recO2;
        private Rectangle recO3;
        private Rectangle recO4;
        private Rectangle recO5;
        private Rectangle[] listaRec;
        private PictureBox[] papeles;
        private PictureBox[] vidrio;
        private PictureBox[] plastico;
        private PictureBox[] basura;
        private Rectangle[] recBasura;
        private Rectangle re1, re2, re3, re4, re5, re6, re7, re8, re9, cpa, cpla, cvi;
        


        public Juego()
        {


            InitializeComponent();
            listaRec = new Rectangle[5];
            
            obstaculos[0] = O1;
            obstaculos[1] = O2;
            obstaculos[2] = O3;
            obstaculos[3] = O4;
            obstaculos[4] = O5;

            recJugador = new Rectangle(Jugador.Location.X, Jugador.Location.Y, Jugador.Width, Jugador.Height);
            recO1 = new Rectangle(O1.Location.X, O1.Location.Y, O1.Width, O1.Height);
            recO2 = new Rectangle(O2.Location.X, O2.Location.Y, O2.Width, O2.Height);
            recO3 = new Rectangle(O3.Location.X, O3.Location.Y, O3.Width, O3.Height);
            recO4 = new Rectangle(O4.Location.X, O4.Location.Y, O4.Width, O4.Height);
            recO5 = new Rectangle(O5.Location.X, O5.Location.Y, O5.Width, O5.Height);

            listaRec[0] = recO1;
            listaRec[1] = recO2;
            listaRec[2] = recO3;
            listaRec[3] = recO4;
            listaRec[4] = recO5;

            
            x1 = 35;
            x2 = 30;
            puntos=0;
            

            papeles = new PictureBox[3];
            plastico = new PictureBox[4];
            vidrio = new PictureBox[2];

            basura = new PictureBox[9];
            basura[0] = Papel1;
            basura[1] = Papel2;
            basura[2] = Papel3;
            basura[3] = Plasticos2;
            basura[4] = Plastico1;
            basura[5] = Plastico3;
            basura[6] = Plastico4;
            basura[7] = Vidrio1;
            basura[8] = Vidrio2;

           


            papeles[0] = Papel1;
            papeles[1] = Papel2;
            papeles[2] = Papel3;
            plastico[0] = Plasticos2;
            plastico[1] = Plastico1;
            plastico[2] = Plastico3;
            plastico[3] = Plastico4;
            vidrio[0] = Vidrio1;
            vidrio[1] = Vidrio2;


            

            recBasura = new Rectangle[9];
            re1 = new Rectangle(Papel1.Location.X, Papel1.Location.Y, Papel1.Height, Papel1.Width);
            re2 = new Rectangle(Papel2.Location.X, Papel2.Location.Y, Papel2.Height, Papel2.Width);
            re3 = new Rectangle(Papel3.Location.X, Papel3.Location.Y, Papel3.Height, Papel3.Width);
            re4 = new Rectangle(Plasticos2.Location.X, Plasticos2.Location.Y, Plasticos2.Height, Plasticos2.Width);
            re5 = new Rectangle(Plastico1.Location.X, Plastico1.Location.Y, Plastico1.Height, Plastico1.Width);
            re6 = new Rectangle(Plastico3.Location.X, Plastico3.Location.Y, Plastico3.Height, Plastico3.Width);
            re7 = new Rectangle(Plastico4.Location.X, Plastico4.Location.Y, Plastico4.Height, Plastico4.Width);
            re8 = new Rectangle(Vidrio1.Location.X, Vidrio1.Location.Y, Vidrio1.Height, Vidrio1.Width);
            re9 = new Rectangle(Vidrio2.Location.X, Vidrio2.Location.Y, Vidrio2.Height, Vidrio2.Width);


            recBasura[0] = re1;
            recBasura[1] = re2;
            recBasura[2] = re3;
            recBasura[3] = re4;
            recBasura[4] = re5;
            recBasura[5] = re6;
            recBasura[6] = re7;
            recBasura[7] = re8;
            recBasura[8] = re9;

            cpa = new Rectangle(CPapel.Location.X, CPapel.Location.Y, CPapel.Width, CPapel.Height);
            cpla = new Rectangle(CPlastico.Location.X, CPlastico.Location.Y, CPlastico.Width, CPlastico.Height);
            cvi = new Rectangle(CVidrio.Location.X, CVidrio.Location.Y, CVidrio.Width, CVidrio.Height);






        }

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {

                case Keys.A:
                    if (Jugador.Location.X >= 200)
                    {
                        Jugador.Location = new Point(Jugador.Location.X - 10, Jugador.Location.Y);
                    }
                    break;
                case Keys.D:
                    if (Jugador.Location.X <= 540)
                    {
                        Jugador.Location = new Point(Jugador.Location.X + 10, Jugador.Location.Y);
                    }
                    break;
                case Keys.W:
                    if (Jugador.Location.Y >= 0)
                    {
                        Jugador.Location = new Point(Jugador.Location.X, Jugador.Location.Y - 10);
                    }
                    break;
                case Keys.S:
                    if (Jugador.Location.Y <= 540)
                    {
                        Jugador.Location = new Point(Jugador.Location.X, Jugador.Location.Y + 10);
                    }
                    break;
            }
        }




        private void timer_Tick(object sender, EventArgs e)
        {

            mostrarBasuras();
            Colisiones();
            O1.Location = new Point(O1.Location.X + x1, O1.Location.Y);
            O2.Location = new Point(O2.Location.X + x2, O2.Location.Y);
            O3.Location = new Point(O3.Location.X + x1, O3.Location.Y);
            O4.Location = new Point(O4.Location.X + x2, O4.Location.Y);
            O5.Location = new Point(O5.Location.X + x1, O5.Location.Y);
            recJugador.Location = Jugador.Location;
            recO1.Location = O1.Location;
            recO2.Location = O2.Location;
            recO3.Location = O3.Location;
            recO4.Location = O4.Location;
            recO5.Location = O5.Location;
            recO1.Location = new Point(O1.Location.X + x1, O1.Location.Y);
            recO2.Location = new Point(O2.Location.X + x2, O2.Location.Y);
            recO3.Location = new Point(O3.Location.X + x1, O3.Location.Y);
            recO4.Location = new Point(O4.Location.X + x2, O4.Location.Y);
            recO5.Location = new Point(O5.Location.X + x1, O5.Location.Y);



            for (int i = 0; i < obstaculos.Length; i++)
            {


                if (obstaculos[i].Location.X <= 0)
                {
                    x = -x;
                    x1 = -x1;
                    O1.Location = new Point(O1.Location.X + x1, O1.Location.Y);
                    O3.Location = new Point(O3.Location.X + x1, O3.Location.Y);
                    O5.Location = new Point(O5.Location.X + x1, O5.Location.Y);



                }
                else if (obstaculos[i].Location.X > 740)
                {
                    x = -x;
                    x1 = -x1;
                    O1.Location = new Point(O1.Location.X + x1, O1.Location.Y);
                    O3.Location = new Point(O3.Location.X + x1, O3.Location.Y);
                    O5.Location = new Point(O5.Location.X + x1, O5.Location.Y);

                }
            }
            for (int i = 0; i < obstaculos.Length; i++)
            {
                if (obstaculos[i].Location.X <= 0)
                {
                    x = -x;
                    x2 = -x2;
                    O2.Location = new Point(O2.Location.X + x2, O2.Location.Y);
                    O4.Location = new Point(O4.Location.X + x2, O4.Location.Y);




                }
                else if (obstaculos[i].Location.X > 740)
                {
                    x = -x;
                    x2 = -x2;
                    O2.Location = new Point(O2.Location.X + x2, O2.Location.Y);
                    O4.Location = new Point(O4.Location.X + x2, O4.Location.Y);

                }
            }




        }
        private void Colisiones()
        {
            if (recO1.IntersectsWith(recJugador))
            {
                pictureBox2.Visible = true;
                textBox3.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                O1.Visible = false;
                O2.Visible = false;
                O3.Visible=false;
                O4.Visible=false;
                O5.Visible = false;
                Jugador.Visible = false;
                basura[0].Visible = false;
                basura[1].Visible = false;
                basura[2].Visible = false;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                Puntaje.Visible = false;
                label13.Visible = false;
                Puntaje1.Text = "Tu puntaje es " + Puntaje.Text;
                Puntaje1.Visible = true;
                timer.Stop();
                Puntaje.Text = puntos.ToString();
                CPapel.Visible = false;
                CVidrio.Visible = false;
                CPlastico.Visible = false;
            }
            if (recO2.IntersectsWith(recJugador))
            {
                pictureBox2.Visible = true;
                textBox3.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                O1.Visible = false;
                O2.Visible = false;
                O3.Visible = false;
                O4.Visible = false;
                O5.Visible = false;
                Jugador.Visible = false;
                basura[0].Visible = false;
                basura[1].Visible = false;
                basura[2].Visible = false;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                Puntaje.Visible = false;
                label13.Visible = false;
                Puntaje1.Text = "Tu puntaje es " + Puntaje.Text;
                Puntaje1.Visible = true;
                timer.Stop();
                Puntaje.Text = puntos.ToString();
                CPapel.Visible = false;
                CVidrio.Visible = false;
                CPlastico.Visible = false;
            }
            if (recO3.IntersectsWith(recJugador))
            {
                pictureBox2.Visible = true;
                textBox3.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                O1.Visible = false;
                O2.Visible = false;
                O3.Visible = false;
                O4.Visible = false;
                O5.Visible = false;
                Jugador.Visible = false;
                basura[0].Visible = false;
                basura[1].Visible = false;
                basura[2].Visible = false;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                
                timer.Stop();
                Puntaje.Text = puntos.ToString();
                Puntaje1.Text = Puntaje.Text;
                Puntaje.Visible = false;
                label13.Visible = false;
                Puntaje1.Text = "Tu puntaje es " + Puntaje.Text;
                CPapel.Visible = false;
                CVidrio.Visible = false;
                CPlastico.Visible = false;
                Puntaje1.Visible = true;


            }
            if (recO4.IntersectsWith(recJugador))
            {
                pictureBox2.Visible = true;
                textBox3.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                O1.Visible = false;
                O2.Visible = false;
                O3.Visible = false;
                O4.Visible = false;
                O5.Visible = false;
                Jugador.Visible = false;
                basura[0].Visible = false;
                basura[1].Visible = false;
                basura[2].Visible = false;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                Puntaje.Visible = false;
                label13.Visible = false;
                Puntaje1.Text = "Tu puntaje es " + Puntaje.Text; 
                Puntaje1.Visible = true;
                timer.Stop();
                Puntaje.Text = puntos.ToString();
                CPapel.Visible = false;
                CVidrio.Visible = false;
                CPlastico.Visible = false;
            }
            if (recO5.IntersectsWith(recJugador))
            {
                pictureBox2.Visible = true;
                textBox3.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                O1.Visible = false;
                O2.Visible = false;
                O3.Visible = false;
                O4.Visible = false;
                O5.Visible = false;
                Jugador.Visible = false;
                basura[0].Visible = false;
                basura[1].Visible = false;
                basura[2].Visible = false;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                Puntaje.Visible = false;
                label13.Visible = false;
                Puntaje1.Text = "Tu puntaje es " + Puntaje.Text;
                Puntaje1.Visible = true;
                timer.Stop();
                Puntaje.Text = puntos.ToString();
                CPapel.Visible = false;
                CVidrio.Visible = false;
                CPlastico.Visible = false;
            }


        }
        private void mostrarBasuras()
        {


            if (recJugador.IntersectsWith(recBasura[0]) && (recBasura[0].Location == papeles[0].Location) && basura[0].Visible == true)//papel 1 de 3
            {
                basura[0].Visible = false;
                basura[1].Visible = true;
                basura[2].Visible = false;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label2.Visible = true;
                label1.Visible = false;
                puntos=10;
                
                

            }
            if (recJugador.IntersectsWith(recBasura[1]) && (recBasura[1].Location == papeles[1].Location) && basura[1].Visible == true)//papel 2 de 3
            {
                basura[0].Visible = false;
                basura[1].Visible = false;
                basura[2].Visible = true;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label3.Visible = true;
                label2.Visible = false;
                puntos=20;


            }
            if (recJugador.IntersectsWith(recBasura[2]) && (recBasura[2].Location == papeles[2].Location) && basura[2].Visible == true)//papel 3 de 3
            {
                basura[0].Visible = false;
                basura[1].Visible = false;
                basura[2].Visible = false;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label3.Visible = true;
                label2.Visible = false;
                CPapel.Visible = true;
                label12.Visible = true;
                label3.Visible = false;
                puntos = 30;
            }

            if (recJugador.IntersectsWith(cpa) && CPapel.Visible == true)
            {
                basura[0].Visible = true;
                basura[1].Visible = true;
                basura[2].Visible = true;
                basura[0].Location = new Point(CPapel.Location.X + 58, CPapel.Location.Y);
                basura[0].Size = new Size(20, 20);
                basura[1].Location = new Point(CPapel.Location.X + 58, CPapel.Location.Y+22);
                basura[1].Size = new Size(20, 20);
                basura[2].Location = new Point(CPapel.Location.X + 58, CPapel.Location.Y+44);
                basura[2].Size = new Size(20, 20);
                label12.Visible = true;
                label4.Visible = true;
                basura[3].Visible = true;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                CPlastico.Visible = false;
                label10.Visible = false;
                CVidrio.Visible = false;
                label11.Visible = false;
                puntos = 40;
                
                
                               
            }
            if (recJugador.IntersectsWith(recBasura[3]) && (recBasura[3].Location == plastico[0].Location) && basura[3].Visible == true)//plastico 1 de 4
            {
                basura[0].Visible = true;
                basura[1].Visible = true;
                basura[2].Visible = true;
                basura[3].Visible = false;
                basura[4].Visible = true;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label5.Visible = true;
                label4.Visible = false;
                puntos = 50;
            }
            if (recJugador.IntersectsWith(recBasura[4]) && (recBasura[4].Location == plastico[1].Location) && basura[4].Visible == true)//plastico 2 de 4
            {
                basura[0].Visible = true;
                basura[1].Visible = true;
                basura[2].Visible = true;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = true;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label6.Visible = true;
                label5.Visible = false;
                puntos =60 ;
            }
            if (recJugador.IntersectsWith(recBasura[5]) && (recBasura[5].Location == plastico[2].Location) && basura[5].Visible == true)//plastico 3 de 4
            {
                basura[0].Visible = true;
                basura[1].Visible = true;
                basura[2].Visible = true;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = true;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label7.Visible = true;
                label6.Visible = false;
                puntos = 70;
            }
            if (recJugador.IntersectsWith(recBasura[6]) && (recBasura[6].Location == plastico[3].Location) && basura[6].Visible == true)//plastico 4 de 4
            {
                basura[0].Visible = true;
                basura[1].Visible = true;
                basura[2].Visible = true;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;                
                label7.Visible = false;
                CPlastico.Visible = true;
                label10.Visible = true;
                puntos = 80;
            }


            if (recJugador.IntersectsWith(cpla) && CPlastico.Visible == true)
            {
                basura[3].Visible = true;
                basura[4].Visible = true;
                basura[5].Visible = true;
                basura[6].Visible = true;
                basura[3].Location = new Point(CPlastico.Location.X - 21, CPlastico.Location.Y );
                basura[3].Size = new Size(20, 20);
                basura[4].Location = new Point(CPlastico.Location.X - 21, CPlastico.Location.Y + 21);
                basura[4].Size = new Size(20, 20);
                basura[5].Location = new Point(CPlastico.Location.X - 21, CPlastico.Location.Y + 42);
                basura[5].Size = new Size(20, 20);
                basura[6].Location = new Point(CPlastico.Location.X - 21, CPlastico.Location.Y + 63);
                basura[6].Size = new Size(20, 20);
                label12.Visible = true;                
                basura[7].Visible = true;
                label9.Visible = true;
                basura[8].Visible = false;                            
                label8.Visible = false;
                CVidrio.Visible = false;
                label11.Visible = false;
                puntos = 90;

                

                

            }
            
            
            if (recJugador.IntersectsWith(recBasura[7]) && (recBasura[7].Location == vidrio[0].Location) && basura[7].Visible == true)//vidrio 1 de 2
            {
                basura[0].Visible = true;
                basura[1].Visible = true;
                basura[2].Visible = true;
                basura[3].Visible = true;
                basura[4].Visible = true;
                basura[5].Visible = true;
                basura[6].Visible = true;
                basura[7].Visible = false;
                basura[8].Visible = true;                
                label9.Visible = false;
                label8.Visible = true;
                puntos = 110;
            }
            if (recJugador.IntersectsWith(recBasura[8]) && (recBasura[8].Location == vidrio[1].Location) && basura[8].Visible == true)//vidrio 2 de 2
            {
                basura[0].Visible = true;
                basura[1].Visible = true;
                basura[2].Visible = true;
                basura[3].Visible = true;
                basura[4].Visible = true;
                basura[5].Visible = true;
                basura[6].Visible = true;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label8.Visible = false;
                CVidrio.Visible = true;
                label11.Visible = true;
                puntos = 120;
            }

            if (recJugador.IntersectsWith(cvi) && CVidrio.Visible == true)
            {
                basura[7].Visible = true;
                basura[8].Visible = true;               
                basura[7].Location = new Point(CVidrio.Location.X - 21, CVidrio.Location.Y+36);
                basura[7].Size = new Size(20, 20);
                basura[8].Location = new Point(CVidrio.Location.X + 58, CVidrio.Location.Y+36);
                basura[8].Size = new Size(20, 20);               
                label12.Visible = true;

                pictureBox1.Visible = true;
                textBox2.Visible = true;
                button4.Visible = true;
                button2.Visible = true;
                O1.Visible = false;
                O2.Visible = false;
                O3.Visible = false;
                O4.Visible = false;
                O5.Visible = false;
                Jugador.Visible = false;
                basura[0].Visible = false;
                basura[1].Visible = false;
                basura[2].Visible = false;
                basura[3].Visible = false;
                basura[4].Visible = false;
                basura[5].Visible = false;
                basura[6].Visible = false;
                basura[7].Visible = false;
                basura[8].Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                Puntaje.Visible = false;
                label13.Visible = false;
                Puntaje1.Text = "Tu puntaje es " + Puntaje.Text;
                Puntaje1.Visible = true;               
                timer.Stop();
                CPapel.Visible = false;
                CVidrio.Visible = false;
                CPlastico.Visible = false;
                

            }           
            Puntaje.Text = puntos.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
      
        
    }
}



        
        


