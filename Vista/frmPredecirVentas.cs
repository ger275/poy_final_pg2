using Microsoft.ML;
using Mysqlx.Cursor;
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
    public partial class frmPredecirVentas : Form
    {
        public int indice = 2;
        private List<string> meses = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        private List<int>[] mesesPosteriores = new List<int>[2];
        public frmPredecirVentas()
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

        private void button1_Click(object sender, EventArgs e)
        {
            //boton cerrar
            this.Close();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmPredecirVentas_Load(object sender, EventArgs e)
        {
            mesesPosteriores[0] = new List<int>();
            mesesPosteriores[1] = new List<int>();
            MsgBoxController msgBox = new MsgBoxController();
            FrmConfiguracionController ctrler = new FrmConfiguracionController();
            BDController bd = new BDController();
            AES aes = new AES();

            grProductosAgregar.Columns.Add("codigo", "Código");
            grProductosAgregar.Columns.Add("nombre", "Nombre");

            grProductosAgregados.Columns.Add("codigo", "Código");
            grProductosAgregados.Columns.Add("nombre", "Nombre");

            List<string> datos = new List<string>();
            datos = ctrler.GetConfiguracion();

            if (datos.Count == 8)
            {
                string consultaProductos = aes.DesEncriptarDato(datos[6].Split(" ::: ")[1]);

                bd.Conectar();

                if (bd.conectado)
                {
                    List<string>[] listaSelectProductos = bd.BDSelectProductos(consultaProductos);

                    if (bd.consultaProductos)
                    {
                        for (int i = 0; i < listaSelectProductos[0].Count; i++)
                        {
                            grProductosAgregar.Rows.Add(listaSelectProductos[0][i], listaSelectProductos[1][i]);
                        }
                    }
                    else
                    {
                        msgBox.Errorr("Atención", bd.mensajeErrorConsultaProductos);
                    }
                }
                else
                {
                    msgBox.Errorr("Atención", bd.mensajeErrorConexion);
                }
            }
            else
            {
                msgBox.Errorr("Atención", "No se encontró la configuración del servidor, revise.");
            }

            DateTime fecha = DateTime.Now;

            for (int i = 1; i <= 12; i++)
            {
                cmbPeriodoHasta.Items.Add(meses[fecha.AddMonths(i).Month - 1] + " " + fecha.AddMonths(i).Year);
                mesesPosteriores[0].Add(fecha.AddMonths(i).Month);
                mesesPosteriores[1].Add(fecha.AddMonths(i).Year);
            }

            txtPeriodoDesde.Text = meses[fecha.AddMonths(-10).Month - 1] + " " + fecha.AddMonths(-11).Year.ToString();
        }

        private void cmbPeriodoHasta_SelectedValueChanged(object sender, EventArgs e)
        {
            int indiceComboPeriodoHasta = cmbPeriodoHasta.SelectedIndex;
            int anio = mesesPosteriores[1][indiceComboPeriodoHasta];
            int mes = mesesPosteriores[0][indiceComboPeriodoHasta];
            DateTime fecha = DateTime.ParseExact(anio + "-" + mes + "-1", "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
            fecha = fecha.AddMonths(-11);

            txtPeriodoDesde.Text = meses[fecha.Month - 1] + " " + fecha.Year.ToString();

            actualizarTablaPrediccion();
        }

        private void grProductosAgregar_DoubleClick(object sender, EventArgs e)
        {
            if (grProductosAgregar.Rows.Count > 1)
            {
                int grIndice = grProductosAgregar.CurrentCell.RowIndex;

                if ((grIndice + 1) < grProductosAgregar.Rows.Count)
                {
                    grProductosAgregados.Rows.Add(grProductosAgregar.Rows[grIndice].Cells[0].Value.ToString(), grProductosAgregar.Rows[grIndice].Cells[1].Value.ToString());
                    grProductosAgregar.Rows.RemoveAt(grIndice);
                    //grProductosAgregar.Rows[1].Cells[0].Style.
                }
            }

            actualizarTablaPrediccion();
        }

        private void grProductosAgregados_DoubleClick(object sender, EventArgs e)
        {
            if (grProductosAgregados.Rows.Count > 1)
            {
                int grIndice = grProductosAgregados.CurrentCell.RowIndex;

                if ((grIndice + 1) < grProductosAgregados.Rows.Count)
                {
                    grProductosAgregar.Rows.Add(grProductosAgregados.Rows[grIndice].Cells[0].Value.ToString(), grProductosAgregados.Rows[grIndice].Cells[1].Value.ToString());
                    grProductosAgregados.Rows.RemoveAt(grIndice);
                }
            }

            actualizarTablaPrediccion();
        }

        private void chkCrecimientoMensual_Click(object sender, EventArgs e)
        {
            actualizarTablaPrediccion();
        }

        public void actualizarTablaPrediccion()
        {
            bool continuar = false;
            List<string> mesesAPredecir = new List<string>();

            if (mesesPosteriores.Length == 2)
            {
                int indiceCmb = cmbPeriodoHasta.SelectedIndex;
                if (indiceCmb > -1)
                {
                    if (mesesPosteriores[0].Count == 12 && mesesPosteriores[1].Count == 12)
                    {
                        DateTime fechaInicial = DateTime.ParseExact(mesesPosteriores[1][indiceCmb] + "-" + mesesPosteriores[0][indiceCmb] + "-1", "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
                        DateTime fechaActual = fechaInicial.AddMonths(-11);
                        grPrediccion.Columns.Clear();

                        grPrediccion.Columns.Add("codigo", "");
                        grPrediccion.Columns.Add("nombre", "");

                        for (int i = 0; i < 12; i++)
                        {
                            grPrediccion.Columns.Add(fechaActual.Month + "-" + fechaActual.Year, meses[fechaActual.Month - 1].Substring(0, 3) + " - " + fechaActual.Year);
                            mesesAPredecir.Add(fechaActual.Year + "-" + fechaActual.Month + "-01");
                            fechaActual = fechaActual.AddMonths(1);
                        }

                        continuar = true;
                    }
                }
            }

            if (continuar)
            {
                if (grProductosAgregados.Rows.Count > 1)
                {
                    if (chkCrecimientoMensual.Checked)
                    {
                        for (int i = 0; i < (grProductosAgregados.Rows.Count - 1); i++)
                        {
                            grPrediccion.Rows.Add(grProductosAgregados.Rows[i].Cells[0].Value.ToString(), grProductosAgregados.Rows[i].Cells[1].Value.ToString());
                            grPrediccion.Rows.Add("");
                        }

                        for (int i = 0; i < (grPrediccion.Rows.Count - 1); i++)
                        {
                            if (grPrediccion.Rows[i].Cells[0].Value.ToString() != "")
                            {
                                double nuevovalor = 13;
                                for (int j = 0; j < mesesAPredecir.Count; j++)
                                {
                                    //Load sample data
                                    var sampleData = new MLModel.ModelInput()
                                    {
                                        Fecha = DateTime.Parse(mesesAPredecir[j]),
                                        Producto = @"B001",
                                    };

                                    //Load model and predict output
                                    var result = MLModel.Predict(sampleData);

                                    grPrediccion.Rows[i].Cells[j + 2].Value = Math.Round(nuevovalor, 0);
                                    nuevovalor = nuevovalor * 1.33;

                                    if ((j + 2) > 2)
                                    {
                                        if (IsNumeric(grPrediccion.Rows[i].Cells[j + 2].Value.ToString()) && IsNumeric(grPrediccion.Rows[i].Cells[(j + 2) - 1].Value.ToString()))
                                        {
                                            decimal creceMensual = Math.Round(
                                                (((Convert.ToDecimal(grPrediccion.Rows[i].Cells[j + 2].Value.ToString()) -
                                                Convert.ToDecimal(grPrediccion.Rows[i].Cells[(j + 2) - 1].Value.ToString())) / 
                                                Convert.ToDecimal(grPrediccion.Rows[i].Cells[(j + 2) - 1].Value.ToString())) * 
                                                100), 2);
                                            grPrediccion.Rows[i + 1].Cells[j + 2].Value = creceMensual + "%";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < (grProductosAgregados.Rows.Count - 1); i++)
                        {
                            grPrediccion.Rows.Add(grProductosAgregados.Rows[i].Cells[0].Value.ToString(), grProductosAgregados.Rows[i].Cells[1].Value.ToString());
                        }
                    }
                }
                else
                {
                    continuar = false;
                }
            }
        }

        public bool IsNumeric(string valor)
        {
            return valor.All(char.IsNumber);
        }
    }
}
