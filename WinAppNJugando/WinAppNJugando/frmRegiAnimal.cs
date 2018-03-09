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
using System.Runtime.InteropServices;
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
        private int hits=0;
        private int hitsok=0;
        private int level;
        private int timeS;
        private int timeHelp = 18;
        private SoundPlayer player = new SoundPlayer();
        private bool notPush;
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(70, 76, 255, 0));
        public Point MouseDownLocation { get; private set; }
        //Objetos
        private PictureBox[] destination = new PictureBox[13];
        private PictureBox[] back = new PictureBox[8];
        private PictureBox[] images = new PictureBox[8];
        private frmHelp help = new frmHelp();
        private CPictureSounds sound = new CPictureSounds();
        private CInitializeImages pictures = new CInitializeImages();
        private CInitializePictureBox initializePictureBox = new CInitializePictureBox();
        private CTranslation translation = new CTranslation();
        private CInitializeThings ms = new CInitializeThings();

        private const int APPCOMMAND_VOLUMEN_UP = 0xA0000;
        private const int APPCOMMAND_VOLUMEN_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;


        [DllImport("user32.dll")]

        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        #endregion

        #region Constructores

        public Regianimal()
        {
            InitializeComponent();

        }

        public Regianimal(int level)
        {
            this.DoubleBuffered = true; //Evita el flickering entre Canvas

            help.Show();            
            help.TopMost = true;
            this.level = level;

            InitializeComponent();
            initilize();
        }

        #endregion

        #region Dificult

        private void lblDificutl()
        {
            lblSeconds.BackColor = Color.Transparent;
            lblScore.BackColor = Color.Transparent;

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
            ms.Mouse(this, 2);
        }

        #endregion

        #region Sonido al pasar el raton en cada Picture Box
        private void picCost1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picCost1);
            picCost1.BringToFront();
        }

        private void picCost2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picCost2);
            picCost2.BringToFront();
        }

        private void picGalapagos1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picGalapagos1);
            picGalapagos1.BringToFront();
        }

        private void picGalapagos2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picGalapagos2);
            picGalapagos2.BringToFront();
        }

        private void picOriente1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picOriente1);
            picOriente1.BringToFront();
        }

        private void picOriente2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picOriente2);
            picOriente2.BringToFront();
        }

        private void picSierra1_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picSierra1);
            picSierra1.BringToFront();
        }

        private void picSierra2_MouseHover(object sender, EventArgs e)
        {
            sound.playSound(picSierra2);
            picSierra2.BringToFront();
        }
        #endregion

        #region Costa


        //COSTA
        //PicCosta1(PicRetorno2)
        private void picCost1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translateTotalCO((PictureBox)sender, ref destination, 0 ,1 ,2 , ref hits, ref hitsok, ref lblScore);
            if(notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno1);
            }
        }
        //PicCosta2(PicRetorno1)
        private void picCost2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translateTotalCO((PictureBox)sender, ref destination, 0, 1, 2, ref hits, ref hitsok, ref lblScore);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno2);
            }
        }

        #endregion

        #region Sierra
        //COSTA
        //PicSierra1(PicRetorno3)
        private void picSierra1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translateTotalS((PictureBox)sender, ref destination, 3, 4, 5, 6, ref hits, ref hitsok, ref lblScore);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno3);
            }
        }
        //PicSierra2(PicRetorno4)
        private void picSierra2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translateTotalS((PictureBox)sender, ref destination, 3, 4, 5, 6, ref hits, ref hitsok, ref lblScore);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno4);
            }
        }
        #endregion

        #region Galapagos
        //Galapagos
        //PicGalagos1(PicRetorno5)
        private void picGalapagos1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            picGalapagos1.BringToFront();
            notPush = translation.translateTotalG((PictureBox)sender, ref destination, 10, 11, ref hits, ref hitsok, ref lblScore);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno5);
            }
        }

        //PicGalagos2(PicRetorno6)
        private void picGalapagos2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            picGalapagos2.BringToFront();
            notPush = translation.translateTotalG((PictureBox)sender, ref destination, 10, 11, ref hits, ref hitsok, ref lblScore);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno6);
            }
        }
        #endregion

        #region Oriente
        //ORIENTE
        //PicOriente1(PicRetorno7)
        private void picOriente1_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translateTotalCO((PictureBox)sender, ref destination, 7, 8, 9, ref hits, ref hitsok, ref lblScore);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno7);
            }
        }
        //PicOriente1(PicRetorno8)
        private void picOriente2_MouseUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;
            notPush = translation.translateTotalCO((PictureBox)sender, ref destination, 7, 8, 9, ref hits, ref hitsok, ref lblScore);
            if (notPush == false)
            {
                translation.translatePicBoxToSpace((PictureBox)sender, picRetorno8);
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
            sound.playSound("go");
            lblBegin.Text = "3";
            picScore.Visible = false;
            lblBegin.Visible = true;
            clockHelp.Enabled = true;
            timeHelp = 3;
            clock.Stop();
            initilize();
        }


        private void picBntHelp_Click(object sender, EventArgs e)
        {
            if(help!=null)
                help.Dispose();
            help = new frmHelp();
            help.Show();
            
        }
    
        private void timer_Tick_1(object sender, EventArgs e)
        {
            timeS--;            

            if (timeS == 0 || hits == 8)
            {
                picScore.BringToFront();
                initializePictureBox.draggableDisable(ref images);
                lblDificutl();
                clock.Stop();
                initializePictureBox.score(picScore, hitsok);
                if (help != null)
                    help.Dispose();
            }
            else
            {

                if (timeS < 10 && timeS > 0)
                {
                    lblSeconds.Text = "0" + timeS.ToString();
                }
                else
                    lblSeconds.Text = timeS.ToString();
            } 
        }       
        private void picBtnPlay_MouseHover(object sender, EventArgs e)
        {
            picBtnPlay.BorderStyle = BorderStyle.Fixed3D;
            pictures.menuButtonshover(picBtnPlay, 2);
        }

        private void picBtnPlay_MouseLeave(object sender, EventArgs e)
        {
            picBtnPlay.BorderStyle = BorderStyle.None;
            pictures.menuButtonsleave(picBtnPlay, 2);
        }

        private void picBtnHome_MouseHover(object sender, EventArgs e)
        {
            picBtnHome.BorderStyle = BorderStyle.Fixed3D;
            pictures.menuButtonshover(picBtnHome, 1);
        }

        private void picBtnHome_MouseLeave(object sender, EventArgs e)
        {
            picBtnHome.BorderStyle = BorderStyle.None;
            pictures.menuButtonsleave(picBtnHome, 1);
        }
        private void savePictures()
        {
            this.destination[0] = picDestinoCosta1;
            this.destination[1] = picDestinoCosta2;
            this.destination[2] = picDestinoCosta3;
            this.destination[3] = picDestinoSierra1;
            this.destination[4] = picDestinoSierra2;
            this.destination[5] = picDestinoSierra3;
            this.destination[6] = picDestinoSierra4;
            this.destination[7] = picDestinoOriente1;
            this.destination[8] = picDestinoOriente2;
            this.destination[9] = picDestinoOriente3;
            this.destination[10] = picDestinoGalapagos1;
            this.destination[11] = picDestinoGalapagos2;

            this.back[0] = picRetorno1;
            this.back[1] = picRetorno2;
            this.back[2] = picRetorno3;
            this.back[3] = picRetorno4;
            this.back[4] = picRetorno5;
            this.back[5] = picRetorno6;
            this.back[6] = picRetorno7;
            this.back[7] = picRetorno8;

            this.images[0] = picCost1;
            this.images[1] = picCost2;
            this.images[2] = picSierra1;
            this.images[3] = picSierra2;
            this.images[4] = picGalapagos1;
            this.images[5] = picGalapagos2;
            this.images[6] = picOriente1;
            this.images[7] = picOriente2;

            picClockes1.BackColor = Color.Transparent;
            
            grbClock.BackColor = Color.Transparent;
        }
        #endregion

        #region Tiempo
        private void clockHelp_Tick(object sender, EventArgs e)
        {
            timeHelp--;
            
            if (timeHelp < 4 && timeHelp > 0)
            {
                if(timeHelp==2)
                {
                    lblBegin.ForeColor = System.Drawing.Color.Yellow;
                }
                if(timeHelp==1)
                {
                    lblBegin.ForeColor = System.Drawing.Color.Green;
                }
                lblBegin.Visible = true;
                lblBegin.Text = timeHelp.ToString();
            }
            if (timeHelp == 0)
            {
                lblBegin.ForeColor = System.Drawing.Color.Blue;
                lblBegin.Text = "!GO!";
                initializePictureBox.setDraggable(ref images);

                clock.Enabled = true;
            }
            if (timeHelp < 0)
            {
                lblBegin.Text = "3";
                lblBegin.Visible = false;
                clockHelp.Enabled = false;
            }
        }

        private void Regianimal_Load(object sender, EventArgs e)
        {
            picVolDown.BackColor = Color.Transparent;
            picVolUp.BackColor = Color.Transparent;
        }

        private void initilize()
        {
            Stopwatch sw = Stopwatch.StartNew();

            savePictures();

            CenterToScreen();

            Mouse();

            initializePictureBox.Style(ref back, ref grbClock);

            initializePictureBox.RefreshPictureBox(ref images, ref destination, ref hitsok, ref hits, ref lblScore);

            initializePictureBox.VisibilityDestination(ref destination, lblBegin);

            initializePictureBox.VisibilityReturn(ref back);

            initializePictureBox.PositionReturn(ref back);

            initializePictureBox.PositionImages(ref back, ref images);

            pictures.animalesCosta(picCost1, picCost2);
            pictures.animalesGalapagos(picGalapagos1, picGalapagos2);
            pictures.animalesOriente(picOriente1, picOriente2);
            pictures.animalesSierra(picSierra1, picSierra2);

            pictures.buttons(picBtnPlay, picBtnHome);

            sw.Stop();

            picScore.Visible = false;

            lblDificutl();
            this.hits = 0;
        }
        #endregion

        #region Volumen 

        private void picVolUp_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUMEN_UP);
        }

        private void picVolDown_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUMEN_DOWN);
        }

        private void picVolDown_MouseHover(object sender, EventArgs e)
        {
            picVolDown.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picVolDown_MouseLeave(object sender, EventArgs e)
        {
            picVolDown.BorderStyle = BorderStyle.None;
        }

        private void picVolUp_MouseHover(object sender, EventArgs e)
        {
            picVolUp.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picVolUp_MouseLeave(object sender, EventArgs e)
        {
            picVolUp.BorderStyle = BorderStyle.None;
        }
        #endregion
    }
}
