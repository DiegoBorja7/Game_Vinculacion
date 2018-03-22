using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
        private CResize ObjResize = new CResize();

        private List<PictureBox> ListaEstrellas = new List<PictureBox>();
        private List<PictureBox> ListaPictureBotones = new List<PictureBox>();

        public frmPuntajeAutoevaluacion()
        {
            InitializeComponent();
            InsertarDatosLista();
            ObjResize.ResolutionAutoevaluationScore(this);
            ObjResize.ResizeComponentsAutoevaluationScore(ListaEstrellas, ListaPictureBotones);
        }

        private void InsertarDatosLista()
        {
            ListaEstrellas.Add(picStar1);
            ListaEstrellas.Add(picStar2);
            ListaEstrellas.Add(picStar3);
            ListaEstrellas.Add(picStar4);
            ListaPictureBotones.Add(picCalification);
            ListaPictureBotones.Add(picHome);
        }

        private void frmPuntajeAutoevaluacion_Load(object sender, EventArgs e)
        {
            ObjInstruction.Puntuacion(this,picCalification, ListaEstrellas);
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
