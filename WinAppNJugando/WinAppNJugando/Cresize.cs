using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

/**
 * @Autor: Jonathan Altamirano.
 * 
**/

namespace WinAppNiñitosEnAccion
{   
    class CResize
    {
        private float RWidth = 1300;
        private float RHeight = 660;
        private float ResolutionW = 1366;
        private float ResolutionH = 768;
        private float NewResolutionW;
        private float NewResolutionH;
        private float mNewWidth;
        private float mNewHeight;

        public float NewWidth
        {
            get { return mNewWidth; }
            set { mNewWidth = value; }
        }

        public float NewHeight
        {
            get { return mNewHeight; }
            set { mNewHeight = value; }
        }

        public void Resolution(Form form)
        {
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                form.Width = (int)(RWidth * mNewWidth);
                form.Height = (int)(RHeight * mNewHeight);
            }
        }

        public void ResizeComponentsMenu(PictureBox picHome, PictureBox picRegianimal, PictureBox picPlay)
        {
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                picHome.Width = (int)(picHome.Width * mNewWidth);
                picHome.Height = (int)(picHome.Height * mNewHeight);
                picHome.Location = new Point((int)(picHome.Location.X * mNewWidth), (int)(picHome.Location.Y * mNewHeight));


                picRegianimal.Width = (int)(picRegianimal.Width * mNewWidth);
                picRegianimal.Height = (int)(picRegianimal.Height * mNewHeight);
                picRegianimal.Location = new Point((int)(picRegianimal.Location.X * mNewWidth), (int)(picRegianimal.Location.Y * mNewHeight));

                picPlay.Width = (int)(picPlay.Width * mNewWidth);
                picPlay.Height = (int)(picPlay.Height * mNewHeight);
                picPlay.Location = new Point((int)(picPlay.Location.X * mNewWidth), (int)(picPlay.Location.Y * mNewHeight));

            }

        }

        public void ResizeReturn(PictureBox picHome, PictureBox picRegianimal, PictureBox picPlay, PictureBox picPlay1)
        {
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                picHome.Width = (int)(picHome.Width * mNewWidth);
                picHome.Height = (int)(picHome.Height * mNewHeight);
                picHome.Location = new Point((int)(picHome.Location.X * mNewWidth), (int)(picHome.Location.Y * mNewHeight));


                picRegianimal.Width = (int)(picRegianimal.Width * mNewWidth);
                picRegianimal.Height = (int)(picRegianimal.Height * mNewHeight);
                picRegianimal.Location = new Point((int)(picRegianimal.Location.X * mNewWidth), (int)(picRegianimal.Location.Y * mNewHeight));

                picPlay.Width = (int)(picPlay.Width * mNewWidth);
                picPlay.Height = (int)(picPlay.Height * mNewHeight);
                picPlay.Location = new Point((int)(picPlay.Location.X * mNewWidth), (int)(picPlay.Location.Y * mNewHeight));

                picPlay1.Width = (int)(picPlay1.Width * mNewWidth);
                picPlay1.Height = (int)(picPlay1.Height * mNewHeight);
                picPlay1.Location = new Point((int)(picPlay1.Location.X * mNewWidth), (int)(picPlay1.Location.Y * mNewHeight));

            }

        }

        public void ResizeComponentsRegianimal(PictureBox[] destination, PictureBox[] back, PictureBox[] images, PictureBox[] buttons, Label lblSeconds,Label lblScore, Label lblBegin)
        {
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {

                lblSeconds.Width = (int)(lblSeconds.Width * mNewWidth);
                lblSeconds.Height = (int)(lblSeconds.Height * mNewHeight);
                lblSeconds.Location = new Point((int)(lblSeconds.Location.X * mNewWidth), (int)(lblSeconds.Location.Y * mNewHeight));

                lblScore.Width = (int)(lblScore.Width * mNewWidth);
                lblScore.Height = (int)(lblScore.Height * mNewHeight);
                lblScore.Location = new Point((int)(lblScore.Location.X * mNewWidth), (int)(lblScore.Location.Y * mNewHeight));

                lblBegin.Width = (int)(lblBegin.Width * mNewWidth);
                lblBegin.Height = (int)(lblBegin.Height * mNewHeight);
                lblBegin.Location = new Point((int)(lblBegin.Location.X * mNewWidth), (int)(lblBegin.Location.Y * mNewHeight));

                for (int i = 0; i < 10; i++)
                {
                    buttons[i].Width = (int)(buttons[i].Width * mNewWidth);
                    buttons[i].Height = (int)(buttons[i].Height * mNewHeight);
                    buttons[i].Location = new Point((int)(buttons[i].Location.X * mNewWidth), (int)(buttons[i].Location.Y * mNewHeight));
                }

                for (int j = 0; j < 12; j++)
                {
                    destination[j].Width = (int)(destination[j].Width * mNewWidth);
                    destination[j].Height = (int)(destination[j].Height * mNewHeight);
                    destination[j].Location = new Point((int)(destination[j].Location.X * mNewWidth), (int)(destination[j].Location.Y * mNewHeight));
                }

                for (int k = 0; k < 8; k++)
                {
                    images[k].Width = (int)(images[k].Width * mNewWidth);
                    images[k].Height = (int)(images[k].Height * mNewHeight);
                }

            }

        }

        public void resizeEncasa(List<PictureBox> lienzo, List<PictureBox> casa, List<PictureBox> escuela, List<PictureBox> buttons,Label lbltime)
        {
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                for (int k = 0; k < 6; k++)
                {
                    lienzo[k].Width = (int)(lienzo[k].Width * mNewWidth);
                    lienzo[k].Height = (int)(lienzo[k].Height * mNewHeight);
                }
                for (int k = 0; k < 3; k++)
                {
                    casa[k].Width = (int)(casa[k].Width * mNewWidth);
                    casa[k].Height = (int)(casa[k].Height * mNewHeight);
                }
                for (int k = 0; k < 3; k++)
                {
                    escuela[k].Width = (int)(escuela[k].Width * mNewWidth);
                    escuela[k].Height = (int)(escuela[k].Height * mNewHeight);
                }

                for (int i = 0; i < 6; i++)
                {
                    buttons[i].Width = (int)(buttons[i].Width * mNewWidth);
                    buttons[i].Height = (int)(buttons[i].Height * mNewHeight);
                    buttons[i].Location = new Point((int)(buttons[i].Location.X * mNewWidth), (int)(buttons[i].Location.Y * mNewHeight));
                }

                lbltime.Width = (int)(lbltime.Width * mNewWidth);
                lbltime.Height = (int)(lbltime.Height * mNewHeight);
                lbltime.Location = new Point((int)(lbltime.Location.X * mNewWidth), (int)(lbltime.Location.Y * mNewHeight));

            }
        }

        //
        public void ResolutionInicio(Form frm)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            RWidth = 1280;
            RHeight = 720;
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                frm.Width = (int)(RWidth * mNewWidth);
                frm.Height = (int)(RHeight * mNewHeight);
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ResizeComponentsInicio(PictureBox picbtnPlay, PictureBox picVideo, PictureBox picExit)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                picbtnPlay.Width = (int)(picbtnPlay.Width * mNewWidth);
                picbtnPlay.Height = (int)(picbtnPlay.Height * mNewHeight);
                picbtnPlay.Location = new Point((int)(picbtnPlay.Location.X * mNewWidth), (int)(picbtnPlay.Location.Y * mNewHeight));


                picVideo.Width = (int)(picVideo.Width * mNewWidth);
                picVideo.Height = (int)(picVideo.Height * mNewHeight);
                picVideo.Location = new Point((int)(picVideo.Location.X * mNewWidth), (int)(picVideo.Location.Y * mNewHeight));

                picExit.Width = (int)(picExit.Width * mNewWidth);
                picExit.Height = (int)(picExit.Height * mNewHeight);
                picExit.Location = new Point((int)(picExit.Location.X * mNewWidth), (int)(picExit.Location.Y * mNewHeight));
            }
        }

        public void ResolutionSelectGame(Form frm)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            RWidth = 1024;
            RHeight = 720;
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                frm.Width = (int)(RWidth * mNewWidth);
                frm.Height = (int)(RHeight * mNewHeight);
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ResizeComponentsSelectGame(PictureBox picEnCasaGame, PictureBox picRegiAnimalGame, PictureBox picAutoevaluacion, PictureBox picExit)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                picEnCasaGame.Width = (int)(picEnCasaGame.Width * mNewWidth);
                picEnCasaGame.Height = (int)(picEnCasaGame.Height * mNewHeight);
                picEnCasaGame.Location = new Point((int)(picEnCasaGame.Location.X * mNewWidth), (int)(picEnCasaGame.Location.Y * mNewHeight));


                picRegiAnimalGame.Width = (int)(picRegiAnimalGame.Width * mNewWidth);
                picRegiAnimalGame.Height = (int)(picRegiAnimalGame.Height * mNewHeight);
                picRegiAnimalGame.Location = new Point((int)(picRegiAnimalGame.Location.X * mNewWidth), (int)(picRegiAnimalGame.Location.Y * mNewHeight));

                picAutoevaluacion.Width = (int)(picAutoevaluacion.Width * mNewWidth);
                picAutoevaluacion.Height = (int)(picAutoevaluacion.Height * mNewHeight);
                picAutoevaluacion.Location = new Point((int)(picAutoevaluacion.Location.X * mNewWidth), (int)(picAutoevaluacion.Location.Y * mNewHeight));

                picExit.Width = (int)(picExit.Width * mNewWidth);
                picExit.Height = (int)(picExit.Height * mNewHeight);
                picExit.Location = new Point((int)(picExit.Location.X * mNewWidth), (int)(picExit.Location.Y * mNewHeight));
            }
        }
        public void ResolutionAutoevaluation(Form frm)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            RWidth = 1024;
            RHeight = 720;
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                frm.Width = (int)(RWidth * mNewWidth);
                frm.Height = (int)(RHeight * mNewHeight);
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ResizeComponentsAutoevaluation(List<PictureBox> ListaPictureBoxObjetos, List<PictureBox> ListaPictureBoxLugares, List<PictureBox>ListaPictureBotones)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                for (int i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    ListaPictureBoxObjetos[i].Width = (int)(ListaPictureBoxObjetos[i].Width * mNewWidth);
                    ListaPictureBoxObjetos[i].Height = (int)(ListaPictureBoxObjetos[i].Height * mNewHeight);
                    ListaPictureBoxObjetos[i].Location = new Point((int)(ListaPictureBoxObjetos[i].Location.X * mNewWidth), (int)(ListaPictureBoxObjetos[i].Location.Y * mNewHeight));
                }

                for (int i = 0; i < ListaPictureBoxLugares.Count; i++)
                {
                    ListaPictureBoxLugares[i].Width = (int)(ListaPictureBoxLugares[i].Width * mNewWidth);
                    ListaPictureBoxLugares[i].Height = (int)(ListaPictureBoxLugares[i].Height * mNewHeight);
                    ListaPictureBoxLugares[i].Location = new Point((int)(ListaPictureBoxLugares[i].Location.X * mNewWidth), (int)(ListaPictureBoxLugares[i].Location.Y * mNewHeight));
                }

                for (int i = 0; i < ListaPictureBotones.Count; i++)
                {
                    ListaPictureBotones[i].Width = (int)(ListaPictureBotones[i].Width * mNewWidth);
                    ListaPictureBotones[i].Height = (int)(ListaPictureBotones[i].Height * mNewHeight);
                    ListaPictureBotones[i].Location = new Point((int)(ListaPictureBotones[i].Location.X * mNewWidth), (int)(ListaPictureBotones[i].Location.Y * mNewHeight));
                }
            }
        }

        public void ResizeComponentsAutoevaluation(List<PictureBox> ListaPictureBoxObjetos, List<PictureBox> ListaPictureBotones)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                for (int i = 0; i < ListaPictureBoxObjetos.Count; i++)
                {
                    ListaPictureBoxObjetos[i].Width = (int)(ListaPictureBoxObjetos[i].Width * mNewWidth);
                    ListaPictureBoxObjetos[i].Height = (int)(ListaPictureBoxObjetos[i].Height * mNewHeight);
                    ListaPictureBoxObjetos[i].Location = new Point((int)(ListaPictureBoxObjetos[i].Location.X * mNewWidth), (int)(ListaPictureBoxObjetos[i].Location.Y * mNewHeight));
                }

                for (int i = 0; i < ListaPictureBotones.Count; i++)
                {
                    ListaPictureBotones[i].Width = (int)(ListaPictureBotones[i].Width * mNewWidth);
                    ListaPictureBotones[i].Height = (int)(ListaPictureBotones[i].Height * mNewHeight);
                    ListaPictureBotones[i].Location = new Point((int)(ListaPictureBotones[i].Location.X * mNewWidth), (int)(ListaPictureBotones[i].Location.Y * mNewHeight));
                }
            }
        }

        public void ResolutionAlert(Form frm)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            RWidth = 410;
            RHeight = 250;
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                frm.Width = (int)(RWidth * mNewWidth);
                frm.Height = (int)(RHeight * mNewHeight);
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ResizeComponentsAlert(PictureBox picBtnYes, PictureBox picBtnNo)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                picBtnYes.Width = (int)(picBtnYes.Width * mNewWidth);
                picBtnYes.Height = (int)(picBtnYes.Height * mNewHeight);
                picBtnYes.Location = new Point((int)(picBtnYes.Location.X * mNewWidth), (int)(picBtnYes.Location.Y * mNewHeight));


                picBtnNo.Width = (int)(picBtnNo.Width * mNewWidth);
                picBtnNo.Height = (int)(picBtnNo.Height * mNewHeight);
                picBtnNo.Location = new Point((int)(picBtnNo.Location.X * mNewWidth), (int)(picBtnNo.Location.Y * mNewHeight));
            }
        }

        public void ResolutionMessageAutoevalaution(Form frm)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            RWidth = 425;
            RHeight = 400;
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                frm.Width = (int)(RWidth * mNewWidth);
                frm.Height = (int)(RHeight * mNewHeight);
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ResizeComponentsMessageAutoevalaution(Label lblResult, PictureBox picResult)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                lblResult.Width = (int)(lblResult.Width * mNewWidth);
                lblResult.Height = (int)(lblResult.Height * mNewHeight);
                lblResult.Location = new Point((int)(lblResult.Location.X * mNewWidth), (int)(lblResult.Location.Y * mNewHeight));

                picResult.Width = (int)(picResult.Width * mNewWidth);
                picResult.Height = (int)(picResult.Height * mNewHeight);
                picResult.Location = new Point((int)(picResult.Location.X * mNewWidth), (int)(picResult.Location.Y * mNewHeight));
            }
        }
        public void ResolutionAutoevaluationScore(Form frm)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            RWidth = 550;
            RHeight = 450;
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                frm.Width = (int)(RWidth * mNewWidth);
                frm.Height = (int)(RHeight * mNewHeight);
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ResizeComponentsAutoevaluationScore(List<PictureBox> ListaEstrellas, List<PictureBox> ListaPictureBotones)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                for (int i = 0; i < ListaEstrellas.Count; i++)
                {
                    ListaEstrellas[i].Width = (int)(ListaEstrellas[i].Width * mNewWidth);
                    ListaEstrellas[i].Height = (int)(ListaEstrellas[i].Height * mNewHeight);
                    ListaEstrellas[i].Location = new Point((int)(ListaEstrellas[i].Location.X * mNewWidth), (int)(ListaEstrellas[i].Location.Y * mNewHeight));
                }

                for (int i = 0; i < ListaPictureBotones.Count; i++)
                {
                    ListaPictureBotones[i].Width = (int)(ListaPictureBotones[i].Width * mNewWidth);
                    ListaPictureBotones[i].Height = (int)(ListaPictureBotones[i].Height * mNewHeight);
                    ListaPictureBotones[i].Location = new Point((int)(ListaPictureBotones[i].Location.X * mNewWidth), (int)(ListaPictureBotones[i].Location.Y * mNewHeight));
                }
            }
        }
        public void ResolutionHelpAutoevaluation(Form frm)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            RWidth = 1024;
            RHeight = 720;
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                frm.Width = (int)(RWidth * mNewWidth);
                frm.Height = (int)(RHeight * mNewHeight);
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
        }
        public void ResizeComponentsVideo(AxWMPLib.AxWindowsMediaPlayer Video)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                    Video.Width = (int)(Video.Width * mNewWidth);
                    Video.Height = (int)(Video.Height * mNewHeight);
                    Video.Location = new Point((int)(Video.Location.X * mNewWidth), (int)(Video.Location.Y * mNewHeight));
            }
        }

        public void ResolutionCreditsVideo(Form frm)
        {
            ResolutionW = 1920;
            ResolutionH = 1080;
            RWidth = 1280;
            RHeight = 720;
            NewResolutionH = Screen.PrimaryScreen.Bounds.Height;
            NewResolutionW = Screen.PrimaryScreen.Bounds.Width;

            if ((NewResolutionH != ResolutionH) || (NewResolutionW != ResolutionW))
            {
                mNewHeight = (NewResolutionH) / ResolutionH;
                mNewWidth = (NewResolutionW) / ResolutionW;

                frm.Width = (int)(RWidth * mNewWidth);
                frm.Height = (int)(RHeight * mNewHeight);
            }
            frm.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
