using System;
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

        public frmHelp()
        {
            InitializeComponent();
            wmpHelp.URL = Application.StartupPath + @"/Video/help.mp4";
            player = new SoundPlayer(Application.StartupPath + @"/Audio/help.wav");
            player.Play();
        }
    }
}
