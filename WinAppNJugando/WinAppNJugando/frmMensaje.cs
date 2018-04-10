using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Media;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmMensaje : Form
    {
        private string bandera = "";

        public frmMensaje(string nombre)
        {
            InitializeComponent();
            tmrError.Enabled = true;
            tmrError.Start();
            bandera = nombre;
        }

        private void Error_Load(object sender, EventArgs e)
        {
            SoundPlayer player;
            if (bandera == "error")
            {
                picError.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\Bueno, Malo\\error.png");
                player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\Malo.wav");
            }

            else
            {
                picError.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Resources\\Bueno, Malo\\acierto.png");
                player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\Bueno.wav");
            }
            try
            {
                player.Play();
            }
            catch { }
        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            try
            {
                tmrError.Stop();
            }
            catch { }

            this.Dispose();
        }
    }
}
