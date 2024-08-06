using SistemaParaPrediccionDeVentas.Vista.MSGBOX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParaPrediccionDeVentas.Controlador
{
    internal class FrmEntrenarModeloController
    {
        private List<string>[] listaSelectPedidos = null;
        private List<string> listaFecha = new List<string>();
        private List<string> listaCodigo = new List<string>();
        private List<string> listaCantidad = new List<string>();
        private MsgBoxController msgBox = new MsgBoxController();
        private string nombreArchivo;
        public string pathArchivo;
        public bool existeArchivo = false;

        public FrmEntrenarModeloController()
        {

        }

        public void GenerarInformacion()
        {
            BDController bDController = new BDController();
            AES aes = new AES();
            FrmConfiguracionController ctrler = new FrmConfiguracionController();
            msgCargando msgFrm = new msgCargando();

            List<string> datos = new List<string>();

            datos = ctrler.GetConfiguracion();

            string queDato;
            string consultaPedidos = "";

            //se obtiene la consulta guardada
            if (datos.Count > 0)
            {
                datos.RemoveRange(0, 1);

                foreach (string dato in datos)
                {
                    if (dato.Split(" ::: ").Length == 2)
                    {
                        queDato = aes.DesEncriptarDato(dato.Split(" ::: ")[0]);

                        if (queDato.Equals("pedidos"))
                        {
                            consultaPedidos = aes.DesEncriptarDato(dato.Split(" ::: ")[1]);
                        }
                    }
                }
            }
            
            //se hace la conexion a la base de datos y se obtienen las ventas de la base de datos con la consulta anterior
            msgFrm.lblTitulo.Text = "Conectando al servidor..";
            msgFrm.Show();
            msgFrm.pBar.Value = 40;
            System.Threading.Thread.Sleep(1000);
            msgFrm.pBar.Value = 60;

            bDController.Conectar();

            if (bDController.conectado)
            {
                msgFrm.pBar.Value = 80;
                System.Threading.Thread.Sleep(1000);
                msgFrm.pBar.Value = 100;
                msgFrm.Close();

                msgCargando msgFrm3 = new msgCargando();
                msgFrm3.lblTitulo.Text = "Obteniendo datos.....";
                msgFrm3.pBar.Value = 40;
                System.Threading.Thread.Sleep(1000);
                msgFrm3.pBar.Value = 60;
                msgFrm3.Show();

                System.Threading.Thread.Sleep(1000);

                listaSelectPedidos = bDController.BDSelectPedidos(consultaPedidos);

                if (bDController.consultaPedidos)
                {
                    msgFrm3.pBar.Value = 80;
                    System.Threading.Thread.Sleep(1000);
                    msgFrm3.pBar.Value = 100;
                    msgFrm3.Close();
                    //msgBox.Info("Atención", "¡Se obtuvieron los datos de la consulta!");

                    if (listaSelectPedidos.Length == 3)
                    {
                        listaFecha = listaSelectPedidos[0];
                        listaCodigo = listaSelectPedidos[1];
                        listaCantidad = listaSelectPedidos[2];
                    }

                    if ((listaFecha.Count > 0) && (listaFecha.Count == listaCodigo.Count) && (listaCodigo.Count == listaCantidad.Count))
                    {
                        DateTime fecha = DateTime.Now;
                        nombreArchivo = "ventas_" + fecha.Year.ToString() + "_" + fecha.Month.ToString() + "_" + fecha.Day.ToString() + "_" + fecha.Hour.ToString() + "_" + fecha.Minute.ToString() + "_" + fecha.Second.ToString() + ".csv";

                        EscibirVentasCsv();

                        msgBox.Info("Atención", "Se genero la información para el entrenamiento.");
                    }
                    else
                    {
                        msgBox.Errorr("Atención", "No se encontro información en la base de datos");
                    }
                }
                else
                {
                    msgFrm3.pBar.Value = 100;
                    System.Threading.Thread.Sleep(1000);
                    msgFrm3.Close();
                    msgBox.Errorr("Atención", bDController.mensajeErrorConsultaPedidos);
                }
            }
            else
            {
                msgFrm.pBar.Value = 100;
                System.Threading.Thread.Sleep(1000);
                msgFrm.Close();
                msgBox.Errorr("Atención", bDController.mensajeErrorConexion);
            }
        }

        public void EscibirVentasCsv()
        {
            pathArchivo = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathArchivo = Path.Combine(pathArchivo, "SistemaPrediccion");
            pathArchivo = Path.Combine(pathArchivo, "Temp");

            if (!Directory.Exists(pathArchivo))
            {
                Directory.CreateDirectory(pathArchivo);
            }

            pathArchivo = Path.Combine(pathArchivo, nombreArchivo);

            using (StreamWriter sw = File.AppendText(pathArchivo))
            {
                sw.WriteLine("fecha;producto;cantidad");

                for (int i = 0; i < listaFecha.Count; i++)
                {
                    sw.WriteLine(listaFecha[i] + ";" + listaCodigo[i] + ";" + listaCantidad[i]);
                }

                sw.Close();
            }

            existeArchivo = true;
        }
    }
}
