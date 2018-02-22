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
using System.IO;

namespace WinAppProject
{
    class CImages
    {

        int image1 = 0, image2 = 0, image3 = 0;

        private Bitmap myBitmap;
        private Bitmap myBitmap1;
        private Bitmap myBitmap2;

        //NOMBRES DE IMAGENES Y AUDIO DE OBJETOS
        private string[] objectsCasaEscuela = new string[] {"bancasescuela","grapaescuela","lapizescuela","pizarronescuela","sacaescuela","tijeraescuela",
                                                            "camacasa","lavadoracasa","licuadoracasa","microcasa","ollacasa","planchacasa"};

        public void escuela(PictureBox pic, PictureBox pic1, PictureBox pic2)
        {
            Random random = new Random();
            image1 = random.Next(5);
            image2 = random.Next(5);
            image3 = random.Next(5);

            while ((image1 == image2) || (image1 == image3) || (image2 == image3))
            {
                if (image1 == image2)
                {
                    image2 = random.Next(5);
                }
                if (image1 == image3)
                {
                    image3 = random.Next(5);
                }
                if (image2 == image3)
                {
                    image3 = random.Next(5);
                }

            }

            try
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/escuela/" + objectsCasaEscuela[image1] + ".png");
                pic.Image = myBitmap;
                myBitmap1 = new Bitmap(Application.StartupPath + @"/escuela/" + objectsCasaEscuela[image2] + ".png");
                pic1.Image = myBitmap1;
                myBitmap2 = new Bitmap(Application.StartupPath + @"/escuela/" + objectsCasaEscuela[image3] + ".png");
                pic2.Image = myBitmap2;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
            //TOMAMOS TAGS PARA INGRESAR NOMBRE Y ASI OBTENER LUEGO EL AUDIO CON LA IMAGEN CORRESPONDIENTE
            pic.Tag = objectsCasaEscuela[image1];
            pic1.Tag = objectsCasaEscuela[image2];
            pic2.Tag = objectsCasaEscuela[image3];

            pic.BackColor = Color.Transparent;
            pic1.BackColor = Color.Transparent;
            pic2.BackColor = Color.Transparent;
        }

        public void casa(PictureBox pic, PictureBox pic1, PictureBox pic2)
        {
            Random random = new Random();
            image1 = random.Next(6, 11);
            image2 = random.Next(6, 11);
            image3 = random.Next(6, 11);

            while ((image1 == image2) || (image1 == image3) || (image2 == image3))
            {
                if (image1 == image2)
                {
                    image2 = random.Next(6, 11);
                }
                if (image1 == image3)
                {
                    image3 = random.Next(6, 11);
                }
                if (image2 == image3)
                {
                    image3 = random.Next(6, 11);
                }

            }

            try
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/casa/" + objectsCasaEscuela[image1] + ".png");
                pic.Image = myBitmap;
                myBitmap1 = new Bitmap(Application.StartupPath + @"/casa/" + objectsCasaEscuela[image2] + ".png");
                pic1.Image = myBitmap1;
                myBitmap2 = new Bitmap(Application.StartupPath + @"/casa/" + objectsCasaEscuela[image3] + ".png");
                pic2.Image = myBitmap2;

            }
            catch
            {
                MessageBox.Show("ERROR LA IMAGEN NO ERA LA TERMINACION CORRECTA");
            }



            pic.Tag = objectsCasaEscuela[image1];
            pic1.Tag = objectsCasaEscuela[image2];
            pic2.Tag = objectsCasaEscuela[image3];

            pic.BackColor = Color.Transparent;
            pic1.BackColor = Color.Transparent;
            pic2.BackColor = Color.Transparent;
        }
    }
}
