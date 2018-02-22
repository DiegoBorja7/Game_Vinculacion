﻿using System;
using System.Windows.Forms;
using RegiAnimal;
using WinAppProject;
/**
  * @Autor: Diego Borja.
  * */

namespace WinAppNiñitosEnAccion
{
    public partial class frmSelectGame : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CInstructions ObjInstruction = new CInstructions();

        public frmSelectGame()
        {
            InitializeComponent();
        }

        private void picAutoevaluacion_Click(object sender, EventArgs e)
        {
            frmAutoevaluacion1 ObjFormularioAutoevaluacion1 = new frmAutoevaluacion1();
            ObjFormularioAutoevaluacion1.Show();
            Hide();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSelectGame_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picAutoevaluacion.BorderStyle = BorderStyle.None;
            picExit.BorderStyle = BorderStyle.None;
            picTuCasaoTuEscuelaGame.BorderStyle = BorderStyle.None;
            picRegiAnimalGame.BorderStyle = BorderStyle.None;
        }

        private void picAutoevaluacion_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picAutoevaluacion);
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picExit);
        }

        private void picTuCasaoTuEscuelaGame_MouseEnter(object sender, EventArgs e)
        {

            ObjInitialize.Seleccionar(this, picTuCasaoTuEscuelaGame);
        }
        private void picRegiAnimalGame_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Seleccionar(this, picRegiAnimalGame);
        }
        private void picRegiAnimalGame_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Dispose();
        }
        private void picTuCasaoTuEscuelaGame_Click(object sender, EventArgs e)
        {
            frmMenuC menuc = new frmMenuC();
            menuc.Show();
            Dispose();
        }

        private void frmSelectGame_Load(object sender, EventArgs e)
        {
            ObjInstruction.playSound("Introduccion2");
        }
    }
}