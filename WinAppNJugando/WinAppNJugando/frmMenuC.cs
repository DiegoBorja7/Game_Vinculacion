using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppNiñitosEnAccion;
namespace WinAppProject
{
    public partial class frmMenuC : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();

        public frmMenuC()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnPlay.BackColor = Color.Transparent;
            btnReturn.BackColor = Color.Transparent;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmSelectGame selecgame = new frmSelectGame();
            selecgame.Show();
            this.Dispose();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmJuego frmObject = new frmJuego();
            frmObject.StartPosition = FormStartPosition.CenterScreen;
            frmObject.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_MouseMove(object sender, MouseEventArgs e)
        {
            //ControlExtension.Draggable(btnPlay , true);
        }
    }
}
