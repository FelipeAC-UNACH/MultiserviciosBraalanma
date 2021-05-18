using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SCMB
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            AbrirFormHijo(new Inicio());
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Hace que podamos mover la ventana donde guste
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login inicia = new Login();
            inicia.Show();
        }
        private void AbrirFormHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnVentaContado_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentaDeContado());
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Inicio());
        }
        private void btnHerramienta_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Herramientas());
        }
        private void btnTabuladorPrecio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new TabuladorDePrecios());
        }
        private void btnGastosIndirectos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new GastosIndirectos());
        }

        private void btnVentaCredito_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VentaCredito());
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Comprobante());
        }

        private void BtnReciboDePago_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new RecibodePago());
        }
    }
}
