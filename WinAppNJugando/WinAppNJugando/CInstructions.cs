using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Collections.Generic;

/**
  * @Autor: Diego Borja.
  * 
**/

namespace WinAppNiñitosEnAccion
{
    class CInstructions
    {
        #region Atributes of the class
        private static int puntaje;
        private int clicks;
        private int aciertos;

        private Bitmap myBitmap;
        private SoundPlayer player;

        #endregion

        #region Properties (Set & Get)
        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }

        public int Clicks
        {
            get { return clicks; }
            set { clicks = value; }
        }

        public int Aciertos
        {
            get { return aciertos; }
            set { aciertos = value; }
        }

        public SoundPlayer Player
        {
            get { return player; }
            set { player = value; }
        }

        #endregion

        #region Constructors of the class
        public CInstructions()
        {
            clicks = 0; aciertos = 0;   
        }
        #endregion

        #region Methods
        //Validacion del Drag & Drop
        public void ValidateDragDrop(List<PictureBox> ListaUse, PictureBox picComparate, PictureBox picAux, DragEventArgs e)
        {
            int i;
            switch (picComparate.Name.ToString())
            {
                #region Autoevaluacion 1:
                case "picDormitorio":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Cama" || ListaUse[i].Name == "Lampara")
                            {
                                puntaje++;
                                e.Effect = DragDropEffects.Copy;
                                ListaUse[i].Enabled = false;
                                picComparate.BackgroundImage= new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picSaladeEstudio":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Silla" || ListaUse[i].Name == "Escritorio")
                            {
                                puntaje++;
                                e.Effect = DragDropEffects.Copy;
                                ListaUse[i].Enabled = false;
                                picComparate.BackgroundImage = new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picBaño":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "TinadeBaño" || ListaUse[i].Name == "Lavavo")
                            {
                                puntaje++;
                                e.Effect = DragDropEffects.Copy;
                                ListaUse[i].Enabled = false;
                                picComparate.BackgroundImage = new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picSala":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Sofa" || ListaUse[i].Name == "Comedor")
                            {
                                puntaje++;
                                e.Effect = DragDropEffects.Copy;
                                ListaUse[i].Enabled = false;
                                picComparate.BackgroundImage = new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picCocina":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Olla" || ListaUse[i].Name == "Refrigeradora")
                            {
                                puntaje++;
                                e.Effect = DragDropEffects.Copy;
                                ListaUse[i].Enabled = false;
                                picComparate.BackgroundImage = new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;
                #endregion

                #region Autoevaluacion 2:
                case "picClock":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Relog")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/RelogAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picBoard":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Pizarron")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/PizarronAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picBag":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Mochila")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/MochilaAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picBooks":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Libros")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/LibrosAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picPuzzle":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Rompecabezas")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/RompecabezasAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picChair":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "SillaAula")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/SillaAulaAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picCrayons":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Crayones")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/CrayonesAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "picNotebooks":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Cuadernos")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/CuadernosAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }

                    }
                    break;

                case "picBall":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Pelota")
                            {
                                puntaje++;
                                aciertos++;
                                e.Effect = DragDropEffects.Move;
                                ListaUse[i].Enabled = false;
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/PelotaAcierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;
                    #endregion
            }
        }
        public void ValidateDragDrop(List<PictureBox> ListaUse, PictureBox picComparate, PictureBox picResult, PictureBox picAux, DragEventArgs e)
        {
            int i;
            switch (picComparate.Name.ToString())
            {
                #region Autoevaluacion 4:
                case "Costa":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Cangrejo" || ListaUse[i].Name == "Gaviota" || ListaUse[i].Name == "Langosta" || ListaUse[i].Name == "Ballena")
                            {
                                puntaje++;
                                aciertos++;
                                ListaUse[i].Enabled = false;
                                picResult.Visible = true;
                                picResult.Location = new Point(picComparate.Location.X+7, picComparate.Location.Y-75);
                                picResult.Parent = picComparate;
                                picResult.BackgroundImage = new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");

                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "Sierra":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Condor" || ListaUse[i].Name == "Conejo" || ListaUse[i].Name == "Pato" || ListaUse[i].Name == "Raton")
                            {
                                puntaje++;
                                aciertos++;
                                ListaUse[i].Enabled = false;
                                picResult.Visible = true;
                                picResult.Location = new Point(picComparate.Location.X + 7, picComparate.Location.Y - 75);
                                picResult.Parent = picComparate;
                                picResult.BackgroundImage = new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "Oriente":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "Mono" || ListaUse[i].Name == "OsoPerezoso" || ListaUse[i].Name == "Rana" || ListaUse[i].Name == "Serpiente")
                            {
                                puntaje++;
                                aciertos++;
                                ListaUse[i].Enabled = false;
                                picResult.Visible = true;
                                picResult.Location = new Point(picComparate.Location.X + 7, picComparate.Location.Y - 75);
                                picResult.Parent = picComparate;
                                picResult.BackgroundImage = new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                case "Insular":
                    for (i = 0; i < ListaUse.Count; i++)
                    {
                        if (e.Data.GetDataPresent(DataFormats.Bitmap) && (picAux == ListaUse[i]))
                        {
                            clicks++;
                            if (ListaUse[i].Name == "DelfinGalapagos" || ListaUse[i].Name == "Pinguino" || ListaUse[i].Name == "Tiburon" || ListaUse[i].Name == "Tortuga")
                            {
                                puntaje++;
                                aciertos++;
                                ListaUse[i].Enabled = false;
                                picResult.Visible = true;
                                picResult.Location = new Point(picComparate.Location.X + 7, picComparate.Location.Y - 75);
                                picResult.Parent = picComparate;
                                picResult.BackgroundImage = new Bitmap(Application.StartupPath + @"/Image/" + ListaUse[i].Name + ".png");
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Acierto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Acierto");
                            }
                            else
                            {
                                myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + ListaUse[i].Name.ToString() + "Incorrecto.png");
                                ListaUse[i].BackgroundImage = myBitmap;
                                playSound("Incorrecto");
                            }
                        }
                    }
                    break;

                #endregion
            }
        }
        //Compara los PictureBox de la Autoevaluacion3
        public void CompararPictureBox1(PictureBox PicComparate, MouseEventArgs e)
        {
            Bitmap myBitmap;

            if (e.Button == MouseButtons.Left)
            {
                clicks++;
                if (PicComparate.Name == "Almohada" || PicComparate.Name == "Aspiradora" || PicComparate.Name == "Arco" ||
                    PicComparate.Name == "Escalera" || PicComparate.Name == "Escritorio" || PicComparate.Name == "Escuela" ||
                    PicComparate.Name == "Impresora" || PicComparate.Name == "Iman" || PicComparate.Name == "Iguana"||
                    PicComparate.Name == "Olla" || PicComparate.Name == "Ocho" || PicComparate.Name == "Oso" ||
                    PicComparate.Name == "Uvas" || PicComparate.Name == "Utiles" || PicComparate.Name == "Uno")
                {
                    switch(PicComparate.Name.ToString())
                    {
                        case "Almohada" :
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/AlmohadaAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Aspiradora":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/AspiradoraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Arco":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/ArcoAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Escalera":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/EscaleraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Escritorio":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/EscritorioAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Escuela":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/EscuelaAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Impresora":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/ImpresoraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Iman":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/ImanAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Iguana":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/IguanaAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Olla":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/OllaAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Ocho":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/OchoAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Oso":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/OsoAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Uvas":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/UvasAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Utiles":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/UtilesAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Uno":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/UnoAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;
                    }
                    puntaje++;
                    aciertos++;
                    playSound("Acierto");
                }
                else
                {
                    myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + PicComparate.Name + "Incorrecto.png");
                    PicComparate.BackgroundImage = myBitmap;
                    playSound("Incorrecto");
                }
            }
        }

        //Compara los PictureBox de la Autoevaluacion5
        public void CompararPictureBox(PictureBox PicComparate, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clicks++;
                if (PicComparate.Name == "Tiburon" || PicComparate.Name == "Avion" || PicComparate.Name == "Pizarron" || 
                    PicComparate.Name == "Aspiradora" || PicComparate.Name == "Refrigeradora" || PicComparate.Name == "Licuadora" ||
                    PicComparate.Name == "Escalera" || PicComparate.Name == "Bandera" || PicComparate.Name == "Cafetera")
                {

                    switch (PicComparate.Name.ToString())
                    {
                        case "Tiburon":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/TiburonAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Avion":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/AvionAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Pizarron":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/PizarronAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Aspiradora":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/AspiradoraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Refrigeradora":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/RefrigeradoraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Licuadora":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/LicuadoraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Escalera":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/EscaleraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Bandera":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/BanderaAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Cafetera":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/CafeteraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;
                        
                    }
                    puntaje++;
                    aciertos++;
                    playSound("Acierto");
                }
                else
                {
                    myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/" + PicComparate.Name + "Incorrecto.png");
                    PicComparate.BackgroundImage = myBitmap;
                    playSound("Incorrecto");
                }
            }
        }

        //Cargar el audio
        public void playSound(String text)
        {
            player = new SoundPlayer(Application.StartupPath + @"/Sound/"+text.ToString()+".wav");
            player.Play();
        }

        //Asiganacion de el puntaje en el frmPuntajeAutoevaluacion.
        public void Puntuacion(PictureBox picUse, List<PictureBox> ListaUse)
        {
            if (puntaje >= 20)
            { 
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/PuntuacionAlta.png");
                picUse.BackgroundImage = myBitmap;
                picUse.Name = "PuntuacionAlta";
                playSound("Excelente");
                for (int i = 0; i < ListaUse.Count; i++)
                    ListaUse[i].Visible = true;
            }
            else if(puntaje>=15 && puntaje<20)
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/PuntuacionMedia.png");
                picUse.BackgroundImage = myBitmap;
                picUse.Name = "PuntuacionMedia";
                playSound("MuyBien");
                ListaUse[0].Location = new Point(160, 285);
                ListaUse[1].Location = new Point(240, 285); ;
                ListaUse[2].Location = new Point(320, 285); ;
                ListaUse[0].Visible = true;
                ListaUse[1].Visible = true;
                ListaUse[2].Visible = true;
            }
            else if (puntaje >= 5 && puntaje < 15)
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/PuntuacionBaja.png");
                picUse.BackgroundImage = myBitmap;
                picUse.Name = "PuntuacionBaja";
                playSound("LaProxima");
                ListaUse[1].Visible = true;
                ListaUse[2].Visible = true;
            }
            else if(puntaje<5)
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/PuntuacionCero.png");
                picUse.BackgroundImage = myBitmap;
                picUse.Name = "PuntuacionCero";
                playSound("IntentaloNuevamente");
                ListaUse[0].Location = new Point(240, 285);
                ListaUse[0].Visible = true;
            }
        }

        #endregion

    }
}
