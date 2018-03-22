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
    public partial class frmAutoevaluacion3 : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();
        private CResize ObjResize = new CResize();

        private List<PictureBox> ListaPictureBoxObjetos = new List<PictureBox>();
        private List<PictureBox> ListaPictureBotones = new List<PictureBox>();
        private PictureBox picAux = new PictureBox();
        private string vocal;

        public frmAutoevaluacion3()
        {
            InitializeComponent();
            InsertarDatosLista();
            vocal = ObjInitialize.Vocales(ListaPictureBoxObjetos);
            ObjInstruction.playSound("Autoevaluacion3");
            ObjResize.ResolutionAutoevaluation(this);
            ObjResize.ResizeComponentsAutoevaluation(ListaPictureBoxObjetos, ListaPictureBotones);
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
            ListaPictureBotones.Add(picHome);
            ListaPictureBotones.Add(picNext);
            ListaPictureBotones.Add(picHelp);
            ListaPictureBotones.Add(picBtnAudioHelp);
        }

        //Calificacion
        private void Calificacion()
        {
            if (ObjInstruction.Aciertos == 3)
            {
                new frmMessageAutoevaluacion("Correcto").ShowDialog();
                new frmAutoevaluacion4().Show();
                Hide();
            }
            else if (ObjInstruction.Clicks >= 6)
            {
                new frmMessageAutoevaluacion("Inorrecto").ShowDialog();
                new frmAutoevaluacion4().Show();
                Hide();
            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            frmAlerta ObjFormulario = new frmAlerta();
            ObjFormulario.ShowDialog();
            Timer.Enabled = false;
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            frmAutoevaluacion4 ObjFormulario = new frmAutoevaluacion4();
            ObjFormulario.Show();
            Hide();
            Timer.Enabled = false;
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            ObjInstruction.Player.Stop();
            Timer.Enabled = false;
            new frmHelpAutoevaluacion("Autoevaluacion3").ShowDialog();
        }

        private void picBtnAudioHelp_Click(object sender, EventArgs e)
        {
            ObjInstruction.playSound("Autoevaluacion3");
            Timer.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ObjInstruction.playSound(vocal);
            Timer.Enabled = false;
        }

        #region Puntero Mouse
        private void frmAutoevaluacion3_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Mouse(this,1);
            Calificacion();
            picHome.BorderStyle = BorderStyle.None;
            picNext.BorderStyle = BorderStyle.None;
            picHelp.BorderStyle = BorderStyle.None;

            for (int i = 0; i < ListaPictureBoxObjetos.Count; i++)
                ListaPictureBoxObjetos[i].BorderStyle = BorderStyle.None;
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

        #region Comparar Los Picture Box's
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

        #endregion

    }
}
