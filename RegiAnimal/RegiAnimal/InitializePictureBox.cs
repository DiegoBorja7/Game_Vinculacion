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

namespace RegiAnimal
{
    class InitializePictureBox
    {
        private Bitmap myBitmap;
        private SoundPlayer player;

        private Point[] position = new Point[8] {new Point(12, 39), new Point(12, 201), new Point(12, 362),
                                                 new Point(12, 523), new Point(1172, 39), new Point(1172, 189),
                                                 new Point(1172, 351), new Point(1172, 501)};

        private string[] scoreImages = new string[3] { "PuntuacionBaja", "PuntuacionMedia", "PuntuacionAlta" };

        private Random random = new Random();

        public void PositionReturn( PictureBox picReturn1, PictureBox picReturn2, PictureBox picReturn3, PictureBox picReturn4,
                                    PictureBox picReturn5, PictureBox picReturn6, PictureBox picReturn7, PictureBox picReturn8)
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
            picReturn1.Location = position[randomNum[0]];
            picReturn2.Location = position[randomNum[1]];
            picReturn3.Location = position[randomNum[2]];
            picReturn4.Location = position[randomNum[3]];
            picReturn5.Location = position[randomNum[4]];
            picReturn6.Location = position[randomNum[5]];
            picReturn7.Location = position[randomNum[6]];
            picReturn8.Location = position[randomNum[7]];

        }

        public void PositionImages( PictureBox picReturn1, PictureBox picReturn2, PictureBox picReturn3, PictureBox picReturn4,
                                    PictureBox picReturn5, PictureBox picReturn6, PictureBox picReturn7, PictureBox picReturn8,
                                    PictureBox picImgCosta1, PictureBox picImgCosta2, PictureBox picImgSierra1, PictureBox picImgSierra2,
                                    PictureBox picImgGalapagos1, PictureBox picImgGalapagos2, PictureBox picImgOriente1, PictureBox picImgOriente2)
        {
            picImgCosta2.Location = picReturn1.Location;
            picImgCosta1.Location = picReturn2.Location;
            picImgSierra1.Location = picReturn3.Location;
            picImgSierra2.Location = picReturn4.Location;
            picImgGalapagos1.Location = picReturn5.Location;
            picImgGalapagos2.Location = picReturn6.Location;
            picImgOriente1.Location = picReturn7.Location;
            picImgOriente2.Location = picReturn8.Location;
        }

        public void VisibilityDestination(PictureBox picDestinoCosta1, PictureBox picDestinoCosta2, PictureBox picDestinoCosta3,
                                        PictureBox picDestinoSierra1, PictureBox picDestinoSierra2 , PictureBox picDestinoSierra3,
                                        PictureBox picDestinoSierra4 , PictureBox picDestinoOriente1, PictureBox picDestinoOriente2,
                                        PictureBox picDestinoOriente3 , PictureBox picDestinoGalapagos1 , PictureBox picDestinoGalapagos2)

        {
            picDestinoCosta1.BackColor = Color.Transparent;
            picDestinoCosta2.BackColor = Color.Transparent;
            picDestinoCosta3.BackColor = Color.Transparent;
            picDestinoSierra1.BackColor = Color.Transparent;
            picDestinoSierra2.BackColor = Color.Transparent;
            picDestinoSierra3.BackColor = Color.Transparent;
            picDestinoSierra4.BackColor = Color.Transparent;
            picDestinoOriente1.BackColor = Color.Transparent;
            picDestinoOriente2.BackColor = Color.Transparent;
            picDestinoOriente3.BackColor = Color.Transparent;
            picDestinoGalapagos1.BackColor = Color.Transparent;
            picDestinoGalapagos2.BackColor = Color.Transparent;
        }

        public void VisibilityReturn(PictureBox picReturn1, PictureBox picReturn2, PictureBox picReturn3, PictureBox picReturn4,
                                    PictureBox picReturn5, PictureBox picReturn6, PictureBox picReturn7, PictureBox picReturn8)
        {
            picReturn1.BackColor = Color.Transparent;
            picReturn2.BackColor = Color.Transparent;
            picReturn3.BackColor = Color.Transparent;
            picReturn4.BackColor = Color.Transparent;
            picReturn5.BackColor = Color.Transparent;
            picReturn6.BackColor = Color.Transparent;
            picReturn7.BackColor = Color.Transparent;
            picReturn8.BackColor = Color.Transparent;
        }

        public void draggableDisable(PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4,
                                     PictureBox pic5, PictureBox pic6, PictureBox pic7, PictureBox pic8)
        {
            ControlExtension.Draggable(pic1, false);
            ControlExtension.Draggable(pic2, false);
            ControlExtension.Draggable(pic3, false);
            ControlExtension.Draggable(pic4, false);
            ControlExtension.Draggable(pic5, false);
            ControlExtension.Draggable(pic6, false);
            ControlExtension.Draggable(pic7, false);
            ControlExtension.Draggable(pic8, false);
        }

        public void setDraggable(PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4,
                                     PictureBox pic5, PictureBox pic6, PictureBox pic7, PictureBox pic8)
        {
            ControlExtension.Draggable(pic1, true);
            ControlExtension.Draggable(pic2, true);
            ControlExtension.Draggable(pic3, true);
            ControlExtension.Draggable(pic4, true);
            ControlExtension.Draggable(pic5, true);
            ControlExtension.Draggable(pic6, true);
            ControlExtension.Draggable(pic7, true);
            ControlExtension.Draggable(pic8, true);
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
