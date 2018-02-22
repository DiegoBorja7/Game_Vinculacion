using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProject
{
    public partial class frmPuntuacion : Form
    {
        private String mensaje;

        public frmPuntuacion(String mensaje)
        {
            InitializeComponent();
            this.mensaje = mensaje;
        }

        private void frmPuntuacion_Load(object sender, EventArgs e)
        {
            picRegalo.BackColor = Color.Transparent;
            label1.Text = mensaje;

            label1.BackColor = Color.Transparent;
            btnRepeat.BackColor = Color.Transparent;

            CSounds sonido = new CSounds();

            sonido.playSound("Felicidades");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            frmJuego objfrm = new frmJuego();
            objfrm.Show();
            Close();
        }

        private void btnRepeat_MouseHover(object sender, EventArgs e)
        {
            CSounds sonido = new CSounds();

            sonido.playSound("volverIntentar");
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            CSounds sonido = new CSounds();

            sonido.playSound("salir");
        }
    }
}
