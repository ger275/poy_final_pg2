using Microsoft.ML.Runtime;
using Microsoft.VisualBasic;
using SistemaParaPrediccionDeVentas.Controlador;
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
    public partial class frmConfiguracionUsuario : Form
    {
        public int indice = 5;

        public frmConfiguracionUsuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //botón cerrar
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfiguracionUsuario_Load(object sender, EventArgs e)
        {
            FrmConfiguracionUsuarioController ctrl = new FrmConfiguracionUsuarioController();
            AES aES = new AES();
            string queDato = "";
            List<string> datos = ctrl.GetConfiguracion();

            if (datos.Count == 2)
            {
                if (datos[0].Split(" ::: ").Length == 2)
                {
                    queDato = datos[0].Split(" ::: ")[1];
                    txtUsuario.Text = aES.DesEncriptarDato(queDato);
                }

                if (datos[1].Split(" ::: ").Length == 2)
                {
                    queDato = datos[1].Split(" ::: ")[1];
                    txtContrasena.Text = aES.DesEncriptarDato(queDato);
                }
            }

            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            txtConfirmContrasena.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            txtConfirmContrasena.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AES aES = new AES();
            MsgBoxController msg = new MsgBoxController();
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "ConfiguracionUsuario");

            if (txtContrasena.Text != txtConfirmContrasena.Text)
            {
                msg.Errorr("Atención", "La contraseña ingresada no coincide, vuelva a ingresarla.");
                return;
            }

            if (!Directory.Exists(pathRaiz)) { Directory.CreateDirectory(pathRaiz); }

            pathRaiz = Path.Combine(pathRaiz, "usuario.txt");

            if (File.Exists(pathRaiz)) { File.Delete(pathRaiz); }

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine(aES.EncriptarDato("usuario") + " ::: " + aES.EncriptarDato(txtUsuario.Text));
                sw.WriteLine(aES.EncriptarDato("contrasena") + " ::: " + aES.EncriptarDato(txtContrasena.Text));
                sw.Close();
            }

            msg.Info("Atención", "¡Se actualizaron los datos!");

            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            txtConfirmContrasena.Enabled = false;
        }
    }
}
