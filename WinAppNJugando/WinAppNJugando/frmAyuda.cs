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
    public partial class frmAyuda : Form
    {
        SoundPlayer player;

        public frmAyuda()
        {
            InitializeComponent();
        }

        private void lblButtonJugarAyuda_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {
            string ruta = Directory.GetCurrentDirectory();
            ruta = ruta + "\\audios\\";
            string ruta_final = ruta + "instrucciones";
            string terminacion = ".wav";
            ruta_final = ruta_final + terminacion;

            player = new SoundPlayer(ruta_final);
            player.Play();

            lblButtonJugarAyuda.BackColor = Color.Transparent;
            lblText1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            picMouse.BackColor = Color.Transparent;
        }
    }
}
