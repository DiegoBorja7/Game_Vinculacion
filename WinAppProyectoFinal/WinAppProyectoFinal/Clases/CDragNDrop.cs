using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppProyectoFinal.Forms;

namespace WinAppProyectoFinal.Clases
{
    class CDragNDrop
    {
        private List<PictureBox> mImages;
        private PictureBox picAux;
        private CDestino destinoCasa, destinoEscuela;


        public List<PictureBox> MImages
        {
            get
            {
                return mImages;
            }

            set
            {
                mImages = value;
            }
        }

        public PictureBox PicAux
        {
            get
            {
                return picAux;
            }

            set
            {
                picAux = value;
            }
        }

        internal CDestino DestinoCasa
        {
            get
            {
                return destinoCasa;
            }

            set
            {
                destinoCasa = value;
            }
        }

        internal CDestino DestinoEscuela
        {
            get
            {
                return destinoEscuela;
            }

            set
            {
                destinoEscuela = value;
            }
        }

        public CDragNDrop(List<PictureBox> images)
        {
            MImages = images;
            AllowDrop();
        }

        public CDragNDrop(List<PictureBox> images, List<PictureBox> casa, List<PictureBox> escuela)
        {
            MImages = images;
            DestinoEscuela = new CDestino(escuela);
            DestinoCasa = new CDestino(casa); 
            AllowDrop();
        }

        public void AllowDrop()
        {
            for (int i = 0; i < MImages.Count; i++)
            {
                MImages[i].AllowDrop = true;
            }
        }

        public void validacionCasa(PictureBox pic1, PictureBox pic2)
        {
            frmMensaje ObjForm;
            if (pic1.Tag == pic2.Tag)
            {
                ObjForm = new frmMensaje("acierto");
                pic1.Image = null;
                pic1.Enabled = false;
                DestinoCasa.copiarEnDestino(pic2.Image);
                pic2.Image = null;
                DestinoCasa.aumentarIndice();
                ObjForm.Show();
            }
            else
            {
                ObjForm = new frmMensaje("error");
                pic2.Image = null;
                ObjForm.Show();
            }
        }

        public void validacionEscuela(PictureBox pic1, PictureBox pic2)
        {
            frmMensaje ObjForm;
            if (pic1.Tag == pic2.Tag)
            {
                ObjForm = new frmMensaje("acierto");
                pic1.Image = null;
                pic1.Enabled = false;
                DestinoEscuela.copiarEnDestino(pic2.Image);
                pic2.Image = null;
                DestinoEscuela.aumentarIndice();
                ObjForm.Show();
            }
            else
            {
                ObjForm = new frmMensaje("error");
                pic2.Image = null;
                ObjForm.Show();
            }
        }

        public void mouseAplastado(object sender)
        {
            PicAux = (PictureBox)sender;

            PicAux.Select();

            try
            {
                PicAux.DoDragDrop(PicAux.Image, DragDropEffects.Move);
            }
            catch { }
        }

        public void dragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        public void dragDrop(DragEventArgs e, Object sender, int bandera)
        {
            PictureBox picAux2 = (PictureBox)sender;
            picAux2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            if (bandera == 1)
            {
                validacionCasa(PicAux, picAux2);
            }
            else
            {
                validacionEscuela(PicAux, picAux2);
            }
        }

    }
}
