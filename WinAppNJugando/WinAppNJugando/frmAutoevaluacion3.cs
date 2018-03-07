using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

/**
  * @Autor: Diego Borja.
  * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmAutoevaluacion3 : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();

        private List<PictureBox> ListaPictureBoxObjetos = new List<PictureBox>();
        private PictureBox picAux = new PictureBox();

        public frmAutoevaluacion3()
        {
            InitializeComponent();
            InsertarDatosLista();
            ObjInitialize.Vocales(ListaPictureBoxObjetos);
        }

        //Insertar todos los PictureBox en una lista.
        private void InsertarDatosLista()
        {
            ListaPictureBoxObjetos.Add(picVowel);
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

        //Calificacion
        private void Calificacion()
        {
            if (ObjInstruction.Puntaje >= 13 || ObjInstruction.Aciertos >= 3 || ObjInstruction.Clicks >= 6)
            {
                MessageBox.Show("Siguiente Autoevalaución");//un msj de muy bien hecho que indique ago
                new frmAutoevaluacion4().Show();
                Hide();
            }
        }

        #region Puntero Mouse

        private void picHome_Click(object sender, EventArgs e)
        {
            frmAlerta ObjFormulario = new frmAlerta();
            ObjFormulario.ShowDialog();
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            frmAutoevaluacion4 ObjFormulario = new frmAutoevaluacion4();
            ObjFormulario.Show();
            Hide();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            ObjInstruction.playSound("Autoevaluacion3");
        }

        private void frmAutoevaluacion3_MouseEnter(object sender, EventArgs e)
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
            ObjInitialize.Seleccionar(this, picNext);
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

        private void picImage1_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage1, e);
        }

        private void picImage2_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage2, e);
        }

        private void picImage3_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage3, e);
        }

        private void picImage4_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage4, e);
        }

        private void picImage5_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage5, e);
        }

        private void picImage6_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage6, e);
        }

        private void picImage7_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage7, e);
        }

        private void picImage8_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage8, e);
        }

        private void picImage9_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox1(picImage9, e);
        }

    }
}
