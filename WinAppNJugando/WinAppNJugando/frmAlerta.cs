using System;
using System.Windows.Forms;

/**
  * @Autor: Diego Borja.
  * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmAlerta : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();

        public frmAlerta()
        {
            InitializeComponent();
        }

        private void frmAlerta_Load(object sender, EventArgs e)
        {
            ObjInstruction.playSound("RegresoMenu");
        }

        private void picBtnYes_Click(object sender, EventArgs e)
        {
            frmSelectGame ObjFormulario = new frmSelectGame();
            ObjFormulario.ShowDialog();
            Dispose();
        }

        private void picBtnNo_Click(object sender, EventArgs e)
        {
            Close();
            ObjInstruction.Player.Stop();
        }

        private void frmAlerta_MouseEnter(object sender, EventArgs e)
        {
            picBtnYes.BorderStyle = BorderStyle.None;
            picBtnNo.BorderStyle = BorderStyle.None;
            Cursor = Cursors.Default;
        }

        private void picBtnYes_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picBtnYes);
        }

        private void picBtnNo_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picBtnNo);
        }
    }
}
