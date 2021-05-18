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
    public partial class RecibodePago : Form
    {
        public RecibodePago()
        {
            InitializeComponent();
        }
        public void limpia()
        {
            txtDirEmp.Clear();
            txtNomEmp.Clear();
            txtPuestoEmp.Clear();
            txtSueldoEmp.Clear();
            txtTelEmp.Clear();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            PagoEmp.CreaTicket Ticket1 = new PagoEmp.CreaTicket();

            Ticket1.TextoCentro("Empresa MultiserVicios Braalanma "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda("Jefe: Alexander Pérez Hernández");
            Ticket1.TextoIzquierda("Dirección: Tuxtla Gutiérrez");
            Ticket1.TextoIzquierda("Teléfono: 961-524-8639");
            Ticket1.TextoIzquierda("RFC: AOCF990315LF1");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Comprobante de pago"); //imprime una linea de descripcion

            Ticket1.TextoIzquierda("No Comp: 0120102");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Empleado: "+txtNomEmp.Text);
            Ticket1.TextoIzquierda("Telefono: " + txtTelEmp.Text);
            Ticket1.TextoIzquierda("Dirección: " + txtDirEmp.Text);
            Ticket1.TextoIzquierda("Puesto: " + txtPuestoEmp.Text);
            Ticket1.TextoIzquierda("Sueldo: " + txtSueldoEmp.Text);
            Ticket1.TextoIzquierda("");

            PagoEmp.CreaTicket.LineasGuion();

            //PagoEmp.CreaTicket.EncabezadoVenta();
            PagoEmp.CreaTicket.LineasGuion();
           // foreach (DataGridViewRow r in dgvLista.Rows)
            //{
                // PROD                     //PrECIO                                    CANT                         TOTAL
              //  Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            //}


            //string v = Factura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(txtSueldoEmp.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtSueldoEmp.Text));
            //Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtCambio.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*   Felicitaciones Empleado  *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Se ha generado el comprobante de pago");
            limpia();
        }
    }
}
