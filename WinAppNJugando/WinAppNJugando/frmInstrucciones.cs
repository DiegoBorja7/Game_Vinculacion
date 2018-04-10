using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmInstrucciones : Form
    {
        string instruction;
        SoundPlayer player;
        Timer timer;

        public frmInstrucciones()
        {
            InitializeComponent();
            this.instruction = "Haz clic sobre el objeto y arrastralo hacia la casa o escuela donde tu creas que sea correcto";
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\instrucciones juego.wav");
            try
            {
                player.Play();
            }
            catch { }
        }

        public frmInstrucciones(string instruction)
        {
            InitializeComponent();
            this.instruction = instruction;
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\instrucciones level.wav");
            try
            {
                player.Play();
            }
            catch { }
        }

        private void lblButtonJugarAyuda_Click(object sender, EventArgs e)
        {
            if (instruction == "Haz clic sobre el objeto y arrastralo hacia la casa o escuela donde tu creas que sea correcto")
            {
                try
                {
                    timer.Start();
                }
                catch { }
            }
            Close();
        }

        private void frmInstrucciones_Load(object sender, EventArgs e)
        {
            lblInstructions.Text = instruction;
        }

        private void lblButtonJugarAyuda_MouseHover(object sender, EventArgs e)
        {
            if(instruction == "Haz clic sobre el objeto y arrastralo hacia la casa o escuela donde tu creas que sea correcto")
            {
                SoundPlayer player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\jugar.wav");
                try
                {
                    player.Play();
                }
                catch { }
            }
        }

        public void obtenerTimer(Timer tim)
        {
            timer = tim;
            timer.Stop();
        }
    }
}
