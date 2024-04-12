using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaParaPrediccionDeVentas.Vista.MSGBOX;

namespace SistemaParaPrediccionDeVentas.Controlador
{
    internal class MsgBoxController
    {
        public MsgBoxController()
        {

        }

        public bool SiNo(string titulo, string mensaje)
        {
            msgBoxSiNo msgFrm = new msgBoxSiNo();
            msgFrm.lblTitulo.Text = titulo;
            msgFrm.lblMensaje.Text = mensaje;

            DialogResult dg = msgFrm.ShowDialog();

            if (dg == DialogResult.Yes)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
