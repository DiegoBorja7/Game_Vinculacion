﻿using System;
using WinAppNiñitosEnAccion;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace RegiAnimal
{
    public partial class frmHelp : Form
    {
        SoundPlayer player = new SoundPlayer();
        CPictureSounds players = new CPictureSounds();
        private int lifeTime = 15;

        public frmHelp()
        {
            InitializeComponent();
            wmpHelp.URL = Application.StartupPath + @"/Video/help.mp4";
            player = new SoundPlayer(Application.StartupPath + @"/Audio/help.wav");
            player.Play();
            clock.Enabled = true;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lifeTime--;
            if (lifeTime == 0)
            {
                this.Dispose();
                players.playSound("go");
            }

        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            lblInstruccion.BackColor = Color.Transparent;

            CResize resize = new CResize();

            resize.Resolution(this);

            this.CenterToScreen();

        }
    }
}
