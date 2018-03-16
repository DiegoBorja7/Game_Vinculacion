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
    class CTranslation
    {
        private SoundPlayer player = new SoundPlayer();
        private bool notPush = true;
        private CInitializeImages img = new CInitializeImages();
        private Color wrong = Color.Red;

        public Boolean translateTotalCO(PictureBox origen, ref PictureBox[] destinos, int referencia1, int referencia2, int referencia3, ref int hits, ref int hitsok, ref Label score)
        {
            Boolean ping = false;            
            for (int i = 0; i < 12; i++)
            {
                if (origen.Bounds.IntersectsWith(destinos[i].Bounds))
                {
                    ping = true;
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia1].Bounds))
                    {
                        Point punto = new Point(destinos[referencia1].Location.X, destinos[referencia1].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia1].Enabled = false;
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia2].Bounds))
                    {
                        Point punto = new Point(destinos[referencia2].Location.X, destinos[referencia2].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia2].Enabled = false;
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia3].Bounds))
                    {
                        Point punto = new Point(destinos[referencia3].Location.X, destinos[referencia3].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia3].Enabled = false;
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else
                    {
                        Point punto = new Point(destinos[i].Location.X, destinos[i].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[i].Enabled = false;
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Wrong.wav");
                        player.Play();
                        return true;
                    }
                }
            }
            if (ping == false)
            {
                return false;
            }
            return notPush;
        }
        public Boolean translateTotalS(PictureBox origen, ref PictureBox[] destinos, int referencia1, int referencia2, int referencia3, int referencia4, ref int hits, ref int hitsok, ref Label score)
        {
            Boolean ping = false;
            for (int i = 0; i < 12; i++)
            {

                if (origen.Bounds.IntersectsWith(destinos[i].Bounds))
                {
                    ping = true;
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia1].Bounds))
                    {
                        Point punto = new Point(destinos[referencia1].Location.X, destinos[referencia1].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia1].Enabled = false;
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia2].Bounds))
                    {
                        Point punto = new Point(destinos[referencia2].Location.X, destinos[referencia2].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia2].Enabled = false;
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia3].Bounds))
                    {
                        Point punto = new Point(destinos[referencia3].Location.X, destinos[referencia3].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia3].Enabled = false;              
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia4].Bounds))
                    {
                        Point punto = new Point(destinos[referencia4].Location.X, destinos[referencia4].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia4].Enabled = false;
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else
                    {
                        Point punto = new Point(destinos[i].Location.X, destinos[i].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[i].Enabled = false;
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Wrong.wav");
                        player.Play();
                        return true;
                    }
                }
            }
            if (ping == false)
            {
                return false;
            }
            return notPush;
        }
        public Boolean translateTotalG(PictureBox origen, ref PictureBox[] destinos, int referencia1, int referencia2, ref int hits, ref int hitsok, ref Label score)
        {
            Boolean ping = false;
            for (int i = 0; i < 12; i++)
            {
                if (origen.Bounds.IntersectsWith(destinos[i].Bounds))
                {
                    ping = true;
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia1].Bounds))
                    {
                        Point punto = new Point(destinos[referencia1].Location.X, destinos[referencia1].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia1].Enabled = false;
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else if (origen.Bounds.IntersectsWith(destinos[referencia2].Bounds))
                    {
                        Point punto = new Point(destinos[referencia2].Location.X, destinos[referencia2].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[referencia2].Enabled = false;
                        hitsok++;
                        score.Text = hitsok.ToString();
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                        player.Play();
                        return true;
                    }
                    if (destinos[i].Enabled == false)
                    {
                        notPush = false;
                        return notPush;
                    }
                    else
                    {
                        Point punto = new Point(destinos[i].Location.X, destinos[i].Location.Y);
                        origen.Location = punto;
                        notPush = true;
                        origen.Enabled = false;
                        destinos[i].Enabled = false;
                        player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Wrong.wav");
                        player.Play();
                        return true;
                    }

                }

            }
            if (ping == false)
            {
                return false;
            }
            return notPush;
        }
        public void translatePicBoxToSpace(PictureBox origen, PictureBox destino)
        {
            Point punto = new Point(destino.Location.X, destino.Location.Y);
            origen.Location = punto;
            player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Wrong.wav");
            player.Play();
        }
    }
}