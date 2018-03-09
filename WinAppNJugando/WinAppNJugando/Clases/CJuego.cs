using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Clases
{
    class CJuego
    {
        private CPictures picImages;
        private int level;
        private int aciertos, fallos;

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public int Aciertos
        {
            get
            {
                return aciertos;
            }

            set
            {
                aciertos = value;
            }
        }

        public int Fallos
        {
            get
            {
                return fallos;
            }

            set
            {
                fallos = value;
            }
        }

        internal CPictures PicImages { get => picImages; set => picImages = value; }

        public CJuego(List<PictureBox> Pictures)
        {
            picImages = new CPictures(Pictures);
            Level = 1;
        }

        public CJuego(List<PictureBox> Pictures, int nivel)
        {
            picImages = new CPictures(Pictures);
            Level = nivel;
        }

        public void mostrarImagenes()
        {
            picImages.imgRandom();
        }
    }
}
