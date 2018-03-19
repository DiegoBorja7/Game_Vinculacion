using System;
using System.Drawing;
using System.Windows.Forms;
using WinAppNiñitosEnAccion;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

        }
            
        private void btnReturnHome1_Click(object sender, EventArgs e)
        {
            new frmSelectGame().Show();
            Hide();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmMenuLevel ObjForm = new frmMenuLevel();
            ObjForm.StartPosition = FormStartPosition.CenterScreen;
            ObjForm.Show();
            this.Visible=false;
        }

        private void btnReturnHome1_MouseMove(object sender, MouseEventArgs e)
        {
            btnReturnHome1.Size = new Size(96,100);
        }

        private void frmMenuPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            btnReturnHome1.Size = new Size(86, 90);
            btnPlay.Size = new Size(84, 79);
        }

        private void btnPlay_MouseMove(object sender, MouseEventArgs e)
        {
            btnPlay.Size = new Size(94, 89);
        }


    }
}
