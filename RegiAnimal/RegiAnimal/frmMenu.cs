using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegiAnimal
{
    public partial class frmMenu : Form
    {
        private int level = 2;

        private Regianimal regi;
        private InitializeImages im = new InitializeImages();
        private frmLevelSelection ls;

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
            Icon picaflor;
            picaflor = Properties.Resources.Mouse;
            this.Cursor = new Cursor(picaflor.Handle);
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
            Application.Exit();
        }
    }
}
