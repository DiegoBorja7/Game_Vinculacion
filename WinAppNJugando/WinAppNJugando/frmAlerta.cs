using System;
using System.Windows.Forms;

/**
 *@Autor Borja Diego
 * **/

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
            frmPuntajeAutoevaluacion ObjFormulario = new frmPuntajeAutoevaluacion();
            ObjFormulario.ShowDialog();
            Hide();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAlerta_Load(object sender, EventArgs e)
        {
            ObjInstruction.playSound("RegresoMenu");
        }
    }
}
