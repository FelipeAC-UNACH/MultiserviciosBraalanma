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
using MySql.Data.MySqlClient;
using System.IO;

namespace SCMB
{
    public partial class Login : Form
    {
        Conexion conectar = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            string sql = ("SELECT * FROM usuario WHERE correo='" + txtUser.Text + "'and password='" + txtPassWord.Text + "'");
            MySqlCommand comando = new MySqlCommand(sql, conectar.GetConexion());
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
                Menu inicia = new Menu();
                inicia.Show();
            }
            else
            {
                MessageBox.Show("Correo y/o contraseña incorrecto");
                txtPassWord.Text = "";
                txtUser.Text = "";
            }
        }

        private void cbOk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOk.Checked == true)
            {
                if(txtPassWord.PasswordChar== '•')
                {
                    txtPassWord.PasswordChar = '\0';
                }
            }
            else
            {
                txtPassWord.PasswordChar = '•';
            }
        }
    }
}
