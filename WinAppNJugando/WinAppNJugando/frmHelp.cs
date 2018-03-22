using System;
using WinAppNiñitosEnAccion;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegiAnimal
{
    public partial class frmHelp : Form
    {
        SoundPlayer player = new SoundPlayer();
        CPictureSounds players = new CPictureSounds();
        private int lifeTime = 15;

        public frmHelp()
        {
            InitializeComponent();
            wmpHelp.URL = Application.StartupPath + @"/Video/help.mp4";
            player = new SoundPlayer(Application.StartupPath + @"/Audio/help.wav");
            player.Play();
            clock.Enabled = true;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lifeTime--;
            if (lifeTime == 0)
            {
                this.Dispose();
                players.playSound("go");
            }

        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            Cresize resize = new Cresize();

            resize.Resolution(this);

            this.CenterToScreen();

        }
    }
}
