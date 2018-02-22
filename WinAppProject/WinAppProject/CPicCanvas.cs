using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;



namespace WinAppProject
{
    class CPicCanvas
    {
        private Point[] position = new Point[6] {new Point(116, 118), new Point(28, 319), new Point(143, 492),
                                                 new Point(995, 26), new Point(1154,249), new Point(995, 447)
                                                 };

        private Random random = new Random();

        public void PositionReturn(PictureBox picImage1, PictureBox picImage2, PictureBox picImage3,
                                    PictureBox picImage4, PictureBox picImage5, PictureBox picImage6)
        {
            int[] randomNum = new int[6] {-1, -1, -1, -1, -1, -1 };


            int auxiliar = 0;
            int contador = 0;

            for (int i = 0; i < 6; i++)
            {
                auxiliar = random.Next(6);
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
                        auxiliar = random.Next(6);
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
            picImage1.Location = position[randomNum[0]];
            picImage2.Location = position[randomNum[1]];
            picImage3.Location = position[randomNum[2]];
            picImage4.Location = position[randomNum[3]];
            picImage5.Location = position[randomNum[4]];
            picImage6.Location = position[randomNum[5]];

        }

        public void PositionImages(PictureBox picImage1, PictureBox picImage2, PictureBox picImage3,
                                    PictureBox picImage4, PictureBox picImage5, PictureBox picImage6,
                                    PictureBox picImgCasa1, PictureBox picImgCasa2, PictureBox picImgCasa3,
                                    PictureBox picImgEscuela1, PictureBox picImgEscuela2, PictureBox picImgEscuela3)
        {
            picImgCasa2.Location = picImage1.Location;
            picImgCasa1.Location = picImage2.Location;
            picImgCasa3.Location = picImage3.Location;

            picImgEscuela1.Location = picImage4.Location;
            picImgEscuela2.Location = picImage5.Location;
            picImgEscuela3.Location = picImage6.Location;
        }

        public void VisibilityDestination(PictureBox picDestinoCasa1, PictureBox picDestinoCasa2, PictureBox picDestinoCasa3,
                                        PictureBox picDestinoEscuela1, PictureBox picDestinoEscuela2, PictureBox picDestinoEscuela3)

        {
            picDestinoCasa1.BackColor = Color.Transparent;
            picDestinoCasa2.BackColor = Color.Transparent;
            picDestinoCasa3.BackColor = Color.Transparent;
            picDestinoEscuela1.BackColor = Color.Transparent;
            picDestinoEscuela2.BackColor = Color.Transparent;
            picDestinoEscuela3.BackColor = Color.Transparent;
        }
        public void VisibilityReturn(PictureBox picImage1, PictureBox picImage2, PictureBox picImage3,
                                    PictureBox picImage4, PictureBox picImage5, PictureBox picImage6)
        {
            picImage1.BackColor = Color.Transparent;
            picImage2.BackColor = Color.Transparent;
            picImage3.BackColor = Color.Transparent;
            picImage4.BackColor = Color.Transparent;
            picImage5.BackColor = Color.Transparent;
            picImage6.BackColor = Color.Transparent;
        }




    }
}
