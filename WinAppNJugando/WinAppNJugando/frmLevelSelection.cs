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
    public partial class frmLevelSelection : Form
    {
        private int level ;
        private Regianimal regiAnimal;
        private CPictureSounds sound = new CPictureSounds();
        private CInitializeThings ms = new CInitializeThings();

        public frmLevelSelection()
        {
            
            InitializeComponent();
            CenterToScreen();
            Mouse();
            picLvlEasy.BackColor = Color.Transparent;
            picLvlMedium.BackColor = Color.Transparent;
            picLvlHard.BackColor = Color.Transparent;
            sound.playIntruction();
        }

        private void Mouse()
        {
            ms.Mouse(this, 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.level = 1;
            regiAnimal = new Regianimal(level);
            regiAnimal.Show();
            this.Dispose();
        }

        private void picLvlMedium_Click(object sender, EventArgs e)
        {
            this.level = 2;
            regiAnimal = new Regianimal(level);
            regiAnimal.Show();
            this.Dispose();
        }

        private void picLvlHard_Click(object sender, EventArgs e)
        {
            this.level = 3;
            regiAnimal = new Regianimal(level);
            regiAnimal.Show();
            this.Dispose();
        }

        private void picLvlEasy_MouseHover(object sender, EventArgs e)
        {
            picLvlEasy.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picLvlMedium_MouseHover(object sender, EventArgs e)
        {
            picLvlMedium.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picLvlHard_MouseHover(object sender, EventArgs e)
        {
            picLvlHard.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picLvlEasy_MouseLeave(object sender, EventArgs e)
        {
            picLvlEasy.BorderStyle = BorderStyle.None;
        }

        private void picLvlMedium_MouseLeave(object sender, EventArgs e)
        {
            picLvlMedium.BorderStyle = BorderStyle.None;
        }

        private void picLvlHard_MouseLeave(object sender, EventArgs e)
        {
            picLvlHard.BorderStyle = BorderStyle.None;
        }

        private void frmLevelSelection_Load_1(object sender, EventArgs e)
        {
            Cresize resize = new Cresize();
            resize.Resolution(this);
            resize.ResizeComponentsMenu(picLvlEasy, picLvlMedium, picLvlHard);
        }
    }
}
