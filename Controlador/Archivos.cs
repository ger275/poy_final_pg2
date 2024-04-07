using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SistemaParaPrediccionDeVentas.Controlador
{
    internal class Archivos
    {
        public Archivos()
        {

        }

        //Metodo para validar la estructura de los archivos cargados
        public bool EstructuraValida(string filePath, int columnas)
        {
            string separador = "";
            string[] lineaArray = null;
            string linea = "";

            using (StreamReader sr = new StreamReader(filePath))
            {
                linea = sr.ReadLine();

                if ((lineaArray = linea.Split(",")).Length == columnas)
                {
                    separador = ",";
                } else if ((lineaArray = linea.Split(";")).Length == columnas)
                {
                    separador = ";";
                }

                if (separador != "")
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if ((lineaArray = linea.Split(separador)).Length == columnas)
                        {
                            for (int i = 0; i < columnas; i++)
                            {
                                if (lineaArray[i] == "")
                                {
                                    goto estructuraInvalida;
                                }
                            }
                        }
                        else
                        {
                            goto estructuraInvalida;
                        }
                    }

                    return true;
                }
                else
                {
                    goto estructuraInvalida;
                }
            }

        estructuraInvalida:
            return false;
        }

        //Metodo utilizado para hacer la carga del archivo con los datos del producto
        public void CargarProductos(string pathOrigen)
        {
            string separador = "";
            string linea = "";
            string[] lineaArray = null;

            using (StreamReader sr = new StreamReader(pathOrigen))
            {
                linea = sr.ReadLine();

                if ((lineaArray = linea.Split(",")).Length == 2)
                {
                    separador = ",";
                }
                else if ((lineaArray = linea.Split(";")).Length == 2)
                {
                    separador = ";";
                }

                while ((linea = sr.ReadLine()) != null)
                {
                    lineaArray = linea.Split(separador);

                    if (!ExisteProducto(lineaArray[0]))
                    {
                        EscribirProducto(lineaArray);
                    }
                }
            }
        }

        private bool ExisteProducto(string producto)
        {
            string linea = "";
            string codigoDesencriptado = "";
            string[] lineaArray = null;
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion");
            pathRaiz = Path.Combine(pathRaiz, "Datos");

            if (!Directory.Exists(pathRaiz))
            {
                Directory.CreateDirectory(pathRaiz);
            }

            pathRaiz = Path.Combine(pathRaiz, "PRODUCTOS.csv");

            if (!File.Exists(pathRaiz))
            {
                using (StreamWriter sw = File.AppendText(pathRaiz))
                {
                    sw.WriteLine("codigo;nombre");
                    sw.Close();
                }
            }

            using (StreamReader sr = new StreamReader(pathRaiz))
            {
                linea = sr.ReadLine();

                while ((linea = sr.ReadLine()) != null)
                {
                    lineaArray = linea.Split(";");

                    codigoDesencriptado = DesEncriptarDato(lineaArray[0]);

                    if (codigoDesencriptado == producto)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        private void EscribirProducto(string[] producto)
        {
            string codigoEncript = "";
            string productoEncript = "";
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Datos", "PRODUCTOS.csv");

            codigoEncript = EncriptarDato(producto[0]);
            productoEncript = EncriptarDato(producto[1]);

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine(codigoEncript + ";" + productoEncript);
                sw.Close();
            }
        }

        public void CargarVentas(string pathOrigen)
        {
            DateTime fecha = DateTime.Now;
            string separador = "";
            string linea = "";
            string nombreArchivo = "";
            string[] lineaArray = null;
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "HistorialVentas");

            if (!Directory.Exists(pathRaiz))
            {
                Directory.CreateDirectory(pathRaiz);
            }

            nombreArchivo = Path.GetFileNameWithoutExtension(pathOrigen) + "_" + fecha.Year.ToString() + "_" + fecha.Month.ToString() + "_" + fecha.Day.ToString() + "_" + fecha.Hour.ToString() + "_" + fecha.Minute.ToString() + "_" + fecha.Second.ToString() + ".csv";

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine("fecha;cantidad");
                sw.Close();
            }

            using (StreamReader sr = new StreamReader(pathOrigen))
            {
                linea = sr.ReadLine();

                if ((lineaArray = linea.Split(",")).Length == 2)
                {
                    separador = ",";
                }
                else if ((lineaArray = linea.Split(";")).Length == 2)
                {
                    separador = ";";
                }

                while ((linea = sr.ReadLine()) != null)
                {
                    lineaArray = linea.Split(separador);

                    EscribirVenta(lineaArray, pathRaiz);
                }
            }
        }

        private void EscribirVenta(string[] venta, string pathRaiz)
        {
            string fechaEncript = "";
            string cantidadEncript = "";

            fechaEncript = EncriptarDato(venta[0]);
            cantidadEncript = EncriptarDato(venta[1]);

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine(fechaEncript + ";" + cantidadEncript);
                sw.Close();
            }
        }

        public string DesencriptarTemp(string pathOrigen)
        {
            string linea = "";
            string[] lineaArray = null;
            string nombreArchivo = Path.GetFileName(pathOrigen);
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Temp", nombreArchivo);

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine("fecha;cantidad");
                sw.Close();
            }

            using (StreamReader sr = new StreamReader(pathOrigen))
            {
                linea = sr.ReadLine();

                while ((linea = sr.ReadLine()) != null)
                {
                    lineaArray = linea.Split(";");

                    EscribirTemp(lineaArray, pathRaiz);
                }
            }

            return pathRaiz;
        }

        public void EscribirTemp(string[] venta, string pathRaiz)
        {
            string fechaDesEncript = "";
            string cantidadDesEncript = "";

            fechaDesEncript = DesEncriptarDato(venta[0]);
            cantidadDesEncript = DesEncriptarDato(venta[1]);

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine(fechaDesEncript + ";" + cantidadDesEncript);
                sw.Close();
            }
        }

        public void GuardarPrediccion(string codigoProducto, float valorPredicho)
        {
            DateTime fecha = DateTime.Now;
            string nombreArchivo = "";
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Pedicciones");
            string nombreProductoEncriptado = GetNombreProducto(codigoProducto);
            string codigoProductoEncriptado = EncriptarDato(codigoProducto);

            if (!Directory.Exists(pathRaiz))
            {
                Directory.CreateDirectory(pathRaiz);
            }

            nombreArchivo = codigoProducto + "_" + fecha.Year.ToString() + "_" + fecha.Month.ToString() + "_" + fecha.Day.ToString() + "_" + fecha.Hour.ToString() + "_" + fecha.Minute.ToString() + "_" + fecha.Second.ToString() + ".csv";

            pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

            using (StreamWriter sw = File.AppendText(pathRaiz))
            {
                sw.WriteLine("codigo;nombre;valorPredicho");
                sw.WriteLine(codigoProductoEncriptado + ";" + nombreProductoEncriptado + ";" + EncriptarDato(valorPredicho.ToString()));
                sw.Close();
            }
        }

        public string GetNombreProducto(string codigoProducto)
        {
            string linea = "";
            string nombreEncriptado = "";
            string codigoDesencriptado = "";
            string[] lineaArray = null;
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Datos", "PRODUCTOS.csv");

            if (File.Exists(pathRaiz))
            {
                using (StreamReader sr = new StreamReader(pathRaiz))
                {
                    linea = sr.ReadLine();

                    while ((linea = sr.ReadLine()) != null)
                    {
                        lineaArray = linea.Split(";");

                        codigoDesencriptado = DesEncriptarDato(lineaArray[0]);

                        if (codigoDesencriptado == codigoProducto)
                        {
                            nombreEncriptado = lineaArray[1];

                            goto Encontrado;
                        }
                    }
                }
            }

        Encontrado:

            return nombreEncriptado;
        }

        public string EncriptarDato(string datoDesencriptado)
        {
            AES aes = new AES();
            string datoEncriptado = "";

            using (Aes encript = Aes.Create())
            {
                byte[] llave = new byte[16];
                byte[] i_v = new byte[16];
                
                datoEncriptado = aes.Encriptar(datoDesencriptado, llave, i_v);
            }

            return datoEncriptado;
        }

        public string DesEncriptarDato(string datoEncriptado)
        {
            AES aes = new AES();
            string datoDesEncriptado = "";

            using (Aes encript = Aes.Create())
            {
                byte[] llave = new byte[16];
                byte[] i_v = new byte[16];

                datoDesEncriptado = aes.DesEncriptar(datoEncriptado, llave, i_v);
            }

            return datoDesEncriptado;
        }

        public void GuardarReporteComparativo(string path, float mes, float cantidad, string codigoProducto)
        {
            DateTime fecha = DateTime.Now;
            int contadorAux = 0;
            string nombreArchivo = "";
            string linea = "";
            List<string> lineaArray = new List<string>();
            string pathRaiz = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathRaiz = Path.Combine(pathRaiz, "SistemaPrediccion", "Comparativos");

            if (!Directory.Exists(pathRaiz))
            {
                Directory.CreateDirectory(pathRaiz);
            }

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    linea = sr.ReadLine();

                    contadorAux = 0;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        lineaArray.Add(linea);

                        contadorAux = contadorAux + 1;
                    }

                    lineaArray.Add(mes.ToString() + ";" + cantidad.ToString());
                }

                contadorAux = 0;

                nombreArchivo = Path.GetFileNameWithoutExtension(path) + "_" + fecha.Year.ToString() + "" + fecha.Month.ToString() + "" + fecha.Day.ToString() + "" + fecha.Hour.ToString() + "" + fecha.Minute.ToString() + "" + fecha.Second.ToString() + ".csv";
                pathRaiz = Path.Combine(pathRaiz, nombreArchivo);

                using (StreamWriter sw = File.AppendText(pathRaiz))
                {
                    sw.WriteLine("codigo;producto");
                    sw.WriteLine(EncriptarDato(codigoProducto) + ";" + GetNombreProducto(codigoProducto));

                    sw.WriteLine("fecha;cantidad");

                    string[] arrayTemp = lineaArray.ToArray();
                    
                    for (int i = (arrayTemp.Length - 1); i >= 0; i--)
                    {
                        if (contadorAux <= 5)
                        {
                            string[] lineaArrayTemp = null;
                            lineaArrayTemp = arrayTemp[i].Split(";");

                            sw.WriteLine(EncriptarDato(lineaArrayTemp[0]) + ";" + EncriptarDato(lineaArrayTemp[1]));
                        }

                        contadorAux++;
                    }

                    sw.Close();
                }
            }

        }

    }
}
