/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;*/

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
    class CSounds
    {
        SoundPlayer player;

        public void playSound(PictureBox picSound)
        {
            try
            {
                string ruta = Directory.GetCurrentDirectory();
                ruta = ruta + "\\audios\\";
                string ruta_final = ruta + (String)picSound.Tag;
                string terminacion = ".wav";
                ruta_final = ruta_final + terminacion;

                // player = new SoundPlayer(Application.StartupPath + @"\Audio\" + (String)picSound.Tag + ".wav");
                player = new SoundPlayer(ruta_final);
                player.Play();

            }
            catch
            {

                string ruta = Directory.GetCurrentDirectory();
                ruta = ruta + "\\Audio\\";
                string terminacion = ".wav";

                string imagen = ruta + (String)picSound.Tag + terminacion;


                player = new SoundPlayer(imagen);
                //player.Play();

                MessageBox.Show(imagen);
            }

            
        }

    }
}
