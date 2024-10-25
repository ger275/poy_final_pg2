using Microsoft.ML;
using Mysqlx.Cursor;
using ScottPlot;
using SistemaParaPrediccionDeVentas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

            lblCosto.Visible = false;
            lblVenta.Visible = false;
            lblValorRoi.Visible = false;
            txtCosto.Visible = false;
            txtVenta.Visible = false;
            txtValorRoi.Visible = false;

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

                    bd.Desconectar();
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
            actualizarGraficaPrediccion();
        }

        private void grProductosAgregar_DoubleClick(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;

                lblCosto.Visible = false;
                lblValorRoi.Visible = false;
                lblVenta.Visible = false;

                txtCosto.Visible = false;
                txtVenta.Visible = false;
                txtValorRoi.Visible = false;
            }

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
            actualizarGraficaPrediccion();
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
            actualizarGraficaPrediccion();
        }

        private void chkCrecimientoMensual_Click(object sender, EventArgs e)
        {
            actualizarTablaPrediccion();
            actualizarGraficaPrediccion();
        }

        public void actualizarTablaPrediccion()
        {
            bool continuar = false;
            List<string> mesesAPredecir = new List<string>();
            MsgBoxController msgBox = new MsgBoxController();
            FrmConfiguracionController ctrler = new FrmConfiguracionController();
            BDController bd = new BDController();
            AES aes = new AES();
            List<string> datos = new List<string>();

            bd.Conectar();

            datos = ctrler.GetConfiguracion();

            string consultaVentas = aes.DesEncriptarDato(datos[7].Split(" ::: ")[1]);

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
                            mesesAPredecir.Add(fechaActual.Year + "-" + fechaActual.Month + "-1");
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
                                    string fechaActual = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-1";
                                    string fechaDePrediccion = mesesAPredecir[j];

                                    DateTime fechaUno = DateTime.ParseExact(fechaActual, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
                                    DateTime fechaDos = DateTime.ParseExact(fechaDePrediccion, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
                                    if (fechaDos < fechaUno)
                                    {
                                        //grPrediccion.Rows[i].Cells[j + 2].Value = 1;

                                        if (bd.conectado)
                                        {
                                            List<string>[] listaSelectProductos = bd.BDSelectPedidos(consultaVentas);

                                            if (bd.consultaPedidos)
                                            {
                                                grPrediccion.Rows[i].Cells[j + 2].Value = bd.BDSelectVentaMes(consultaVentas, fechaDos.Month, fechaDos.Year, grPrediccion.Rows[i].Cells[0].Value.ToString());
                                            }
                                            else
                                            {
                                                msgBox.Errorr("Atención", bd.mensajeErrorConsultaPedidos);
                                            }

                                            bd.Desconectar();
                                        }
                                        else
                                        {
                                            msgBox.Errorr("Atención", bd.mensajeErrorConexion);
                                        }
                                    }
                                    else
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
                                    }

                                    if ((j + 2) > 2)
                                    {
                                        if (IsNumeric(grPrediccion.Rows[i].Cells[j + 2].Value.ToString()) && IsNumeric(grPrediccion.Rows[i].Cells[(j + 2) - 1].Value.ToString()) && Int32.Parse(grPrediccion.Rows[i].Cells[(j + 2) - 1].Value.ToString()) > 0)
                                        {
                                            decimal creceMensual = Math.Round(
                                                (((Convert.ToDecimal(grPrediccion.Rows[i].Cells[j + 2].Value.ToString()) -
                                                Convert.ToDecimal(grPrediccion.Rows[i].Cells[(j + 2) - 1].Value.ToString())) /
                                                Convert.ToDecimal(grPrediccion.Rows[i].Cells[(j + 2) - 1].Value.ToString())) *
                                                100), 2);
                                            grPrediccion.Rows[i + 1].Cells[j + 2].Value = creceMensual + "%";
                                        }
                                        else
                                        {
                                            grPrediccion.Rows[i + 1].Cells[j + 2].Value = "-";
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

                        for (int i = 0; i < (grPrediccion.Rows.Count - 1); i++)
                        {
                            if (grPrediccion.Rows[i].Cells[0].Value.ToString() != "")
                            {
                                double nuevovalor = 13;
                                for (int j = 0; j < mesesAPredecir.Count; j++)
                                {
                                    string fechaActual = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-1";
                                    string fechaDePrediccion = mesesAPredecir[j];

                                    DateTime fechaUno = DateTime.ParseExact(fechaActual, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
                                    DateTime fechaDos = DateTime.ParseExact(fechaDePrediccion, "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
                                    if (fechaDos < fechaUno)
                                    {
                                        //grPrediccion.Rows[i].Cells[j + 2].Value = 1;

                                        if (bd.conectado)
                                        {
                                            List<string>[] listaSelectProductos = bd.BDSelectPedidos(consultaVentas);

                                            if (bd.consultaPedidos)
                                            {
                                                grPrediccion.Rows[i].Cells[j + 2].Value = bd.BDSelectVentaMes(consultaVentas, fechaDos.Month, fechaDos.Year, grPrediccion.Rows[i].Cells[0].Value.ToString());
                                            }
                                            else
                                            {
                                                msgBox.Errorr("Atención", bd.mensajeErrorConsultaPedidos);
                                            }

                                            bd.Desconectar();
                                        }
                                        else
                                        {
                                            msgBox.Errorr("Atención", bd.mensajeErrorConexion);
                                        }
                                    }
                                    else
                                    {
                                        //Load sample data
                                        var sampleData = new MLModel.ModelInput()
                                        {
                                            Fecha = DateTime.Parse(mesesAPredecir[j]),
                                            Producto = @"B001",
                                        };

                                        //Load model and predict output
                                        var result = MLModel.Predict(sampleData);

                                        var valorPredicho = result.Score;

                                        grPrediccion.Rows[i].Cells[j + 2].Value = Math.Round(nuevovalor, 0);
                                        nuevovalor = (nuevovalor * 1.33) + i;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    continuar = false;
                }
            }
        }

        public void actualizarGraficaPrediccion2()
        {
            // create data sample data
            DateTime[] myDates = new DateTime[12];
            for (int i = 0; i < myDates.Length; i++)
            {
                myDates[i] = new DateTime(2023, 9, 1).AddMonths(i);
            }

            double[] xs = myDates.Select(x => x.ToOADate()).ToArray();
            double[] ys = DataGen.RandomWalk(myDates.Length);
            frmGrafica.Plot.AddScatter(xs, ys);

            // Then tell the axis to display tick labels using a time format
            frmGrafica.Plot.XAxis.DateTimeFormat(true);

            //plt.SaveFig("ticks_dateTime.png");
            frmGrafica.Refresh();
        }

        public void actualizarGraficaPrediccion()
        {
            frmGrafica.Reset();

            List<double[]> datosPredichos = new List<double[]>();
            List<string> productosPredichos = new List<string>();
            DateTime[] misFechas = new DateTime[12];
            double[] xs;

            if (grPrediccion.Rows.Count > 1)
            {
                for (int i = 0; i < (grPrediccion.Rows.Count - 1); i++)
                {
                    if (grPrediccion.Rows[i].Cells[0].Value.ToString() != "")
                    {
                        double[] arrayTemp = { Convert.ToDouble(grPrediccion.Rows[i].Cells[2].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[3].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[4].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[5].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[6].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[7].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[8].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[9].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[10].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[11].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[12].Value.ToString()),
                                                Convert.ToDouble(grPrediccion.Rows[i].Cells[13].Value.ToString())
                        };

                        datosPredichos.Add(arrayTemp);
                        productosPredichos.Add(grPrediccion.Rows[i].Cells[1].Value.ToString());
                    }
                }

                if (mesesPosteriores.Length == 2)
                {
                    int indiceCmb = cmbPeriodoHasta.SelectedIndex;
                    if (indiceCmb > -1)
                    {
                        if (mesesPosteriores[0].Count == 12 && mesesPosteriores[1].Count == 12)
                        {
                            DateTime fechaInicial = DateTime.ParseExact(mesesPosteriores[1][indiceCmb] + "-" + mesesPosteriores[0][indiceCmb] + "-1", "yyyy-M-d", System.Globalization.CultureInfo.InvariantCulture);
                            DateTime fechaActual = fechaInicial.AddMonths(-11);

                            for (int i = 0; i < 12; i++)
                            {
                                misFechas[i] = new DateTime(fechaActual.Year, fechaActual.Month, 1).AddMonths(i);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < datosPredichos.Count; i++)
            {
                xs = misFechas.Select(x => x.ToOADate()).ToArray();
                frmGrafica.Plot.AddScatter(xs, datosPredichos[i], label: productosPredichos[i]);
            }

            frmGrafica.Plot.Legend();

            frmGrafica.Plot.XAxis.DateTimeFormat(true);
            frmGrafica.Plot.XAxis.TickLabelFormat("MMMM / yyyy", true);

            frmGrafica.Plot.XAxis.ManualTickSpacing(1, ScottPlot.Ticks.DateTimeUnit.Month);
            frmGrafica.Plot.XAxis.TickLabelStyle(rotation: 45);

            frmGrafica.Refresh();
        }

        public bool IsNumeric(string valor)
        {
            return valor.All(char.IsNumber);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReportePrediccion frm = new frmReportePrediccion(grPrediccion);

            frm.Show();
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            var printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            var printDialog = new PrintPreviewDialog { Document = printDocument };
            printDialog.ShowDialog();
            actualizarGraficaPrediccion();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            ScottPlot.Plot graficaTemp = frmGrafica.Plot;

            // Determine how large you want the plot to be on the page and resize accordingly
            int width = e.MarginBounds.Width;
            int height = (int)(e.MarginBounds.Width * 1);
            graficaTemp.Resize(width, height);

            // Give the plot a white background so it looks good on white paper
            graficaTemp.Style(figureBackground: Color.White);

            graficaTemp.Title("Gráfica de Predicciones");

            // Render the plot as a Bitmap and draw it onto the page
            Bitmap bmp = graficaTemp.Render();
            e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            MsgBoxController msg = new MsgBoxController();

            if (checkBox4.Checked)
            {
                if (grProductosAgregados.Rows.Count > 2)
                {
                    msg.Info("Atención", "Debe seleccionar solo un producto para este cálculo.");
                    checkBox4.Checked = false;

                    lblCosto.Visible = false;
                    lblVenta.Visible = false;
                    lblValorRoi.Visible = false;
                    txtCosto.Visible = false;
                    txtVenta.Visible = false;
                    txtValorRoi.Visible = false;
                }
                else
                {
                    lblCosto.Visible = true;
                    lblVenta.Visible = true;
                    lblValorRoi.Visible = true;
                    txtCosto.Visible = true;
                    txtVenta.Visible = true;
                    txtValorRoi.Visible = true;
                }
            }
            else
            {
                lblCosto.Visible = false;
                lblVenta.Visible = false;
                lblValorRoi.Visible = false;
                txtCosto.Visible = false;
                txtVenta.Visible = false;
                txtValorRoi.Visible = false;
            }

            actualizarTablaPrediccion();
            actualizarGraficaPrediccion();
        }

        public void calcularRoi()
        {
            if (checkBox4.Checked)
            {
                int fila = 0;
                int ventas = 0;
                decimal roi = 0;

                if (chkCrecimientoMensual.Checked)
                {
                    fila = 2;
                }
                else
                {
                    fila = 1;
                }

                for (int i = 0; i < 12; i++)
                {
                    ventas += Int32.Parse(grPrediccion.Rows[0].Cells[i + 2].Value.ToString());
                }

                decimal ingresos = decimal.Parse(ventas.ToString()) * decimal.Parse(txtVenta.Text);
                decimal inversion = decimal.Parse(ventas.ToString()) * decimal.Parse(txtCosto.Text);

                if (inversion == 0)
                {
                    txtValorRoi.Text = 0.ToString();
                }
                else
                {
                    roi = ((ingresos - inversion) / inversion) * 100;
                    txtValorRoi.Text = Math.Round(roi, 2).ToString() + "%";
                }
            }
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVenta.Text, @"^[0-9]+(.[0-9]+)?$") && System.Text.RegularExpressions.Regex.IsMatch(txtCosto.Text, @"^[0-9]+(.[0-9]+)?$"))
            {
                calcularRoi();
            }
        }

        private void txtVenta_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVenta.Text, @"^[0-9]+(.[0-9]+)?$") && System.Text.RegularExpressions.Regex.IsMatch(txtCosto.Text, @"^[0-9]+(.[0-9]+)?$"))
            {
                calcularRoi();
            }
        }
    }
}
