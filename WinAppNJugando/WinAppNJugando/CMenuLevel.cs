using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Clases
{
    class CMenuLevel
    {
        #region VARIABLES
        private List<PictureBox> mPictures;
        private int level;

        public List<PictureBox> MPictures
        {
            get
            {
                return mPictures;
            }

            set
            {
                mPictures = value;
            }
        }

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
        #endregion

        #region GETTERS Y SETTERS

        /*
        public List<PictureBox> MPictures { get => mPictures; set => mPictures = value; }
        public int Level { get => level; set => level = value; }
        */
        #endregion

        #region CONSTRUCTORES
        public CMenuLevel()
        {
            MPictures = new List<PictureBox>();
            Level = 1;
        }

        public CMenuLevel(List<PictureBox> Pictures)
        {
            MPictures = Pictures;
            Level = 1;
        }

        #endregion

        #region METODOS
        public void InitializePic(PictureBox pic, String nombre)
        {
            pic.BackColor = Color.Transparent;
            Image image1 = Image.FromFile(Application.StartupPath + @"/Resources/Botones/" + nombre + ".png"); ;
            pic.Image = image1;
            pic.Tag = nombre;
        }

        public void iniciarPics()
        {
            InitializePic(MPictures[0], "11");
            InitializePic(MPictures[1], "3");
            InitializePic(MPictures[2], "2");
            MPictures[0].Tag = "1";
        }

        public void devolverLevel(string mov)
        {
            if (mov == "next")
            {
                if (Level < 3)
                {
                    Level += 1;
                }
                else if (Level == 3)
                {
                    Level = 1;
                }
            }
            else
            {
                if (Level > 1)
                {
                    Level -= 1;
                }
                else if (Level == 1)
                {
                    Level = 3;
                }
            }
        }

        public void moveNext()
        {
            string[] auxArray = new string[3];
            string ban;

            for (int i = 0; i < auxArray.Length; i++)
            {
                auxArray[i] = MPictures[i].Tag.ToString();
            }

            ban = auxArray[2];

            auxArray[2] = auxArray[2] + "1";
            InitializePic(MPictures[0], auxArray[2]);
            InitializePic(MPictures[1], auxArray[0]);
            InitializePic(MPictures[2], auxArray[1]);

            MPictures[0].Tag = ban;
            devolverLevel("next");
        }

        public void moveAnt()
        {
            string[] auxArray = new string[3];
            string ban;

            for (int i = 0; i < auxArray.Length; i++)
            {
                auxArray[i] = MPictures[i].Tag.ToString();
            }
            ban = auxArray[1];

            auxArray[1] = auxArray[1] + "1";
            InitializePic(MPictures[0], auxArray[1]);
            InitializePic(MPictures[1], auxArray[2]);
            InitializePic(MPictures[2], auxArray[0]);

            MPictures[0].Tag = ban;
            devolverLevel("ant");
        }

        #endregion
    }
}