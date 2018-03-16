using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;
using WinAppProyectoFinal.Clases;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmMenuLevel : Form
    {
        List<PictureBox> pictures;
        CMenuLevel menuLevel;
        frmJuego ObjForm;
        SoundPlayer player;

        public frmMenuLevel()
        {
            InitializeComponent();

            pictures = new List<PictureBox>();
            menuLevel = new CMenuLevel();
            ObjForm = new frmJuego();
        }

        private void frmMenuLevel_Load(object sender, EventArgs e)
        {
            pictures.Add(picFacil); pictures.Add(picDificil); pictures.Add(picMedio);
            menuLevel.MPictures = pictures;
            menuLevel.iniciarPics();
        }

        private void btnReturnGame_Click_1(object sender, EventArgs e)
        {
            frmMenuPrincipal objfrm = new frmMenuPrincipal();
            Close();
            objfrm.Visible = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmInstrucciones objfrm = new Forms.frmInstrucciones("Haz clic sobre el nivel que quieras jugar");
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.ShowDialog();
        }

        private void btnReturnGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnReturnGame.Size = new Size(84, 84);
        }

        private void btnHelp_MouseMove(object sender, MouseEventArgs e)
        {
            btnHelp.Size = new Size(84, 84);
        }

        private void frmMenuLevel_MouseMove(object sender, MouseEventArgs e)
        {
            btnReturnGame.Size = new Size(74, 74);
            btnHelp.Size = new Size(74, 74);
        }

        private void picFacil_MouseMove(object sender, MouseEventArgs e)
        {
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\facil.wav");
            try
            {
                player.Play();
            
            picFacil.Size = new Size(265, 265);
            picFacil.Location = new Point(275, 233);

            picMedio.Size = new Size(140, 140);
            picMedio.Location = new Point(125, 115);
            picDificil.Size = new Size(140, 140);
            picDificil.Location = new Point(525, 115);
            }
            catch { }
        }

        private void picMedio_MouseMove(object sender, MouseEventArgs e)
        {
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\medio.wav");
            try
            {
                player.Play();
            
            picMedio.Size = new Size(265, 265);
            picMedio.Location = new Point(75, 115);

            picFacil.Size = new Size(140, 140);
            picFacil.Location = new Point(325, 233);
            picDificil.Size = new Size(140, 140);
            picDificil.Location = new Point(525, 115);

            }
            catch { }
        }

        private void picDificil_MouseMove(object sender, MouseEventArgs e)
        {
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\dificil.wav");
            try
            {
                player.Play();

            picDificil.Size = new Size(265, 265);
            picDificil.Location = new Point(475, 115);

            picFacil.Size = new Size(140, 140);
            picFacil.Location = new Point(325, 233);
            picMedio.Size = new Size(140, 140);
            picMedio.Location = new Point(125, 115);
            }
            catch { }

        }

        private void picFacil_Click(object sender, EventArgs e)
        {
            iniciarGame(1);
        }

        private void picMedio_Click(object sender, EventArgs e)
        {
            iniciarGame(2);
        }

        private void picDificil_Click(object sender, EventArgs e)
        {
            iniciarGame(3);
        }

        public void iniciarGame(int Leve)
        {
            ObjForm = new frmJuego(Leve);
            this.Close();
            ObjForm.StartPosition = FormStartPosition.CenterScreen;
            ObjForm.Show();
        }
    }
}
