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

        public frmInicio()
        {
            InitializeComponent();
            ObjInstruction.playSound("Introduccion1");
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
            picBtnPlay.Size = new Size(335, 140); 
            picBtnPlay.Location = new Point(480, 315);
            picExit.BorderStyle = BorderStyle.None;
        }

        private void picBtnPlay_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picBtnPlay.Location = new Point(470, 305);
            picBtnPlay.Size = new Size(365, 170);
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picExit);
        }
    }
}
