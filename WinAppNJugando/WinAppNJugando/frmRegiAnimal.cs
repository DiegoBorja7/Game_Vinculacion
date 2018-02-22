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
/**
 *@autor Altamirano Jonathan, Kevin Gauchagmira
 * **/
namespace RegiAnimal
{

    public partial class Regianimal : Form
    {
        #region Declaracion de Variables
        //Zona declaracion de variables
        private int hits;
        private int level;
        private int timeS;
        private SoundPlayer player = new SoundPlayer();
        private bool notPush;
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(70, 76, 255, 0));
        public Point MouseDownLocation { get; private set; }
        //Objetos

        private frmHelp help;
        private PictureSounds sound = new PictureSounds();
        private InitializeImages pictures = new InitializeImages();
        private InitializePictureBox initializePictureBox = new InitializePictureBox();
        private Translation translation = new Translation();
        private CInitializeThings ObjInitialize = new CInitializeThings();
        #endregion

        #region Constructores

        public Regianimal()
        {
            InitializeComponent();
        }

        public Regianimal(int level)
        {
            this.DoubleBuffered = true; //Evita el flickering entre Canvas
  

            Stopwatch sw = Stopwatch.StartNew();

            InitializeComponent();

            CenterToScreen();

            Mouse();

            initializePictureBox.VisibilityDestination(picDestinoCosta1, picDestinoCosta2, picDestinoCosta3, picDestinoSierra1, picDestinoSierra2,
                                                        picDestinoSierra3, picDestinoSierra4, picDestinoOriente1, picDestinoOriente2, picDestinoOriente3,
                                                        picDestinoGalapagos1, picDestinoGalapagos2);

            initializePictureBox.VisibilityReturn(picRetorno1, picRetorno2, picRetorno3, picRetorno4, picRetorno5, picRetorno6, picRetorno7, picRetorno8);


            initializePictureBox.PositionReturn(picRetorno1, picRetorno2, picRetorno3, picRetorno4, picRetorno5, picRetorno6, picRetorno7, picRetorno8);


            initializePictureBox.PositionImages(picRetorno1, picRetorno2, picRetorno3, picRetorno4, picRetorno5, picRetorno6, picRetorno7, picRetorno8,
                                               picCost1, picCost2, picSierra1, picSierra2, picGalapagos1, picGalapagos2, picOriente1, picOriente2);


            pictures.animalesCosta(picCost1, picCost2);
            pictures.animalesGalapagos(picGalapagos1, picGalapagos2);
            pictures.animalesOriente(picOriente1, picOriente2);
            pictures.animalesSierra(picSierra1, picSierra2);

            pictures.buttons(picBtnPlay, picBtnHome, picBntHelp);
            

            sw.Stop();

            picScore.Visible = false;
           
            this.level = level;
            lblDificutl();
            this.hits = 0;
        }

        #endregion

        #region Dificult

        private void lblDificutl()
        {
            lblSeconds.BackColor = Color.Transparent;

            if (level == 1)
            {
                lblSeconds.Text = "90";
                timeS = 90;
            }
            if (level == 2)
            {
                lblSeconds.Text = "60";
                timeS = 60;
            }
            if (level == 3)
            {
                lblSeconds.Text = "45";
                timeS = 45;
            }
        }

        #endregion

        #region Carga del Mouse con Picaflor

        private void Mouse()
        {
            ObjInitialize.Mouse(this, 2);
        }

        #endregion

        #region Sonido al pasar el raton en cada Picture Box
        private void picCost1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picCost1);
        }

        private void picCost2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picCost2);
        }

        private void picGalapagos1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picGalapagos1);
        }

        private void picGalapagos2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picGalapagos2);
        }

        private void picOriente1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picOriente1);
        }

        private void picOriente2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picOriente2);
        }

        private void picSierra1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picSierra1);
        }

        private void picSierra2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picSierra2);
        }
        #endregion

        #region Costa
        //COSTA
        //PicCosta1(PicRetorno2)
        private void picCost1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush=translation.translatePicBox((PictureBox)sender, picDestinoCosta1, picDestinoCosta2, picDestinoCosta3 , ref hits);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno2);
            }
        }
        private void picCost1_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picCost1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picCost1_DragEnter(object sender, DragEventArgs e)
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
        //PicCosta2(PicRetorno1)
        private void picCost2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush=translation.translatePicBox((PictureBox)sender, picDestinoCosta1, picDestinoCosta2, picDestinoCosta3, ref hits);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno1);
            }
        }
        private void picCost2_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picCost2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picCost2_DragEnter(object sender, DragEventArgs e)
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

        #region Sierra
        //COSTA
        //PicSierra1(PicRetorno3)
        private void picSierra1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translatePicBox((PictureBox)sender, picDestinoSierra1, picDestinoSierra2, picDestinoSierra3, picDestinoSierra4, ref  hits);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno3);
            }
        }
        private void picSierra1_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picSierra1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picSierra1_DragEnter(object sender, DragEventArgs e)
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
        //PicSierra2(PicRetorno4)
        private void picSierra2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush= translation.translatePicBox((PictureBox)sender, picDestinoSierra1, picDestinoSierra2, picDestinoSierra3, picDestinoSierra4, ref hits);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno4);
            }
        }
        private void picSierra2_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picSierra2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picSierra2_DragEnter(object sender, DragEventArgs e)
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

        #region Galapagos
        //Galapagos
        //PicGalagos1(PicRetorno5)
        private void picGalapagos1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translatePicBox((PictureBox)sender, picDestinoGalapagos1, picDestinoGalapagos2, ref  hits);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno5);
            }
        }
        private void picGalapagos1_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picGalapagos1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picGalapagos1_DragEnter(object sender, DragEventArgs e)
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
        //PicGalagos2(PicRetorno6)
        private void picGalapagos2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translatePicBox((PictureBox)sender, picDestinoGalapagos1, picDestinoGalapagos2, ref hits);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno6);
            }
        }
        private void picGalapagos2_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picGalapagos2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picGalapagos2_DragEnter(object sender, DragEventArgs e)
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

        #region Oriente
        //ORIENTE
        //PicOriente1(PicRetorno7)
        private void picOriente1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translatePicBox((PictureBox)sender, picDestinoOriente1, picDestinoOriente2, picDestinoOriente3, ref hits);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno7);
            }
        }
        private void picOriente1_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picOriente1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picOriente1_DragEnter(object sender, DragEventArgs e)
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
        //PicOriente1(PicRetorno8)
        private void picOriente2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translatePicBox((PictureBox)sender, picDestinoOriente1, picDestinoOriente2, picDestinoOriente3, ref hits);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno8);
            }
        }
        private void picOriente2_DragDrop(object sender, DragEventArgs e)
        {
            this.DoubleBuffered = true;
            picOriente2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        private void picOriente2_DragEnter(object sender, DragEventArgs e)
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

        #region Botones
        private void picBtnHome_Click(object sender, EventArgs e)
        {
            if (help != null)
                help.Dispose();
            frmMenu menu = new RegiAnimal.frmMenu();
            menu.Show();
            this.Dispose();
        }

        private void picBtnPlay_Click(object sender, EventArgs e)
        {                     
                        
            player.Stop();

            picScore.Visible = false;
            
            hits = 0;            
            lblDificutl();
            clock.Enabled = true;

            initializePictureBox.setDraggable(picCost1, picCost2, picSierra1, picSierra2, picGalapagos1, picGalapagos2, picOriente1, picOriente2);

            picBtnPlay.Enabled = false;
            if (help != null)
                help.Dispose();
        }


        private void picBntHelp_Click(object sender, EventArgs e)
        {
            if(help!=null)
                help.Dispose();
            help = new frmHelp();
            help.Show();
            
        }
        #endregion
    
        private void timer_Tick_1(object sender, EventArgs e)
        {
            timeS--;
            if (timeS == 0 || hits == 8)
            {
                initializePictureBox.draggableDisable(picCost1, picCost2, picSierra1, picSierra2,
                                     picOriente1, picOriente2, picGalapagos1, picGalapagos2);
                lblDificutl();
                clock.Stop();
                initializePictureBox.score(picScore, hits);
                picBtnPlay.Enabled = false;
                picBntHelp.Enabled = false;
                if (help != null)
                    help.Dispose();
            }
            else{

                if (timeS < 10 && timeS > 0)
                {
                    lblSeconds.Text = "0" + timeS.ToString();
                }
                else
                    lblSeconds.Text = timeS.ToString();
            } 
        }       

        private void picScore_Click(object sender, EventArgs e)
        {
            if (help != null)
                help.Dispose();

            frmMenu menu = new frmMenu();
            menu.Show();
            player.Stop();
            this.Visible = false;
        }
    }
}
