using System.Diagnostics.CodeAnalysis;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        int canthg1 = 0;
        int canthg2 = 0;
        int canthg3 = 0;
        int canthg4 = 0;
        int canthg5 = 0;
        int cantmg1 = 0;
        int cantmg2 = 0;
        int cantmg3 = 0;
        int cantmg4 = 0;
        int cantmg5 = 0;
        int totalest = 0;
        int sumedadg1 = 0;
        int sumedadg2 = 0;
        int sumedadg3 = 0;
        int sumedadg4 = 0;
        int sumedadg5 = 0;
        int promg1 = 0;
        int promg2 = 0;
        int promg3 = 0;
        int promg4 = 0;
        int promg5 = 0;
        //punto 2
        double valort = 0;
        double descuento = 0;
        double valorf = 0;
        double totalventas = 0;
        int cantventas = 0;
        //punto 3
        int canhe = 0;
        int canme = 0;
        int canhc = 0;
        int canhv = 0;
        int canmc = 0;
        int canmv = 0;
        int canhch = 0;
        int canhsh = 0;
        int canmch = 0;
        int canmsh = 0;
        int canmc1h = 0;
        int canmc2h = 0;
        int canhc1h = 0;
        int canhc2h = 0;
        int canhvm = 0;
        int canhvc = 0;
        int canmvm = 0;
        int canmvc = 0;
        int canhmed = 0;
        int canharq = 0;
        int canmmed = 0;
        int canmarq = 0;
        int canhsv = 0;
        int canhnv = 0;
        int canmsv = 0;
        int canmnv = 0;
        int canhva = 0;
        int canhve = 0;
        int canmva = 0;
        int canmve = 0;
        //Punto 4
        int fianza = 0;
        double cuota = 0;
        int cantfme7 = 0;
        int cantfe7y10 = 0;
        int cantfma10 = 0;
        //Punto 5
        int canaling = 0;
        double notasbd = 0;
        double notases = 0;
        double notasin = 0;
        double promediobd = 0;
        double promedioes = 0;
        double promedioin = 0;
        int aprobd = 0;
        int aproes = 0;
        int aproin = 0;
        double notmaybd = 0;
        double notmayes = 0;
        double notmayin = 0;
        double notmenbd = 5;
        double notmenes = 5;
        double notmenin = 5;
        string nommenbd = "";
        string nommenes = "";
        string nommenin = "";
        //Punto 6
        double valantcon = 0;
        double valactcon = 0;
        double consumo = 0;
        double consumo1 = 0;
        double consumo2 = 0;
        double valfact = 8600;
        //Punto7
        int aluing = 0;
        string nomalum = "";
        double nota1 = 0;
        double nota2 = 0;
        double nota3 = 0;
        double nota4 = 0;
        double sumnotasal = 0;
        double sumprom = 0;
        double sumnotastot = 0;
        double notamayor = 0;
        double notamenor = 5;
        double promnotas = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnagre_Click(object sender, EventArgs e)
        {
            totalest++;
            int edad = int.Parse(txtedad.Text);
            if (totalest <= 20)
            {
                grbg1.Visible = true;
                sumedadg1 = sumedadg1 + edad;
                if (cmbsex.Text == "Masculino")
                {
                    canthg1++;
                }
                else
                {
                    cantmg1++;
                }
                lblceg1.Text = (canthg1 + cantmg1).ToString();
                lblchg1.Text = canthg1.ToString();
                lblcmg1.Text = cantmg1.ToString();
                lblpromg1.Text = (sumedadg1 / (cantmg1 + canthg1)).ToString();
                lbltotal.Text = totalest.ToString();
            }
            else if (totalest > 20 & totalest <= 40)
            {
                grbg2.Visible = true;
                sumedadg2 = sumedadg2 + edad;
                if (cmbsex.Text == "Masculino")
                {
                    canthg2++;
                }
                else
                {
                    cantmg2++;
                }
                lblceg2.Text = (canthg2 + cantmg2).ToString();
                lblchg2.Text = canthg2.ToString();
                lblcmg2.Text = cantmg2.ToString();
                lblpromg2.Text = (sumedadg2 / (cantmg2 + canthg2)).ToString();
                lbltotal.Text = totalest.ToString();
            }
            else if (totalest > 40 & totalest <= 60)
            {
                grbg3.Visible = true;
                sumedadg3 = sumedadg3 + edad;
                if (cmbsex.Text == "Masculino")
                {
                    canthg3++;
                }
                else
                {
                    cantmg3++;
                }
                lblceg3.Text = (canthg3 + cantmg3).ToString();
                lblchg3.Text = canthg3.ToString();
                lblcmg3.Text = cantmg3.ToString();
                lblpromg3.Text = (sumedadg3 / (cantmg3 + canthg3)).ToString();
                lbltotal.Text = totalest.ToString();
            }
            else if (totalest > 60 & totalest <= 80)
            {
                grbg4.Visible = true;
                sumedadg4 = sumedadg4 + edad;
                if (cmbsex.Text == "Masculino")
                {
                    canthg4++;
                }
                else
                {
                    cantmg4++;
                }
                lblceg4.Text = (canthg4 + cantmg4).ToString();
                lblchg4.Text = canthg4.ToString();
                lblcmg4.Text = cantmg4.ToString();
                lblpromg4.Text = (sumedadg4 / (cantmg4 + canthg4)).ToString();
                lbltotal.Text = totalest.ToString();
            }
            else if (totalest > 80 & totalest <= 100)
            {
                grbg5.Visible = true;
                sumedadg5 = sumedadg5 + edad;
                if (cmbsex.Text == "Masculino")
                {
                    canthg5++;
                }
                else
                {
                    cantmg5++;
                }
                lblceg5.Text = (canthg5 + cantmg5).ToString();
                lblchg5.Text = canthg5.ToString();
                lblcmg5.Text = cantmg5.ToString();
                lblpromg5.Text = (sumedadg5 / (cantmg5 + canthg5)).ToString();
                lbltotal.Text = totalest.ToString();
            }
            else
            {
                MessageBox.Show("Cantidad de cupos disponibles completado");
                totalest = 100;
                btnagre.Enabled = false;
            }
            txtnom.Text = "";
            txtape.Text = "";
            txtdoc.Text = "";
            cmbsex.Text = "";
            txtedad.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            btntotal.Enabled = true;
            cantventas++;
            valort = double.Parse(txtvalt.Text);
            if (valort >= 100000 & valort < 200000)
            {
                MessageBox.Show("Obtienes un descuento del 10%");
                descuento = valort * 0.1;
                txtdesc.Text = descuento.ToString();
                valorf = valort - descuento;
                txtvalf.Text = valorf.ToString();
            }
            else if (valort >= 200000 & valort < 500000)
            {
                MessageBox.Show("Obtienes un descuento del 20%");
                descuento = valort * 0.2;
                txtdesc.Text = descuento.ToString();
                valorf = valort - descuento;
                txtvalf.Text = valorf.ToString();
            }
            else if (valort >= 500000)
            {
                MessageBox.Show("Obtienes un descuento del 30%");
                descuento = valort * 0.3;
                txtdesc.Text = descuento.ToString();
                valorf = valort - descuento;
                txtvalf.Text = valorf.ToString();
            }
            else
            {
                MessageBox.Show("No obtienes descuentos");
                descuento = 0;
                txtdesc.Text = descuento.ToString();
                valorf = valort;
                txtvalf.Text = valorf.ToString();

            }
            MessageBox.Show("El total a pagar con el descuento es: $" + valorf.ToString());
            totalventas = totalventas + valorf;
            grbventa.Visible = false;
            btnventa.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtvalt.Text = "";
            txtvalf.Text = "";
            txtdesc.Text = "";
            txtvalt.Focus();
            btntotal.Enabled = false;
            grbtotal.Visible = false;
            btnventa.Visible = false;
            grbventa.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grbtotal.Visible = true;
            grbventa.Visible = false;
            btnventa.Visible = true;
            lblcantv.Text = cantventas.ToString();
            lbltotalv.Text = totalventas.ToString();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            btntotal.Enabled = true;
            btnventa.Visible = true;
            grbventa.Visible = false;
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            if (cmbgen.Text == "Masculino")
            {
                canhe++;
                if (cmbec.Text == "Casado")
                {
                    canhc++;
                }
                else if (cmbec.Text == "Viudo")
                {
                    canhv++;
                }
                if (cmbth.Text == "Si")
                {
                    canhch++;
                    if (cmbch.Text == "1")
                    {
                        canhc1h++;
                    }
                    else if (cmbch.Text == "2 o mas")
                    {
                        canhc2h++;
                    }
                }
                else if (cmbth.Text == "No")
                {
                    canhsh++;
                }
                if (cmbciu.Text == "Medellin")
                {
                    canhvm++;
                }
                else if (cmbciu.Text == "Cali")
                {
                    canhvc++;
                }
                if (cmbprof.Text == "Medico")
                {
                    canhmed++;
                }
                else if (cmbprof.Text == "Arquitecto")
                {
                    canharq++;
                }
                if (cmbviaj.Text == "Si")
                {
                    canhsv++;
                    if (cmbdv.Text == "America")
                    {
                        canhva++;
                    }
                    else if (cmbdv.Text == "Europa")
                    {
                        canhve++;
                    }
                }
                else if (cmbviaj.Text == "No")
                {
                    canhnv++;
                }

            }
            //femenino
            else if (cmbgen.Text == "Femenino")
            {
                canme++;
                if (cmbec.Text == "Casado")
                {
                    canmc++;
                }
                else if (cmbec.Text == "Viudo")
                {
                    canmv++;
                }
                if (cmbth.Text == "Si")
                {
                    canmch++;
                    if (cmbch.Text == "1")
                    {
                        canmc1h++;
                    }
                    else if (cmbch.Text == "2 o mas")
                    {
                        canmc2h++;
                    }
                }
                else if (cmbth.Text == "No")
                {
                    canmsh++;
                }
                if (cmbciu.Text == "Medellin")
                {
                    canmvm++;
                }
                else if (cmbciu.Text == "Cali")
                {
                    canmvc++;
                }
                if (cmbprof.Text == "Medico")
                {
                    canmmed++;
                }
                else if (cmbprof.Text == "Arquitecto")
                {
                    canmarq++;
                }
                if (cmbviaj.Text == "Si")
                {
                    canmsv++;
                    if (cmbdv.Text == "America")
                    {
                        canmva++;
                    }
                    else if (cmbdv.Text == "Europa")
                    {
                        canmve++;
                    }
                }
                else if (cmbviaj.Text == "No")
                {
                    canmnv++;
                }
            }
            cmbch.Visible = false;
            cmbch.Text = "";
            cmbdv.Visible = false;
            cmbdv.Text = "";
            txtnomenc.Text = "";
            txtapelenc.Text = "";
            cmbgen.Text = "";
            cmbec.Text = "";
            cmbth.Text = "";
            cmbciu.Text = "";
            cmbprof.Text = "";
            cmbviaj.Text = "";
            grbresenc.Visible = false;
        }

        private void cmbth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbth.Text == "Si")
            {
                cmbch.Visible = true;
            }
            else
            {
                cmbch.Visible = false;
                cmbch.Text = "";
            }
        }

        private void cmbviaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbviaj.Text == "Si")
            {
                cmbdv.Visible = true;
            }
            else
            {
                cmbdv.Visible = false;
                cmbdv.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grbresenc.Visible = true;
            lblhe.Text = canhe.ToString();
            lblme.Text = canme.ToString();
            lblhc.Text = canhc.ToString();
            lblmc.Text = canmc.ToString();
            lblhv.Text = canhv.ToString();
            lblmv.Text = canmv.ToString();
            lblhch.Text = canhch.ToString();
            lblmch.Text = canmch.ToString();
            lblhc1h.Text = canhc1h.ToString();
            lblhc2h.Text = canhc2h.ToString();
            lblmc1h.Text = canmc1h.ToString();
            lblmc2h.Text = canmc2h.ToString();
            lblhsh.Text = canhsh.ToString();
            lblmsh.Text = canmsh.ToString();
            lblhvc.Text = canhvc.ToString();
            lblmvc.Text = canmvc.ToString();
            lblhvm.Text = canhvm.ToString();
            lblmvm.Text = canmvm.ToString();
            lblhmed.Text = canhmed.ToString();
            lblmmed.Text = canmmed.ToString();
            lblharq.Text = canharq.ToString();
            lblmarq.Text = canmarq.ToString();
            lblhsv.Text = canhsv.ToString();
            lblmsv.Text = canmsv.ToString();
            lblhva.Text = canhva.ToString();
            lblmva.Text = canmva.ToString();
            lblhve.Text = canhve.ToString();
            lblmve.Text = canmve.ToString();
            lblhnv.Text = canhnv.ToString();
            lblmnv.Text = canmnv.ToString();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            fianza = int.Parse(txtfian.Text);
            grbccpm.Visible = false;
            if (fianza <= 7300000)
            {
                cantfme7++;
                cuota = fianza * 0.04;
            }
            else if (fianza >= 10500000)
            {
                cantfma10++;
                cuota = fianza * 0.02;
            }
            else
            {
                cantfe7y10++;
                cuota = fianza * 0.03;
            }
            txtcuota.Text = cuota.ToString();
            MessageBox.Show("La cuota a pagar por el usuario sería de: $" + cuota.ToString());
            txtfian.Text = "";
            txtcuota.Text = "";
            txtfian.Focus();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            grbccpm.Visible = true;
            lblcantfme7.Text = cantfme7.ToString();
            lblcantfe7y10.Text = cantfe7y10.ToString();
            lblcantfma10.Text = cantfma10.ToString();
            lblftotal.Text = (cantfme7 + cantfma10 + cantfe7y10).ToString();
        }

        private void btningr_Click(object sender, EventArgs e)
        {
            canaling++;
            double notabd = double.Parse(txtnotabd.Text);
            double notaes = double.Parse(txtnotaes.Text);
            double notain = double.Parse(txtnotain.Text);
            if (canaling <= 25)
            {
                notasbd = notasbd + notabd;
                notases = notases + notaes;
                notasin = notasin + notain;
                if (notabd >= 3)
                {
                    aprobd++;
                }
                if (notaes >= 3)
                {
                    aproes++;
                }
                if (notain >= 3)
                {
                    aproin++;
                }
                if (notabd >= notmaybd)
                {
                    notmaybd = notabd;
                }
                if (notaes >= notmayes)
                {
                    notmayes = notaes;
                }
                if (notain >= notmayin)
                {
                    notmayin = notain;
                }
                if (notabd <= notmenbd)
                {
                    notmenbd = notabd;
                    nommenbd = txtnomest.Text;
                }
                if (notaes <= notmenes)
                {
                    notmenes = notaes;
                    nommenes = txtnomest.Text;
                }
                if (notain <= notmenin)
                {
                    notmenin = notain;
                    nommenin = txtnomest.Text;
                }
            }
            else
            {
                MessageBox.Show("Ya se han ingresado las notas de los 25 estudiantes");
                btningr.Enabled = false;
                canaling = 25;
            }
            promediobd = notasbd / canaling;
            promedioes = notases / canaling;
            promedioin = notasin / canaling;
            //mostrar resultados
            lblprombd.Text = promediobd.ToString();
            lblpromes.Text = promedioes.ToString();
            lblpromin.Text = promedioin.ToString();
            lblaprobd.Text = aprobd.ToString();
            lblaproes.Text = aproes.ToString();
            lblaproin.Text = aproin.ToString();
            lblnotmaybd.Text = notmaybd.ToString();
            lblnotmayes.Text = notmayes.ToString();
            lblnotmayin.Text = notmayin.ToString();
            lblnotmenbd.Text = notmenbd.ToString();
            lblnotmenes.Text = notmenes.ToString();
            lblnotmenin.Text = notmenin.ToString();
            lblnommenbd.Text = nommenbd.ToString();
            lblnommenes.Text = nommenes.ToString();
            lblnommenin.Text = nommenin.ToString();
        }

        private void btnverprom_Click(object sender, EventArgs e)
        {
            grbprom.Visible = true;
            grbaprob.Visible = false;
            grbnotmay.Visible = false;
            grbnotmen.Visible = false;
        }

        private void btnveraprob_Click(object sender, EventArgs e)
        {
            grbprom.Visible = false;
            grbaprob.Visible = true;
            grbnotmay.Visible = false;
            grbnotmen.Visible = false;
        }

        private void btnnotmay_Click(object sender, EventArgs e)
        {
            grbprom.Visible = false;
            grbaprob.Visible = false;
            grbnotmay.Visible = true;
            grbnotmen.Visible = false;
        }

        private void btnnotmen_Click(object sender, EventArgs e)
        {
            grbprom.Visible = false;
            grbaprob.Visible = false;
            grbnotmay.Visible = false;
            grbnotmen.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalfac_Click(object sender, EventArgs e)
        {
            valantcon = double.Parse(txtvalant.Text);
            valactcon = double.Parse(txtvalact.Text);
            consumo = valactcon - valantcon;

            if (consumo <= 200)
            {
                valfact = valfact + (consumo * 300);
            }
            else if (consumo > 200 & consumo <= 450)
            {
                consumo1 = consumo - 200;
                valfact = valfact + (200 * 300) + (consumo1 * 280);
            }
            else
            {
                consumo1 = consumo - 200;
                consumo2 = consumo1 - 250;
                valfact = valfact + (200 * 300) + (250 * 280) + (consumo2 * 170);
            }
            txtconsum.Text = consumo.ToString();
            txtvalfac.Text = valfact.ToString();
            MessageBox.Show("El valor a pagar en tu factura es: $" + valfact.ToString());
            valfact = 8600;
            txtvalant.Text = "";
            txtvalact.Text = "";
            txtconsum.Text = "";
            txtvalfac.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aluing++;
            nota1 = double.Parse(txtnota1.Text);
            nota2 = double.Parse(txtnota2.Text);
            nota3 = double.Parse(txtnota3.Text);
            nota4 = double.Parse(txtnota4.Text);
            if (aluing <= 10)
            {
                sumnotasal = nota1 + nota2 + nota3 + nota4;
                sumnotastot = sumnotastot + sumnotasal;
                promnotas = sumnotasal / 4;
                sumprom = sumprom + promnotas;
                if (promnotas > notamayor)
                {
                    notamayor = promnotas;
                }
                if (promnotas < notamenor)
                {
                    notamenor = promnotas;
                }
                lstpromedios.Items.Add(txtnomalum.Text + "     " + promnotas.ToString());
                MessageBox.Show("El alumno " + txtnomalum.Text + " tuvo un promedio de: " + promnotas.ToString());
            }
            if (aluing == 10)
            {
                MessageBox.Show("Ya se han ingresado los 10 alumnos");
                btningnot.Enabled = false;
                grbresalum.Visible = true;
                lblnotamayor.Text = notamayor.ToString();
                lblnotamenor.Text = notamenor.ToString();
                lblsumnot.Text = sumnotastot.ToString();
                lblsumprom.Text = sumprom.ToString();
            }
        }
    }
}