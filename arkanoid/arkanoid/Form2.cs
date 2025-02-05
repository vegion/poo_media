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
    public partial class Form2 : Form
    {
        private Rectangle rec0;
        private Rectangle rec1;
        private Rectangle rec2;
        private Rectangle rec3;
        private Rectangle rec4;
        private Rectangle rec5;
        private Rectangle rec6;
        private Rectangle rec7;
        private Rectangle rec8;
        private Rectangle rec9;
        private Rectangle rec10;
        private Rectangle rec11;
        private Rectangle rec12;
        private Rectangle rec13;
        private Rectangle rec14;
        private Rectangle rec15;
        private Rectangle rec16;
        private Rectangle rec17;
        private Rectangle rec18;
        private Rectangle rec19;
        private Rectangle rec20;
        private Rectangle rec21;
        private Rectangle rec22;
        private Rectangle rec23;
        private Rectangle rec24;
        private Rectangle rec25;
        private Rectangle rec26;
        private Rectangle rec27;
        private Rectangle rec28;
        private Rectangle rec29;
        private Rectangle rec30;
        private Rectangle rec31;
        private Rectangle rec32;
        private Rectangle rec33;
        private Rectangle rec34;
        private Rectangle rec35;


        private Rectangle[] recArray;
        private Button[] ldrArray;

        private Rectangle recBola;
        private Rectangle recLadrillo;
        private Rectangle recBarra;
        private Random aleatorio = new Random();
        private int velocidad = 0;
        private int velocidadX = 0;
        private int velocidadY = 0;
        int vida = 2, puntuacion = 0;
        int contador = 0;
        public Form2()
        {            
            InitializeComponent();            
            velocidadX = 1;
            velocidadY = 1;
            velocidad = 5;
            recArray = new Rectangle[37];
            ldrArray = new Button[37];

            recBola = new Rectangle(bola.Location.X, bola.Location.Y, bola.Width, bola.Height);
            recBarra = new Rectangle(tabla.Location.X, tabla.Location.Y, tabla.Width, tabla.Height);

            recLadrillo = new Rectangle(ldrinicial.Location.X, ldrinicial.Location.Y, ldrinicial.Width, ldrinicial.Height);
            rec0 = new Rectangle(ldr1.Location.X, ldr1.Location.Y, ldr1.Width, ldr1.Height);
            rec1 = new Rectangle(ldr2.Location.X, ldr2.Location.Y, ldr2.Width, ldr2.Height);
            rec2 = new Rectangle(ldr3.Location.X, ldr13.Location.Y, ldr3.Width, ldr3.Height);
            rec3 = new Rectangle(ldr4.Location.X, ldr4.Location.Y, ldr4.Width, ldr4.Height);
            rec4 = new Rectangle(ldr5.Location.X, ldr5.Location.Y, ldr5.Width, ldr5.Height);
            rec5 = new Rectangle(ldr6.Location.X, ldr6.Location.Y, ldr6.Width, ldr6.Height);
            rec6 = new Rectangle(ldr7.Location.X, ldr7.Location.Y, ldr7.Width, ldr7.Height);
            rec7 = new Rectangle(ldr8.Location.X, bola.Location.Y, ldr8.Width, ldr8.Height);
            rec8 = new Rectangle(ldr9.Location.X, ldr9.Location.Y, ldr9.Width, ldr9.Height);
            rec9 = new Rectangle(ldr10.Location.X, ldr10.Location.Y, ldr10.Width, ldr10.Height);
            rec10 = new Rectangle(ldr11.Location.X, ldr11.Location.Y, ldr11.Width, ldr11.Height);
            rec11 = new Rectangle(ldr12.Location.X, ldr12.Location.Y, ldr12.Width, ldr12.Height);
            rec12 = new Rectangle(ldr13.Location.X, ldr13.Location.Y, ldr13.Width, ldr13.Height);
            rec13 = new Rectangle(ldr14.Location.X, ldr14.Location.Y, ldr14.Width, ldr14.Height);
            rec14 = new Rectangle(ldr15.Location.X, ldr15.Location.Y, ldr15.Width, ldr15.Height);
            rec15 = new Rectangle(ldr16.Location.X, ldr16.Location.Y, ldr16.Width, ldr16.Height);
            rec16 = new Rectangle(ldr17.Location.X, ldr17.Location.Y, ldr17.Width, ldr17.Height);
            rec17 = new Rectangle(ldr18.Location.X, ldr18.Location.Y, ldr18.Width, ldr18.Height);
            rec18 = new Rectangle(ldr19.Location.X, ldr19.Location.Y, ldr19.Width, ldr19.Height);
            rec19 = new Rectangle(ldr20.Location.X, ldr20.Location.Y, ldr20.Width, ldr20.Height);
            rec20 = new Rectangle(ldr21.Location.X, ldr21.Location.Y, ldr21.Width, ldr21.Height);
            rec21 = new Rectangle(ldr22.Location.X, ldr22.Location.Y, ldr22.Width, ldr22.Height);
            rec22 = new Rectangle(ldr23.Location.X, ldr23.Location.Y, ldr23.Width, ldr23.Height);
            rec23 = new Rectangle(ldr24.Location.X, ldr24.Location.Y, ldr24.Width, ldr24.Height);
            rec24 = new Rectangle(ldr25.Location.X, ldr25.Location.Y, ldr25.Width, ldr25.Height);
            rec25 = new Rectangle(ldr26.Location.X, ldr26.Location.Y, ldr26.Width, ldr26.Height);
            rec26 = new Rectangle(ldr27.Location.X, ldr27.Location.Y, ldr27.Width, ldr27.Height);
            rec27 = new Rectangle(ldr28.Location.X, ldr28.Location.Y, ldr28.Width, ldr28.Height);
            rec28 = new Rectangle(ldr29.Location.X, ldr29.Location.Y, ldr29.Width, ldr29.Height);
            rec29 = new Rectangle(ldr30.Location.X, ldr30.Location.Y, ldr30.Width, ldr30.Height);
            rec30 = new Rectangle(ldr31.Location.X, ldr31.Location.Y, ldr31.Width, ldr31.Height);
            rec31 = new Rectangle(ldr32.Location.X, ldr32.Location.Y, ldr32.Width, ldr32.Height);
            rec32 = new Rectangle(ldr33.Location.X, ldr33.Location.Y, ldr33.Width, ldr33.Height);
            rec33 = new Rectangle(ldr34.Location.X, ldr34.Location.Y, ldr34.Width, ldr34.Height);
            rec34 = new Rectangle(ldr35.Location.X, ldr35.Location.Y, ldr35.Width, ldr35.Height);
            rec35 = new Rectangle(ldr36.Location.X, ldr36.Location.Y, ldr36.Width, ldr36.Height);


            recArray[0] = recLadrillo;
            recArray[1] = rec1;
            recArray[2] = rec2;
            recArray[3] = rec3;
            recArray[4] = rec4;
            recArray[5] = rec5;
            recArray[6] = rec6;
            recArray[7] = rec7;
            recArray[8] = rec8;
            recArray[9] = rec9;
            recArray[10] = rec10;
            recArray[11] = rec11;
            recArray[12] = rec12;
            recArray[13] = rec13;
            recArray[14] = rec14;
            recArray[15] = rec15;
            recArray[16] = rec16;
            recArray[17] = rec17;
            recArray[18] = rec18;
            recArray[19] = rec19;
            recArray[20] = rec20;
            recArray[21] = rec21;
            recArray[22] = rec22;
            recArray[23] = rec23;
            recArray[24] = rec24;
            recArray[25] = rec25;
            recArray[26] = rec26;
            recArray[27] = rec27;
            recArray[28] = rec28;
            recArray[29] = rec29;
            recArray[30] = rec30;
            recArray[31] = rec31;
            recArray[32] = rec32;
            recArray[33] = rec33;
            recArray[34] = rec34;
            recArray[35] = rec35;
            recArray[36] = rec0;


            ldrArray[0] = ldr1;
            ldrArray[1] = ldr2;
            ldrArray[2] = ldr3;
            ldrArray[3] = ldr4;
            ldrArray[4] = ldr5;
            ldrArray[5] = ldr6;
            ldrArray[6] = ldr7;
            ldrArray[7] = ldr8;
            ldrArray[8] = ldr9;
            ldrArray[9] = ldr10;
            ldrArray[10] = ldr11;
            ldrArray[11] = ldr12;
            ldrArray[12] = ldr13;
            ldrArray[13] = ldr14;
            ldrArray[14] = ldr15;
            ldrArray[15] = ldr16;
            ldrArray[16] = ldr17;
            ldrArray[17] = ldr18;
            ldrArray[18] = ldr19;
            ldrArray[19] = ldr20;
            ldrArray[20] = ldr21;
            ldrArray[21] = ldr22;
            ldrArray[22] = ldr23;
            ldrArray[23] = ldr24;
            ldrArray[24] = ldr25;
            ldrArray[25] = ldr26;
            ldrArray[26] = ldr27;
            ldrArray[27] = ldr28;
            ldrArray[28] = ldr29;
            ldrArray[29] = ldr30;
            ldrArray[30] = ldr31;
            ldrArray[31] = ldr32;
            ldrArray[32] = ldr33;
            ldrArray[33] = ldr34;
            ldrArray[34] = ldr35;
            ldrArray[35] = ldr36;
            ldrArray[36] = ldrinicial;





        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.X >= 65 && e.X <= 783 - 63)
            {
                this.tabla.Location = new System.Drawing.Point(e.X - tabla.Width / 2, 524);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bola.Location = new System.Drawing.Point(bola.Location.X + velocidadX, bola.Location.Y + velocidadY);

            recBarra.Location = tabla.Location;
            recBola.Location = bola.Location;

            for (int i = 0; i < recArray.Length; i++)
            {
                if ((ldrArray[i].Visible == true) && (recArray[i].IntersectsWith(recBola)))
                {
                    velocidadY = velocidad;
                    ldrArray[i].Visible = false;
                    puntuacion = puntuacion + 10;
                    puntos.Text = puntuacion.ToString();
                    contador++;
                    if (contador == 36)
                    {
                        Form4 frm = new Form4();
                        frm.Show();
                    }
                    
                }
            }
            if (ldrinicial.Visible == true && recLadrillo.IntersectsWith(recBola))
            {
                velocidadY = velocidad;
                ldrinicial.Visible = false;
            }

            if (recBola.IntersectsWith(recBarra)) 
            velocidadY = -velocidad;
            else 
                if (bola.Location.X >= 745) velocidadX = -velocidad;

            else 
                    if (bola.Location.X <= 1) velocidadX = velocidad;

            else 
                        if (bola.Location.Y <= 38) velocidadY = velocidad;

            else
                            if (bola.Location.Y > 550)
                            {
                                velocidadY = -velocidad;
                                if(vida >= 0)
                                {
                                    vida--;
                                    vidas.Text = vida.ToString();
                                    bola.Location = new Point(tabla.Location.X,tabla.Location.Y);
                                    if (vida < 0)
                                    {                                       
                                        Form3 frm = new Form3();
                                        frm.Show();
                                        
                                                                               
                                    }
                                    

                                }                         
                                   
                               
                                                                
                            }
            
            


        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
       
    }

}



