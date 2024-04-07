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
    public partial class frmReportPrediccionActual : Form
    {
        public frmReportPrediccionActual()
        {
            InitializeComponent();
        }

        private void frmReportPrediccionActual_Load(object sender, EventArgs e)
        {
            Archivos archivos = new Archivos();
            string[] lineaArray = null;
            string linea = "";
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Pedicciones");
            DataTable dt = new DataTable("datos");
            DataColumn dc = new DataColumn();
            DataRow dr;

            dc.ColumnName = "codigo";
            dc.Caption = "Codigo";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "nombre";
            dc.Caption = "Nombre";

            dt.Columns.Add(dc);

            dc = new DataColumn();

            dc.ColumnName = "valor";
            dc.Caption = "Valor Predicho";

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
                        linea = sr.ReadLine();

                        while ((linea = sr.ReadLine()) != null)
                        {
                            lineaArray = linea.Split(";");

                            dr = dt.NewRow();

                            dr["codigo"] = archivos.DesEncriptarDato(lineaArray[0]);
                            dr["nombre"] = archivos.DesEncriptarDato(lineaArray[1]);
                            dr["valor"] = archivos.DesEncriptarDato(lineaArray[2]);

                            dt.Rows.Add(dr);
                        }
                    }
                }
            }

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource dataSource = new ReportDataSource("DataSetPrediccionActual", dt);

            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaParaPrediccionDeVentas.Vista.Reportes.ReportePrediccionActual.rdlc";
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
