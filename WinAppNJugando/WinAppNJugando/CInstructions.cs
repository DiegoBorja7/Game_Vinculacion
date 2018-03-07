using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

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

        //Compara los PictureBox de la Autoevaluacion3
        public void CompararPictureBox1(PictureBox PicComparate, MouseEventArgs e)
        {
            Bitmap myBitmap;

            if (e.Button == MouseButtons.Left)
            {
                Clicks++;
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
                }
            }
        }

        //Compara los PictureBox de la Autoevaluacion5
        public void CompararPictureBox(PictureBox PicComparate, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Clicks++;
                if (PicComparate.Name == "Tiburon" || PicComparate.Name == "Avion" || PicComparate.Name == "Pizarron" || 
                    PicComparate.Name == "Aspiradora" || PicComparate.Name == "Refrigeradora" || PicComparate.Name == "Licuadora" ||
                    PicComparate.Name == "Escalera" || PicComparate.Name == "Bandera" || PicComparate.Name == "Cafetera")
                {

                    switch (PicComparate.Name.ToString())
                    {
                        case "Tiburon":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/AlmohadaAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Avion":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/AspiradoraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Pizarron":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/ArcoAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Aspiradora":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/EscaleraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Refrigeradora":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/EscritorioAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Licuadora":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/EscuelaAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Escalera":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/ImpresoraAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Bandera":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/ImanAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        case "Cafetera":
                            myBitmap = new Bitmap(Application.StartupPath + @"/ImageResults/IguanaAcierto.png");
                            PicComparate.BackgroundImage = myBitmap;
                            break;

                        
                    }
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
