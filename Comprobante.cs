using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCMB
{
    public partial class Comprobante : Form
    {
        int bandera, pocicion;
        Conexion bd = new Conexion();
        Consultas consulta = new Consultas();
        public Comprobante()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                if (cbTipo.Text == "Producto")
                {
                    consulta.pedidosProductosTodos();
                    dgvPrducServ.DataSource = consulta.datos;
                    dgvPrducServ.DataMember = "Pedidoproducto, Producto";
                    bandera = 1;
                }
                else
                {
                    consulta.pedidosServiciosTodos();
                    dgvPrducServ.DataSource = consulta.datos;
                    dgvPrducServ.DataMember = "Pedidoservicio, Servicio";
                    bandera = 2;
                }
            
            
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (txtEfectivo.Text != "")
            {
                txtCambio.Text = Convert.ToString(Convert.ToInt32(txtEfectivo.Text) - Convert.ToInt32(txtTotalAPagar.Text));
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Factura.CreaTicket Ticket1 = new Factura.CreaTicket();

            Ticket1.TextoCentro("Empresa MultiserVicios Braalanma "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda("Dirección: Tuxtla Gutiérrez");
            Ticket1.TextoIzquierda("Teléfono: 961-524-8639");
            Ticket1.TextoIzquierda("RFC: AOCF990315LF1");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 0120102");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: Alexander Pérez Hernández");
            Ticket1.TextoIzquierda("");
            Factura.CreaTicket.LineasGuion();

            Factura.CreaTicket.EncabezadoVenta();
            Factura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            string v = Factura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(txtTotalAPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtCambio.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

        }


        private void dgvPrducServ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (bandera == 1)
            {
                
                pocicion = dgvPrducServ.CurrentRow.Index;
                txtCodigo.Text = dgvPrducServ[0, pocicion].Value.ToString();
                txtCantidad.Text = dgvPrducServ[6, pocicion].Value.ToString();
                txtProdServ.Text = dgvPrducServ[8, pocicion].Value.ToString();
                txtPrecio.Text = dgvPrducServ[9, pocicion].Value.ToString(); bandera = 1;
                txtTotalAPagar.Text = Convert.ToString(Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text));
                //for(int i=0; i < contador; i++)
                //{
                //   costot = float.Parse(dgvResultado.Rows[i].Cells[4].Value.ToString());
                //}
                DataGridViewRow file = new DataGridViewRow();
                file.CreateCells(dgvLista);
                file.Cells[0].Value = txtCodigo.Text;
                file.Cells[1].Value = txtProdServ.Text;
                file.Cells[2].Value = txtPrecio.Text;
                file.Cells[3].Value = txtCantidad.Text;
                file.Cells[4].Value = txtTotalAPagar.Text;
                dgvLista.Rows.Add(file); bandera = 1;
            }
            else
            {
                pocicion = dgvPrducServ.CurrentRow.Index;
                txtCodigo.Text = dgvPrducServ[0, pocicion].Value.ToString();
                txtCantidad.Text = "1";
                txtProdServ.Text = dgvPrducServ[8, pocicion].Value.ToString();
                txtPrecio.Text = dgvPrducServ[5, pocicion].Value.ToString(); 
                txtTotalAPagar.Text = Convert.ToString(Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text)); bandera = 2;
                DataGridViewRow file = new DataGridViewRow();
                file.CreateCells(dgvLista);
                file.Cells[0].Value = txtCodigo.Text;
                file.Cells[1].Value = txtProdServ.Text;
                file.Cells[2].Value = txtPrecio.Text;
                file.Cells[3].Value = txtCantidad.Text;
                file.Cells[4].Value = txtTotalAPagar.Text;
                dgvLista.Rows.Add(file); bandera = 2;
            }            
        }
    }
}
