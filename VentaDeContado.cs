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
    public partial class VentaDeContado : Form
    {
        Conexion bd = new Conexion();
        Consultas consulta = new Consultas();
        public int bandera=1;
        int pocicion;
        public VentaDeContado()
        {
            InitializeComponent();
        }

        
        private void VentaDeContado_Load(object sender, EventArgs e)
        {
          
        }

        private void btnPedidosProdTodos_Click(object sender, EventArgs e)
        {
            try
            {
                consulta.pedidosProductosTodos();
                dgvMuestraPedidoID.DataSource = consulta.datos;
                dgvMuestraPedidoID.DataMember = "Pedidoproducto, Producto";
                bandera = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPedidosServTodos_Click(object sender, EventArgs e)
        {
            try
            {
                consulta.pedidosServiciosTodos();
                dgvMuestraPedidoID.DataSource = consulta.datos;
                dgvMuestraPedidoID.DataMember = "Pedidoservicio, Servicio";
                bandera = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void btnBuscarProdServID_Click(object sender, EventArgs e)
        {
            if (cbTipoPedidoID.Text == "Producto")
            {
                try
                {
                    consulta.buscarProductoID(txtClavePedidoID.Text);
                    dgvMuestraPedidoID.DataSource = consulta.datos;
                    dgvMuestraPedidoID.DataMember = "PedidoProducto, Producto";
                    lblPrecioID.Visible = false;
                    txtPrecioServicioID.Visible = false;
                    btnActualizarPrecioID.Visible = false;
                    btnBuscarProdServID.Visible = true;
                    lblCantidad.Visible = true;
                    txtCantidad.Visible = true;
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
                    consulta.buscarServicioID(txtClavePedidoID.Text);
                    dgvMuestraPedidoID.DataSource = consulta.datos;
                    dgvMuestraPedidoID.DataMember = "PedidoServicio, Servicio";
                    lblPrecioID.Visible=true;
                    txtPrecioServicioID.Visible=true;
                    btnActualizarPrecioID.Visible = true;
                    btnBuscarProdServID.Visible = false;
                    lblCantidad.Visible = false;
                    txtCantidad.Visible = true;
                    bandera = 2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnActualizarPrecioID_Click(object sender, EventArgs e)
        {
            try
            {
                consulta.actualizarPrecioServicio(txtPrecioServicioID.Text, txtClavePedidoID.Text);
                consulta.buscarServicioID(txtClavePedidoID.Text);
                dgvMuestraPedidoID.DataSource = consulta.datos;
                dgvMuestraPedidoID.DataMember = "PedidoServicio, Servicio";
                MessageBox.Show("Se ha agregado el precio del servicio correctamente");
                lblPrecioID.Visible = false;
                txtPrecioServicioID.Visible = false;
                btnActualizarPrecioID.Visible = false;
                btnBuscarProdServID.Visible = true;
                bandera = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.Text == "Producto")
            {
                lblPrecio.Visible = false;
                txtPrecio.Visible = false;
                lblCantidad.Visible = true;
                txtCantidad.Visible = true;
                consulta.muestraProducto();
                dgvProducServi.DataSource = consulta.datos;
                dgvProducServi.DataMember = "Producto";
                bandera = 1;
            }
            else
            {
                lblPrecio.Visible = true;
                txtPrecio.Visible = true;
                lblCantidad.Visible = false;
                txtCantidad.Visible = false;
                consulta.muestraServicio();
                dgvProducServi.DataSource = consulta.datos;
                dgvProducServi.DataMember = "Servicio";
                bandera = 2;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNomCliente.Text != "" & txtCorreo.Text != "" & txtNumTel.Text != "" & txtDireccion.Text != "" & txtIdControlPedido.Text !="")
            {
                if (cbTipo.Text == "Producto")
                {
                    try
                    {
                        MySqlCommand sql = new MySqlCommand("INSERT INTO PedidoProducto(Nombrec, Correoc, Telefonoc, Direccionc, IdProducto, Cantidad) VALUES (@Nombrec, @Correoc, @Telefonoc, @Direccionc, @IdProducto, @Cantidad)", bd.GetConexion());
                        sql.Parameters.AddWithValue("@Nombrec", txtNomCliente.Text);
                        sql.Parameters.AddWithValue("@Correoc", txtCorreo.Text);
                        sql.Parameters.AddWithValue("@Telefonoc", txtNumTel.Text);
                        sql.Parameters.AddWithValue("@Direccionc", txtDireccion.Text);
                        sql.Parameters.AddWithValue("@IdProducto", txtIdControlPedido.Text);
                        sql.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Datos guardados correctamente");
                        consulta.pedidosProductosTodos();
                        dgvMuestraPedidoID.DataSource = consulta.datos;
                        dgvMuestraPedidoID.DataMember = "Pedidoproducto, Producto";
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
                        MySqlCommand sql = new MySqlCommand("INSERT INTO PedidoServicio(Nombrec, Correoc, Telefonoc, Direccionc, Precio, Idservicio) VALUES (@Nombrec, @Correoc, @Telefonoc, @Direccionc, @Precio, @Idservicio)", bd.GetConexion());
                        sql.Parameters.AddWithValue("@Nombrec", txtNomCliente.Text);
                        sql.Parameters.AddWithValue("@Correoc", txtCorreo.Text);
                        sql.Parameters.AddWithValue("@Telefonoc", txtNumTel.Text);
                        sql.Parameters.AddWithValue("@Direccionc", txtDireccion.Text);
                        sql.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                        sql.Parameters.AddWithValue("@Idservicio", txtIdControlPedido.Text);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Datos guardados correctamente");
                        consulta.pedidosServiciosTodos();
                        dgvMuestraPedidoID.DataSource = consulta.datos;
                        dgvMuestraPedidoID.DataMember = "PedidoServicio, Servicio";
                        bandera = 2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor");
            }
        }

        private void dgvProducServi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pocicion = dgvProducServi.CurrentRow.Index;
            txtIdControlPedido.Text = dgvProducServi[0, pocicion].Value.ToString();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (bandera == 1)
            {
                try
                {
                   
                    MySqlCommand sql = new MySqlCommand("UPDATE Pedidoproducto SET Nombrec=@Nombrec, Correoc=@Correoc, Telefonoc=@Telefonoc, Direccionc=@DireccionC, Idproducto=@idproducto, Cantidad=@Cantidad WHERE Idpedido=@Idpedido", bd.GetConexion());
                    sql.Parameters.AddWithValue("@Nombrec", txtNomCliente.Text);
                    sql.Parameters.AddWithValue("@Correoc", txtCorreo.Text);
                    sql.Parameters.AddWithValue("@Telefonoc", txtNumTel.Text);
                    sql.Parameters.AddWithValue("@Direccionc", txtDireccion.Text);
                    sql.Parameters.AddWithValue("@Idproducto", txtIdControlPedido.Text);
                    sql.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
                    sql.Parameters.AddWithValue("@Idpedido", txtControlClave.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente");
                    consulta.pedidosProductosTodos();
                    dgvMuestraPedidoID.DataSource = consulta.datos;
                    dgvMuestraPedidoID.DataMember = "Pedidoproducto, Producto";
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
                    
                    MySqlCommand sql = new MySqlCommand("UPDATE Pedidoservicio SET Nombrec=@Nombrec, Correoc=@Correoc, Telefonoc=@Telefonoc, Direccionc=@DireccionC, Precio=@Precio, Idservicio=@Idservicio WHERE IdPedido=@Idpedido", bd.GetConexion());
                    sql.Parameters.AddWithValue("@Nombrec", txtNomCliente.Text);
                    sql.Parameters.AddWithValue("@Correoc", txtCorreo.Text);
                    sql.Parameters.AddWithValue("@Telefonoc", txtNumTel.Text);
                    sql.Parameters.AddWithValue("@Direccionc", txtDireccion.Text);
                    sql.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                    sql.Parameters.AddWithValue("@Idservicio", txtIdControlPedido.Text);
                    sql.Parameters.AddWithValue("@Idpedido", txtControlClave.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos actualizados correctamente");
                    consulta.pedidosServiciosTodos();
                    dgvMuestraPedidoID.DataSource = consulta.datos;
                    dgvMuestraPedidoID.DataMember = "PedidoServicio, Servicio";
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
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtControlClave.Clear();
            txtIdControlPedido.Clear();
        }
        private void dgvMuestraPedidoID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pocicion = dgvMuestraPedidoID.CurrentRow.Index;
            if (bandera == 2)
            {
                cbTipo.Text = "Servicio";
                lblCantidad.Visible = false;
                txtCantidad.Visible = false;
                txtControlClave.Text = dgvMuestraPedidoID[0, pocicion].Value.ToString();
                txtNomCliente.Text = dgvMuestraPedidoID[1, pocicion].Value.ToString();
                txtCorreo.Text = dgvMuestraPedidoID[2, pocicion].Value.ToString();
                txtNumTel.Text = dgvMuestraPedidoID[3, pocicion].Value.ToString();
                txtDireccion.Text = dgvMuestraPedidoID[4, pocicion].Value.ToString();
                txtPrecio.Text = dgvMuestraPedidoID[5, pocicion].Value.ToString();
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
                lblCantidad.Visible = true;
                txtCantidad.Visible = true;
                txtControlClave.Text = dgvMuestraPedidoID[0, pocicion].Value.ToString();
                txtNomCliente.Text = dgvMuestraPedidoID[1, pocicion].Value.ToString();
                txtCorreo.Text = dgvMuestraPedidoID[2, pocicion].Value.ToString();
                txtNumTel.Text = dgvMuestraPedidoID[3, pocicion].Value.ToString();
                txtDireccion.Text = dgvMuestraPedidoID[4, pocicion].Value.ToString();
                txtIdControlPedido.Text = dgvMuestraPedidoID[5, pocicion].Value.ToString();
                txtCantidad.Text = dgvMuestraPedidoID[6, pocicion].Value.ToString();
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
                    MySqlCommand sql = new MySqlCommand("DELETE FROM Pedidoproducto WHERE Idpedido=@Idpedido", bd.GetConexion());
                    sql.Parameters.AddWithValue("@Idpedido", txtControlClave.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados correctamente");
                    consulta.pedidosProductosTodos();
                    dgvMuestraPedidoID.DataSource = consulta.datos;
                    dgvMuestraPedidoID.DataMember = "Pedidoproducto, Producto";
                    btnGuardar.Visible = true;
                    btnActualizar.Visible = false;
                    btnEliminar.Visible = false;
                    bandera = 1;
                    limpia();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand("DELETE FROM Pedidoservicio WHERE Idpedido=@Idpedido", bd.GetConexion());
                    sql.Parameters.AddWithValue("@Idpedido", txtControlClave.Text);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados correctamente");
                    consulta.pedidosServiciosTodos();
                    dgvMuestraPedidoID.DataSource = consulta.datos;
                    dgvMuestraPedidoID.DataMember = "Pedidoservicio, Servicio";
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
            
        }
    }
}
