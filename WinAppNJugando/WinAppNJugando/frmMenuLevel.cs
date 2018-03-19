using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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

        public frmMenuLevel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
            frmInstrucciones objfrm = new frmInstrucciones("Haz clic sobre el nivel que quieras jugar");
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
            Close();
            ObjForm.StartPosition = FormStartPosition.CenterScreen;
            ObjForm.Show();
        }

        private void picMedio_MouseHover(object sender, EventArgs e)
        {
            menuLevel.ImgSeleccion(picMedio, "medio");
        }

        private void picDificil_MouseHover(object sender, EventArgs e)
        {
            menuLevel.ImgSeleccion(picDificil, "dificil");
        }

        private void picFacil_MouseHover(object sender, EventArgs e)
        {
            menuLevel.ImgSeleccion(picFacil, "facil");
        }

        private void btnReturnGame_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\regresar.wav");
            try
            {
                player.Play();
            }
            catch { }
        }
    }
}
