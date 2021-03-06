﻿using System;
using System.Windows.Forms;

/**
 * @Autor: Diego Borja.
 * 
**/

namespace WinAppNiñitosEnAccion
{
    public partial class frmHelpAutoevaluacion : Form
    {
        private CInitializeThings ObjInitialize = new CInitializeThings();
        private CResize ObjResize = new CResize();

        public frmHelpAutoevaluacion(String Name)
        {
            InitializeComponent();
            ObjResize.ResolutionHelpAutoevaluation(this);
            ObjResize.ResizeComponentsVideo(HelpVideo);
            CenterToScreen();
            InicializacionVideo(Name);
            HelpVideo.Ctlcontrols.play();            
        }

        public void InicializacionVideo(String Name)
        {
            switch(Name)
            {
                case "Autoevaluacion1":
                    HelpVideo.URL = Application.StartupPath + @"/Video/Autoevaluacion1.mp4";
                    break;
                case "Autoevaluacion2":
                    HelpVideo.URL = Application.StartupPath + @"/Video/Autoevaluacion2.mp4";
                    break;
                case "Autoevaluacion3":
                    HelpVideo.URL = Application.StartupPath + @"/Video/Autoevaluacion3.mp4";
                    break;
                case "Autoevaluacion4":
                    HelpVideo.URL = Application.StartupPath + @"/Video/Autoevaluacion4.mp4";
                    break;
                case "Autoevaluacion5":
                    HelpVideo.URL = Application.StartupPath + @"/Video/Autoevaluacion5.mp4";
                    break;
            }
        }

        private void frmHelpAutoevaluacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            HelpVideo.Ctlcontrols.stop();
        }

        private void frmHelpAutoevaluacion_MouseEnter(object sender, EventArgs e)
        {
            ObjInitialize.Mouse(this, 1);
        }
    }
}
