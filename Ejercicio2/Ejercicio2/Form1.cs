namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        int[] codigo = { 0111, 0211, 0212, 0311, 0411, 0511, 0611, 0711 };
        string[] producto = { "Salchipapa", "Perro", "Perra", "Hamburguesa", "Chorizo", "Chuzo", "Tacos", "Picada", "Gaseosas" };
        double[] precio = { 12000, 15000, 17000, 20000, 12000, 15500, 7000, 25000, 4000 };

        Image[] fotos = {Ejercicio2.Properties.Resources.salchipapa, Ejercicio2.Properties.Resources.perro, Ejercicio2.Properties.Resources.perra,
        Ejercicio2.Properties.Resources.hamburguesa, Ejercicio2.Properties.Resources.chorizo, Ejercicio2.Properties.Resources.chuzo_de_pollo, Ejercicio2.Properties.Resources.tacos,
        Ejercicio2.Properties.Resources.picada};
        int codped = 0;
        int prod = 0;
        string productoped = "";
        string gaseosa = "";
        double subtotal = 0;
        //proceso venta
        double valorped = 0;
        double valorpag = 0;
        double devuelta = 0;

        //Venta diaria
        int[] ventas = { 0, 0, 0, 0, 0, 0, 0, 0, 0};
        double totven = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncarta_Click(object sender, EventArgs e)
        {
            grbcarta.Visible = true;
            grbpedido.Visible = false;
            grbpago.Visible = false;
            grbventas.Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtcod.Text == string.Empty)
                {
                    MessageBox.Show("Se debe ingresar un código válido");
                }
                else
                {
                    int i = 0;
                    int sw = 0;
                    codped = int.Parse(txtcod.Text);
                    while (i < 8 && sw != 1)
                    {
                        if (codped == codigo[i])
                        {
                            sw = 1;
                            prod = i;
                        }
                        i++;
                    }
                    if (sw == 1)
                    {
                        pctproped.Visible = true;
                        lblproped.Visible = true;
                        lblgas.Visible = true;
                        cmbgas.Visible = true;
                        btnañad.Visible = true;
                        btnfin.Visible = true;
                        pctproped.Image = fotos[prod];
                        lblproped.Text = producto[prod];
                        productoped = producto[prod];
                        ventas[prod] = ventas[prod] + 1;
                        valorped = valorped + precio[prod];
                        subtotal = precio[prod];
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado es incorrecto", "Error");
                        txtcod.Text = "";
                        lblgas.Visible = false;
                        cmbgas.Visible = false;
                        btnañad.Visible = false;
                        btnfin.Visible = false;
                        pctproped.Visible = false;
                        lblproped.Visible = false;
                    }
                }
                
            }
        }

        private void btnañad_Click(object sender, EventArgs e)
        {
            if (cmbgas.Text == "Si")
            {
                valorped = valorped + 4000;
                subtotal = subtotal + 4000;
                gaseosa = "Si";
                ventas[8] = ventas[8] + 1;
            }
            else if (cmbgas.Text == string.Empty)
            {
                MessageBox.Show("No se selecciono ninguna opcion, no se añadirá gaseosa");
                gaseosa = "No";

            } else
            {
                
                gaseosa = "No";
            }
            dtgped.Rows.Add(productoped, gaseosa, subtotal);
            pctproped.Visible = false;
            lblproped.Visible = false;
            btnañad.Visible = false;
            btnfin.Visible = false;
            lblgas.Visible = false;
            cmbgas.Visible = false;
            cmbgas.Text = "";
            txtcod.Clear();
            txtcod.Focus();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            btncarta.Enabled = false;
            grbcarta.Visible = false;
            grbpedido.Visible = true;
            grbpago.Visible = false;
            grbventas.Visible = false;
            valorped = 0;
            dtgped.Rows.Clear();
            dtgped.Visible = false;
        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            dtgped.Visible = true;
            if (cmbgas.Text == "Si")
            {
                valorped = valorped + 4000;
                subtotal = subtotal + 4000;
                gaseosa = "Si";
            }
            else if (cmbgas.Text == string.Empty)
            {
                MessageBox.Show("No se selecciono ninguna opcion, no se añadirá gaseosa");
                gaseosa = "No";

            }
            else
            {
                gaseosa = "No";
            }
            dtgped.Rows.Add(productoped, gaseosa, subtotal);
            pctproped.Visible = false;
            lblproped.Visible = false;
            btnañad.Visible = false;
            btnfin.Visible = false;
            lblgas.Visible = false;
            cmbgas.Visible = false;
            cmbgas.Text = "";
            txtcod.Clear();
            MessageBox.Show("El valor total de tu pedido es: $" + valorped, "Total");
            grbpago.Visible = true;
            grbpedido.Visible = false;
            grbcarta.Visible = false;
            txttotal.Text = valorped.ToString();
        }

        private void btnpago_Click(object sender, EventArgs e)
        {
            if (txtpago.Text == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un valor pagado");
                txtpago.Focus();
            }
            else
            {
                valorpag = double.Parse(txtpago.Text);
                devuelta = valorpag - valorped;
                if (valorpag < valorped)
                {
                    MessageBox.Show("Valor pagado inválido", "Error");
                    txtpago.Clear();
                    txtpago.Focus();
                }
                else
                {
                    txtdev.Text = devuelta.ToString();
                    MessageBox.Show("El valor a devolver al usuario es: $" + devuelta);
                    grbcarta.Visible = false;
                    grbpago.Visible = false;
                    grbpedido.Visible = false;
                    txtpago.Clear();
                    txttotal.Clear();
                    txtdev.Clear();
                }
                button3.Enabled = true;
                btncarta.Enabled = true;
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grbcarta.Visible = false;
            grbpedido.Visible = false;
            grbpago.Visible = false;
            grbventas.Visible = true;
            btncarta.Enabled = false;
            btnpedido.Enabled = false;
            for (int i= 0; i <9; i++)
            {
                dtgventas.Rows.Add(producto[i], ventas[i], ventas[i] * precio[i]);
                totven = totven + (ventas[i] * precio[i]);
            }
            lbltotven.Text = "$" + totven.ToString();
            button3.Enabled = false;
        }
    }
}
