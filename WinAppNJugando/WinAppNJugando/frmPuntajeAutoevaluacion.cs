using System;
using System.Windows.Forms;

/**
  * @Autor: Diego Borja.
  * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmPuntajeAutoevaluacion : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();

        public frmPuntajeAutoevaluacion()
        {
            InitializeComponent();
        }

        private void frmPuntajeAutoevaluacion_Load(object sender, EventArgs e)
        {
            ObjInstruction.Puntuacion(picCalification);
        }

        private void frmPuntajeAutoevaluacion_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Mouse(this,1);
            picHome.BorderStyle = BorderStyle.None;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            frmSelectGame ObjFormulario = new frmSelectGame();
            ObjFormulario.ShowDialog();
            Hide();
        }

        private void picHome_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picHome);
        }
    }
}
