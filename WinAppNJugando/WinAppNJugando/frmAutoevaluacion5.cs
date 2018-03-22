using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

/**
 * @Autor: Diego Borja.
 * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmAutoevaluacion5 : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();
        private CResize ObjResize = new CResize();

        private List<PictureBox> ListaPictureBoxObjetos = new List<PictureBox>();
        private List<PictureBox> ListaPictureBotones = new List<PictureBox>();

        public frmAutoevaluacion5()
        {
            InitializeComponent();
            InsertarDatosLista();
            ObjInitialize.TerminanEn(ListaPictureBoxObjetos);
            ObjInstruction.playSound("Autoevaluacion5");
            ObjResize.ResolutionAutoevaluation(this);
            ObjResize.ResizeComponentsAutoevaluation(ListaPictureBoxObjetos, ListaPictureBotones);
        }

        //Insertar todos los PictureBox en una lista.
        private void InsertarDatosLista()
        {
            ListaPictureBoxObjetos.Add(picImage1);
            ListaPictureBoxObjetos.Add(picImage2);
            ListaPictureBoxObjetos.Add(picImage3);
            ListaPictureBoxObjetos.Add(picImage4);
            ListaPictureBoxObjetos.Add(picImage5);
            ListaPictureBoxObjetos.Add(picImage6);
            ListaPictureBoxObjetos.Add(picImage7);
            ListaPictureBoxObjetos.Add(picImage8);
            ListaPictureBoxObjetos.Add(picImage9);
            ListaPictureBoxObjetos.Add(picImage10);
            ListaPictureBotones.Add(picHome);
            ListaPictureBotones.Add(picNext);
            ListaPictureBotones.Add(picHelp);
            ListaPictureBotones.Add(picBtnAudioHelp);
        }

        private void Calificacion()
        {
            frmPuntajeAutoevaluacion ObjFormulario = new frmPuntajeAutoevaluacion();

            if (ObjInstruction.Aciertos == 3)
            {
                new frmMessageAutoevaluacion("Correcto").ShowDialog();
                ObjFormulario.Show();
                Hide();
            }
            else if (ObjInstruction.Clicks > 6)
            {
                new frmMessageAutoevaluacion("Incorrecto").ShowDialog();
                ObjFormulario.Show();
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
            frmPuntajeAutoevaluacion ObjFormulario = new frmPuntajeAutoevaluacion();
            ObjFormulario.Show();
            Hide();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            ObjInstruction.Player.Stop();
            new frmHelpAutoevaluacion("Autoevaluacion5").ShowDialog();
        }

        private void picBtnAudioHelp_Click(object sender, EventArgs e)
        {
            ObjInstruction.playSound("Autoevaluacion5");
        }

        #region Puntero Mouse
        private void frmAutoevaluacion5_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Mouse(this,1);
            Calificacion();
            picHome.BorderStyle = BorderStyle.None;
            picNext.BorderStyle = BorderStyle.None;
            picHelp.BorderStyle = BorderStyle.None;

            for (int i=0; i<ListaPictureBoxObjetos.Count;i++)
                ListaPictureBoxObjetos[i].BorderStyle= BorderStyle.None;
            
        }

        private void picBtnAudioHelp_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picBtnAudioHelp.Width = (picBtnAudioHelp.Width + 10);
            picBtnAudioHelp.Height = (picBtnAudioHelp.Height + 10);
            picBtnAudioHelp.Location = new Point((picBtnAudioHelp.Location.X - 5), (picBtnAudioHelp.Location.Y - 5));
        }

        private void picBtnAudioHelp_MouseLeave(object sender, EventArgs e)
        {
            picBtnAudioHelp.Width = (picBtnAudioHelp.Width - 10);
            picBtnAudioHelp.Height = (picBtnAudioHelp.Height - 10);
            picBtnAudioHelp.Location = new Point((picBtnAudioHelp.Location.X + 5), (picBtnAudioHelp.Location.Y + 5));
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
            ObjInstruction.playSound(ListaPictureBoxObjetos[0].Name);

        }

        private void picImage2_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage2);
            ObjInstruction.playSound(ListaPictureBoxObjetos[1].Name);
        }

        private void picImage3_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage3);
            ObjInstruction.playSound(ListaPictureBoxObjetos[2].Name);
        }

        private void picImage4_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage4);
            ObjInstruction.playSound(ListaPictureBoxObjetos[3].Name);
        }

        private void picImage5_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage5);
            ObjInstruction.playSound(ListaPictureBoxObjetos[4].Name);
        }

        private void picImage6_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage6);
            ObjInstruction.playSound(ListaPictureBoxObjetos[5].Name);
        }

        private void picImage7_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage7);
            ObjInstruction.playSound(ListaPictureBoxObjetos[6].Name);
        }

        private void picImage8_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage8);
            ObjInstruction.playSound(ListaPictureBoxObjetos[7].Name);
        }

        private void picImage9_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage9);
            ObjInstruction.playSound(ListaPictureBoxObjetos[8].Name);
        }

        private void picImage10_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picImage10);
            ObjInstruction.playSound(ListaPictureBoxObjetos[9].Name);
        }
        #endregion

        #region Comparar Los Picture Box's
        private void picImage1_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage1, e);
        }

        private void picImage2_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage2, e);
        }

        private void picImage3_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage3, e);
        }

        private void picImage4_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage4, e);
        }

        private void picImage5_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage5, e);
        }

        private void picImage6_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage6, e);
        }

        private void picImage7_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage7, e);
        }

        private void picImage8_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage8, e);
        }

        private void picImage9_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage9, e);
        }

        private void picImage10_MouseUp(object sender, MouseEventArgs e)
        {
            ObjInstruction.CompararPictureBox(picImage10, e);
        }
        #endregion

    }
}
