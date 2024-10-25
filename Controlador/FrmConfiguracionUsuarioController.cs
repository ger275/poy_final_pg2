using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParaPrediccionDeVentas.Controlador
{
    internal class FrmConfiguracionUsuarioController
    {
        public List<string> GetConfiguracion()
        {
            string nombreArchivo = "usuario.txt";
            string linea = "";
            List<string> lineaArray = new List<string>();
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "ConfiguracionUsuario");

            if (!Directory.Exists(pathRaiz)) { Directory.CreateDirectory(pathRaiz); }

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            if (File.Exists(pathRaiz))
            {
                using (StreamReader sr = new StreamReader(pathRaiz))
                {
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
