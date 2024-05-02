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
            msgFrm.lblMensaje.Text = mensaje;
            msgFrm.Text = titulo;

            DialogResult dg = msgFrm.ShowDialog();

            if (dg == DialogResult.Yes)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string PedirContrasena(string titulo, string mensaje)
        {
            msgBoxPedirContrasena msgFrm = new msgBoxPedirContrasena();
            msgFrm.lblMensaje.Text = mensaje;
            msgFrm.Text = titulo;

            DialogResult dg = msgFrm.ShowDialog();

            if (dg == DialogResult.OK)
            {
                return msgFrm.txtContrasena.Text;
            }
            else
            {
                return "CancelarMsgBoxFrm";
            }

        }

        public void Info(string titulo, string mensaje)
        {
            msgBoxInfo msgFrm = new msgBoxInfo();
            msgFrm.lblMensaje.Text = mensaje;
            msgFrm.Text = titulo;

            DialogResult dg = msgFrm.ShowDialog();
        }
    }
}
