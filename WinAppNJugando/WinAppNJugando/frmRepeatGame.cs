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
            frm.Enabled = false;
        }

        private void btnRepeatGame_Click(object sender, EventArgs e)
        {
            frmMenuLevel objfrm = new frmMenuLevel();
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.ShowDialog();
            Close();
            frm.Close();
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
