using SistemaParaPrediccionDeVentas.Vista.MSGBOX;
using SistemaParaPrediccionDeVentas.Vista;
using System.Runtime.InteropServices;

namespace SistemaParaPrediccionDeVentas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Panel p = new Panel();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(0, 191, 255);
            p.Size = new Size(160, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (!pReportes.Visible)
            {
                pReportes.Visible = true;
                pReportes.BringToFront();
            }
            else
            {
                pReportes.Visible = false;
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1121, 670);

            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnPredecir_Click(object sender, EventArgs e)
        {
            //abrirFormularioHijo(new Vista.frmPredecir());
        }

        private Form[] formularioActivo = null;

        private void abrirFormularioHijo(Form formularioHijo, int indice)
        {
            if (formularioActivo != null)
            {
                //formularioActivo.Close();
            }

            if (formularioActivo == null)
            {
                formularioActivo = new Form[10];
            }

            formularioActivo[indice] = formularioHijo;
            formularioActivo[indice].TopLevel = false;
            formularioActivo[indice].Location = new Point(((pFormulariosHijos.Width / 2) - (formularioHijo.Width / 2)), ((pFormulariosHijos.Height / 2) - (formularioHijo.Height / 2)));
            pFormulariosHijos.Controls.Add(formularioActivo[indice]);
            pFormulariosHijos.Tag = formularioActivo[indice];
            formularioActivo[indice].BringToFront();
            formularioActivo[indice].Show();

            /*formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.Location = new Point(((pFormulariosHijos.Width / 2) - (formularioHijo.Width / 2)), ((pFormulariosHijos.Height / 2) - (formularioHijo.Height / 2)));
            pFormulariosHijos.Controls.Add(formularioHijo);
            pFormulariosHijos.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();*/
        }

        private void btnPrediccionActual_Click(object sender, EventArgs e)
        {
            //abrirFormularioHijo(new Vista.frmReportPrediccionActual());
        }

        private void btnComparativo_Click(object sender, EventArgs e)
        {
            //abrirFormularioHijo(new Vista.frmReporteComparativo());
        }

        private void btnGraficas_Click(object sender, EventArgs e)
        {
            //abrirFormularioHijo(new Vista.frmGraficas());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (!pConfiguracion.Visible)
            {
                pConfiguracion.Visible = true;
                pConfiguracion.BringToFront();
            }
            else
            {
                pConfiguracion.Visible = false;
            }
        }

        private void btnConfigServidor_Click(object sender, EventArgs e)
        {
            frmConfiguracion frm = new frmConfiguracion();
            abrirFormularioHijo(frm, frm.indice);

            if (pConfiguracion.Visible)
            {
                pConfiguracion.Visible = false;
            }
        }

        private void btnEntrenarModelo_Click(object sender, EventArgs e)
        {
            frmEntrenarModelo frm = new frmEntrenarModelo();
            abrirFormularioHijo(frm, frm.indice);

            if (pConfiguracion.Visible)
            {
                pConfiguracion.Visible = false;
            }
        }
    }
}