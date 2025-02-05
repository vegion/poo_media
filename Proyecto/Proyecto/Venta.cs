using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Venta : Form
    {
        int n = 0;
        int valorTotal = 0;
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            rellenarProd();
            contar();
        }

        
        private void rellenarProd()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            string consulta = "SELECT marca, modelo, precio, stock FROM productos";
            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexionBD);
            MySqlCommandBuilder comando = new MySqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dtgProDis.DataSource = ds.Tables[0];
            conexionBD.Close();
        }

        private void contar()
        {
            string consulta = "SELECT COUNT(id_factura) from ventas";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexionBD);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lblVentas.Text = dt.Rows[0][0].ToString();
            conexionBD.Close();
        }

        private void dtgProDis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdu.Text = dtgProDis.SelectedRows[0].Cells[0].Value.ToString() + " " + dtgProDis.SelectedRows[0].Cells[1].Value.ToString();
            txtPrecioP.Text = dtgProDis.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (txtPrecioP.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Ingresar todos los datos", "Error");
            }
            else if (int.Parse(txtCantidad.Text) > int.Parse(dtgProDis.CurrentRow.Cells[3].Value.ToString()))
            {
                MessageBox.Show("Cantidad ingresada mayor al stock disponible del producto", "Error");
            }
            else
            {
                int total = Convert.ToInt32(txtPrecioP.Text) * Convert.ToInt32(txtCantidad.Text);
                dtgFactura.Rows.Add((n + 1), txtProdu.Text, txtPrecioP.Text, txtCantidad.Text, total);
                n++;
                valorTotal = valorTotal + total;
                lbltotal.Text = valorTotal.ToString();
                btnRegresar.Enabled = false;

                int stockAct = int.Parse(dtgProDis.CurrentRow.Cells[3].Value.ToString());
                int nuevoStock = stockAct - int.Parse(txtCantidad.Text);

                string sql = "UPDATE productos SET stock='" + nuevoStock + "' WHERE marca='" + dtgProDis.CurrentRow.Cells[0].Value.ToString() + "'";

                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado a la venta");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al agregar producto: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                    rellenarProd();

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFactura.Text == "" || txtCliente.Text == "")
            {
                MessageBox.Show("Rellenar todos los datos requeridos", "Error");
            }
            else
            {
                try
                {
                    int id_factura = int.Parse(txtFactura.Text);
                    string nombre = txtCliente.Text;
                    int valorPagado = int.Parse(lbltotal.Text);

                    string sql = "INSERT INTO ventas (id_factura, cliente, valor) VALUES ('" + id_factura + "', '" + nombre + "', '" + valorPagado + "')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Venta generada");
                        dtgFactura.Rows.Clear();
                        dtgFactura.Refresh();
                        btnRegresar.Enabled = true;
                        txtFactura.Text = "";
                        txtCliente.Text = "";
                        txtProdu.Text = "";
                        txtPrecioP.Text = "";
                        txtCantidad.Text = "";
                        valorTotal = 0;
                        lbltotal.Text = valorTotal.ToString();
                        contar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al ingresar venta: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();                       
                        
                    }
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Datos incorrectos: " + fex.Message);
                }
            }
        }
    }
}
