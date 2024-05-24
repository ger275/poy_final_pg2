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
using SistemaParaPrediccionDeVentas.Controlador;

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
            AES aes = new AES();
            string queDato = "";
            FrmConfiguracionController ctrler = new FrmConfiguracionController();
            List<string> datos = new List<string>();
            datos = ctrler.GetConfiguracion();

            //cargar datos iniciales
            cmbServidor.Items.Add("MySQL 8.0");
            cmbServidor.Items.Add("SQL Server 2000");

            cmbServidor.Enabled = false;
            txtHost.Enabled = false;
            txtPuerto.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            btnGuardar.Enabled = false;

            //se carga la configuración guardada
            if (datos.Count > 0)
            {
                if (datos[0].Split(" ::: ").Length == 2)
                {
                    queDato = datos[0].Split(" ::: ")[1];
                } else
                {
                    queDato = "-1";
                }

                cmbServidor.SelectedIndex = int.Parse(queDato);

                datos.RemoveRange(0, 1);

                foreach (string dato in datos)
                {
                    if (dato.Split(" ::: ").Length == 2)
                    {
                        queDato = aes.DesEncriptarDato(dato.Split(" ::: ")[0]);

                        if (queDato.Equals("host"))
                        {
                            txtHost.Text = aes.DesEncriptarDato(dato.Split(" ::: ")[1]);
                        }
                        if (queDato.Equals("puerto"))
                        {
                            txtPuerto.Text = aes.DesEncriptarDato(dato.Split(" ::: ")[1]);
                        }
                        if (queDato.Equals("usuario"))
                        {
                            txtUsuario.Text = aes.DesEncriptarDato(dato.Split(" ::: ")[1]);
                        }
                        if (queDato.Equals("contrasena"))
                        {
                            txtContrasena.Text = aes.DesEncriptarDato(dato.Split(" ::: ")[1]);
                        }
                    }
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MsgBoxController msgBox = new MsgBoxController();
            String contrasena = "";

            if (msgBox.SiNo("Atención", "¿Desea modificar la configuración del servidor?"))
            {
                contrasena = msgBox.PedirContrasena("Atención", "Para modificar la configuración ingrese su contraseña.");

                if (contrasena.Equals("CancelarMsgBoxFrm"))
                {

                }
                else
                {
                    MessageBox.Show("Valirdar contraseña");
                    cmbServidor.Enabled = true;
                    txtHost.Enabled = true;
                    txtPuerto.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtContrasena.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnModificar.Enabled = false;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            MsgBoxController msgBox = new MsgBoxController();
            FrmConfiguracionController ctrler = new FrmConfiguracionController();
            string msjError = "";



            //VERIFICAR QUE SE HALLAN LLENADO LOS CAMPOS NECESARIOS
            if (cmbServidor.SelectedIndex == -1)
            {
                msjError = msjError + "Seleccione el tipo de servidor.\n";
            }
            if (txtHost.Text == "")
            {
                msjError = msjError + "Ingrese la dirección del host.\n";
            }
            if (txtPuerto.Text == "")
            {
                msjError = msjError + "Ingrese el puerto.\n";
            }
            if (txtUsuario.Text == "")
            {
                msjError = msjError + "Ingrese el usuario.\n";
            }
            if (txtContrasena.Text == "")
            {
                msjError = msjError + "Ingrese la contraseña.\n";
            }

            if (msjError != "")
            {
                msgBox.Info("Atención", msjError);
                return;
            }

            //GUARDAR LA CONFIGURACION DEL SERVIDOR
            if (cmbServidor.SelectedIndex == 0)
            {
                if (ctrler.GuardarConfiguracionMySQL(aes.EncriptarDato(txtHost.Text), aes.EncriptarDato(txtPuerto.Text), aes.EncriptarDato(txtUsuario.Text), aes.EncriptarDato(txtContrasena.Text)))
                {
                    msgBox.Info("Atención", "Se guardaron los datos.");
                }
            }
            else if (cmbServidor.SelectedIndex == 1)
            {
                if (ctrler.GuardarConfiguracionSQLServer(aes.EncriptarDato(txtHost.Text), aes.EncriptarDato(txtPuerto.Text), aes.EncriptarDato(txtUsuario.Text), aes.EncriptarDato(txtContrasena.Text)))
                {
                    msgBox.Info("Atención", "Se guardaron los datos.");
                }
            }

            //INICIALIZAR LOS CAMPOS
            cmbServidor.Enabled = false;
            txtHost.Enabled = false;
            txtPuerto.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
