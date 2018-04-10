using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Reflection;

namespace RegiAnimal
{
    class CInitializePictureBox
    {
        private Bitmap myBitmap;
        private SoundPlayer player;
        private CPictureSounds sound = new CPictureSounds();

        private Point[] position = new Point[8];

        private string[] scoreImages = new string[3] { "PuntuacionBaja", "PuntuacionMedia", "PuntuacionAlta" };

        private Random random = new Random();

        public void PointsReturn(ref PictureBox[] back)
        {
            for (int i = 0; i < 8; i++)
            {
                position[i] = back[i].Location;
            }
        }

        public void PositionReturn(ref PictureBox[] retornos)
        {
            int[] randomNum = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };


            int auxiliar = 0;
            int contador = 0;

            for (int i = 0; i < 8; i++)
            {
                auxiliar = random.Next(8);
                bool continuar = false;

                while (!continuar)
                {
                    for (int j = 0; j <= contador; j++)
                    {
                        if (auxiliar == randomNum[j])
                        {
                            continuar = true;
                            j = contador;
                        }
                    }

                    if (continuar)
                    {
                        auxiliar = random.Next(8);
                        continuar = false;
                    }
                    else
                    {
                        continuar = true;
                        randomNum[i] = auxiliar;
                        contador++;
                    }
                }
            }
            for(int h=0;h<8;h++)
            {
                retornos[h].Location =position[randomNum[h]];
            }

        }       

        public void RefreshPictureBox(ref PictureBox[] images, ref PictureBox[] destinos, ref int hitsok, ref int hits, ref Label score)
        {
            for (int i= 0;i<8;i++)
            {
                images[i].Enabled = true;
            }
            for (int j = 0; j < 12; j++)
            {
                destinos[j].Enabled = true;
            }
            hitsok = 0;
            hits = 0;
            score.Text = "0";
        }
        
        public void PositionImages(ref PictureBox[] retornos, ref PictureBox [] images)
        {
            for(int i =0; i<8;i++)
            {
                images[i].Location = retornos[i].Location;
            }
        }

        public void VisibilityDestination(ref PictureBox [] destinos,Label lblBegin)
        {
            lblBegin.BackColor = Color.Transparent;
            for(int i=0;i<12;i++)
            {
                destinos[i].BackColor = Color.Transparent;
            }
        }

        public void VisibilityReturn(ref PictureBox[] retornos)
        {
            for (int i = 0; i < 8; i++)
            {
                retornos[i].BackColor = Color.Transparent;
            }
        }

        public void draggableDisable(ref PictureBox[] images)
        {
            for(int i=0;i<8;i++)
            {
                ControlExtension.Draggable(images[i], false);
            }
        }

        public void setDraggable(ref PictureBox[] images)
        {
            for (int i = 0; i < 8; i++)
            {
                ControlExtension.Draggable(images[i], true);
            }
        }

        public void score(PictureBox picScore, int hits)
        {
            picScore.Visible = true;           
            picScore.BackColor = Color.Transparent;

            if ((hits > (-1)) && (hits < 4))
            {
                player = new SoundPlayer(Application.StartupPath + @"/Audio/" + scoreImages[0] + ".wav");
                player.Play();
                myBitmap = new Bitmap(Application.StartupPath + @"/Puntuacion/" + scoreImages[0] + ".png");
                picScore.Image = myBitmap;
            }
            if ((hits == 4) || (hits == 5))
            {
                player = new SoundPlayer(Application.StartupPath + @"/Audio/" + scoreImages[1] + ".wav");
                player.Play();
                myBitmap = new Bitmap(Application.StartupPath + @"/Puntuacion/" + scoreImages[1] + ".png");
                picScore.Image = myBitmap;
            }
            if ((hits > 5) && (hits < 9))
            {
                player = new SoundPlayer(Application.StartupPath + @"/Audio/" + scoreImages[2] + ".wav");
                player.Play();
                myBitmap = new Bitmap(Application.StartupPath + @"/Puntuacion/" + scoreImages[2] + ".png");
                picScore.Image = myBitmap;
            }            

        }
    }
}
