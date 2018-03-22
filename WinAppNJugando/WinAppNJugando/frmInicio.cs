using System;
using System.Drawing;
using System.Windows.Forms;

/**
 * @Autor: Diego Borja.
 * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmInicio : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();
        private CResize ObjResize = new CResize();
      
        public frmInicio()
        {
            InitializeComponent();
            ObjInstruction.playSound("Introduccion1");
            ObjResize.ResolutionInicio(this);
            ObjResize.ResizeComponentsInicio(picBtnPlay, picVideo, picExit);
        }

        private void picBtnPlay_Click(object sender, EventArgs e)
        {
            ObjInstruction.playSound("Clic");
            frmSelectGame ObjFormulario = new frmSelectGame();
            ObjFormulario.Show();
            Hide();
        }
        
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInicio_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picVideo.BorderStyle = BorderStyle.None;
            picExit.BorderStyle = BorderStyle.None;
        }

        private void picBtnPlay_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picBtnPlay.Width = (picBtnPlay.Width + 20);
            picBtnPlay.Height = (picBtnPlay.Height + 20);
            picBtnPlay.Location = new Point((picBtnPlay.Location.X  - 10),(picBtnPlay.Location.Y - 10));
        }

        private void picBtnPlay_MouseLeave(object sender, EventArgs e)
        {
            picBtnPlay.Width = (picBtnPlay.Width - 20);
            picBtnPlay.Height = (picBtnPlay.Height - 20);
            picBtnPlay.Location = new Point((picBtnPlay.Location.X + 10), (picBtnPlay.Location.Y + 10));
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picExit);
        }

        private void picVideo_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picVideo);
        }

        private void picVideo_Click(object sender, EventArgs e)
        {
            ObjInstruction.Player.Stop();
            new frmVideoCreditos().Show();
            Hide();
        }
    }
}
