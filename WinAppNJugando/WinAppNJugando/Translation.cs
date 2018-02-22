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

    class Translation
    {
        private SoundPlayer player = new SoundPlayer();
        private bool notPush=true;
        public Boolean translatePicBox(PictureBox origen, PictureBox destino, PictureBox destino2, ref int hits)
        {
            if (origen.Bounds.IntersectsWith(destino.Bounds))
            {
                if (destino.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto = new Point(destino.Location.X, destino.Location.Y);
                    origen.Location = punto;
                    notPush = true;
                    origen.Enabled = false;
                    destino.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else if (origen.Bounds.IntersectsWith(destino2.Bounds))
            {
                if (destino2.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto2 = new Point(destino2.Location.X, destino2.Location.Y);
                    origen.Location = punto2;
                    notPush = true;
                    origen.Enabled = false;
                    destino2.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else
            {
                notPush = false;
            }
            return notPush;
        }
        public Boolean translatePicBox(PictureBox origen, PictureBox destino, PictureBox destino2, PictureBox destino3, ref int hits)
        {

            if (origen.Bounds.IntersectsWith(destino.Bounds))
            {
                if (destino.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto = new Point(destino.Location.X, destino.Location.Y);
                    origen.Location = punto;
                    notPush = true;
                    origen.Enabled = false;
                    destino.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else if (origen.Bounds.IntersectsWith(destino2.Bounds))
            {
                if (destino2.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto2 = new Point(destino2.Location.X, destino2.Location.Y);
                    origen.Location = punto2;
                    notPush = true;
                    origen.Enabled = false;
                    destino2.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else if (origen.Bounds.IntersectsWith(destino3.Bounds))
            {
                if (destino3.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto3 = new Point(destino3.Location.X, destino3.Location.Y);
                    origen.Location = punto3;
                    notPush = true;
                    origen.Enabled = false;
                    destino3.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else
            {
                 notPush = false;
            }
            return notPush;
                
        }
        public Boolean translatePicBox(PictureBox origen, PictureBox destino, PictureBox destino2, PictureBox destino3, PictureBox destino4, ref int hits)
        {
            if (origen.Bounds.IntersectsWith(destino.Bounds))
            {
                if (destino.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto = new Point(destino.Location.X, destino.Location.Y);
                    origen.Location = punto;
                    notPush = true;
                    origen.Enabled = false;
                    destino.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else if (origen.Bounds.IntersectsWith(destino2.Bounds))
            {
                if (destino2.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto2 = new Point(destino2.Location.X, destino2.Location.Y);
                    origen.Location = punto2;
                    notPush = true;
                    origen.Enabled = false;
                    destino2.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else if (origen.Bounds.IntersectsWith(destino3.Bounds))
            {
                if (destino3.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto3 = new Point(destino3.Location.X, destino3.Location.Y);
                    origen.Location = punto3;
                    notPush = true;
                    origen.Enabled = false;
                    destino3.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else if (origen.Bounds.IntersectsWith(destino4.Bounds))
            {
                if (destino4.Enabled == false)
                {
                    notPush = false;
                }
                else
                {
                    Point punto3 = new Point(destino4.Location.X, destino4.Location.Y);
                    origen.Location = punto3;
                    notPush = true;
                    origen.Enabled = false;
                    destino4.Enabled = false;
                    hits++;
                    player = new SoundPlayer(Application.StartupPath + @"/EspecialSounds/Correct.wav");
                    player.Play();
                }
            }
            else
            {
                notPush = false;
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
