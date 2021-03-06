﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Clases
{
    class CDestino
    {
        private List<PictureBox> destinos;
        private int indice;

        public int Indice
        {
            get
            {
                return indice;
            }

            set
            {
                indice = value;
            }
        }

        public List<PictureBox> Destinos
        {
            get
            {
                return destinos;
            }

            set
            {
                destinos = value;
            }
        }



        public CDestino(List<PictureBox> destinos)
        {
            Indice = 0;
            this.Destinos = destinos;
        }

        public void copiarEnDestino(Image imagen)
        {
            Destinos[Indice].Image = imagen;
            Destinos[Indice].BringToFront();
            Destinos[Indice].Enabled = false;
        }

        public void aumentarIndice()
        {
            if (Indice < Destinos.Count)
            {
                Indice++;
            }
        }
    }
}
