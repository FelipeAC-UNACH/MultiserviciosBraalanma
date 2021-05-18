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
    public partial class VentaCredito : Form
    {
        Conexion bd = new Conexion();
        Consultas consulta = new Consultas();
        int bandera, pocicion;
        public VentaCredito()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("UPDATE VentadeCreditop SET Nombrec=@Nombrec, Correoc=@Correoc, Telefonoc=@Telefonoc, Direccionc=@DireccionC, Idproducto=@idproducto, Abono=@Abono, Fecha_Abono=@Abono_Fecha WHERE IdVentadeCreditop=@Idventa", bd.GetConexion());
                    sql.Parameters.AddWithValue("@Nombrec", txtNomCliente.Text);
                    sql.Parameters.AddWithValue("@Correoc", txtCorreo.Text);
                    sql.Parameters.AddWithValue("@Telefonoc", txtNumTel.Text);
                    sql.Parameters.AddWithValue("@Direccionc", txtDireccion.Text);
                    sql.Parameters.AddWithValue("@idproducto", txtClaveCreditoID.Text);
                    sql.Parameters.AddWithValue("@Abono", txtAbono.Text);
                    sql.Parameters.AddWithValue("@Abono_Fecha", dtpFechaAbono.Text);
                    sql.Parameters.AddWithValue("@Idventa", txtControlClave.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente");
                    consulta.muestraVentaCreditProdTodo();
                    dgvMuestraVentaCredit.DataSource = consulta.datos;
                    dgvMuestraVentaCredit.DataMember = "VentadeCreditoP, Producto";
                    btnGuardar.Visible = true;
                    btnActualizar.Visible = false;
                    btnEliminar.Visible = false;
                    bandera = 1;
                    limpia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {

                    MySqlCommand sql = new MySqlCommand("UPDATE VentadeCreditoS SET Nombrec=@Nombrec, Correoc=@Correoc, Telefonoc=@Telefonoc, Direccionc=@DireccionC, Idservicio=@idservicio, Precio=@Precio, Abono=@Abono, Fecha_Abono=@Abono_Fecha WHERE IdVentadeCreditoS=@Idventa", bd.GetConexion());
                    sql.Parameters.AddWithValue("@Nombrec", txtNomCliente.Text);
                    sql.Parameters.AddWithValue("@Correoc", txtCorreo.Text);
                    sql.Parameters.AddWithValue("@Telefonoc", txtNumTel.Text);
                    sql.Parameters.AddWithValue("@Direccionc", txtDireccion.Text);
                    sql.Parameters.AddWithValue("@idservicio", txtClaveCreditoID.Text);
                    sql.Parameters.AddWithValue("@Precio", txtPrecioTotal.Text);
                    sql.Parameters.AddWithValue("@Abono", txtAbono.Text);
                    sql.Parameters.AddWithValue("@Abono_Fecha", dtpFechaAbono.Text);
                    sql.Parameters.AddWithValue("@Idventa", txtControlClave.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente");
                    consulta.muestraVentaCreditServTodo();
                    dgvMuestraVentaCredit.DataSource = consulta.datos;
                    dgvMuestraVentaCredit.DataMember = "VentadeCreditoS, Servicio";
                    btnGuardar.Visible = true;
                    btnActualizar.Visible = false;
                    btnEliminar.Visible = false;
                    bandera = 2;
                    limpia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnProdCredTodos_Click(object sender, EventArgs e)
        {
            try
            {
                consulta.muestraVentaCreditProdTodo();
                dgvMuestraVentaCredit.DataSource = consulta.datos;
                dgvMuestraVentaCredit.DataMember = "VentadeCreditoP, Producto";
                bandera = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnServCredTodos_Click(object sender, EventArgs e)
        {
            try
            {
                consulta.muestraVentaCreditServTodo();
                dgvMuestraVentaCredit.DataSource = consulta.datos;
                dgvMuestraVentaCredit.DataMember = "VentadeCreditoS, Servicio";
                bandera = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscarProdServID_Click(object sender, EventArgs e)
        {
            if (cbTipoPedidoID.Text == "Producto")
            {
                try
                {
                    consulta.buscarVentaCreditProdID(txtClaveCreditoID.Text);
                    dgvMuestraVentaCredit.DataSource = consulta.datos;
                    dgvMuestraVentaCredit.DataMember = "VentadeCreditoP, Producto";
                    bandera = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    consulta.buscarVentaCreditServID(txtClaveCreditoID.Text);
                    dgvMuestraVentaCredit.DataSource = consulta.datos;
                    dgvMuestraVentaCredit.DataMember = "VentadeCreditoS, Servicio";
                    bandera = 2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Producto")
            {
                lblPrecioTotal.Visible = false;
                txtPrecioTotal.Visible = false;
                consulta.muestraProducto();
                dgvProducServi.DataSource = consulta.datos;
                dgvProducServi.DataMember = "Producto";
                bandera = 1;
            }
            else
            {
                lblPrecioTotal.Visible = true;
                txtPrecioTotal.Visible = true;
                consulta.muestraServicio();
                dgvProducServi.DataSource = consulta.datos;
                dgvProducServi.DataMember = "Servicio";
                bandera = 2;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNomCliente.Text != "" & txtCorreo.Text != "" & txtNumTel.Text != "" & txtDireccion.Text != "" & txtClaveCreditoID.Text != "")
            {
                if (cbTipo.Text == "Producto")
                {
                    try
                    {
                        MySqlCommand sql = new MySqlCommand("INSERT INTO VentadeCreditoP(Nombrec, Correoc, Telefonoc, Direccionc, Idproducto, Abono, Fecha_Abono) VALUES (@Nombrec, @Correoc, @Telefonoc, @Direccionc, @Idproducto, @Abono, @Fecha_Abono)", bd.GetConexion());
                        sql.Parameters.AddWithValue("@Nombrec", txtNomCliente.Text);
                        sql.Parameters.AddWithValue("@Correoc", txtCorreo.Text);
                        sql.Parameters.AddWithValue("@Telefonoc", txtNumTel.Text);
                        sql.Parameters.AddWithValue("@Direccionc", txtDireccion.Text);
                        sql.Parameters.AddWithValue("@Idproducto", txtClaveCreditoID.Text);
                        sql.Parameters.AddWithValue("@Abono", txtAbono.Text);
                        sql.Parameters.AddWithValue("@Fecha_Abono", dtpFechaAbono.Text);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Datos guardados correctamente");
                        consulta.muestraVentaCreditProdTodo();
                        dgvMuestraVentaCredit.DataSource = consulta.datos;
                        dgvMuestraVentaCredit.DataMember = "VentadeCreditoP, Producto";
                        bandera = 1;
                        limpia();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        MySqlCommand sql = new MySqlCommand("INSERT INTO VentadeCreditoS(Nombrec, Correoc, Telefonoc, Direccionc, Idservicio, Precio, Abono, Fecha_Abono) VALUES (@Nombrec, @Correoc, @Telefonoc, @Direccionc, @Idservicio, @Precio, @Abono, @Fecha_Abono)", bd.GetConexion());
                        sql.Parameters.AddWithValue("@Nombrec", txtNomCliente.Text);
                        sql.Parameters.AddWithValue("@Correoc", txtCorreo.Text);
                        sql.Parameters.AddWithValue("@Telefonoc", txtNumTel.Text);
                        sql.Parameters.AddWithValue("@Direccionc", txtDireccion.Text);
                        sql.Parameters.AddWithValue("@Idservicio", txtClaveCreditoID.Text);
                        sql.Parameters.AddWithValue("@Precio", txtPrecioTotal.Text);
                        sql.Parameters.AddWithValue("@Abono", txtAbono.Text);
                        sql.Parameters.AddWithValue("@Fecha_Abono", dtpFechaAbono.Text);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Datos guardados correctamente");
                        consulta.muestraVentaCreditServTodo();
                        dgvMuestraVentaCredit.DataSource = consulta.datos;
                        dgvMuestraVentaCredit.DataMember = "VentadeCreditoS, Servicio";
                        bandera = 2;
                        limpia();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dgvProducServi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pocicion = dgvProducServi.CurrentRow.Index;
            txtClaveCreditoID.Text = dgvProducServi[0, pocicion].Value.ToString();
        }

        private void dgvMuestraVentaCredit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pocicion = dgvMuestraVentaCredit.CurrentRow.Index;
            if (bandera == 2)
            {
                cbTipo.Text = "Servicio";
                txtControlClave.Text = dgvMuestraVentaCredit[0, pocicion].Value.ToString();
                txtNomCliente.Text = dgvMuestraVentaCredit[1, pocicion].Value.ToString();
                txtCorreo.Text = dgvMuestraVentaCredit[2, pocicion].Value.ToString();
                txtNumTel.Text = dgvMuestraVentaCredit[3, pocicion].Value.ToString();
                txtDireccion.Text = dgvMuestraVentaCredit[4, pocicion].Value.ToString();
                txtIdControlCredito.Text= dgvMuestraVentaCredit[5, pocicion].Value.ToString();
                txtPrecioTotal.Text = dgvMuestraVentaCredit[6, pocicion].Value.ToString();
                txtAbono.Text= dgvMuestraVentaCredit[7, pocicion].Value.ToString();
                consulta.muestraServicio();
                dgvProducServi.DataSource = consulta.datos;
                dgvProducServi.DataMember = "Servicio";
                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
                btnEliminar.Visible = true;
                bandera = 2;
            }
            else
            {
                cbTipo.Text = "Producto";
                txtControlClave.Text = dgvMuestraVentaCredit[0, pocicion].Value.ToString();
                txtNomCliente.Text = dgvMuestraVentaCredit[1, pocicion].Value.ToString();
                txtCorreo.Text = dgvMuestraVentaCredit[2, pocicion].Value.ToString();
                txtNumTel.Text = dgvMuestraVentaCredit[3, pocicion].Value.ToString();
                txtDireccion.Text = dgvMuestraVentaCredit[4, pocicion].Value.ToString();
                txtIdControlCredito.Text = dgvMuestraVentaCredit[5, pocicion].Value.ToString();
                txtAbono.Text = dgvMuestraVentaCredit[6, pocicion].Value.ToString();
                consulta.muestraProducto();
                dgvProducServi.DataSource = consulta.datos;
                dgvProducServi.DataMember = "Producto";
                btnGuardar.Visible = false;
                btnActualizar.Visible = true;
                btnEliminar.Visible = true;
                bandera = 1;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("DELETE FROM VentadeCreditop WHERE IdVentadeCreditoP=@Idpedido", bd.GetConexion());
                    sql.Parameters.AddWithValue("@Idpedido", txtControlClave.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados correctamente");
                    consulta.muestraVentaCreditProdTodo();
                    dgvMuestraVentaCredit.DataSource = consulta.datos;
                    dgvMuestraVentaCredit.DataMember = "VentadeCreditoP, Producto";
                    btnGuardar.Visible = true;
                    btnActualizar.Visible = false;
                    btnEliminar.Visible = false;
                    bandera = 1;
                    limpia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("DELETE FROM VentadeCreditoS WHERE IdVentadeCreditoS=@Idpedido", bd.GetConexion());
                    sql.Parameters.AddWithValue("@Idpedido", txtControlClave.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados correctamente");
                    consulta.muestraVentaCreditServTodo();
                    dgvMuestraVentaCredit.DataSource = consulta.datos;
                    dgvMuestraVentaCredit.DataMember = "VentadeCreditoS, Servicio";
                    btnGuardar.Visible = true;
                    btnActualizar.Visible = false;
                    btnEliminar.Visible = false;
                    bandera = 2;
                    limpia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public void limpia()
        {
            txtNomCliente.Clear();
            txtCorreo.Clear();
            txtNumTel.Clear();
            txtDireccion.Clear();
            txtAbono.Clear();
            txtPrecioTotal.Clear();
            txtControlClave.Clear();
            txtIdControlCredito.Clear();
            txtClaveCreditoID.Clear();
        }
    }
}
