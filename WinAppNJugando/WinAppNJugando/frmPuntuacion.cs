using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using WinAppProyectoFinal.Clases;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmPuntuacion : Form
    {
        CPuntuacion puntuacion;
        private string message;
        SoundPlayer player;

        public frmPuntuacion(int fallos)
        {
            InitializeComponent();
            puntuacion = new CPuntuacion();
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\alegria.wav");
            try
            {
                player.Play();
            }
            catch { }
        }

        private void frmPuntuacion_Load(object sender, EventArgs e)
        {
            message=puntuacion.sendMessage();
            lblMessage.Text = message;
        }

        private void btnRepeatGame_Click(object sender, EventArgs e)
        {
            frmMenuLevel objfrm = new frmMenuLevel();
            Close();
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.Show();
        }

        private void btnRepeatGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnRepeatGame.Size = new Size(89, 89);
        }

        private void frmPuntuacion_MouseMove(object sender, MouseEventArgs e)
        {
            btnRepeatGame.Size = new Size(79, 79);
        }

    }
}
