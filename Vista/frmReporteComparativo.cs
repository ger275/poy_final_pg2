using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteComparativo : Form
    {
        public frmReporteComparativo()
        {
            InitializeComponent();
        }

        private void frmReporteComparativo_Load(object sender, EventArgs e)
        {
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

            dc.ColumnName = "codigo";
            dc.Caption = "Codigo";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "producto";
            dc.Caption = "Producto";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "mes1";
            dc.Caption = "mes1";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "mes2";
            dc.Caption = "mes2";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "mes3";
            dc.Caption = "mes3";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "mes4";
            dc.Caption = "mes4";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "mes5";
            dc.Caption = "mes5";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "mes6";
            dc.Caption = "mes6";

            dt.Columns.Add(dc);

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
        }
    }
}
