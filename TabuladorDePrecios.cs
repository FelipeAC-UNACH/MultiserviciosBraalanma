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
    
    public partial class TabuladorDePrecios : Form
    {
        Consultas consulta = new Consultas();
        public int pocicion;
        public TabuladorDePrecios()
        {
            InitializeComponent();
        }

        private void btnTabular_Click(object sender, EventArgs e)
        {
            if(txtNombreProduc.Text !="" & txtCantidad.Text != "")
            {
                consulta.muestraMaterialProducto(txtCantidad.Text, txtNombreProduc.Text);
                dgvMateriales.DataSource = consulta.datos;
                dgvMateriales.DataMember = "MaterialUnit";
            }
            else
            {
                MessageBox.Show("Por favor complete los campos vacíos");
            }            
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pocicion = dgvProductos.CurrentRow.Index;
            txtNombreProduc.Text = dgvProductos[0, pocicion].Value.ToString();
        }

        private void TabuladorDePrecios_Load(object sender, EventArgs e)
        {
            try
            {
                consulta.muestraProducto();
                dgvProductos.DataSource = consulta.datos;
                dgvProductos.DataMember = "Producto";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
