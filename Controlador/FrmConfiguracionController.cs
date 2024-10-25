using Microsoft.ML.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParaPrediccionDeVentas.Controlador
{
    internal class FrmConfiguracionController
    {
        public FrmConfiguracionController()
        {

        }

        public bool GuardarConfiguracionMySQL(string host, string puerto, string usuario, string contrasena, string baseDeDatos, string consultaProductos, string consultaPedidos)
        {
            AES aES = new AES();
            string nombreArchivo = "ConfigBDMySQL.txt";
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Configuracion");

            if (!Directory.Exists(pathRaiz)) { Directory.CreateDirectory(pathRaiz); }

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            if (File.Exists(pathRaiz)) { File.Delete(pathRaiz); }

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine(aES.EncriptarDato("host") + " ::: " + host);
                sw.WriteLine(aES.EncriptarDato("puerto") + " ::: " + puerto);
                sw.WriteLine(aES.EncriptarDato("usuario") + " ::: " + usuario);
                sw.WriteLine(aES.EncriptarDato("contrasena") + " ::: " + contrasena);
                sw.WriteLine(aES.EncriptarDato("baseDeDatos") + " ::: " + baseDeDatos);
                sw.WriteLine(aES.EncriptarDato("productos") + " ::: " + consultaProductos);
                sw.WriteLine(aES.EncriptarDato("pedidos") + " ::: " + consultaPedidos);
                sw.Close();
            }

            //se elimina la configuración de sql server en caso exista
            nombreArchivo = "ConfigBDSQLServer.txt";
            pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Configuracion");

            if (!Directory.Exists(pathRaiz)) { Directory.CreateDirectory(pathRaiz);}

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            if (File.Exists(pathRaiz)) { File.Delete(pathRaiz); }

            return true;
        }

        public bool GuardarConfiguracionSQLServer(string host, string puerto, string usuario, string contrasena, string baseDeDatos, string consultaProductos, string consultaPedidos)
        {
            AES aES = new AES();
            string nombreArchivo = "ConfigBDSQLServer.txt";
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Configuracion");

            if (!Directory.Exists(pathRaiz)) { Directory.CreateDirectory(pathRaiz); }

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            if (File.Exists(pathRaiz)) { File.Delete(pathRaiz); }

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine(aES.EncriptarDato("host") + " ::: " + host);
                sw.WriteLine(aES.EncriptarDato("puerto") + " ::: " + puerto);
                sw.WriteLine(aES.EncriptarDato("usuario") + " ::: " + usuario);
                sw.WriteLine(aES.EncriptarDato("contrasena") + " ::: " + contrasena);
                sw.WriteLine(aES.EncriptarDato("baseDeDatos") + " ::: " + baseDeDatos);
                sw.WriteLine(aES.EncriptarDato("productos") + " ::: " + consultaProductos);
                sw.WriteLine(aES.EncriptarDato("pedidos") + " ::: " + consultaPedidos);
                sw.Close();
            }

            //se elimina la configuración de MySql en caso exista
            nombreArchivo = "ConfigBDMySQL.txt";
            pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Configuracion");

            if (!Directory.Exists(pathRaiz)) { Directory.CreateDirectory(pathRaiz); }

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            if (File.Exists(pathRaiz)) { File.Delete(pathRaiz); }

            return true;
        }

        public List<string> GetConfiguracion() //este metodo se llama desde la vista de configuracion y desde el controlador de la base de datos para recuperar la configuración guardada
        {
            string nombreArchivo = "ConfigBDMySQL.txt";
            string linea = "";
            List<string> lineaArray = new List<string>();
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Configuracion");

            if (!Directory.Exists(pathRaiz)) { Directory.CreateDirectory(pathRaiz); }

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            if (File.Exists(pathRaiz))
            {
                using (StreamReader sr = new StreamReader(pathRaiz))
                {
                    lineaArray.Add("servidor ::: 0");

                    while ((linea = sr.ReadLine()) != null)
                    {
                        lineaArray.Add(linea);
                    }
                }

                return lineaArray;
            }

            nombreArchivo = "ConfigBDSQLServer.txt";
            linea = "";
            lineaArray = new List<string>();
            pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Configuracion");

            if (!Directory.Exists(pathRaiz)) { Directory.CreateDirectory(pathRaiz); }

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            if (File.Exists(pathRaiz))
            {
                using (StreamReader sr = new StreamReader(pathRaiz))
                {
                    lineaArray.Add("servidor ::: 1");

                    while ((linea = sr.ReadLine()) != null)
                    {
                        lineaArray.Add(linea);
                    }
                }
            }

            return lineaArray;
        }

    }
}
