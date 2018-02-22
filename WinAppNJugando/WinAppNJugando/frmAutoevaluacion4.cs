using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

/**
 *@Autor Borja Diego
 * **/

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
            if (ObjInstruction.Puntaje >= 17 || ObjInstruction.Aciertos >= 4 || ObjInstruction.Clicks > 7)
            {
                MessageBox.Show("Siguiente Autoevalaución");//un msj de muy bien hecho que indique ago
                new frmAutoevaluacion5().Show();
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
            frmAutoevaluacion5 ObjFormulario = new frmAutoevaluacion5();
            ObjFormulario.Show();
            Hide();
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            ObjInstruction.playSound("Autoevaluacion4");
        }

        private void frmAutoevaluacion4_MouseEnter(object sender, EventArgs e)
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

        private void picRegion1_DragEnter(object sender, DragEventArgs e)
        {
            int i;
            string name = picRegion1.Name.ToString();

            if(name=="Costa")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Delfin"|| ListaPictureBoxObjetos[i].Name == "Gaviota" || ListaPictureBoxObjetos[i].Name == "Langosta" || ListaPictureBoxObjetos[i].Name == "Ballena")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
             else
                if(name == "Sierra")
                {
                    for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                        {
                            ObjInstruction.Clicks++;
                            e.Effect = DragDropEffects.Move;
                            ListaPictureBoxObjetos[i].Visible = false;
                            if (ListaPictureBoxObjetos[i].Name == "Condor" || ListaPictureBoxObjetos[i].Name == "Conejo" || ListaPictureBoxObjetos[i].Name == "Pato" || ListaPictureBoxObjetos[i].Name == "Raton")
                            {
                                ObjInstruction.Puntaje++;
                                ObjInstruction.Aciertos++;
                            }
                        }
                    }
                }
                else
                    if (name == "Oriente")
                    {
                        for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                        {
                            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                            {
                                ObjInstruction.Clicks++;
                                e.Effect = DragDropEffects.Move;
                                ListaPictureBoxObjetos[i].Visible = false;
                                if (ListaPictureBoxObjetos[i].Name == "Mono" || ListaPictureBoxObjetos[i].Name == "OsoPerezoso" || ListaPictureBoxObjetos[i].Name == "Rana" || ListaPictureBoxObjetos[i].Name == "Serpiente")
                                {
                                    ObjInstruction.Puntaje++;
                                    ObjInstruction.Aciertos++;
                                }
                            }
                        }
                    }
                    else
                        if (name == "Insular")
                        {
                            for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                            {
                                if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                                {
                                    ObjInstruction.Clicks++;
                                    e.Effect = DragDropEffects.Move;
                                    ListaPictureBoxObjetos[i].Visible = false;
                                    if (ListaPictureBoxObjetos[i].Name == "DelfinGalapagos" || ListaPictureBoxObjetos[i].Name == "Pinguino" || ListaPictureBoxObjetos[i].Name == "Tiburon" || ListaPictureBoxObjetos[i].Name == "Tortuga")
                                    {
                                        ObjInstruction.Puntaje++;
                                        ObjInstruction.Aciertos++;
                                    }
                                }
                            }
                        }

        }

        private void picRegion1_DragDrop(object sender, DragEventArgs e)
        {
            picRegion1.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picRegion2_DragEnter(object sender, DragEventArgs e)
        {
            int i;
            string name = picRegion2.Name.ToString();

            if (name == "Costa")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Delfin" || ListaPictureBoxObjetos[i].Name == "Gaviota" || ListaPictureBoxObjetos[i].Name == "Langosta" || ListaPictureBoxObjetos[i].Name == "Ballena")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
                if (name == "Sierra")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Condor" || ListaPictureBoxObjetos[i].Name == "Conejo" || ListaPictureBoxObjetos[i].Name == "Pato" || ListaPictureBoxObjetos[i].Name == "Raton")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
                    if (name == "Oriente")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Mono" || ListaPictureBoxObjetos[i].Name == "OsoPerezoso" || ListaPictureBoxObjetos[i].Name == "Rana" || ListaPictureBoxObjetos[i].Name == "Serpiente")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
                        if (name == "Insular")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "DelfinGalapagos" || ListaPictureBoxObjetos[i].Name == "Pinguino" || ListaPictureBoxObjetos[i].Name == "Tiburon" || ListaPictureBoxObjetos[i].Name == "Tortuga")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
        }

        private void picRegion2_DragDrop(object sender, DragEventArgs e)
        {
            picRegion2.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picRegion3_DragEnter(object sender, DragEventArgs e)
        {
            int i;
            string name = picRegion3.Name.ToString();

            if (name == "Costa")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Delfin" || ListaPictureBoxObjetos[i].Name == "Gaviota" || ListaPictureBoxObjetos[i].Name == "Langosta" || ListaPictureBoxObjetos[i].Name == "Ballena")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
                if (name == "Sierra")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Condor" || ListaPictureBoxObjetos[i].Name == "Conejo" || ListaPictureBoxObjetos[i].Name == "Pato" || ListaPictureBoxObjetos[i].Name == "Raton")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
            if (name == "Oriente")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Mono" || ListaPictureBoxObjetos[i].Name == "OsoPerezoso" || ListaPictureBoxObjetos[i].Name == "Rana" || ListaPictureBoxObjetos[i].Name == "Serpiente")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
            if (name == "Insular")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "DelfinGalapagos" || ListaPictureBoxObjetos[i].Name == "Pinguino" || ListaPictureBoxObjetos[i].Name == "Tiburon" || ListaPictureBoxObjetos[i].Name == "Tortuga")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
        }

        private void picRegion3_DragDrop(object sender, DragEventArgs e)
        {
            picRegion3.BackgroundImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picRegion4_DragEnter(object sender, DragEventArgs e)
        {
            int i;
            string name = picRegion4.Name.ToString();

            if (name == "Costa")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Delfin" || ListaPictureBoxObjetos[i].Name == "Gaviota" || ListaPictureBoxObjetos[i].Name == "Langosta" || ListaPictureBoxObjetos[i].Name == "Ballena")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
                if (name == "Sierra")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Condor" || ListaPictureBoxObjetos[i].Name == "Conejo" || ListaPictureBoxObjetos[i].Name == "Pato" || ListaPictureBoxObjetos[i].Name == "Raton")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
            if (name == "Oriente")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "Mono" || ListaPictureBoxObjetos[i].Name == "OsoPerezoso" || ListaPictureBoxObjetos[i].Name == "Rana" || ListaPictureBoxObjetos[i].Name == "Serpiente")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
            else
            if (name == "Insular")
            {
                for (i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaPictureBoxObjetos[i]))
                    {
                        ObjInstruction.Clicks++;
                        e.Effect = DragDropEffects.Move;
                        ListaPictureBoxObjetos[i].Visible = false;
                        if (ListaPictureBoxObjetos[i].Name == "DelfinGalapagos" || ListaPictureBoxObjetos[i].Name == "Pinguino" || ListaPictureBoxObjetos[i].Name == "Tiburon" || ListaPictureBoxObjetos[i].Name == "Tortuga")
                        {
                            ObjInstruction.Puntaje++;
                            ObjInstruction.Aciertos++;
                        }
                    }
                }
            }
        }

        #endregion
    }
}
