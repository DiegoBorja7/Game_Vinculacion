using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

/**
 *@Autor Borja Diego
 * **/

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
            if (ObjInstruction.Puntaje >= 13 || ObjInstruction.Aciertos >= 3 || ObjInstruction.Clicks > 7)
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

        private void picVowel_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Almohada" || ListaPictureBoxObjetos[i].Name == "Aspiradora" || ListaPictureBoxObjetos[i].Name == "Arco" ||
                        ListaPictureBoxObjetos[i].Name == "Escalera" || ListaPictureBoxObjetos[i].Name == "Escritorio" || ListaPictureBoxObjetos[i].Name == "Escuela" ||
                        ListaPictureBoxObjetos[i].Name == "Impresora" || ListaPictureBoxObjetos[i].Name == "Iman" || ListaPictureBoxObjetos[i].Name == "Iguana" ||
                        ListaPictureBoxObjetos[i].Name == "Olla" || ListaPictureBoxObjetos[i].Name == "Ocho" || ListaPictureBoxObjetos[i].Name == "Oso" ||
                        ListaPictureBoxObjetos[i].Name == "Uvas" || ListaPictureBoxObjetos[i].Name == "Utiles" || ListaPictureBoxObjetos[i].Name == "Uno")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        #endregion

        
    }
}
