using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ScottPlot.Renderable;
using SistemaParaPrediccionDeVentas.Vista.MSGBOX;
using static Plotly.NET.StyleParam.LinearAxisId;

namespace SistemaParaPrediccionDeVentas.Controlador
{
    internal class BDController
    {
        public MySqlConnection conexion;
        private string host;
        private string usuario;
        private string contrasena;
        private string baseDeDatos;
        public string mensajeErrorConexion = "";
        public string mensajeErrorConsultaProductos = "";
        public string mensajeErrorConsultaPedidos = "";
        public bool conectado = false;
        public bool consultaProductos = false;
        public bool consultaPedidos = false;

        public void Conectar()
        {
            AES aes = new AES();
            string queDato = "";
            string cadenaConexion = "";
            FrmConfiguracionController ctrler = new FrmConfiguracionController();
            List<string> datos = new List<string>();
            datos = ctrler.GetConfiguracion();

            //se carga la configuración guardada
            if (datos.Count > 0)
            {
                if (datos[0].Split(" ::: ").Length == 2)
                {
                    queDato = datos[0].Split(" ::: ")[1];
                }
                else
                {
                    queDato = "-1";
                }

                if (queDato.Equals("0")) //configuración para MySQL
                {
                    datos.RemoveRange(0, 1);

                    foreach (string dato in datos)
                    {
                        if (dato.Split(" ::: ").Length == 2)
                        {
                            queDato = aes.DesEncriptarDato(dato.Split(" ::: ")[0]);

                            if (queDato.Equals("host"))
                            {
                                cadenaConexion = cadenaConexion + "Server=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + "; ";
                            }
                            if (queDato.Equals("puerto"))
                            {
                                cadenaConexion = cadenaConexion + "Port=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + "; ";
                            }
                            if (queDato.Equals("usuario"))
                            {
                                cadenaConexion = cadenaConexion + "Uid=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + "; ";
                            }
                            if (queDato.Equals("contrasena"))
                            {
                                cadenaConexion = cadenaConexion + "Pwd=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + "; ";
                            }
                            if (queDato.Equals("baseDeDatos"))
                            {
                                cadenaConexion = cadenaConexion + "Database=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + "; ";
                            }
                        }
                    }

                    try
                    {
                        conexion = new MySqlConnection(cadenaConexion);
                        conexion.Open();
                        conectado = true;
                    }
                    catch (MySqlException e)
                    {
                        mensajeErrorConexion = e.Message;
                        conectado = false;
                    }
                }
            }
        }

        public void Desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public List<string>[] BDSelectProductos(string consulta)
        {
            List<string>[] listaSelect = new List<string>[2];
            listaSelect[0] = new List<string>();
            listaSelect[1] = new List<string>();

            if (conectado)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("select codigo, nombre from (" + consulta + ") as a", conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaSelect[0].Add(reader["codigo"] + "");
                        listaSelect[1].Add(reader["nombre"] + "");
                    }

                    reader.Close();
                    consultaProductos = true;
                }
                catch (MySqlException e)
                {
                    consultaProductos = false;
                    mensajeErrorConsultaProductos = e.Message;
                }

                return listaSelect;
            } else
            {
                return listaSelect;
            }
        }

        public List<string>[] BDSelectPedidos(string consulta)
        {
            List<string>[] listaSelect = new List<string>[3];
            listaSelect[0] = new List<string>();
            listaSelect[1] = new List<string>();
            listaSelect[2] = new List<string>();

            if(conectado)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("select fecha, codigo, cantidad from (" + consulta + ") as b", conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaSelect[0].Add(reader["fecha"] + "");
                        listaSelect[1].Add(reader["codigo"] + "");
                        listaSelect[2].Add(reader["cantidad"] + "");
                    }

                    reader.Close();
                    consultaPedidos = true;
                }
                catch (MySqlException e)
                {
                    consultaPedidos = false;
                    mensajeErrorConsultaPedidos = e.Message;
                }

                return listaSelect;
            }else
            {
                return listaSelect;
            }
        }

    }
}
