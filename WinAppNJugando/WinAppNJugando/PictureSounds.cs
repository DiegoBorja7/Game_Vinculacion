using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

namespace RegiAnimal
{
    class PictureSounds
    {
        SoundPlayer player;

        public void playSound(PictureBox picSound)
        {
            player = new SoundPlayer(Application.StartupPath + @"/Audio/"+ (String)picSound.Tag +".wav");
            player.Play();
        }
    }
}
