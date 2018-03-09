using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

namespace WinAppProyectoFinal.Clases
{
    class CArchivos
    {
        private ArrayList nombres;
        private StreamReader archivo;
        private String line;

        public CArchivos()
        {
            nombres = new ArrayList();
            line = "";
        }
        
        public ArrayList obtenerDatos(string Seleccion)
        {
            try
            {
                archivo = new StreamReader(Application.StartupPath + @"/Resources/" + Seleccion + ".txt",System.Text.Encoding.Default);

                while (!archivo.EndOfStream)
                {
                    line = archivo.ReadLine();
                    nombres.Add(line);
                }
            }
            catch
            {
                MessageBox.Show("NO EXISTE ARCHIVO DE " + Seleccion + ".txt");
            }

            return (nombres);
        }
    }
}
