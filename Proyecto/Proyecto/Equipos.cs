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
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtMarca.Text == "" || txtMod.Text == "" || txtCamP.Text == "" || txtCamF.Text == "" || cmbMemIn.Text == "" || cmbMemRam.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Rellenar todos los datos requeridos", "Error");
            }
            else
            {
                try
                {
                    int id_producto = int.Parse(txtId.Text);
                    string marca = txtMarca.Text;
                    string modelo = txtMod.Text;
                    string campr = txtCamP.Text;
                    string camfro = txtCamF.Text;
                    string memint = cmbMemIn.Text;
                    string memram = cmbMemRam.Text;
                    double precio = double.Parse(txtPrecio.Text);
                    int stock = int.Parse(txtStock.Text);

                    string sql = "INSERT INTO productos (id_producto, marca, modelo, camara_pr, camara_fro, memoria_in, memoria_ram, precio, stock) VALUES ('" + id_producto + "', '" + marca + "', '" + modelo + "','" + campr + "','" + camfro + "','" + memint + "','" + memram + "','" + precio + "','" + stock + "')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Producto agregado");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al agregar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                        rellenar();
                        limpiar();
                    }
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Datos incorrectos: " + fex.Message);
                }
            }
        }

        private void rellenar()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            string consulta = "SELECT * FROM productos";
            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexionBD);
            MySqlCommandBuilder comando = new MySqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dtgProd.DataSource = ds.Tables[0];
            conexionBD.Close();
        }

        private void limpiar()
        {
            txtId.Text = "";
            txtMarca.Text = "";
            txtMod.Text = "";
            txtCamP.Text = "";
            txtCamF.Text = "";
            cmbMemIn.Text = "";
            cmbMemRam.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            rellenar();
        }

        private void dtgProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgProd.SelectedRows[0].Cells[0].Value.ToString();
            txtMarca.Text = dtgProd.SelectedRows[0].Cells[1].Value.ToString();
            txtMod.Text = dtgProd.SelectedRows[0].Cells[2].Value.ToString();
            txtCamP.Text = dtgProd.SelectedRows[0].Cells[3].Value.ToString();
            txtCamF.Text = dtgProd.SelectedRows[0].Cells[4].Value.ToString();
            cmbMemIn.SelectedItem = dtgProd.SelectedRows[0].Cells[5].Value.ToString();
            cmbMemRam.SelectedItem = dtgProd.SelectedRows[0].Cells[6].Value.ToString();
            txtPrecio.Text = dtgProd.SelectedRows[0].Cells[7].Value.ToString();
            txtStock.Text = dtgProd.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Seleccione el producto a eliminar", "Error");
            }
            else
            {
                string sql = "DELETE FROM productos WHERE id_producto=" + txtId.Text + "";

                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Producto eliminado");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                    rellenar();
                    limpiar();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtMarca.Text == "" || txtMod.Text == "" || txtCamP.Text == "" || txtCamF.Text == "" || cmbMemIn.Text == "" || cmbMemRam.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
            {
                MessageBox.Show("Rellenar todos los datos requeridos", "Error");
            }
            else
            {
                try
                {
                    int id_producto = int.Parse(txtId.Text);
                    string marca = txtMarca.Text;
                    string modelo = txtMod.Text;
                    string campr = txtCamP.Text;
                    string camfro = txtCamF.Text;
                    string memint = cmbMemIn.Text;
                    string memram = cmbMemRam.Text;
                    double precio = double.Parse(txtPrecio.Text);
                    int stock = int.Parse(txtStock.Text);

                    string sql = "UPDATE productos SET marca='" + marca + "', modelo='" + modelo + "', camara_pr='" + campr + "', camara_fro='" + camfro + "', memoria_in='" + memint + "', memoria_ram='" + memram + "', precio='" + precio + "', stock='" + stock + "' WHERE id_producto='" + id_producto + "'";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Producto actualizado");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al actualizar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                        rellenar();
                        limpiar();
                    }
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Datos incorrectos: " + fex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();            
            this.Hide();
        }
    }
}
