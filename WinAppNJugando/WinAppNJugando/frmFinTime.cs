﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmFinTime : Form
    {
        Form frm;
        public frmFinTime(Form frm)
        {
            InitializeComponent();
            timeEnd.Start();
            this.frm = frm;
        }

        private void frmFinTime_Load(object sender, EventArgs e)
        {
            SoundPlayer player;
            player = new SoundPlayer(Directory.GetCurrentDirectory() + "\\Resources\\audios\\fin reloj v2.wav");
            try
            {
                player.Play();
            }
            catch { }
        }

        private void timeEnd_Tick(object sender, EventArgs e)
        {
            try{
                endTime();
                timeEnd.Enabled = false;
            }
            catch { }           
        }

        public void endTime()
        {
            
            Dispose();
            frmRepeatGame objfrm = new frmRepeatGame(frm);
            objfrm.StartPosition = FormStartPosition.CenterScreen;
            objfrm.Show();
            
        }

    }
}
