using System;
using System.Drawing;
using System.Windows.Forms;
using WinAppNiñitosEnAccion;

namespace RegiAnimal
{
    public partial class frmMenu : Form
    {
        private CInitializeImages im = new CInitializeImages();
        private frmLevelSelection ls;
        private CPictureSounds sound = new CPictureSounds();
        private CInitializeThings ms = new CInitializeThings();

        public frmMenu()
        {
            InitializeComponent();
            im.menuButtons(picBtnPlay, picBtnHome);
            picRegianimal.BackColor = Color.Transparent;
            Mouse();
            sound.playIntro();            
        }

        private void Mouse()
        {
            ms.Mouse(this, 2);
        }

        private void picBtnPlay_Click(object sender, EventArgs e)
        {
            ls = new frmLevelSelection();
            ls.Show();
            this.Visible=false;
        }

        private void picBtnLevel_Click(object sender, EventArgs e)
        {
            ls = new frmLevelSelection();
            ls.Show();
            this.Visible = false;
        }

        private void picBtnHome_Click(object sender, EventArgs e)
        {
            frmSelectGame lvl = new frmSelectGame();
            lvl.Show();
            this.Dispose();
        }

        private void picBtnPlay_MouseHover(object sender, EventArgs e)
        {
            im.menuButtonshover(picBtnPlay,0);
            picBtnPlay.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picBtnPlay_MouseLeave(object sender, EventArgs e)
        {
            im.menuButtonsleave(picBtnPlay,0);
            picBtnPlay.BorderStyle = BorderStyle.None;
        }

        private void picBtnHome_MouseLeave(object sender, EventArgs e)
        {
            im.menuButtonsleave(picBtnHome, 1);
            picBtnHome.BorderStyle = BorderStyle.None;
        }

        private void picBtnHome_MouseHover(object sender, EventArgs e)
        {
            im.menuButtonshover(picBtnHome, 1);
            picBtnHome.BorderStyle = BorderStyle.Fixed3D;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            CResize resize = new CResize();
            
            resize.Resolution(this);
            resize.ResizeComponentsMenu(picBtnHome, picRegianimal, picBtnPlay);
        }
    }
}
