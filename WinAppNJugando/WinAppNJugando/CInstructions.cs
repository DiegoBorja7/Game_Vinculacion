using System;
using System.Drawing;
using System.Media;
using System.Collections.Generic;
using System.Windows.Forms;

/**
 *@Autor Borja Diego
 * **/

namespace WinAppNiñitosEnAccion
{
    class CInstructions
    {
        #region Atributes of the class
        private static int puntaje;
        private int clicks;
        private int aciertos;
        private int i,j,k;

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
        #endregion

        #region Constructors of the class
        public CInstructions()
        {
            clicks = 0; aciertos = 0;
        }
        #endregion

        #region Methods
      
        //Compara los PictureBox de la Autoevaluacion5
        public void CompararPictureBox(PictureBox PicComparate, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Clicks++;
                if (PicComparate.Name == "Tiburon" || PicComparate.Name == "Avion" || PicComparate.Name == "Pizarron" || PicComparate.Name == "Aspiradora" || PicComparate.Name == "Refrigeradora" || PicComparate.Name == "Licuadora" || PicComparate.Name == "Escalera" || PicComparate.Name == "Bandera" || PicComparate.Name == "Cafetera")
                {
                    PicComparate.Visible = false;
                    puntaje++;
                    aciertos++;
                }
            }
        }

        //Cargar el audio
        public void playSound(String text)
        {
            player = new SoundPlayer(Application.StartupPath + @"/Sound/"+text.ToString()+".wav");
            player.Play();
        }

        //Funcion para asignar el puntaje del frmPuntajeAutoevaluacion.
        public void Puntuacion(PictureBox picUse)
        {
            if (puntaje == 20)
            { 
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/PuntuacionAlta.png");
                picUse.BackgroundImage = myBitmap;
                picUse.Name = "PuntuacionAlta";
                playSound("Excelente");
            }
            else
                if(puntaje>=15 && puntaje<20)
                {
                    myBitmap = new Bitmap(Application.StartupPath + @"/Image/PuntuacionMedia.png");
                    picUse.BackgroundImage = myBitmap;
                    picUse.Name = "PuntuacionMedia";
                    playSound("MuyBien");
                }
                else
                    if (puntaje >= 5 && puntaje < 15)
                    {
                        myBitmap = new Bitmap(Application.StartupPath + @"/Image/PuntuacionBaja.png");
                        picUse.BackgroundImage = myBitmap;
                        picUse.Name = "PuntuacionBaja";
                        playSound("LaProxima");
                    }
                    else
                        if(puntaje<5)
                        {
                            myBitmap = new Bitmap(Application.StartupPath + @"/Image/PuntuacionCero.png");
                            picUse.BackgroundImage = myBitmap;
                            picUse.Name = "PuntuacionCero";
                            playSound("IntentaloNuevamente");
                        }
        }

        #endregion

    }
}
