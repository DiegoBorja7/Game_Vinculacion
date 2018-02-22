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
using System.IO;

namespace WinAppProject
{
    class CSounds
    {
        SoundPlayer player;

        //ENVIANDO PICTUREBOX PARA TOMAR TAG DE NOMBRE PARA HALLAR SONIDO
        public void playSound(PictureBox picSound)
        {
            try
            {
                string ruta = Directory.GetCurrentDirectory();
                ruta = ruta + "\\audios\\";
                string ruta_final = ruta + (String)picSound.Tag;
                string terminacion = ".wav";
                ruta_final = ruta_final + terminacion;

                player = new SoundPlayer(ruta_final);
                player.Play();

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        //ENVIANDO UNA CADENA PARA REPRODUCIR UN SONIDO ESPECIFICO
        public void playSound(string sonido)
        {
            try
            {
                string ruta = Directory.GetCurrentDirectory();
                ruta = ruta + "\\audios\\";
                string ruta_final = ruta + sonido;
                string terminacion = ".wav";
                ruta_final = ruta_final + terminacion;

                player = new SoundPlayer(ruta_final);
                player.Play();

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
