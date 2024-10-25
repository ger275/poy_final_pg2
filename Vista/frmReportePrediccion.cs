using Microsoft.FSharp.Core;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReportePrediccion : Form
    {
        DataGridView datos = new DataGridView();

        public frmReportePrediccion(DataGridView datoss)
        {
            InitializeComponent();
            datos = datoss;
        }

        private void frmReportePrediccion_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("datos");
            DataColumn dc = new DataColumn();
            DataRow dr;
            //Agregar las columnas y los nombres de las columnas del reporte 
            dc.ColumnName = "codigo";
            dc.Caption = "Codigo";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "producto";
            dc.Caption = "Nombre";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes1";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes2";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes3";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes4";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes5";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes6";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes7";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes8";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes9";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes10";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes11";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);
            dc = new DataColumn();
            dc.ColumnName = "mes12";
            dc.Caption = "Valor Predicho";
            dt.Columns.Add(dc);

            //Agregar las filas del  
            if (datos.Rows.Count > 1)
            {
                for (int i = 0; i < (datos.Rows.Count - 1); i++)
                {
                    dr = dt.NewRow();
                    dr["codigo"] = datos.Rows[i].Cells[0].Value.ToString();
                    dr["producto"] = (datos.Rows[i].Cells[1].Value == null ? "" : datos.Rows[i].Cells[1].Value.ToString());
                    dr["mes1"] = (datos.Rows[i].Cells[2].Value == null ? "" : datos.Rows[i].Cells[2].Value.ToString());
                    dr["mes2"] = (datos.Rows[i].Cells[3].Value == null ? "" : datos.Rows[i].Cells[3].Value.ToString()); ;
                    dr["mes3"] = (datos.Rows[i].Cells[4].Value == null ? "" : datos.Rows[i].Cells[4].Value.ToString()); ;
                    dr["mes4"] = (datos.Rows[i].Cells[5].Value == null ? "" : datos.Rows[i].Cells[5].Value.ToString()); ;
                    dr["mes5"] = (datos.Rows[i].Cells[6].Value == null ? "" : datos.Rows[i].Cells[6].Value.ToString()); ;
                    dr["mes6"] = (datos.Rows[i].Cells[7].Value == null ? "" : datos.Rows[i].Cells[7].Value.ToString()); ;
                    dr["mes7"] = (datos.Rows[i].Cells[8].Value == null ? "" : datos.Rows[i].Cells[8].Value.ToString()); ;
                    dr["mes8"] = (datos.Rows[i].Cells[9].Value == null ? "" : datos.Rows[i].Cells[9].Value.ToString()); ;
                    dr["mes9"] = (datos.Rows[i].Cells[10].Value == null ? "" : datos.Rows[i].Cells[10].Value.ToString()); ;
                    dr["mes10"] = (datos.Rows[i].Cells[11].Value == null ? "" : datos.Rows[i].Cells[11].Value.ToString()); ;
                    dr["mes11"] = (datos.Rows[i].Cells[12].Value == null ? "" : datos.Rows[i].Cells[12].Value.ToString()); ;
                    dr["mes12"] = (datos.Rows[i].Cells[13].Value == null ? "" : datos.Rows[i].Cells[13].Value.ToString()); ;
                    dt.Rows.Add(dr);
                }
            }

            //Agregar los origenes de los datos al componente report viewer 
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource dataSource = new ReportDataSource("DataSetPrediccion", dt);
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            reportViewer1.LocalReport.ReportEmbeddedResource =
            "SistemaParaPrediccionDeVentas.Vista.Reportes.ReportePrediccion.rdlc";
            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("letter", 850, 1100);
            ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.Letter;
            ps.Margins.Bottom = 0;
            ps.Margins.Right = 0;
            ps.Margins.Top = 0;
            ps.Margins.Left = 0;
            reportViewer1.SetPageSettings(ps);
            reportViewer1.RefreshReport();
        }
    }
}
