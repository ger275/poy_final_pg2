using System;
using System.Collections.Generic;
using System.Data.Odbc;
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
        public MySqlConnection conexion = new MySqlConnection();
        public OdbcConnection conexionSQLServer = new OdbcConnection();
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
                } else if (queDato.Equals("1")) //configuración para SQL Server 2000
                {
                    datos.RemoveRange(0, 1);
                    cadenaConexion = "Driver={SQL Server};";

                    foreach (string dato in datos)
                    {
                        if (dato.Split(" ::: ").Length == 2)
                        {
                            queDato = aes.DesEncriptarDato(dato.Split(" ::: ")[0]);

                            if (queDato.Equals("host"))
                            {
                                cadenaConexion += "Server=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + ";";
                            }
                            if (queDato.Equals("puerto"))
                            {
                                //cadenaConexion = cadenaConexion + "Port=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + "; ";
                            }
                            if (queDato.Equals("usuario"))
                            {
                                cadenaConexion += "UID=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + ";";
                            }
                            if (queDato.Equals("contrasena"))
                            {
                                cadenaConexion += "PWD=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + ";";
                            }
                            if (queDato.Equals("baseDeDatos"))
                            {
                                cadenaConexion += "Database=" + aes.DesEncriptarDato(dato.Split(" ::: ")[1]) + ";";
                            }
                        }
                    }

                    try
                    {
                        conexionSQLServer = new OdbcConnection(cadenaConexion);
                        conexionSQLServer.Open();
                        conectado = true;
                    }
                    catch (Exception ex)
                    {
                        mensajeErrorConexion = ex.Message;
                        conectado = false;
                    }
                }
            }
        }

        public void Desconectar()
        {
            try
            {
                if (conexion.State.ToString() == "Open")
                {
                    conexion.Close();
                } else if (conexionSQLServer.State.ToString() == "Open")
                {
                    conexionSQLServer.Close();
                }
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
                if (conexion.State.ToString() == "Open" && conexionSQLServer.State.ToString() == "Closed")
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
                } else if (conexion.State.ToString() == "Closed" && conexionSQLServer.State.ToString() == "Open")
                {
                    try
                    {
                        OdbcCommand ocmd = new OdbcCommand("select codigo, nombre from (" + consulta + ") as a", conexionSQLServer);
                        OdbcDataReader reader = ocmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listaSelect[0].Add(reader["codigo"] + "");
                            listaSelect[1].Add(reader["nombre"] + "");
                        }

                        reader.Close();
                        consultaProductos = true;
                    } catch (Exception e)
                    {
                        consultaProductos = false;
                        mensajeErrorConsultaProductos = e.Message;
                    }
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
                if (conexion.State.ToString() == "Open" && conexionSQLServer.State.ToString() == "Closed")
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("select date_format(fecha, '%Y-%m-%d') as fecha, codigo, floor(cantidad) as cantidad from (" + consulta + ") as b", conexion);
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
                }
                else if (conexion.State.ToString() == "Closed" && conexionSQLServer.State.ToString() == "Open")
                {
                    try
                    {
                        OdbcCommand ocmd = new OdbcCommand("select fecha as fecha, codigo as codigo, floor(cantidad) as cantidad from (" + consulta + ") as b", conexionSQLServer);
                        OdbcDataReader reader = ocmd.ExecuteReader();

                        while (reader.Read())
                        {
                            listaSelect[0].Add(reader["fecha"] + "");
                            listaSelect[1].Add(reader["codigo"] + "");
                            listaSelect[2].Add(reader["cantidad"] + "");
                        }

                        reader.Close();
                        consultaPedidos = true;
                    }
                    catch (Exception e)
                    {
                        consultaPedidos = false;
                        mensajeErrorConsultaPedidos = e.Message;
                    }
                }

                return listaSelect;
            }else
            {
                return listaSelect;
            }
        }

        public int BDSelectVentaMes(string consulta, int mes, int anio, string codigoProducto)
        {
            int cantidad = 0;

            if (conectado)
            {
                if (conexion.State.ToString() == "Open" && conexionSQLServer.State.ToString() == "Closed")
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("select floor(ifnull(sum(cantidad))) as cantidad from (" + consulta + ") as b where month(fecha) = " + mes.ToString() + " and year(fecha) = " + anio.ToString() + " and codigo = '" + codigoProducto + "'", conexion);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            cantidad = Int32.Parse(reader["cantidad"] + "");
                        }

                        reader.Close();
                    }
                    catch (MySqlException e)
                    {

                    }
                }
                else if (conexion.State.ToString() == "Closed" && conexionSQLServer.State.ToString() == "Open")
                {
                    try
                    {
                        OdbcCommand ocmd = new OdbcCommand("select floor(isnull(sum(cantidad))) as cantidad from (" + consulta + ") as b where month(fecha) = " + mes.ToString() + " and year(fecha) = " + anio.ToString() + " and codigo = '" + codigoProducto + "'", conexionSQLServer);
                        OdbcDataReader reader = ocmd.ExecuteReader();

                        while (reader.Read())
                        {
                            cantidad = Int32.Parse(reader["cantidad"] + "");
                        }

                        reader.Close();
                    }
                    catch (Exception e)
                    {

                    }
                }
            }

            return cantidad;
        }

    }
}
