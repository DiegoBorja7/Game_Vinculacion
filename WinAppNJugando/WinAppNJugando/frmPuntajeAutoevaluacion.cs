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
        private CInstructions ObjInstruction = new CInstructions();
        private CInitializeThings ObjInitialize = new CInitializeThings();

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

            //Detecta los formularios abiertos.
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(frmAutoevaluacion1)) 
                {
                    frm.Hide();
                    break;
                }
                if (frm.GetType() == typeof(frmAutoevaluacion2) )
                {
                    MessageBox.Show("esta abierto !");
                    frm.Hide();
                    break;
                }
                if (frm.GetType() == typeof(frmAutoevaluacion3)) 
                {
                    frm.Hide();
                    break;
                }
                if (frm.GetType() == typeof(frmAutoevaluacion4))
                {
                    frm.Hide();
                    break;
                }
                if (frm.GetType() == typeof(frmAutoevaluacion5))
                {
                    frm.Hide();
                    break;
                }
                if (frm.GetType() == typeof(frmAlerta))
                {
                    frm.Hide();
                    break;
                }
            }
        }

        private void picHome_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picHome);
        }
    }
}
