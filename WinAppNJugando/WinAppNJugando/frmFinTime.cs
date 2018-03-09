using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmFinTime : Form
    {
        Form frm;
        public frmFinTime(Form frm)
        {
            InitializeComponent();
            timeEnd.Start();
            this.frm = frm;
        }

        private void frmFinTime_Load(object sender, EventArgs e)
        {
            SoundPlayer player;
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\fin reloj v2.wav");
            try
            {
                player.Play();
            }
            catch { }
        }

        private void timeEnd_Tick(object sender, EventArgs e)
        {
            try{endTime();}
            catch { }
            this.Dispose();
        }

        public void endTime()
        {
            timeEnd.Stop();
            frmRepeatGame objfrm = new frmRepeatGame(frm);
            this.Dispose();
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.Show();
        }

    }
}
