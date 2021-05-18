using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SCMB
{
    public partial class GastosIndirectos : Form
    {
        Consultas consulta = new Consultas();
        Conexion bd = new Conexion();
        int pocicion;
        public GastosIndirectos()
        {
            InitializeComponent();
        }
        public void limpia()
        {
            txtIdControl.Text = "";
            txtCantidad.Text = "";
            txtNombreGasto.Text = "";
        }
        private void GastosIndirectos_Load(object sender, EventArgs e)
        {
            try
            {
                consulta.muestraGastoIndirecto();
                dgvGastoIndirecto.DataSource = consulta.datos;
                dgvGastoIndirecto.DataMember = "GastoIndirecto";
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreGasto.Text != "" & txtCantidad.Text !="")           
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("INSERT INTO GastoIndirecto(NombreGasto, Cantidad, Fecha) VALUE(@NombreGasto, @Cantidad, @Fecha)",bd.GetConexion());
                    sql.Parameters.AddWithValue("@NombreGasto", txtNombreGasto.Text);
                    sql.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                    sql.Parameters.AddWithValue("@Fecha", dtpFecha.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente");
                    consulta.muestraGastoIndirecto();
                    dgvGastoIndirecto.DataSource = consulta.datos;
                    dgvGastoIndirecto.DataMember = "GastoIndirecto";
                    limpia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombreGasto.Text != "" & txtCantidad.Text != "" & txtIdControl.Text != "")
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("UPDATE GastoIndirecto SET NombreGasto = @NombreGasto, Cantidad = @Cantidad, Fecha = @Fecha WHERE IdGastoIndirecto=@IdGastoIndirecto", bd.GetConexion());
                    sql.Parameters.AddWithValue("@NombreGasto", txtNombreGasto.Text);
                    sql.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                    sql.Parameters.AddWithValue("@Fecha", dtpFecha.Text);
                    sql.Parameters.AddWithValue("@IdGastoIndirecto", txtIdControl.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente");
                    consulta.muestraGastoIndirecto();
                    dgvGastoIndirecto.DataSource = consulta.datos;
                    dgvGastoIndirecto.DataMember = "GastoIndirecto";
                    limpia();
                    btnGuardar.Visible = true;
                    btnActualizar.Visible = false;
                    btnEliminar.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreGasto.Text != "" & txtCantidad.Text != "" & txtIdControl.Text != "")
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("DELETE FROM GastoIndirecto WHERE IdGastoIndirecto=@IdGastoIndirecto", bd.GetConexion());
                    sql.Parameters.AddWithValue("@IdGastoIndirecto", txtIdControl.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados correctamente");
                    consulta.muestraGastoIndirecto();
                    dgvGastoIndirecto.DataSource = consulta.datos;
                    dgvGastoIndirecto.DataMember = "GastoIndirecto";
                    limpia();
                    btnGuardar.Visible = true;
                    btnActualizar.Visible = false;
                    btnEliminar.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor");
            }
        }

        private void dgvGastoIndirecto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pocicion = dgvGastoIndirecto.CurrentRow.Index;
            txtIdControl.Text = dgvGastoIndirecto[0, pocicion].Value.ToString();
            txtNombreGasto.Text = dgvGastoIndirecto[1, pocicion].Value.ToString();
            txtCantidad.Text = dgvGastoIndirecto[2, pocicion].Value.ToString();
            btnGuardar.Visible = false;
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
        }
    }
}
