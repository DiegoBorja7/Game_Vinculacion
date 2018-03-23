using System;
using System.Windows.Forms;
using System.Drawing;
using RegiAnimal;
using WinAppProyectoFinal.Forms;

/**
 * @Autor: Diego Borja.
 * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmSelectGame : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();
        private CPictureSounds sound = new CPictureSounds();
        private CResize ObjResize = new CResize();

        public frmSelectGame()
        {
            InitializeComponent();
            ObjInitialize.CloseAll();
            ObjResize.ResolutionSelectGame(this);
        }

        private void picTuCasaoTuEscuelaGame_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menuc = new frmMenuPrincipal();
            menuc.Show();
            Dispose();
            ObjInstruction.Player.Stop();
        }

        private void picRegiAnimalGame_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Dispose();
            ObjInstruction.Player.Stop();
            sound.playIntro();
        }

        private void picAutoevaluacion_Click(object sender, EventArgs e)
        {
            frmAutoevaluacion1 ObjFormularioAutoevaluacion1 = new frmAutoevaluacion1();
            ObjFormularioAutoevaluacion1.Show();
            Hide();
            ObjInstruction.Player.Stop();
            SoundAutoevaluacion.Ctlcontrols.stop();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSelectGame_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picExit.BorderStyle = BorderStyle.None;
            picTuCasaoTuEscuelaGame.BorderStyle = BorderStyle.None;
            picRegiAnimalGame.BorderStyle = BorderStyle.None;
            picExit.BackColor = Color.Transparent;
        }

        private void picAutoevaluacion_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picAutoevaluacion.Width = (picAutoevaluacion.Width+15);
            picAutoevaluacion.Height = (picAutoevaluacion.Height+15);
            picAutoevaluacion.Location = new Point((picAutoevaluacion.Location.X - 5), (picAutoevaluacion.Location.Y - 5));
            SoundAutoevaluacion.URL = Application.StartupPath + @"/Sound/Autoevaluacion.wav";
            SoundAutoevaluacion.Ctlcontrols.play();
        }

        private void picAutoevaluacion_MouseLeave(object sender, EventArgs e)
        {
            picAutoevaluacion.Width = (picAutoevaluacion.Width - 15);
            picAutoevaluacion.Height = (picAutoevaluacion.Height - 15);
            picAutoevaluacion.Location = new Point((picAutoevaluacion.Location.X + 5), (picAutoevaluacion.Location.Y + 5));
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picExit);
            picExit.BackColor = Color.Bisque;
        }

        private void picTuCasaoTuEscuelaGame_MouseEnter(object sender, EventArgs e)
        {

            ObjInitialize.Seleccionar(this, picTuCasaoTuEscuelaGame);
        }
        private void picRegiAnimalGame_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picRegiAnimalGame);
        }

        private void frmSelectGame_Load(object sender, EventArgs e)
        {
            ObjInstruction.playSound("Introduccion2");
            ObjResize.ResizeComponentsSelectGame(picTuCasaoTuEscuelaGame, picRegiAnimalGame, picAutoevaluacion, picExit);
            CenterToScreen();
        }

        private void frmSelectGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
