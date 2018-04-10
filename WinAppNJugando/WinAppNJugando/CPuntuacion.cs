using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Clases
{
    class CPuntuacion
    {
        private ArrayList mNombres;
        private List<string> messages;
        CArchivos archivo;
        
        public CPuntuacion()
        {
            archivo = new CArchivos();
            messages = new List<string>();
            mNombres = archivo.obtenerDatos("Mensajes");

            for (int i = 0; i < mNombres.Count; i++)
            {
                messages.Add(mNombres[i].ToString());
            }
        }

        public string sendMessage()
        {
            int min, max,index;
            string nMessage;

            min = 0;
            max = messages.Count;
            Random rnd = new Random();
            index=rnd.Next(min, max);

            nMessage=messages[index];

            return nMessage;
        }
    }
}
