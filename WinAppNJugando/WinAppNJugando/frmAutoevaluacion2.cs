﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

/**
 *@Autor Borja Diego
 * **/

namespace WinAppNiñitosEnAccion
{
    public partial class frmAutoevaluacion2 : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();

        private List<PictureBox> ListaPictureBoxObjetos = new List<PictureBox>();
        private List<PictureBox> ListaPictureBoxLugares = new List<PictureBox>();
        private PictureBox picAux = new PictureBox();

        public frmAutoevaluacion2()
        {
            InitializeComponent();
            InsertarDatosLista();
            ObjInitialize.CosasdelaEscuela(ListaPictureBoxObjetos);
            ObjInitialize.AllowDropAll(ListaPictureBoxLugares);
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
            ListaPictureBoxLugares.Add(picClock);
            ListaPictureBoxLugares.Add(picBoard);
            ListaPictureBoxLugares.Add(picBall);
            ListaPictureBoxLugares.Add(picBooks);
            ListaPictureBoxLugares.Add(picBag);
            ListaPictureBoxLugares.Add(picPuzzle);
            ListaPictureBoxLugares.Add(picChair);
            ListaPictureBoxLugares.Add(picCrayons);
            ListaPictureBoxLugares.Add(picNotebooks);
        }

        //Calificacion
        private void Calificacion()
        {
            if (ObjInstruction.Puntaje >= 10 || ObjInstruction.Aciertos >= 5 || ObjInstruction.Clicks > 9)
            {
                MessageBox.Show("Siguiente Autoevalaución");//un msj de muy bien hecho que indique ago
                new frmAutoevaluacion3().Show();
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
            frmAutoevaluacion3 ObjFormulario = new frmAutoevaluacion3();
            ObjFormulario.Show();
            Hide();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            ObjInstruction.playSound("Autoevaluacion2");
        }

        private void frmAutoevaluacion2_MouseEnter(object sender, EventArgs e)
        {
            DoubleBuffered = true;
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
            ObjInitialize.Seleccionar(this, picHelp);
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

        private void picClock_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Relog")
                    { 
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        private void picClock_DragDrop(object sender, DragEventArgs e)
        {
            picClock.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picBoard_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Pizarron")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        private void picBoard_DragDrop(object sender, DragEventArgs e)
        {
            picBoard.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picBag_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Mochila")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        private void picBag_DragDrop(object sender, DragEventArgs e)
        {
            picBag.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picBooks_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Libros")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        private void picBooks_DragDrop(object sender, DragEventArgs e)
        {
            picBooks.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picPuzzle_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Rompecabezas")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }

                }
            }
        }

        private void picPuzzle_DragDrop(object sender, DragEventArgs e)
        {
            picPuzzle.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picChair_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "SillaAula")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        private void picChair_DragDrop(object sender, DragEventArgs e)
        {
            picChair.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picCrayons_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Crayones")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        private void picCrayons_DragDrop(object sender, DragEventArgs e)
        {
            picCrayons.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picNotebooks_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Cuadernos")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        private void picNotebooks_DragDrop(object sender, DragEventArgs e)
        {
            picNotebooks.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picBall_DragEnter(object sender, DragEventArgs e)
        {
            int i;

            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                {
                    ObjInstruction.Clicks++;
                    e.Effect = DragDropEffects.Move;
                    ListaPictureBoxObjetos[i].Visible = false;
                    if (ListaPictureBoxObjetos[i].Name == "Pelota")
                    {
                        ObjInstruction.Puntaje++;
                        ObjInstruction.Aciertos++;
                    }
                }
            }
        }

        private void picBall_DragDrop(object sender, DragEventArgs e)
        {
            picBall.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        #endregion

        
    }
}
