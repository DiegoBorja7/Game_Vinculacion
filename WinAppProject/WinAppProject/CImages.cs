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

        /*
        
        int estado;
        private Point firstPoint = new Point();



        public void printImage(PictureBox picImage)
        {
            picImage.BackgroundImage = Image.FromFile(@"D:\Kevin\Mis Documentos\UNIVERSIDAD\3 SEMESTRE\Proyecto Integrador\button home final.jpg");
           
        }
        public void moveImage(PictureBox picImage)
        {

            ControlExtension.Draggable(picImage, true);

        }
        */

        /*

        private int estado;
        private string nombre;
        private string audio;

        public int Estado
        {

            get { return estado; }
            set { estado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Audio
        {
            get { return audio; }
            set { audio = value; }
        }

        //private Point firstPoint = new Point();

        public CImages()
        {
            estado = 0;
            nombre = audio = "";
        }

        public void escuela(PictureBox pic1, PictureBox pic2, PictureBox pic3)
        {
            string nombreImagen;
            string terminacion;
            string ruta;
            string ruta2;
            string nombreFinal;
            int valor;
            Image imagenFinal = null;
            Random randomico = new Random();

            ruta = Directory.GetCurrentDirectory();
            ruta += "\\resources\\escuela\\";

            CImages[] arreglo = new CImages[6];

            for (int i = 0; i < 6; i++)
            {
                arreglo[i] = new CImages();
            }

            for (int i = 0; i < 6; i++)
            {
                nombreImagen = (i + 1).ToString();
                terminacion = ".jpg";
                nombreFinal = nombreImagen + terminacion;
                ruta2 = ruta + nombreFinal;
                try
                {
                    imagenFinal = Image.FromFile(ruta2);
                }
                catch
                {
                    // MessageBox.Show("ERROR LA IMAGEN NO ERA LA TERMINACION CORRECTA");
                    terminacion = ".png";
                    nombreFinal = nombreImagen + terminacion;
                    ruta2 = ruta + nombreFinal;
                }
                arreglo[i].Nombre = ruta2;
                arreglo[i].Estado = 0;
                arreglo[i].Audio = "";
            }

            for (int i = 0; i < 3; i++)
            {
                bool bandera = false;
                do
                {
                    do
                    {
                        valor = randomico.Next(0, 6);
                    } while (valor > 5);
                    // MessageBox.Show("EL VALOR RANDOMICO FUE: " + valor);
                    if (arreglo[valor].estado == 0)
                    {
                        imagenFinal = Image.FromFile(arreglo[valor].nombre);
                        arreglo[valor].estado = 1;
                        bandera = false;
                        break;
                    }
                    else
                    {
                        bandera = true;
                    }
                } while (bandera == true);
                switch (i)
                {
                    case 0:
                        pic1.BackgroundImage = imagenFinal;
                        break;
                    case 1:
                        pic2.BackgroundImage = imagenFinal;
                        break;
                    case 2:
                        pic3.BackgroundImage = imagenFinal;
                        break;
                }
            }


            pic1.BackColor = Color.Transparent;
            pic2.BackColor = Color.Transparent;
            pic3.BackColor = Color.Transparent;
        }

        public void casa(PictureBox pic1, PictureBox pic2, PictureBox pic3)
        {
            string nombreImagen;
            string terminacion;
            string ruta;
            string ruta2;
            string nombreFinal;
            int valor;
            Image imagenFinal = null;
            Random randomico = new Random();

            ruta = Directory.GetCurrentDirectory();
            ruta += "\\resources\\casa\\";

            CImages[] arreglo = new CImages[6];

            for (int i = 0; i < 6; i++)
            {
                arreglo[i] = new CImages();
            }

            for (int i = 0; i < 6; i++)
            {
                nombreImagen = (i + 1).ToString();
                terminacion = ".jpg";
                nombreFinal = nombreImagen + terminacion;
                ruta2 = ruta + nombreFinal;
                try
                {
                    imagenFinal = Image.FromFile(ruta2);
                }
                catch
                {
                    // MessageBox.Show("ERROR LA IMAGEN NO ERA LA TERMINACION CORRECTA");
                    terminacion = ".png";
                    nombreFinal = nombreImagen + terminacion;
                    ruta2 = ruta + nombreFinal;
                }
                arreglo[i].Nombre = ruta2;
                arreglo[i].Estado = 0;
                arreglo[i].Audio = "";
            }

            for (int i = 0; i < 3; i++)
            {
                bool bandera = false;
                do
                {
                    do
                    {
                        valor = randomico.Next(0, 6);
                    } while (valor > 5);
                    //MessageBox.Show("EL VALOR RANDOMICO FUE: " + valor);
                    if (arreglo[valor].estado == 0)
                    {
                        imagenFinal = Image.FromFile(arreglo[valor].nombre);
                        arreglo[valor].estado = 1;
                        bandera = false;
                        break;
                    }
                    else
                    {
                        bandera = true;
                    }
                } while (bandera == true);
                switch (i)
                {
                    case 0:
                        pic1.BackgroundImage = imagenFinal;
                        break;
                    case 1:
                        pic2.BackgroundImage = imagenFinal;
                        break;
                    case 2:
                        pic3.BackgroundImage = imagenFinal;
                        break;
                }
            }

            pic1.BackColor = Color.Transparent;
            pic2.BackColor = Color.Transparent;
            pic3.BackColor = Color.Transparent;
        }
        */




        // OPCION 2
        
        int image1=0, image2=0,image3=0;

        private Bitmap myBitmap;
        private Bitmap myBitmap1;
        private Bitmap myBitmap2;

        private string[] objectsCasaEscuela = new string[] {"bancasescuela","grapaescuela","lapizescuela","pizarronescuela","sacaescuela","tijeraescuela",
                                                            "camacasa","lavadoracasa","licuadoracasa","microcasa","ollacasa","planchacasa"};
        private string[] button = new string[] { "play", "home", "help" };

        public void escuela(PictureBox pic, PictureBox pic1,PictureBox pic2)
        {
            Random random = new Random();
            image1 = random.Next(5);
            image2 = random.Next(5);
            image3= random.Next(5); 

            while ((image1 == image2) || (image1==image3) || (image2==image3))
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

                /*
                string ruta = Directory.GetCurrentDirectory();
                ruta = ruta + "\\escuela\\";
                string terminacion = ".png";

                string imagen = ruta + objectsCasaEscuela[image1] + terminacion;
                MessageBox.Show(imagen);

                myBitmap = new Bitmap(imagen);
                pic.Image = myBitmap;

                imagen = ruta + objectsCasaEscuela[image2] + terminacion;

                myBitmap1 = new Bitmap(imagen, true);
                pic1.Image = myBitmap1;

                imagen = ruta + objectsCasaEscuela[image3] + terminacion;

                myBitmap2 = new Bitmap(imagen, true);
                pic2.Image = myBitmap2;*/

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

            pic.Tag = objectsCasaEscuela[image1];
            pic1.Tag = objectsCasaEscuela[image2];
            pic2.Tag = objectsCasaEscuela[image3];

            pic.BackColor = Color.Transparent;
            pic1.BackColor = Color.Transparent;
            pic2.BackColor= Color.Transparent;
        }

        public void casa(PictureBox pic, PictureBox pic1,PictureBox pic2)
        {
            Random random = new Random();
            image1 = random.Next(6, 11);
            image2 = random.Next(6, 11);
            image3 = random.Next(6,11);

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

            }catch
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

        /*
        public void buttons(PictureBox play, PictureBox home, PictureBox help)
        {
            myBitmap = new Bitmap(Application.StartupPath + @"/Botones/" + button[0] + ".png");
            myBitmap1 = new Bitmap(Application.StartupPath + @"/Botones/" + button[1] + ".png");
            myBitmap2 = new Bitmap(Application.StartupPath + @"/Botones/" + button[2] + ".png");
            play.Image = myBitmap;
            home.Image = myBitmap1;
            help.Image = myBitmap2;
            play.BackColor = Color.Transparent;
            home.BackColor = Color.Transparent;
            help.BackColor = Color.Transparent;
        }*/



    }
}
