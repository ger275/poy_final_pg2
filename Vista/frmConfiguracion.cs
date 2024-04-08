using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaPrediccionDeVentas.Vista
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button2_Click(object sender, EventArgs e)
        {
            //botón cerrar
            this.Close();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            //cargar datos iniciales
            cmbServidor.Items.Add("MySQL 8.0");
            cmbServidor.Items.Add("SQL Server 2000");

            cmbServidor.Enabled = false;
            txtHost.Enabled = false;
            txtPuerto.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            btnGuardar.Enabled = false;
        }
    }
}
