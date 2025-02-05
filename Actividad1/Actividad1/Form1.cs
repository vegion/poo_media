using System;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        int doc = 0;
        string nombre = "";
        string puesto = "";
        double horastra = 0;
        double salariodia = 0;
        double valorhora = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            DateTime time = new DateTime();
            valorhora = 1300000 / 240;
            if (txtdoc.Text == string.Empty || txtnom.Text == string.Empty || txthe.Text == string.Empty ||
                cmbpuesto.Text == string.Empty || txths.Text == string.Empty)
            {
                MessageBox.Show("Faltan Datos", "ERROR");
                txtdoc.Clear();
                txtnom.Clear();
                cmbpuesto.Text = "";
                txthe.Clear();
                txths.Clear();
                txtht.Clear();
                txtnom.Focus();
            }
            else
            {
                doc = int.Parse(txtdoc.Text);
                nombre = txtnom.Text;
                puesto = cmbpuesto.Text;
                DateTime horaent = DateTime.Parse(txthe.Text);
                DateTime horasal = DateTime.Parse(txths.Text);
                TimeSpan horas = horasal - horaent;
                horastra = horas.TotalHours;
                horastra = Math.Round(horastra, 2);
                salariodia = horastra * valorhora;
                salariodia = Math.Round(salariodia, 2);
                txtht.Text = horastra.ToString();
                dtgsalario.Rows.Add(doc, nombre, puesto, horaent, horasal, horastra, salariodia);
                /*txtdoc.Clear();
                txtnom.Clear();
                cmbpuesto.Text = "";
                txthe.Clear();
                txths.Clear();
                txtht.Clear();
                txtnom.Focus();*/
            }
        }

        private void dtgsalario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
