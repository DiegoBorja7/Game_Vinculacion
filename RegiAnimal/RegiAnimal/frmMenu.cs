using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegiAnimal
{
    public partial class frmMenu : Form
    {
        private int level = 2;

        private CInitializeImages im = new CInitializeImages();
        private frmLevelSelection ls;
        private CPictureSounds sound = new CPictureSounds();
        public frmMenu()
        {
            
            InitializeComponent();
            im.menuButtons(picBtnPlay, picBtnHome);
            picRegianimal.BackColor = Color.Transparent;
            Mouse();
        }

        public frmMenu(int level)
        {
  
            InitializeComponent();
            im.menuButtons(picBtnPlay, picBtnHome);
            picRegianimal.BackColor = Color.Transparent;

            Mouse();

            this.level = level;
        }

        private void Mouse()
        {
            Icon picaflor;
            picaflor = Properties.Resources.Mouse;
            this.Cursor = new Cursor(picaflor.Handle);
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
            Application.Exit();
        }

        private void picBtnPlay_MouseHover(object sender, EventArgs e)
        {
            im.menuButtonshover(picBtnPlay,0);
            picBtnPlay.BorderStyle = BorderStyle.Fixed3D;
            sound.playSound(picBtnPlay, "Pop");
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
            sound.playSound(picBtnHome, "Pop");
        }
    }
}
