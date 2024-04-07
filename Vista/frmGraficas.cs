using Microsoft.Reporting.WinForms;
using ScottPlot;
using SistemaParaPrediccionDeVentas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaPrediccionDeVentas.Vista
{
    public partial class frmGraficas : Form
    {
        int locationX = 0;
        int locationY = 0;

        public frmGraficas()
        {
            InitializeComponent();
        }

        private void frmGraficas_Load(object sender, EventArgs e)
        {
            locationX = this.Location.X;
            locationY = this.Location.Y;

            /* double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };

            formsPlot1.Plot.AddScatter(dataX, dataY);
            formsPlot1.Refresh(); */

            // Create a collection of Bar objects
            
            Random rand = new(0);
            List<ScottPlot.Plottable.Bar> bars = new();
            for (int i = 0; i < 6; i++)
            {
                int value = rand.Next(25, 100);
                ScottPlot.Plottable.Bar bar = new()
                {
                    // Each bar can be extensively customized
                    Value = value,
                    Position = i,
                    FillColor = ScottPlot.Palette.Category10.GetColor(i),
                    Label = value.ToString(),
                    //Label = "mes",
                    LineWidth = 0,
                };
                bars.Add(bar);
            };

            // Add the BarSeries to the plot
            formsPlot1.Plot.XAxis.Label("Mes");
            formsPlot1.Plot.YAxis.Label("Cantidad");
            formsPlot1.Plot.Title("Producto");
            double[] xPositions = { 0, 1, 2, 3, 4, 5 };
            string[] xLabels = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };
            formsPlot1.Plot.XAxis.ManualTickPositions(xPositions, xLabels);

            double[] yPositions = { 0, 40, 60, 80, 100, 120 };
            string[] yLabels = { "0", "40", "60", "80", "100", "120" };
            formsPlot1.Plot.YAxis.ManualTickPositions(yPositions, yLabels);

            formsPlot1.Plot.AddBarSeries(bars);
            
            formsPlot1.Refresh();




            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            Archivos archivos = new Archivos();
            string[] lineaArray = new string[7];
            string[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            string linea = "";
            string codigoProducto = "";
            string nombreProducto = "";
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Comparativos");
            DataTable dt = new DataTable("datos");
            DataColumn dc = new DataColumn();
            DataRow dr;

            if (Directory.Exists(pathRaiz))
            {
                DirectoryInfo infoArchivos = new DirectoryInfo(pathRaiz);

                FileInfo[] archivosInfo = infoArchivos.GetFiles().OrderByDescending(f => f.LastWriteTime).ToArray();

                pathRaiz = Path.Combine(pathRaiz, archivosInfo[0].Name);

                if (archivosInfo.Length > 0)
                {
                    using (StreamReader sr = new StreamReader(pathRaiz))
                    {
                        int contadorAux = 0;
                        linea = sr.ReadLine();
                        linea = sr.ReadLine();

                        codigoProducto = archivos.DesEncriptarDato(linea.Split(";")[0]);
                        nombreProducto = archivos.DesEncriptarDato(linea.Split(";")[1]);

                        linea = sr.ReadLine();

                        while ((linea = sr.ReadLine()) != null)
                        {
                            if (contadorAux <= 5)
                            {
                                lineaArray[contadorAux] = linea;
                            }

                            contadorAux++;
                        }
                    }
                }

                dr = dt.NewRow();
                dr["codigo"] = codigoProducto;
                dr["producto"] = nombreProducto;

                dr["mes1"] = mes[Int32.Parse(archivos.DesEncriptarDato(lineaArray[5].Split(";")[0])) - 1] + "\n" + archivos.DesEncriptarDato(lineaArray[5].Split(";")[1]);
                dr["mes2"] = mes[Int32.Parse(archivos.DesEncriptarDato(lineaArray[4].Split(";")[0])) - 1] + "\n" + archivos.DesEncriptarDato(lineaArray[4].Split(";")[1]);
                dr["mes3"] = mes[Int32.Parse(archivos.DesEncriptarDato(lineaArray[3].Split(";")[0])) - 1] + "\n" + archivos.DesEncriptarDato(lineaArray[3].Split(";")[1]);
                dr["mes4"] = mes[Int32.Parse(archivos.DesEncriptarDato(lineaArray[2].Split(";")[0])) - 1] + "\n" + archivos.DesEncriptarDato(lineaArray[2].Split(";")[1]);
                dr["mes5"] = mes[Int32.Parse(archivos.DesEncriptarDato(lineaArray[1].Split(";")[0])) - 1] + "\n" + archivos.DesEncriptarDato(lineaArray[1].Split(";")[1]);
                dr["mes6"] = mes[Int32.Parse(archivos.DesEncriptarDato(lineaArray[0].Split(";")[0])) - 1] + "\n" + archivos.DesEncriptarDato(lineaArray[0].Split(";")[1]);

                dt.Rows.Add(dr);
            }

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource dataSource = new ReportDataSource("DataSetComparativo", dt);

            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaParaPrediccionDeVentas.Vista.Reportes.ReporteComparativo.rdlc";
            reportViewer1.RefreshReport();
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            button3.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(950, 558);

            this.Location = new Point(locationX, locationY);

            button1.Visible = true;
            button3.Visible = false;
        }
    }
}
