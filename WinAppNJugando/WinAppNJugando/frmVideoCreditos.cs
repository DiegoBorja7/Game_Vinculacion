using System.Windows.Forms;

/**
 * @Autor: Diego Borja.
 * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmVideoCreditos : Form
    {
        public frmVideoCreditos()
        {
            InitializeComponent();
            VideoCreditos.URL = Application.StartupPath + @"/Video/Creditos.mp4";
            VideoCreditos.Ctlcontrols.play();
        }

        private void frmVideoCreditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            new frmInicio().Show();
        }
    }
}
