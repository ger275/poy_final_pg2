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
using System.IO;
using SistemaParaPrediccionDeVentas.Controlador;
using Microsoft.ML;

namespace SistemaParaPrediccionDeVentas.Vista
{
    public partial class frmPredecir : Form
    {
        int locationX = 0;
        int locationY = 0;

        public frmPredecir()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(950, 558);

            this.Location = new Point(locationX, locationY);

            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void frmPredecir_Load(object sender, EventArgs e)
        {
            locationX = this.Location.X;
            locationY = this.Location.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            Archivos archivo = new Archivos();

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "C:\\";
                ofd.Filter = "CSV (delimitado por comas) (*.csv)|*.csv";
                ofd.Multiselect = false;
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (archivo.EstructuraValida(ofd.FileName, 2))
                    {
                        archivo.CargarVentas(ofd.FileName);
                        MessageBox.Show("Cargado correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("El archivo no cuenta con la estructura válida.<");
                    }
                }
            }

        }

        private void btnGenerarPrediccion_Click(object sender, EventArgs e)
        {
            Archivos archivos = new Archivos();
            string codigoProducto = "";
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "HistorialVentas");

            DirectoryInfo infoArchivos = new DirectoryInfo(pathRaiz);

            FileInfo[] archivosInfo = infoArchivos.GetFiles().OrderByDescending(f => f.LastWriteTime).ToArray();

            if (archivosInfo.Length > 0)
            {
                int contadorAux = 0;

                for (int i = archivosInfo[0].Name.Split("_").Length; i >= 0; i--)
                {
                    contadorAux++;

                    if (contadorAux == 7)
                    {
                        break;
                    }
                }

                if ((archivosInfo[0].Name.Split("_")[0].Length - contadorAux) == 1)
                {
                    codigoProducto = archivosInfo[0].Name.Split("_")[0];
                }
                else
                {
                    for (int i = 0; i <= (archivosInfo[0].Name.Split("_").Length - contadorAux); i++)
                    {
                        codigoProducto = codigoProducto + archivosInfo[0].Name.Split("_")[i];

                        if (i != (archivosInfo[0].Name.Split("_").Length - contadorAux))
                        {
                            codigoProducto = codigoProducto + "_";
                        }
                    }
                }

                pathRaiz = archivosInfo[0].FullName;
                pathRaiz = archivos.DesencriptarTemp(pathRaiz);
                //1. creo un arreglo con los datos del historial de ventas
                //2. recorreo ese arreglo de forma inversa y unicamente tomo los datos de los últimos 5 meses y le agrego el mes de la predicción
                //3. guardo ese archivo, lo encripto y de alli ya lo puedo consultar desde el reporte de comparativo por mes
                MLContext mLContext = new MLContext();
                IDataView retrainingData = mLContext.Data.LoadFromTextFile<MLModel.ModelInput>(pathRaiz, hasHeader: true);
                MLModel.RetrainModel(mLContext, retrainingData);

                DateTime fecha = DateTime.Now;
                fecha = fecha.AddMonths(1);
                float mes = fecha.Month;

                var predecirMes = new MLModel.ModelInput()
                {
                    Fecha = mes,
                };

                var resultado = MLModel.Predict(predecirMes);

                archivos.GuardarPrediccion(codigoProducto, resultado.Score);

                archivos.GuardarReporteComparativo(pathRaiz, mes, resultado.Score, codigoProducto);

                File.Delete(pathRaiz);

                MessageBox.Show("Se generó la predicción correctamente!");
            }
            else
            {
                MessageBox.Show("Para hacer una predicción debe haber cargado antes el historial de ventas.");
            }

        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            Archivos archivo = new Archivos();
            var fileContent = string.Empty;
            string pathDestino = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            pathDestino = Path.Combine(pathDestino, "SistemaPrediccion");

            if (!Directory.Exists(pathDestino))
            {
                Directory.CreateDirectory(pathDestino);
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "C:\\";
                ofd.Filter = "CSV (delimitado por comas) (*.csv)|*.csv";
                ofd.Multiselect = false;
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (archivo.EstructuraValida(ofd.FileName, 2))
                    {
                        archivo.CargarProductos(ofd.FileName);
                        MessageBox.Show("Se cargaron los datos correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("El archivo no cuenta con el formato válido, " + "\r\n" + "reviselo y vuelvalo a cargar!");
                    }

                }
            }
        }
    }
}
