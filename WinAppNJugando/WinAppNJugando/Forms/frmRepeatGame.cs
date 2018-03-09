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
    public partial class frmRepeatGame : Form
    {
        Form frm;
        public frmRepeatGame(Form frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmRepeatGame_Load(object sender, EventArgs e)
        {

        }

        private void btnRepeatGame_Click(object sender, EventArgs e)
        {
            frmMenuLevel objfrm = new frmMenuLevel();
            Close();
            frm.Close();

            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.Show();
        }

        private void btnRepeatGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnRepeatGame.Size = new Size(136,136);
        }

        private void frmRepeatGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnRepeatGame.Size = new Size(116, 116);
        }
    }
}
