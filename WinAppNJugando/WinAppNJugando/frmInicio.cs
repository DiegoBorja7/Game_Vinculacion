using System;
using System.Windows.Forms;

 /**
  * @Autor: Diego Borja.
  * */

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
            frmSelectGame ObjFormulario = new frmSelectGame();
            ObjFormulario.Show();
            Hide(); //Oculta el formulario
        }
        
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInicio_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picBtnPlay.BorderStyle = BorderStyle.None;
            picExit.BorderStyle = BorderStyle.None;
        }

        private void picBtnPlay_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picBtnPlay);
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picExit);
        }
    }
}
