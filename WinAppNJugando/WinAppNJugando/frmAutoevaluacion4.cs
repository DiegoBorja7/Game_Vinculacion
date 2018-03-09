using System;
using System.Collections.Generic;
using System.Windows.Forms;

/**
  * @Autor: Diego Borja.
  * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmAutoevaluacion4 : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();

        private List<PictureBox> ListaPictureBoxObjetos = new List<PictureBox>();
        private List<PictureBox> ListaPictureBoxLugares = new List<PictureBox>();
        private PictureBox picAux = new PictureBox();

        public frmAutoevaluacion4()
        {
            InitializeComponent();
            InsertarDatosLista();
            ObjInitialize.Regiones(ListaPictureBoxLugares, ListaPictureBoxObjetos);
        }

        //Insertar todos los PictureBox en una lista.
        private void InsertarDatosLista()
        {
            ListaPictureBoxLugares.Add(picRegion1);
            ListaPictureBoxLugares.Add(picRegion2);
            ListaPictureBoxLugares.Add(picRegion3);
            ListaPictureBoxLugares.Add(picRegion4);
            ListaPictureBoxObjetos.Add(picImage1);
            ListaPictureBoxObjetos.Add(picImage2);
            ListaPictureBoxObjetos.Add(picImage3);
            ListaPictureBoxObjetos.Add(picImage4);
            ListaPictureBoxObjetos.Add(picImage5);
            ListaPictureBoxObjetos.Add(picImage6);
            ListaPictureBoxObjetos.Add(picImage7);
            ListaPictureBoxObjetos.Add(picImage8);
            ListaPictureBoxObjetos.Add(picImage9);
        }

        private void Calificacion()
        {
            if (ObjInstruction.Aciertos == 4)
            {
                //un msj de muy bien hecho
                //ObjInstruction.playSound("BienAutoevaluacion");
                MessageBox.Show("muy bien hecho...Siguiente Autoevalaución");
                new frmAutoevaluacion5().Show();
                Hide();
            }
            else if (ObjInstruction.Clicks > 7)
            {
                //excediste en los intentos
                MessageBox.Show("excediste en los intentos...Siguiente Autoevalaución");
                new frmAutoevaluacion5().Show();
                Hide();
            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            frmAlerta ObjFormulario = new frmAlerta();
            ObjFormulario.ShowDialog();
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            frmAutoevaluacion5 ObjFormulario = new frmAutoevaluacion5();
            ObjFormulario.Show();
            Hide();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            //ObjInstruction.playSound("Autoevaluacion4");
        }

        #region Puntero Mouse
        private void frmAutoevaluacion4_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Mouse(this,1);
            picHome.BorderStyle = BorderStyle.None;
            picNext.BorderStyle = BorderStyle.None;
            picHelp.BorderStyle = BorderStyle.None;

            for (int i = 0; i < ListaPictureBoxObjetos.Count; i++)
                ListaPictureBoxObjetos[i].BorderStyle = BorderStyle.None;

            Calificacion();
        }

        private void picHome_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picHome);
        }

        private void picNext_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picNext);
        }

        private void picHelp_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picHelp);
        }

        private void picImage1_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage1);
        }

        private void picImage2_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage2);
        }

        private void picImage3_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage3);
        }

        private void picImage4_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage4);
        }

        private void picImage5_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage5);
        }

        private void picImage6_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage6);
        }

        private void picImage7_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage7);
        }

        private void picImage8_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage8);
        }

        private void picImage9_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage9);
        }

        #endregion

        #region Drag & Drop

        private void picImage1_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage1;
            picImage1.DoDragDrop(picImage1.BackgroundImage, DragDropEffects.Move);
        }

        private void picImage2_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage2;
            picImage2.DoDragDrop(picImage2.BackgroundImage, DragDropEffects.Move);
        }

        private void picImage3_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage3;
            picImage3.DoDragDrop(picImage3.BackgroundImage, DragDropEffects.Move);
        }

        private void picImage4_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage4;
            picImage4.DoDragDrop(picImage4.BackgroundImage, DragDropEffects.Move);
        }

        private void picImage5_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage5;
            picImage5.DoDragDrop(picImage5.BackgroundImage, DragDropEffects.Move);
        }

        private void picImage6_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage6;
            picImage6.DoDragDrop(picImage6.BackgroundImage, DragDropEffects.Move);
        }

        private void picImage7_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage7;
            picImage7.DoDragDrop(picImage7.BackgroundImage, DragDropEffects.Move);
        }

        private void picImage8_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage8;
            picImage8.DoDragDrop(picImage8.BackgroundImage, DragDropEffects.Move);
        }

        private void picImage9_MouseDown(object sender, MouseEventArgs e)
        {
            picAux = picImage9;
            picImage9.DoDragDrop(picImage9.BackgroundImage, DragDropEffects.Move);
        }

        private void picRegion1_DragEnter(object sender, DragEventArgs e)
        {
            ObjInstruction.ValidateDragDrop(ListaPictureBoxObjetos, picRegion1, picAux, e);

        }

        private void picRegion2_DragEnter(object sender, DragEventArgs e)
        {
            ObjInstruction.ValidateDragDrop(ListaPictureBoxObjetos, picRegion2, picAux, e);
        }

        private void picRegion3_DragEnter(object sender, DragEventArgs e)
        {
            ObjInstruction.ValidateDragDrop(ListaPictureBoxObjetos, picRegion3, picAux, e);
        }

        private void picRegion4_DragEnter(object sender, DragEventArgs e)
        {
            ObjInstruction.ValidateDragDrop(ListaPictureBoxObjetos, picRegion4, picAux, e);
        }

        #endregion

    }
}
