/*
 * Autores: DEL SALTO SANTIAGO, TADAY KEVIN
 * Fecha:8-02-2017
 * PROYECTO INTEGRADOR - JUEGO TU CASA O TU ESCUELA
 */
 // ultima version
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.Diagnostics;
using WinAppNiñitosEnAccion;

namespace WinAppProject
{
    public partial class frmJuego : Form
    {
        private int aciertos,fallos=0;
        private string[] messages= new string []{"EnhoraBuena, Exelente Puntuación", "¡Enhorabuena¡ Lo has hecho muy Bien", "Muy Bien Intentalo otra vez"};
        private string sendMessage;
        private bool presionado, noPresionado;
        private Point punto;
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(70, 76, 255, 0));
        public Point MouseDownLocation { get; private set; }
        private CSounds sound = new CSounds();
        private CImages pictures = new CImages();
        private CPicCanvas initializePictureBox = new CPicCanvas();
        private CInitializeThings mouses = new CInitializeThings();

        public frmJuego()
        {
            this.DoubleBuffered = true; //Evita el flickering entre Canvas
            Stopwatch sw = Stopwatch.StartNew();

            InitializeComponent();
            CenterToScreen();

            Mouse();

            initializePictureBox.PositionReturn(picImage1, picImage2, picImage3, picImage4, picImage5, picImage6);


            initializePictureBox.PositionImages(picImage1, picImage2, picImage3, picImage4, picImage5, picImage6,
                                               picEscuela1,picEscuela2,picEscuela3, picCasa1, picCasa2, picCasa3);

            initializePictureBox.VisibilityDestination(picDestinoCasa1, picDestinoCasa2, picDestinoCasa3, picDestinoEscuela1, picDestinoEscuela2,picDestinoEscuela3);

            initializePictureBox.VisibilityReturn(picImage1, picImage2, picImage3, picImage4, picImage5, picImage6);



            pictures.casa(picCasa1, picCasa2, picCasa3);
            pictures.escuela(picEscuela1, picEscuela2, picEscuela3);


            sw.Stop();
            label1.Text = sw.Elapsed.TotalMilliseconds.ToString();

            //Transparencia de botones
            this.btnHome.BackColor = Color.Transparent;
            this.btnBackRegreat.BackColor= Color.Transparent;
            this.btnHelp.BackColor= Color.Transparent;

        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            printHelp();
        }

        private void Mouse()
        {
            mouses.Mouse(this, 3);
        }


        #region Sonido

        private void picEscuela1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picEscuela1);
        }

        private void picEscuela2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picEscuela2);
        }

        private void picEscuela3_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picEscuela3);
        }

        private void picCasa1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picCasa1);
        }

        private void picCasa2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picCasa2);
        }

        private void picCasa3_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picCasa3);
        }

        #endregion

        #region ESCUELA

        //PIC ESCUELA 1
        private void picEscuela1_MouseDown(object sender, MouseEventArgs e)
        {
            CSounds sonido = new CSounds();
            sonido.playSound("Click");
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela1, true);

            if (e.Button == MouseButtons.Left)
            {
                presionado = true;
                Point ptStartPosition = picEscuela1.PointToScreen(new Point(e.X, e.Y));

                punto = new Point();
                punto.X = picEscuela1.Location.X - ptStartPosition.X;
                punto.Y = picEscuela1.Location.Y - ptStartPosition.Y;
            }
            else
            {
                presionado = false;
            }

        }

        private void picEscuela1_MouseMove(object sender, MouseEventArgs e)
        {
            //Mouse();
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela1, true);
            if (presionado)
            {
                Point newPoint = picEscuela1.PointToScreen(new Point(e.X, e.Y));
            }
        }

        private void picEscuela1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            presionado = false;
            translatePicBox((PictureBox)sender, picDestinoEscuela1, picDestinoEscuela2, picDestinoEscuela3);
            if (noPresionado == false)
            {
                translatePicBoxToSpace((PictureBox)sender, picImage1);
            }
        }

        private void picEscuela1_MouseLeave(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela1, true);
        }

        private void picEscuela1_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picEscuela1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picEscuela1_DragEnter(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        
        
        //PIC ESCUELA 2

        private void picEscuela2_MouseDown(object sender, MouseEventArgs e)
        {
            CSounds sonido = new CSounds();
            sonido.playSound("Click");
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela2, true);

            if (e.Button == MouseButtons.Left)
            {
                presionado = true;
                Point ptStartPosition = picEscuela2.PointToScreen(new Point(e.X, e.Y));

                punto = new Point();
                punto.X = picEscuela2.Location.X - ptStartPosition.X;
                punto.Y = picEscuela2.Location.Y - ptStartPosition.Y;
            }
            else
            {
                presionado = false;
            }
        }

        private void picEscuela2_MouseMove(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela2, true);
            if (presionado)
            {
                Point newPoint = picEscuela2.PointToScreen(new Point(e.X, e.Y));
            }

        }

        private void picEscuela2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            presionado = false;
            translatePicBox((PictureBox)sender, picDestinoEscuela1, picDestinoEscuela2, picDestinoEscuela3);
            if (noPresionado == false)
            {
                translatePicBoxToSpace((PictureBox)sender, picImage2);
            }
        }

        private void picEscuela2_MouseLeave(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela2, true);
        }

        private void picEscuela2_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picEscuela2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picEscuela2_DragEnter(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        // PIC ESCUELA 3
        private void picEscuela3_MouseDown(object sender, MouseEventArgs e)
        {
            CSounds sonido = new CSounds();
            sonido.playSound("Click");
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela3, true);

            if (e.Button == MouseButtons.Left)
            {
                presionado = true;
                Point ptStartPosition = picEscuela3.PointToScreen(new Point(e.X, e.Y));

                punto = new Point();
                punto.X = picEscuela3.Location.X - ptStartPosition.X;
                punto.Y = picEscuela3.Location.Y - ptStartPosition.Y;
            }
            else
            {
                presionado = false;
            }
        }

        private void picEscuela3_MouseMove(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela3, true);
            if (presionado)
            {
                Point newPoint = picEscuela3.PointToScreen(new Point(e.X, e.Y));
            }
        }

        private void picEscuela3_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            presionado = false;
            translatePicBox((PictureBox)sender, picDestinoEscuela1, picDestinoEscuela2, picDestinoEscuela3);
            if (noPresionado == false)
            {
                translatePicBoxToSpace((PictureBox)sender, picImage3);
            }
        }

        private void picEscuela3_MouseLeave(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picEscuela3, true);
        }

        private void picEscuela3_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picEscuela3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picEscuela3_DragEnter(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        #endregion

        #region CASA

        // PIC CASA 1
        private void picCasa1_MouseDown(object sender, MouseEventArgs e)
        {
            CSounds sonido = new CSounds();
            sonido.playSound("Click");
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa1, true);

            if (e.Button == MouseButtons.Left)
            {
                presionado = true;
                Point ptStartPosition = picCasa1.PointToScreen(new Point(e.X, e.Y));

                punto = new Point();
                punto.X = picCasa1.Location.X - ptStartPosition.X;
                punto.Y = picCasa1.Location.Y - ptStartPosition.Y;
            }
            else
            {
                presionado = false;
            }
        }

        private void picCasa1_MouseMove(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa1, true);
            if (presionado)
            {
                Point newPoint = picCasa1.PointToScreen(new Point(e.X, e.Y));
            }
        }

        private void picCasa1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            presionado = false;
            translatePicBox((PictureBox)sender, picDestinoCasa1, picDestinoCasa2, picDestinoCasa3);
            if (noPresionado == false)
            {
                translatePicBoxToSpace((PictureBox)sender, picImage4);
            }
        }

        private void picCasa1_MouseLeave(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa1, true);
        }

        private void picCasa1_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picCasa1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picCasa1_DragEnter(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        
        
        // PIC CASA 2

        private void picCasa2_MouseDown(object sender, MouseEventArgs e)
        {
            CSounds sonido = new CSounds();
            sonido.playSound("Click");
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa2, true);

            if (e.Button == MouseButtons.Left)
            {
                presionado = true;
                Point ptStartPosition = picCasa2.PointToScreen(new Point(e.X, e.Y));

                punto = new Point();
                punto.X = picCasa2.Location.X - ptStartPosition.X;
                punto.Y = picCasa2.Location.Y - ptStartPosition.Y;
            }
            else
            {
                presionado = false;
            }
        }

        private void picCasa2_MouseMove(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa2, true);
            if (presionado)
            {
                Point newPoint = picCasa2.PointToScreen(new Point(e.X, e.Y));
            }
        }

        private void picCasa2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            presionado = false;
            translatePicBox((PictureBox)sender, picDestinoCasa1, picDestinoCasa2, picDestinoCasa3);
            if (noPresionado == false)
            {
                translatePicBoxToSpace((PictureBox)sender, picImage5);
            }
        }

        private void picCasa2_MouseLeave(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa2, true);
        }

        private void picCasa2_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picCasa2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picCasa2_DragEnter(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        // PIC CASA 3

        private void picCasa3_MouseDown(object sender, MouseEventArgs e)
        {
            CSounds sonido = new CSounds();
            sonido.playSound("Click");
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa3, true);

            if (e.Button == MouseButtons.Left)
            {
                presionado = true;
                Point ptStartPosition = picCasa3.PointToScreen(new Point(e.X, e.Y));

                punto = new Point();
                punto.X = picCasa3.Location.X - ptStartPosition.X;
                punto.Y = picCasa3.Location.Y - ptStartPosition.Y;
            }
            else
            {
                presionado = false;
            }
        }

        private void picCasa3_MouseMove(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa3, true);
            if (presionado)
            {
                Point newPoint = picCasa3.PointToScreen(new Point(e.X, e.Y));
            }
        }

        private void picCasa3_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            presionado = false;
            translatePicBox((PictureBox)sender, picDestinoCasa1, picDestinoCasa2, picDestinoCasa3);
            if (noPresionado == false)
            {
                translatePicBoxToSpace((PictureBox)sender, picImage6);
            }
        }

        private void picCasa3_MouseLeave(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            ControlExtension.Draggable(picCasa3, true);
        }

        private void picCasa3_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picCasa3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void picCasa3_DragEnter(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        #endregion


        #region Translacion
        
        public void translatePicBox(PictureBox origen, PictureBox destino, PictureBox destino2, PictureBox destino3)
        {

            if (origen.Bounds.IntersectsWith(destino.Bounds))
            {
                if (destino.Enabled == false)
                {
                    
                    noPresionado = false;
                    //////////////////////////////
                    fallos++;
                    //////////////////////////////
                    label2.Text = fallos.ToString();
                }
                else
                {
                    Point punto = new Point(destino.Location.X, destino.Location.Y);
                    origen.Location = punto;
                    noPresionado = true;
                    origen.Enabled = false;
                    destino.Enabled = false;
                    aciertos++;

                    label1.Text = fallos.ToString();

                }
            }
            else if (origen.Bounds.IntersectsWith(destino2.Bounds))
            {
                if (destino2.Enabled == false)
                {
                    
                    noPresionado = false;
                    //////////////////////////////
                    fallos++;

                    //////////////////////////////
                    label2.Text = fallos.ToString();

                }
                else
                {
                    Point punto2 = new Point(destino2.Location.X, destino2.Location.Y);
                    origen.Location = punto2;
                    noPresionado = true;
                    origen.Enabled = false;
                    destino2.Enabled = false;
                    aciertos++;
                    label1.Text = fallos.ToString();
                }
            }
            else if (origen.Bounds.IntersectsWith(destino3.Bounds))
            {
                if (destino3.Enabled == false)
                {
                    noPresionado = false;

                    //////////////////////////////
                    fallos++;
                    //////////////////////////////
                    label2.Text = fallos.ToString();
                }
                else
                {
                    Point punto3 = new Point(destino3.Location.X, destino3.Location.Y);
                    origen.Location = punto3;
                    noPresionado = true;
                    origen.Enabled = false;
                    destino3.Enabled = false;
                    aciertos++;
                    label1.Text = aciertos.ToString();
                }
            }
            else
                noPresionado = false;


            if (aciertos==6)
            {
                if (fallos>=0 && fallos<=3)
                {
                    sendMessage = messages[0];
                }
                else if(fallos>=4 && fallos<=7){
                    sendMessage = messages[1];
                }
                else if (fallos >=8 && fallos <=12)
                {
                    sendMessage = messages[2];
                }   


                frmPuntuacion objfrm = new frmPuntuacion(sendMessage);
                objfrm.StartPosition = FormStartPosition.CenterScreen;
                objfrm.ShowDialog();
                this.Close();
            }



        }
        
        public void translatePicBoxToSpace(PictureBox origen, PictureBox destino)
        {
            Point punto = new Point(destino.Location.X, destino.Location.Y);
            origen.Location = punto;
        }
        #endregion


        #region OPCION DE AYUDA

        private void btnHelp_Click(object sender, EventArgs e)
        {
            printHelp();
        }

        public void printHelp()
        {
            frmAyuda objfrm = new frmAyuda();
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.ShowDialog();
        }

        #endregion 

        //boton de Regreso

        private void btnBackRegreat_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        
    }
}
