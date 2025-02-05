namespace Proyecto
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipos equipos = new Equipos();
            equipos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.Show();
            this.Hide();
        }
    }
}
