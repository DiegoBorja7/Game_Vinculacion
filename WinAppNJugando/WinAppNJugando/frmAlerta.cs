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
        private CInstructions ObjInstruction = new CInstructions();

        public frmAlerta()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            frmSelectGame ObjFormulario = new frmSelectGame();
            ObjFormulario.ShowDialog();
            Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
            ObjInstruction.Player.Stop();
        }

        private void frmAlerta_Load(object sender, EventArgs e)
        {
            ObjInstruction.playSound("RegresoMenu");
        }
    }
}
