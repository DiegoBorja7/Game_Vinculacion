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
    class InitializeImages
    {
        int image1, image2;

        private Bitmap myBitmap;
        private Bitmap myBitmap1;
        private Bitmap myBitmap2;

        private string[] ecuadorianAnimal = new string[] {"OsoHormigueroCosta","CangrejoCosta","GaviotaCosta","LangostaCosta","CaimanCosta",
                                                          "DelfinGalapagos","PinguinoGalapagos","TiburonGalapagos","TortugaGalapagos","BallenaGalapagos",
                                                          "MonoOriente","OsoPerezosoOriente","RanaOriente","SerpienteOriente","DelfinOriente",
                                                          "CondorSierra","ConejoSierra","PatoSierra","RatonSierra","ZorroSierra"};
        private string[] button = new string[] { "play","home","help","nivel"};

        public void animalesCosta(PictureBox pic, PictureBox pic1)
        {
            Random random = new Random();
            image1 = random.Next(5);
            image2 = random.Next(5);
            while(image1==image2)
            {
                image2 = random.Next(5);
            }

            myBitmap = new Bitmap(Application.StartupPath + @"/Costa/" + ecuadorianAnimal[image1] + ".png");
            pic.Image = myBitmap;
            myBitmap1 = new Bitmap(Application.StartupPath + @"/Costa/" + ecuadorianAnimal[image2] + ".png");
            pic1.Image = myBitmap1;
            pic.Tag = ecuadorianAnimal[image1];
            pic1.Tag = ecuadorianAnimal[image2];
            pic.BackColor = Color.Transparent;
            pic1.BackColor = Color.Transparent;
        }

        public void animalesGalapagos(PictureBox pic, PictureBox pic1)
        {
            Random random = new Random();
            image1 = random.Next(5, 10);
            image2 = random.Next(5, 10);
            while (image1 == image2)
            {
                image2 = random.Next(5, 10);
            }
            myBitmap = new Bitmap(Application.StartupPath + @"/Galapagos/" + ecuadorianAnimal[image1] + ".png");
            pic.Image = myBitmap;
            myBitmap1 = new Bitmap(Application.StartupPath + @"/Galapagos/" + ecuadorianAnimal[image2] + ".png");
            pic1.Image = myBitmap1;
            pic.Tag = ecuadorianAnimal[image1];
            pic1.Tag = ecuadorianAnimal[image2];
            pic.BackColor = Color.Transparent;
            pic1.BackColor = Color.Transparent;

        }

        public void animalesOriente(PictureBox pic, PictureBox pic1)
        {
            Random random = new Random();
            image1 = random.Next(10, 15);
            image2 = random.Next(10, 15);

            while (image1 == image2)
            {
                image2 = random.Next(10, 15);
            }
            myBitmap = new Bitmap(Application.StartupPath + @"/Oriente/" + ecuadorianAnimal[image1] + ".png");
            pic.Image = myBitmap;
            myBitmap1 = new Bitmap(Application.StartupPath + @"/Oriente/" + ecuadorianAnimal[image2] + ".png");
            pic1.Image = myBitmap1;
            pic.Tag = ecuadorianAnimal[image1];
            pic1.Tag = ecuadorianAnimal[image2];
            pic.BackColor = Color.Transparent;
            pic1.BackColor = Color.Transparent;

        }

        public void animalesSierra(PictureBox pic, PictureBox pic1)
        {
            Random random = new Random();
            image1 = random.Next(15, 20);
            image2 = random.Next(15, 20);
            while (image1 == image2)
            {
                image2 = random.Next(15, 20);
            }
            myBitmap = new Bitmap(Application.StartupPath + @"/Sierra/" + ecuadorianAnimal[image1] + ".png");
            pic.Image = myBitmap;
            myBitmap1 = new Bitmap(Application.StartupPath + @"/Sierra/" + ecuadorianAnimal[image2] + ".png");
            pic1.Image = myBitmap1;
            pic.Tag = ecuadorianAnimal[image1];
            pic1.Tag = ecuadorianAnimal[image2];
            pic.BackColor = Color.Transparent;
            pic1.BackColor = Color.Transparent;

        }

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
        }

        public void menuButtons(PictureBox level, PictureBox play, PictureBox home)
        {
            myBitmap = new Bitmap(Application.StartupPath + @"/Botones/" + button[3] + ".png");
            myBitmap1 = new Bitmap(Application.StartupPath + @"/Botones/" + button[0] + ".png");
            myBitmap2 = new Bitmap(Application.StartupPath + @"/Botones/" + button[1] + ".png");
            level.Image = myBitmap;
            play.Image = myBitmap1;
            home.Image = myBitmap2;
            level.BackColor = Color.Transparent;
            play.BackColor = Color.Transparent;
            home.BackColor = Color.Transparent;
        }

    }
}
