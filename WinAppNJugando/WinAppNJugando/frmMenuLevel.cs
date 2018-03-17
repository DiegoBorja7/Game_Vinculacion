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
            
        }

        private void picMedio_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void picDificil_MouseMove(object sender, MouseEventArgs e)
        {
            

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

        private void picMedio_MouseEnter(object sender, EventArgs e)
        {
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\medio.wav");
            try
            {
                player.Play();

                picMedio.Size = new Size(250, 250);
                picMedio.Location = new Point(25, 100);

                picFacil.Size = new Size(180, 180);
                picFacil.Location = new Point(310, 275);
                picDificil.Size = new Size(180, 180);
                picDificil.Location = new Point(565, 125);
            }
            catch { }
        }

        private void picFacil_MouseEnter(object sender, EventArgs e)
        {
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\facil.wav");
            try
            {
                player.Play();

                picFacil.Size = new Size(250, 250);
                picFacil.Location = new Point(275, 250);

                picMedio.Size = new Size(180, 180);
                picMedio.Location = new Point(60, 125);
                picDificil.Size = new Size(180, 180);
                picDificil.Location = new Point(565, 125);
            }
            catch { }
        }

        private void picDificil_MouseEnter(object sender, EventArgs e)
        {
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\dificil.wav");
            try
            {
                player.Play();

                picDificil.Size = new Size(250, 250);
                picDificil.Location = new Point(525, 100);

                picFacil.Size = new Size(180, 180);
                picFacil.Location = new Point(310, 275);
                picMedio.Size = new Size(180, 180);
                picMedio.Location = new Point(60, 125);
            }
            catch { }
        }

        private void frmMenuLevel_MouseEnter(object sender, EventArgs e)
        {
            picFacil.Size = new Size(200, 200);
            picFacil.Location = new Point(300, 265);
            picMedio.Size = new Size(200, 200);
            picMedio.Location = new Point(50, 115);
            picDificil.Size = new Size(200, 200);
            picDificil.Location = new Point(555, 115);
        }
    }
}
