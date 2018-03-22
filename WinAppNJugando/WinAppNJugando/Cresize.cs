using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Windows.Forms;
using WinAppNiñitosEnAccion;

namespace WinAppNiñitosEnAccion
{   
    class Cresize
    {
        private float RWidth = 1300;
        private float RHeight = 660;
        private float ResolutionW = 1366;
        private float ResolutionH = 768;
        private float NewResolutionW;
        private float NewResolutionH;
        private float NewWidth;
        private float NewHeight;

        public void Resolution(Form form)
        {
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                NewHeight = (NewResolutionH) / ResolutionH;
                NewWidth = (NewResolutionW) / ResolutionW;

                form.Width = (int)(RWidth * NewWidth);
                form.Height = (int)(RHeight * NewHeight);
            }
            
        }

        public void ResizeComponentsMenu(PictureBox picHome, PictureBox picRegianimal, PictureBox picPlay)
        {
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                picHome.Width = (int)(picHome.Width * NewWidth);
                picHome.Height = (int)(picHome.Height * NewHeight);
                picHome.Location = new Point((int)(picHome.Location.X * NewWidth), (int)(picHome.Location.Y * NewHeight));


                picRegianimal.Width = (int)(picRegianimal.Width * NewWidth);
                picRegianimal.Height = (int)(picRegianimal.Height * NewHeight);
                picRegianimal.Location = new Point((int)(picRegianimal.Location.X * NewWidth), (int)(picRegianimal.Location.Y * NewHeight));

                picPlay.Width = (int)(picPlay.Width * NewWidth);
                picPlay.Height = (int)(picPlay.Height * NewHeight);
                picPlay.Location = new Point((int)(picPlay.Location.X * NewWidth), (int)(picPlay.Location.Y * NewHeight));

            }

        }

        public void ResizeReturn(PictureBox picHome, PictureBox picRegianimal, PictureBox picPlay, PictureBox picPlay1)
        {
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                picHome.Width = (int)(picHome.Width * NewWidth);
                picHome.Height = (int)(picHome.Height * NewHeight);
                picHome.Location = new Point((int)(picHome.Location.X * NewWidth), (int)(picHome.Location.Y * NewHeight));


                picRegianimal.Width = (int)(picRegianimal.Width * NewWidth);
                picRegianimal.Height = (int)(picRegianimal.Height * NewHeight);
                picRegianimal.Location = new Point((int)(picRegianimal.Location.X * NewWidth), (int)(picRegianimal.Location.Y * NewHeight));

                picPlay.Width = (int)(picPlay.Width * NewWidth);
                picPlay.Height = (int)(picPlay.Height * NewHeight);
                picPlay.Location = new Point((int)(picPlay.Location.X * NewWidth), (int)(picPlay.Location.Y * NewHeight));

                picPlay1.Width = (int)(picPlay1.Width * NewWidth);
                picPlay1.Height = (int)(picPlay1.Height * NewHeight);
                picPlay1.Location = new Point((int)(picPlay1.Location.X * NewWidth), (int)(picPlay1.Location.Y * NewHeight));

            }

        }

        public void ResizeComponentsRegianimal(PictureBox[] destination, PictureBox[] back, PictureBox[] images, PictureBox[] buttons, Label lblSeconds,Label lblScore, Label lblBegin)
        {
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {

                lblSeconds.Width = (int)(lblSeconds.Width * NewWidth);
                lblSeconds.Height = (int)(lblSeconds.Height * NewHeight);
                lblSeconds.Location = new Point((int)(lblSeconds.Location.X * NewWidth), (int)(lblSeconds.Location.Y * NewHeight));

                lblScore.Width = (int)(lblScore.Width * NewWidth);
                lblScore.Height = (int)(lblScore.Height * NewHeight);
                lblScore.Location = new Point((int)(lblScore.Location.X * NewWidth), (int)(lblScore.Location.Y * NewHeight));

                lblBegin.Width = (int)(lblBegin.Width * NewWidth);
                lblBegin.Height = (int)(lblBegin.Height * NewHeight);
                lblBegin.Location = new Point((int)(lblBegin.Location.X * NewWidth), (int)(lblBegin.Location.Y * NewHeight));

                for (int i = 0; i < 10; i++)
                {
                    buttons[i].Width = (int)(buttons[i].Width * NewWidth);
                    buttons[i].Height = (int)(buttons[i].Height * NewHeight);
                    buttons[i].Location = new Point((int)(buttons[i].Location.X * NewWidth), (int)(buttons[i].Location.Y * NewHeight));
                }

                for (int j = 0; j < 12; j++)
                {
                    destination[j].Width = (int)(destination[j].Width * NewWidth);
                    destination[j].Height = (int)(destination[j].Height * NewHeight);
                    destination[j].Location = new Point((int)(destination[j].Location.X * NewWidth), (int)(destination[j].Location.Y * NewHeight));
                }

                for (int k = 0; k < 8; k++)
                {
                    images[k].Width = (int)(images[k].Width * NewWidth);
                    images[k].Height = (int)(images[k].Height * NewHeight);
                }

            }

        }

        public void resizeEncasa(List<PictureBox> lienzo, List<PictureBox> casa, List<PictureBox> escuela)
        {

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                for (int k = 0; k < 6; k++)
                {
                    lienzo[k].Width = (int)(lienzo[k].Width * NewWidth);
                    lienzo[k].Height = (int)(lienzo[k].Height * NewHeight);
                }
                for (int k = 0; k < 3; k++)
                {
                    casa[k].Width = (int)(casa[k].Width * NewWidth);
                    casa[k].Height = (int)(casa[k].Height * NewHeight);
                }
                for (int k = 0; k < 3; k++)
                {
                    escuela[k].Width = (int)(escuela[k].Width * NewWidth);
                    escuela[k].Height = (int)(escuela[k].Height * NewHeight);
                }

            }



        }

    }
}
