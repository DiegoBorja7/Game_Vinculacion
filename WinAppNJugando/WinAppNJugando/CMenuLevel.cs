using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Clases
{
    class CMenuLevel
    {
        #region VARIABLES
        private List<PictureBox> mPictures;
        private int level;
        SoundPlayer player;


        #endregion

        #region GETTERS Y SETTERS

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

        #region CONSTRUCTORES
        public CMenuLevel()
        {
            MPictures = new List<PictureBox>();
            Level = 1;
            player = new SoundPlayer();
        }

        public CMenuLevel(List<PictureBox> Pictures)
        {
            MPictures = Pictures;
            Level = 1;
            player = new SoundPlayer();
        }

        #endregion

        #region METODOS
        public void InitializePic(PictureBox pic, String nombre)
        {
            pic.BackColor = Color.Transparent;
            Image image1 = Image.FromFile(Application.StartupPath + @"/Resources/Botones/" + nombre + ".png"); ;
            pic.Image = image1;
            //pic.Tag = nombre;
        }

        public void iniciarPics()
        {
            InitializePic(MPictures[0], "11");
            InitializePic(MPictures[1], "31");
            InitializePic(MPictures[2], "21");
            //MPictures[0].Tag = "1";
        }

        public void ImgSeleccion(PictureBox pic, string nombre)
        {
            int bandera = -1;

            try
            {
                player.Stop();
            }
            catch { }

            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\" + nombre + ".wav");

            for (int i = 0; i < mPictures.Count; i++)
            {
                if (mPictures[i] == pic)
                {
                    try
                    {
                        player.Play();
                    }
                    catch { }
                    bandera = i;
                    pic.Size = new Size(265, 265);
                    pic.BringToFront();
                    break;
                }
            }

            if (bandera == 0)
            {
                pic.Location = new Point(275, 233);
                for (int j = 0; j < mPictures.Count; j++)
                {
                    if (j != bandera)
                    {
                        mPictures[j].Size = new Size(140, 140);
                        if (mPictures[j].Tag.ToString() == "Medio")
                        {
                            mPictures[j].Location = new Point(125, 115);
                        }
                        if (mPictures[j].Tag.ToString() == "Dificil")
                        {
                            mPictures[j].Location = new Point(550, 115);
                        }
                    }
                }

            }

            else if (bandera == 2)
            {
                pic.Location = new Point(75, 115);
                for (int j = 0; j < mPictures.Count; j++)
                {
                    if (j != bandera)
                    {
                        mPictures[j].Size = new Size(140, 140);
                    }
                    if (mPictures[j].Tag.ToString() == "Facil")
                    {
                        mPictures[j].Location = new Point(345, 333);
                    }
                    if (mPictures[j].Tag.ToString() == "Dificil")
                    {
                        mPictures[j].Location = new Point(555, 115);
                    }
                }
            }
            else
            {
                pic.Location = new Point(475, 115);
                for (int j = 0; j < mPictures.Count; j++)
                {
                    if (j != bandera)
                    {
                        mPictures[j].Size = new Size(140, 140);
                    }
                    if (mPictures[j].Tag.ToString() == "Facil")
                    {
                        mPictures[j].Location = new Point(320, 333);
                    }
                    if (mPictures[j].Tag.ToString() == "Medio")
                    {
                        mPictures[j].Location = new Point(125, 115);
                    }
                }
            }
            bandera = -1;
        }

        #endregion
    }
}