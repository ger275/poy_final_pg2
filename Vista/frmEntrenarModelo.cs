using Microsoft.ML;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using SistemaParaPrediccionDeVentas.Controlador;
using SistemaParaPrediccionDeVentas.Vista.MSGBOX;
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
    public partial class frmEntrenarModelo : Form
    {
        public int indice = 1;
        private string pathArchivo = "";
        private MsgBoxController msgBox = new MsgBoxController();
        public frmEntrenarModelo()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHelpProductos_Click(object sender, EventArgs e)
        {
            string mensaje = "Para entrenar el modelo y obtener resultados mas precisos haga lo siguiente: /nn 1. De clic al botón Generar información /nn 2. Una vez generada la información de clic al botón de Ejecutar entrenamiento. /nn Deberá esperar el tiempo que se indique, con esto se habrá entrenado el modelo con la información de la base de datos.";
            mensaje = mensaje.Replace("/nn", " " + Environment.NewLine);

            msgBox.Info("", mensaje);
        }

        private void btnGenerarInfo_Click(object sender, EventArgs e)
        {
            FrmEntrenarModeloController frmController = new FrmEntrenarModeloController();
            long tamanioArchivo = 0;

            frmController.GenerarInformacion();
            pathArchivo = frmController.pathArchivo;

            if (frmController.existeArchivo)
            {
                if (File.Exists(pathArchivo))
                {
                    DirectoryInfo infoArchivo = new DirectoryInfo(pathArchivo);
                    FileInfo archivoInfo = new FileInfo(pathArchivo);
                    tamanioArchivo = archivoInfo.Length;

                    txtTamanoInfo.Text = tamanioArchivo.ToString() + " bytes";
                }
            }

            //kilobytes
            tamanioArchivo = tamanioArchivo / 1024;

            //megabytes
            tamanioArchivo = tamanioArchivo / 1024;

            if (tamanioArchivo <= 10)
            {
                txtTiempo.Text = "10 seg.";
                return;
            }
            else if (tamanioArchivo <= 100)
            {
                txtTiempo.Text = "10 min.";
                return;
            }
            else if (tamanioArchivo <= 500)
            {
                txtTiempo.Text = "30 min.";
                return;
            }
            else
            {
                //gigabytes
                tamanioArchivo = tamanioArchivo / 1024;
            }

            if (tamanioArchivo <= 1)
            {
                txtTiempo.Text = "60 min.";
                return;
            }
            else
            {
                txtTiempo.Text = "3 hrs.";
                return;
            }
        }

        private void btnEntrenar_Click(object sender, EventArgs e)
        {
            msgCargando msgFrm = new msgCargando();

            msgFrm.lblTitulo.Text = "Conectando al servidor..";
            msgFrm.Show();
            msgFrm.pBar.Value = 40;
            System.Threading.Thread.Sleep(1000);
            msgFrm.pBar.Value = 60;

            if (File.Exists(pathArchivo))
            {
                MLContext mLContext = new MLContext();
                IDataView retrainingData = mLContext.Data.LoadFromTextFile<MLModel.ModelInput>(pathArchivo, hasHeader: true);
                MLModel.RetrainModel(mLContext, retrainingData);

                msgFrm.pBar.Value = 80;
                System.Threading.Thread.Sleep(1000);
                msgFrm.pBar.Value = 100;
                msgFrm.Close();
            }
            else
            {
                msgFrm.pBar.Value = 80;
                System.Threading.Thread.Sleep(1000);
                msgFrm.pBar.Value = 100;
                msgFrm.Close();

                msgBox.Errorr("Atención", "No se encontro la información para ejecutar el entrenamiento, vuelva a generar la información.");
            }
        }

        private void frmEntrenarModelo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(pathArchivo))
            {
                File.Delete(pathArchivo);
            }
        }
    }
}
