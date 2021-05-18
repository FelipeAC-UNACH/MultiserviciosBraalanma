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
    public partial class Herramientas : Form
    {
        Conexion bd = new Conexion();
        Consultas consulta = new Consultas();
        int pocicion;
        public Herramientas()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            try
            {
                consulta.actualizarHerramienta();
                dgvControlHerra.DataSource = consulta.datos;
                dgvControlHerra.DataMember = "Herramienta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Herramientas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreHerra.Text != "" & txtUsuario.Text != "" & cbArea.Text != "" & cbEstado.Text != "")
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("INSERT INTO Herramienta(NombreHerra, Usuario, Area, FechaEgreso, FechaIngreso, Estado) VALUES (@NombreHerra, @Usuario, @Area, @FechaEgreso, @FechaIngreso, @Estado)", bd.GetConexion());
                    sql.Parameters.AddWithValue("@NombreHerra", txtNombreHerra.Text);
                    sql.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    sql.Parameters.AddWithValue("@Area", cbArea.Text);
                    sql.Parameters.AddWithValue("@FechaEgreso", dtpFechaEgreso.Text);
                    sql.Parameters.AddWithValue("@FechaIngreso", dtpFechaIngreso.Text);
                    sql.Parameters.AddWithValue("@Estado", cbEstado.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente");
                    Actualizar();
                    txtIdHerramienta.Text = "";
                    txtUsuario.Text = "";
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
            if (txtNombreHerra.Text != "" & txtUsuario.Text != "" & cbArea.Text != "" & cbEstado.Text != "")
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("UPDATE Herramienta SET NombreHerra = @NombreHerra, Usuario = @Usuario, Area = @Area, FechaEgreso = @FechaEgreso, FechaIngreso = @FechaIngreso, Estado = @Estado WHERE IdHerramienta=@IdHerramienta", bd.GetConexion());
                    sql.Parameters.AddWithValue("@NombreHerra", txtNombreHerra.Text);
                    sql.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    sql.Parameters.AddWithValue("@Area", cbArea.Text);
                    sql.Parameters.AddWithValue("@FechaEgreso", dtpFechaEgreso.Text);
                    sql.Parameters.AddWithValue("@FechaIngreso", dtpFechaIngreso.Text);
                    sql.Parameters.AddWithValue("@Estado", cbEstado.Text);
                    sql.Parameters.AddWithValue("@IdHerramienta", txtIdHerramienta.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente");
                    Actualizar();
                    txtNombreHerra.Text = "";
                    txtUsuario.Text = "";
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
            try
            {

                MySqlCommand sql = new MySqlCommand("DELETE FROM Herramienta WHERE IdHerramienta=@IdHerramienta", bd.GetConexion());
                sql.Parameters.AddWithValue("@IdHerramienta", txtIdHerramienta.Text);
                sql.ExecuteNonQuery();
                MessageBox.Show("Datos eliminados correctamente");
                Actualizar();
                txtNombreHerra.Text = "";
                txtUsuario.Text = "";
                btnGuardar.Visible = true;
                btnActualizar.Visible = false;
                btnEliminar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void dgvControlHerra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pocicion = dgvControlHerra.CurrentRow.Index;
            txtIdHerramienta.Text = dgvControlHerra[0, pocicion].Value.ToString();
            txtNombreHerra.Text = dgvControlHerra[1, pocicion].Value.ToString();
            txtUsuario.Text = dgvControlHerra[2, pocicion].Value.ToString();
            cbArea.Text = dgvControlHerra[3, pocicion].Value.ToString();
            dtpFechaEgreso.Text = dgvControlHerra[4, pocicion].Value.ToString();
            dtpFechaIngreso.Text = dgvControlHerra[5, pocicion].Value.ToString();
            cbEstado.Text = dgvControlHerra[6, pocicion].Value.ToString();
            btnGuardar.Visible = false;
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
        }

    }
}
