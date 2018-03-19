using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using WinAppProyectoFinal.Clases;
using System.Media;
using System.Runtime.InteropServices;
using WinAppNiñitosEnAccion;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmJuego : Form
    {
        CJuego juego;
        List<PictureBox> lienzo, casa, escuela;
        CDragNDrop drag;
        int contador=-1;

        #region Variables Volumen
        private const int APPCOMMAND_VOLUMEN_UP = 0xA0000;
        private const int APPCOMMAND_VOLUMEN_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]

        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        #endregion

        private void picLienzo()
        {
            //AGREGACION DE PICTUREBOXES A LISTA
            lienzo = new List<PictureBox>();
            lienzo.Add(this.picCanvas1); lienzo.Add(this.picCanvas2); lienzo.Add(picCanvas3); lienzo.Add(picCanvas4);
            lienzo.Add(picCanvas5); lienzo.Add(picCanvas6);
        }

        private void picCasa()
        {
            casa = new List<PictureBox>();
            casa.Add(picCasa1); casa.Add(picCasa2); casa.Add(picCasa3);
            picCanvasCasa.AllowDrop = true;
        }

        private void picEscuela()
        {
            escuela = new List<PictureBox>();
            escuela.Add(picEscuela1); escuela.Add(picEscuela2); escuela.Add(picEscuela3);
            picCanvasEscuela.AllowDrop = true;
        }

        private void llenarListas()
        {
            picLienzo();
            picCasa();
            picEscuela();
        }

        public frmJuego()
        {
            InitializeComponent();
            llenarListas();
            drag = new CDragNDrop(lienzo,casa,escuela);
            juego = new CJuego(lienzo);

        }

        public frmJuego(int level)
        {
            InitializeComponent();
            llenarListas();
            drag = new CDragNDrop(lienzo,casa,escuela);
            juego = new CJuego(lienzo,level);

            segundos(juego.Level);
        }

        public void segundos(int level)
        {
            if (level==1)
            {
                contador = 81;
            }
            else if(level == 2)
            {
                contador = 61;
            }
            else
            {
                contador = 41;
            }
        }

        private void frmJuego_Load(object sender, EventArgs e)
        { 
            juego.mostrarImagenes();
            this.DoubleBuffered = true;
        }

        #region DESPLAZAMIENTO
        //ACCIONES PRESIONANDO EL MOUSE

        private void picCanvas1_MouseDown(object sender, MouseEventArgs e)
        {
            drag.mouseAplastado(sender);
        }

        private void picCanvas2_MouseDown(object sender, MouseEventArgs e)
        {
            drag.mouseAplastado(sender);
        }

        private void picCanvas3_MouseDown(object sender, MouseEventArgs e)
        {
            drag.mouseAplastado(sender);
        }

        private void picCanvas4_MouseDown(object sender, MouseEventArgs e)
        {
            drag.mouseAplastado(sender);
        }

        private void picCanvas5_MouseDown(object sender, MouseEventArgs e)
        {
            drag.mouseAplastado(sender);
        }

        private void picCanvas6_MouseDown(object sender, MouseEventArgs e)
        {
            drag.mouseAplastado(sender);
        }

        //ARRASTRE EN picCanvasCasa

        private void picCanvasCasa_DragEnter(object sender, DragEventArgs e)
        {
            drag.dragEnter(e);
        }

        private void picCanvasCasa_DragDrop(object sender, DragEventArgs e)
        {
            int bandera = drag.DestinoCasa.Indice;
            drag.dragDrop(e, sender,1);
            if (bandera != drag.DestinoCasa.Indice)
            {
                juego.Aciertos += 1;

            }
            else
            {
                juego.Fallos += 1;
            }
        }

        //ARRASTE EN ESCUELA

        private void picCanvasEscuela_DragEnter(object sender, DragEventArgs e)
        {
            drag.dragEnter(e);
        }

        private void picCanvasEscuela_DragDrop(object sender, DragEventArgs e)
        {
            int bandera = drag.DestinoEscuela.Indice;
            drag.dragDrop(e, sender,2);

            if (bandera != drag.DestinoEscuela.Indice)
            {
                juego.Aciertos += 1;
            }
            else
            {
                juego.Fallos += 1;
            }
        }

        #endregion

        #region clic buttons
        private void btnHomeGame_Click(object sender, EventArgs e)
        {
            new frmSelectGame().Show();
            Hide();
            timeJuego.Enabled = false;
        }

        private void btnReturnGame_Click(object sender, EventArgs e)
        {
            frmMenuLevel objfrm = new frmMenuLevel();
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.Show();
            Close();
            timeJuego.Enabled = false;
        }
        #endregion

        #region zoomin and zoomout buttons
        private void btnHomeGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnHomeGame.Size = new Size(89, 89);
        }

        private void btnReturnGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnReturnGame.Size = new Size(89, 89);
        }

        private void frmJuego_MouseMove(object sender, MouseEventArgs e)
        {
            btnHomeGame.Size = new Size(79, 79);
            btnReturnGame.Size = new Size(79, 79);
            btnDownVolume.Size = new Size(75, 75);
            btnUpVolume.Size = new Size(75, 75);
        }
        #endregion

        public void puntuacion()
        {
            if (juego.Aciertos == 6)
            {
                frmPuntuacion objfrm2 = new frmPuntuacion(juego.Fallos);
                Close();
                timeJuego.Enabled = false;

                objfrm2.StartPosition = FormStartPosition.CenterScreen;
                objfrm2.Show();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmInstrucciones objfrm = new Forms.frmInstrucciones();
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.obtenerTimer(this.timeJuego);
            objfrm.ShowDialog();
        }

        #region Audio Obj
        private void picCanvas1_MouseHover(object sender, EventArgs e)
        {
            juego.PicImages.reproducirAudio((PictureBox)sender);
        }

        private void picCanvas2_MouseHover(object sender, EventArgs e)
        {
            juego.PicImages.reproducirAudio((PictureBox)sender);
        }

        private void picCanvas3_MouseHover(object sender, EventArgs e)
        {
            juego.PicImages.reproducirAudio((PictureBox)sender);
        }

        private void picCanvas4_MouseHover(object sender, EventArgs e)
        {
            juego.PicImages.reproducirAudio((PictureBox)sender);
        }

        private void picCanvas5_MouseHover(object sender, EventArgs e)
        {
            juego.PicImages.reproducirAudio((PictureBox)sender);
        }

        private void picCanvas6_MouseHover(object sender, EventArgs e)
        {
            juego.PicImages.reproducirAudio((PictureBox)sender);
        }
        #endregion

        private void picCanvas1_MouseUp(object sender, MouseEventArgs e)
        {
            picCanvas1.Visible = true;
        }

        #region Control Volumen

        private void btnUpVolume_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUMEN_UP);
        }

        private void btnDownVolume_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUMEN_DOWN);
        }

        private void btnDownVolume_MouseMove(object sender, MouseEventArgs e)
        {
            btnDownVolume.Size = new Size(85,85);
        }

        private void btnUpVolume_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpVolume.Size = new Size(85,85);
        }
        #endregion

        private void btnReturnGame_MouseHover(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\regresar.wav");
            try
            {
                player.Play();
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                contador--;
                lblTime.Text = contador.ToString();
                puntuacion();
            }

            if (contador == 0)
                endTime();
        }

        public void endTime()
        {
            Image image1 = null;
            picTime.Image = image1;
            frmFinTime objfrm = new frmFinTime(this);
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.Show();
            Hide();

            timeJuego.Enabled = false;
        }

    }
}
