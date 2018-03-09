using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WinAppProyectoFinal.Clases;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmMenuLevel : Form
    {
        List<PictureBox> pictures;
        CMenuLevel menuLevel;
        frmJuego ObjForm;

        public frmMenuLevel()
        {
            InitializeComponent();

            pictures = new List<PictureBox>();
            menuLevel = new CMenuLevel();
            ObjForm = new frmJuego();
        }

        private void frmMenuLevel_Load(object sender, EventArgs e)
        {
            pictures.Add(pic1); pictures.Add(pic2); pictures.Add(pic3);
            menuLevel.MPictures = pictures;
            menuLevel.iniciarPics();
        }

        private void btnSelectLevel1_Click(object sender, EventArgs e)
        {
            menuLevel.moveNext();
        }

        private void btnSelectLevel2_Click(object sender, EventArgs e)
        {
            menuLevel.moveAnt();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            ObjForm = new frmJuego(menuLevel.Level);
            this.Close();
            ObjForm.StartPosition = FormStartPosition.CenterScreen;
            ObjForm.Show();

        }

        private void btnReturnGame_Click_1(object sender, EventArgs e)
        {
            frmMenuPrincipal objfrm = new frmMenuPrincipal();
            Close();
            objfrm.Visible = true;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmInstrucciones objfrm = new Forms.frmInstrucciones();
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.ShowDialog();
        }

        private void btnReturnGame_MouseMove(object sender, MouseEventArgs e)
        {
            btnReturnGame.Size = new Size(84, 84);
        }

        private void btnHelp_MouseMove(object sender, MouseEventArgs e)
        {
            btnHelp.Size = new Size(84, 84);
        }

        private void frmMenuLevel_MouseMove(object sender, MouseEventArgs e)
        {
            btnReturnGame.Size = new Size(74, 74);
            btnHelp.Size = new Size(74, 74);
        }
    }
}
