namespace Tienda
{
    public partial class Form1 : Form
    {
        int totalMec = 0;
        int totalGas = 0;
        int totalCon = 0;
        int totalTin = 0;
        int totalPap = 0;
        int totalPas = 0;
        int valorMec = 500;
        int valorGas = 1200;
        int valorCon = 200;
        int valorTin = 500;
        int valorPap = 800;
        int valorPas = 750;
        int confites = 0;
        int gaseosas = 0;
        int mecato = 0;
        int tinto = 0;
        int pasteles = 0;
        int papitas = 0;
        int venta = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            grbven.Visible = true;
            btnventa.Enabled = false;
            btnvenpro.Enabled = false;
            btntotal.Enabled = false;
        }

        private void btncont_Click(object sender, EventArgs e)
        {
            grbprod.Visible = true;
            grbven.Visible = false;
        }

        private void btnconf_Click(object sender, EventArgs e)
        {
            confites++;
            txtcon.Text = confites.ToString();
        }

        private void btngas_Click(object sender, EventArgs e)
        {
            gaseosas++;
            txtgas.Text = gaseosas.ToString();
        }

        private void btnmec_Click(object sender, EventArgs e)
        {
            mecato++;
            txtmec.Text = mecato.ToString();
        }

        private void btnpap_Click(object sender, EventArgs e)
        {
            papitas++;
            txtpap.Text = papitas.ToString();
        }

        private void btnpas_Click(object sender, EventArgs e)
        {
            pasteles++;
            txtpas.Text = pasteles.ToString();
        }

        private void btntin_Click(object sender, EventArgs e)
        {
            tinto++;
            txttin.Text = tinto.ToString();
        }

        private void btnrei_Click(object sender, EventArgs e)
        {
            txtcon.Text = "";
            txtgas.Text = "";
            txtmec.Text = "";
            txtpap.Text = "";
            txtpas.Text = "";
            txttin.Text = "";
            confites = 0;
            gaseosas = 0;
            mecato = 0;
            papitas = 0;
            pasteles = 0;
            tinto = 0;
        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            int total = (confites * valorCon) + (gaseosas * valorGas) + (mecato * valorMec) + (papitas * valorPap) + (pasteles * valorPas) + (tinto * valorTin);
            MessageBox.Show("El valor total de la compra es de: $" + total.ToString());
            totalCon = totalCon + confites;
            totalGas = totalGas + gaseosas;
            totalMec = totalMec + mecato;
            totalPap = totalPap + papitas;
            totalPas = totalPas + pasteles;
            totalTin = totalTin + tinto;
            confites = 0;
            gaseosas = 0;
            mecato = 0;
            papitas = 0;
            pasteles = 0;
            tinto = 0;
            grbprod.Visible = false;
            btnventa.Enabled = true;
            btnvenpro.Enabled = true;
            btntotal.Enabled = true;
            txtnom.Text = "";
            txtape.Text = "";
            txtcon.Text = "";
            txtgas.Text = "";
            txtmec.Text = "";
            txtpap.Text = "";
            txtpas.Text = "";
            txttin.Text = "";
        }

        private void btncons_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtcod.Text);
            grbinf.Visible = true;
            grbcons.Visible = false;
            switch (codigo)
            {
                case 1:
                    venta = totalCon * valorCon;
                    picbprod.Image = Properties.Resources.confites;
                    lblnom.Text = "Confites";
                    lblvalor.Text = valorCon.ToString();
                    lblcant.Text = totalCon.ToString();
                    lblventa.Text = venta.ToString();
                    break;
                case 2:
                    venta = totalGas * valorGas;
                    picbprod.Image = Properties.Resources.gaseosa;
                    lblnom.Text = "Gaseosa";
                    lblvalor.Text = valorGas.ToString();
                    lblcant.Text = totalGas.ToString();
                    lblventa.Text = venta.ToString();
                    break;
                case 3:
                    venta = totalMec * valorMec;
                    picbprod.Image = Properties.Resources.mecato;
                    lblnom.Text = "Mecato";
                    lblvalor.Text = valorMec.ToString();
                    lblcant.Text = totalMec.ToString();
                    lblventa.Text = venta.ToString();
                    break;
                case 4:
                    venta = totalPap * valorPap;
                    picbprod.Image = Properties.Resources.papitas;
                    lblnom.Text = "Papitas";
                    lblvalor.Text = valorPap.ToString();
                    lblcant.Text = totalPap.ToString();
                    lblventa.Text = venta.ToString();
                    break;
                case 5:
                    venta = totalPas * valorPas;
                    picbprod.Image = Properties.Resources.pasteles;
                    lblnom.Text = "Pasteles";
                    lblvalor.Text = valorPas.ToString();
                    lblcant.Text = totalPas.ToString();
                    lblventa.Text = venta.ToString();
                    break;
                case 6:
                    venta = totalTin * valorTin;
                    picbprod.Image = Properties.Resources.tinto;
                    lblnom.Text = "Tinto";
                    lblvalor.Text = valorTin.ToString();
                    lblcant.Text = totalTin.ToString();
                    lblventa.Text = venta.ToString();
                    break;
                default:
                    MessageBox.Show("Codigo ingresado incorrecto", "Error");
                    break;
            }

        }

        private void btnvenpro_Click(object sender, EventArgs e)
        {
            grbcons.Visible = true;
            btnventa.Enabled = false;
            btnvenpro.Enabled = false;
            btntotal.Enabled = false;
        }

        private void grbinf_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnventa.Enabled = true;
            btnvenpro.Enabled = true;
            btntotal.Enabled = true;
            grbinf.Visible = false;
        }

        private void btnnue_Click(object sender, EventArgs e)
        {
            grbcons.Visible = true;
            grbinf.Visible = false;
            txtcod.Text = "";
            txtcod.Focus();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void btnsal_Click(object sender, EventArgs e)
        {
            btnventa.Enabled = true;
            btnvenpro.Enabled = true;
            btntotal.Enabled = true;
            grbtotal.Visible = false;
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            grbtotal.Visible = true;
            btnventa.Enabled = false;
            btnvenpro.Enabled = false;
            btntotal.Enabled = false;

            lblcon.Text = "$"+ (totalCon*valorCon).ToString();
            lblgas.Text = "$"+ (totalGas * valorGas).ToString();
            lblmec.Text = "$"+ (totalMec * valorMec).ToString();
            lblpap.Text = "$"+ (totalPap * valorPap).ToString();
            lblpas.Text = "$"+ (totalPas * valorPas).ToString();
            lbltin.Text = "$"+ (totalTin * valorTin).ToString();
            lbltotal.Text = "$" + ((totalCon * valorCon) + (totalGas * valorGas) + (totalMec * valorMec) + (totalPap * valorPap) + (totalPas * valorPas) + (totalTin * valorTin)).ToString();
        }
    }
}