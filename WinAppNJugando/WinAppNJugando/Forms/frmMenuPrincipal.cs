using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

        }


        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
            
        private void btnReturnHome1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
