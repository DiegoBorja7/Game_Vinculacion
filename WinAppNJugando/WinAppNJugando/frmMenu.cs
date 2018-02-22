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
namespace RegiAnimal
{
    public partial class frmMenu : Form
    {
        private int level = 2;

        private Regianimal regi;
        private InitializeImages im = new InitializeImages();
        private frmLevelSelection ls;
        private CInitializeThings ObjInitialize = new CInitializeThings();
        public frmMenu()
        {
            
            InitializeComponent();
            im.menuButtons(picBtnLevel, picBtnPlay, picBtnHome);
            picRegianimal.BackColor = Color.Transparent;
            Mouse();
        }

        public frmMenu(int level)
        {
            
            
            InitializeComponent();
            im.menuButtons(picBtnLevel, picBtnPlay, picBtnHome);
            picRegianimal.BackColor = Color.Transparent;

            Mouse();

            this.level = level;
        }

        private void Mouse()
        {
            ObjInitialize.Mouse(this, 2);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
          
        }

        private void picBtnPlay_Click(object sender, EventArgs e)
        {
            regi = new Regianimal(level);
            regi.Show();
            this.Visible = false;
        }

        private void picBtnLevel_Click(object sender, EventArgs e)
        {
            ls = new frmLevelSelection();
            ls.Show();
            this.Visible = false;

        }

        private void picBtnHome_Click(object sender, EventArgs e)
        {
            frmSelectGame selecgame = new frmSelectGame();
            selecgame.Show();
            this.Dispose();
        }

        private void picBtnLevel_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picBtnLevel);
        }

        private void picBtnPlay_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picBtnPlay);
        }

        private void picBtnHome_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picBtnHome);
        }

        private void frmMenu_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picBtnLevel.BorderStyle = BorderStyle.None;
            picBtnPlay.BorderStyle = BorderStyle.None;
            picBtnHome.BorderStyle = BorderStyle.None;
        }
    }
}
