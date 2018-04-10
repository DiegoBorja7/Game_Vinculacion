using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Clases
{
    class CImage
    {
        #region Variables
        private String nombre, audio;
        private bool disponibilidad;
        

        #endregion

        #region Constructores
        public CImage()
        {
            nombre = audio = "";
            disponibilidad = true;
        }

        public CImage(String nombre, String audio)
        {
            this.nombre = nombre;
            this.audio = audio;
            disponibilidad = true;
        }

        #endregion

        #region Getters y Setters
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Audio
        {
            get
            {
                return audio;
            }

            set
            {
                audio = value;
            }
        }

        public bool Disponibilidad
        {
            get
            {
                return disponibilidad;
            }

            set
            {
                disponibilidad = value;
            }
        }

        #endregion

        #region Métodos

        public bool comprobarEstado()
        {
            if (disponibilidad == true)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public Image obtenerImagen(String origen)
        {
            string ruta = Application.StartupPath + @"\Resources\" + origen + "\\" + nombre + ".png";
            Image imagen;
            try
            {
                imagen = Image.FromFile(ruta);
            }
            catch
            {
                MessageBox.Show("ERROR");
                imagen = null;
            }


            return (imagen);
        }



        #endregion
    }
}
