using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.IO;
using System.Collections.Generic;

namespace WinAppProyectoFinal.Clases
{
    class CPictures
    {
        #region VARIABLES

        private List<CImage> mArrayImagesEscuela;
        private List<CImage> mArrayImagesCasa;
        private List<PictureBox> mPictures;
        private ArrayList mNombres;

        #endregion

        //CONSTRUCTORES

        public CPictures(List<PictureBox> Pictures)
        {
            //IGUALAMOS LISTA DE PICTUREBOXES PARA LUEGO TRABAjAR CON ELLOS
            mPictures = Pictures;

            //CREAMOS UNA CLASE ARCHIVO QUE PERMITE EL MANEJO DE ARCHIVOS Y OBTENER NOMBRES DE 
            //OBJETOS DE ESCUELA Y CASA 
            CArchivos archivo = new CArchivos();

            mNombres = archivo.obtenerDatos("Escuela");

            //CREAMOS LISTAS CON LOS NOMBRES DE LOS ARCHIVOS DE ESCUELA Y CASA POR SEPARADO
            mArrayImagesEscuela = new List<CImage>();
            mArrayImagesCasa = new List<CImage>();

            for (int i = 0; i < mNombres.Count; i++)
            {
                mArrayImagesEscuela.Add(new CImage(mNombres[i].ToString(), mNombres[i].ToString()));
            }

            archivo = new CArchivos();

            mNombres = archivo.obtenerDatos("Casa");

            for (int i = 0; i < mNombres.Count; i++)
            {
                mArrayImagesCasa.Add(new CImage(mNombres[i].ToString(), mNombres[i].ToString()));
            }
        }

        //METODOS

        public void pictureBoxesRandom()
        {
            //BASADO EN ALGORIMO DE FISHER
            Random random = new Random();

            //RANDOMICO DE PICTUREBOX

            int num;

            for (int i = mPictures.Count - 1; i >= 1; i--)
            {
                num = random.Next(i);

                PictureBox temp = mPictures[num];

                mPictures[num] = mPictures[i];

                mPictures[i] = temp;
            }

            for (int i = mPictures.Count - 1; i >= 1; i--)
            {
                num = random.Next(i);

                PictureBox temp = mPictures[num];

                mPictures[num] = mPictures[i];

                mPictures[i] = temp;
            }
        }

        public void imgRandom()
        {
            Random random = new Random();

            int num;

            pictureBoxesRandom();
            pictureBoxesRandom();

            bool confirmacion;

            for (int i = 0; i < mPictures.Count; i++)
            {
                confirmacion = true;
                do
                {
                    num = random.Next(0, 6);

                    if (i < (mPictures.Count / 2))
                    {
                        confirmacion = mArrayImagesCasa[num].comprobarEstado();
                    }
                    else
                    {
                        confirmacion = mArrayImagesEscuela[num].comprobarEstado();
                    }
                } while (confirmacion == false);

                if (i < (mPictures.Count / 2))
                {
                    mPictures[i].Image = mArrayImagesCasa[num].obtenerImagen("Casa");
                    mArrayImagesCasa[num].Disponibilidad = false;
                    mPictures[i].Tag = "Casa";
                }
                else
                {
                    mPictures[i].Image = mArrayImagesEscuela[num].obtenerImagen("Escuela");
                    mArrayImagesEscuela[num].Disponibilidad = false;
                    mPictures[i].Tag = "Escuela";
                }
            }
        }

    }
}
