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
    public partial class frmLevelSelection : Form
    {
        private int level ;
        private frmMenu menu;

        public frmLevelSelection()
        {
            InitializeComponent();
            CenterToScreen();
            Mouse();
            picLvlEasy.BackColor = Color.Transparent;
            picLvlMedium.BackColor = Color.Transparent;
            picLvlHard.BackColor = Color.Transparent;
        }

        private void Mouse()
        {
            Icon picaflor;
            picaflor = Properties.Resources.Mouse;
            this.Cursor = new Cursor(picaflor.Handle);
        }

        private void LevelSelection_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.level = 1;
            menu = new frmMenu(level);
            menu.Show();
            this.Dispose();
        }

        private void picLvlMedium_Click(object sender, EventArgs e)
        {
            this.level = 2;
            menu = new frmMenu(level);
            menu.Show();
            this.Dispose();
        }

        private void picLvlHard_Click(object sender, EventArgs e)
        {
            this.level = 3;
            menu = new frmMenu(level);
            menu.Show();
            this.Dispose();
        }
    }
}
