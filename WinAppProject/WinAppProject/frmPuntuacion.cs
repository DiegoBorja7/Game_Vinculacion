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

        /*
        private int estado;
        private string nombre;
        private string audio;

        public int Estado
        {

            get { return estado; }
            set { estado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Audio
        {
            get { return audio; }
            set { audio = value; }
        }*/

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
            
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            frmJuego objfrm = new frmJuego();
            objfrm.Show();
            Close();
        }
    }
}
