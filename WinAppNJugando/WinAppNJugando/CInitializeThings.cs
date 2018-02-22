using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.Diagnostics;
using System.IO;

/**
 *@Autor: Borja Diego
 * **/

namespace WinAppNiñitosEnAccion
{
    class CInitializeThings
    {
        #region Atributes of the class

        private Random random = new Random();
        private Bitmap myBitmap;
        private string[] things = new string[] { "Avion", "Bandera", "Barco", "Carro", "Estadio", "Headphone",
                                                 "Monumento", "Mundo", "Piano", "Puente", "Santa", "Sol", "Torre", "Tren" };

        private string[] thingsWithoutVowels = new string[] { "Bandera", "Barco", "Carro", "Headphone","Monumento", "Mundo", "Piano",
                                                              "Puente", "Santa", "Sol", "Torre", "Tren" };

        private string[] houseThings = new string[] { "Cama", "Lampara","Silla", "Escritorio", "TinadeBaño", "Lavavo","Sofa","Comedor",
                                                      "Olla", "Refrigeradora"};

        private string[] schoolThings = new string[] { "Rompecabezas", "Pelota","Relog", "Mochila", "Crayones", "Cuadernos","Libros",
                                                       "SillaAula", "Pizarron"};

        private string[] vowels = new string[] { "A", "E", "I", "O", "U" };

        private string[] thingsA= new string[] { "Almohada", "Aspiradora", "Arco"};

        private string[] thingsE = new string[] { "Escalera", "Escritorio", "Escuela"};

        private string[] thingsI = new string[] { "Impresora", "Iman", "Iguana" };

        private string[] thingsO = new string[] { "Olla", "Ocho", "Oso" };

        private string[] thingsU = new string[] { "Uvas", "Utiles", "Uno"};

        private string[] regions = new string[] { "Costa", "Sierra", "Oriente","Insular"};

        private string[] costaAnimals = new string[] { "Delfin", "Gaviota", "Langosta", "Ballena" };

        private string[] sierraAnimals = new string[] { "Condor", "Conejo", "Pato", "Raton" };

        private string[] orienteAnimals = new string[] { "Mono", "OsoPerezoso", "Rana", "Serpiente" };

        private string[] galapagosAnimals = new string[] { "DelfinGalapagos", "Pinguino", "Tiburon", "Tortuga" };

        private string[] solution1 = new string[] { "Tiburon", "Avion", "Pizarron"};

        private string[] solution2 = new string[] { "Aspiradora", "Refrigeradora", "Licuadora"};

        private string[] solution3 = new string[] { "Escalera", "Bandera", "Cafetera"};

        private string[] things2 = new string[] { "Ventana", "Mochila", "Barco", "Carro", "Estadio", "Headphone",
                                                 "Monumento", "Mundo", "Piano", "Puente", "Santa", "Sol", "Torre", "Tren" };
        
        #endregion

        #region Methods
        //Cambio del cursor del mouse.
        public void Mouse(Form frmUse,int x)
        {
            if (x == 1)
            {
                Icon visto;
                visto = Properties.Resources.Puntero;
                frmUse.Cursor = new Cursor(visto.Handle);
            }
            else if(x==2)
            {
                Icon visto;
                visto = Properties.Resources.Picaflor;
                frmUse.Cursor = new Cursor(visto.Handle);
            }
            else if(x==3)
            {
                Icon visto;
                visto = Properties.Resources.icons8_Paper_Plane_48px;
                frmUse.Cursor = new Cursor(visto.Handle);
            }

        }

        //Cambia de cursor al mouse al momento de selccionar un PictureBox
        public void Seleccionar(Form frmUse, PictureBox PicUse)
        {
            frmUse.Cursor = Cursors.Hand;
            PicUse.BorderStyle = BorderStyle.FixedSingle;
        }

        //Comprobar si se repiten los imagenes.
        bool Comprobar(string[] Ubicacion, string cadena)
        {
            int i;
            for (i = 0; i < Ubicacion.Length; i++)
            {
                if (Ubicacion[i] == cadena)
                    return true;
            }
            return false;
        }
        
        //Cargar las imagenes de la Autoevaluacion1
        public void CosasdelaCasa(List<PictureBox> ListaUse)
        {
            string[] Ubicacion=new string[9] { "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1"};
            int i,j,k;

            cuarto1:
            j = random.Next(9);
            if (Ubicacion[j] == "-1")
                Ubicacion[j] = houseThings[random.Next(2)];
            else
                goto cuarto1;

            cuarto2:
            j = random.Next(9);
            if (Ubicacion[j] == "-1")
                Ubicacion[j] = houseThings[random.Next(2,4)];
            else
                goto cuarto2;

            cuarto3:
            j = random.Next(9);
            if (Ubicacion[j] == "-1")
                Ubicacion[j] = houseThings[random.Next(4, 6)];
            else
                goto cuarto3;

            cuarto4:
            j = random.Next(9);
            if (Ubicacion[j] == "-1")
                Ubicacion[j] = houseThings[random.Next(6, 8)];
            else
                goto cuarto4;

            cuarto5:
            j = random.Next(9);
            if (Ubicacion[j] == "-1")
                Ubicacion[j] = houseThings[random.Next(8, 10)];
            else
                goto cuarto5;

            for (i = 0; i < 4; i++)
            {
                j = random.Next(9);
                k = random.Next(14);
                if (Ubicacion[j] == "-1")
                {
                    if (Comprobar(Ubicacion, things[k]))
                        i--;
                    else
                        Ubicacion[j] = things[k];
                }
                else
                    i--;
            }

            for(i = 0; i < ListaUse.Count; i++)
            { 
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/" + Ubicacion[i] + ".png");
                ListaUse[i].BackgroundImage= myBitmap;
                ListaUse[i].Name = Ubicacion[i];
                //ControlExtension.Draggable(ListaUse[i], true);
                ListaUse[i].AllowDrop = true;
            }
        }
       
        //Cargar las imagenes de la Autoevaluacion2
        public void CosasdelaEscuela(List<PictureBox> ListaUse)
        {
            string[] Ubicacion = new string[9] { "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1"};
            int i,j,k;

            for (i = 0; i < 5; i++)
            {
                j = random.Next(9);
                k = random.Next(9);
                if (Ubicacion[j] == "-1")
                {
                    
                    if (Comprobar(Ubicacion,schoolThings[k]))
                        i--;
                    else
                        Ubicacion[j] = schoolThings[k];
                }
                else
                    i--;
            }

            for (i = 0; i < 4; i++)
            {
                j = random.Next(9);
                k = random.Next(14);
                if (Ubicacion[j] == "-1")
                {
                    if (Comprobar(Ubicacion, things[k]))
                        i--;
                    else
                        Ubicacion[j] = things[k];
                }
                else
                    i--;
            }

            for (i = 0; i < ListaUse.Count; i++)
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/" + Ubicacion[i] + ".png");
                ListaUse[i].BackgroundImage = myBitmap;
                ListaUse[i].Name = Ubicacion[i];
               // ControlExtension.Draggable(ListaUse[i], true);
                ListaUse[i].AllowDrop = true;
            }
        }
        
        //Cargar imagenes de la Autoevaluacion3
        public void Vocales(List<PictureBox> ListaUse)
        {
            string[] Ubicacion = new string[9] { "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1"};
            string vocal;
            int i, j, k;          
            
            i = random.Next(5);
            vocal = vowels[i];

            myBitmap = new Bitmap(Application.StartupPath + @"/Image/" + vocal + ".png");
            ListaUse[0].BackgroundImage = myBitmap;
            ListaUse[0].Name = vocal;
            ListaUse[0].AllowDrop = true;

            switch (vocal)
            {
                case "A":
                    for (i = 0; i < 3; i++)
                    {
                        j = random.Next(9);
                        if (Ubicacion[j] == "-1")
                        {
                            Ubicacion[j] = thingsA[i];
                        }
                        else
                            i--;
                    }
                    break;
                case "E":
                    for (i = 0; i < 3; i++)
                    {
                        j = random.Next(9);
                        if (Ubicacion[j] == "-1")
                        {
                            Ubicacion[j] = thingsE[i];
                        }
                        else
                            i--;
                    }
                    break;
                case "I":
                    for (i = 0; i < 3; i++)
                    {
                        j = random.Next(9);
                        if (Ubicacion[j] == "-1")
                        {
                            Ubicacion[j] = thingsI[i];
                        }
                        else
                            i--;
                    }
                    break;
                case "O":
                    for (i = 0; i < 3; i++)
                    {
                        j = random.Next(9);
                        if (Ubicacion[j] == "-1")
                        {
                            Ubicacion[j] = thingsO[i];
                        }
                        else
                            i--;
                    }
                    break;
                case "U":
                    for (i = 0; i < 3; i++)
                    {
                        j = random.Next(9);
                        if (Ubicacion[j] == "-1")
                        {
                            Ubicacion[j] = thingsU[i];
                        }
                        else
                            i--;
                    }
                    break;
            }

            for (i = 0; i < 6; i++)
            {
                j = random.Next(9);
                k = random.Next(12);
                if (Ubicacion[j] == "-1")
                {
                    if (Comprobar(Ubicacion, thingsWithoutVowels[k]))
                        i--;
                    else
                        Ubicacion[j] = thingsWithoutVowels[k];
                }
                else
                    i--;
            }

            for(i = 1; i < ListaUse.Count; i++)
            { 
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/" + Ubicacion[i-1] + ".png");
                ListaUse[i].BackgroundImage= myBitmap;
                ListaUse[i].Name = Ubicacion[i-1];
                //ControlExtension.Draggable(ListaUse[i], true);
                ListaUse[i].AllowDrop = true;
            }
        }
        
        //Cargar imagenes de la Autoevaluacion4
        public void Regiones(List<PictureBox> ListaRegions, List<PictureBox> ListaUse)
        {
            string[] UbicacionRegion = new string[4] { "-1", "-1", "-1", "-1", };
            string[] Ubicacion = new string[9] { "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1" };
            int i, j, k;
            for (i = 0; i < 4; i++)
            {
                j = random.Next(4);
                if (UbicacionRegion[j] == "-1")
                {
                    UbicacionRegion[j] = regions[i];
                }
                else
                    i--;
            }

            for (i = 0; i < ListaRegions.Count; i++)
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/" + UbicacionRegion[i] + ".png");
                ListaRegions[i].BackgroundImage = myBitmap;
                ListaRegions[i].Name = UbicacionRegion[i];
                ListaRegions[i].AllowDrop = true;
            }

            costa:
            i = random.Next(9);
            if (Ubicacion[i] == "-1")
                Ubicacion[i] = costaAnimals[random.Next(4)];
            else
                goto costa;

            sierra:
            i = random.Next(9);
            if (Ubicacion[i] == "-1")
                Ubicacion[i] = sierraAnimals[random.Next(4)];
            else
                goto sierra;

            oriente:
            i = random.Next(9);
            if (Ubicacion[i] == "-1")
                Ubicacion[i] = orienteAnimals[random.Next(4)];
            else
                goto oriente;

            galapagos:
            i = random.Next(9);
            if (Ubicacion[i] == "-1")
                Ubicacion[i] = galapagosAnimals[random.Next(4)];
            else
                goto galapagos;

            for (i = 0; i < 5; i++)
            {
                j = random.Next(9);
                k = random.Next(14);
                if (Ubicacion[j] == "-1")
                {
                    if (Comprobar(Ubicacion, things[k]))
                        i--;
                    else
                        Ubicacion[j] = things[k];
                }
                else
                    i--;
            }

            for (i = 0; i < ListaUse.Count; i++)
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/" + Ubicacion[i] + ".png");
                ListaUse[i].BackgroundImage = myBitmap;
                ListaUse[i].Name = Ubicacion[i];
                //ControlExtension.Draggable(ListaUse[i], true);
                ListaUse[i].AllowDrop = true;
            }
        }

        //Cargar imagenes de la Autoevaluacion5
        public void TerminanEn(List<PictureBox> ListaUse)
        {
            
            string[] Ubicacion = new string[10] { "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1" };
            int i, j, k;

            k = random.Next(3);
            switch(k)
            {
                case 0:
                    for(i=0;i<3;i++)
                    {
                        j = random.Next(10);
                        if (Ubicacion[j] == "-1")
                            Ubicacion[j] = solution1[i];
                        else
                            i--;
                    }
                    break;

                case 1:
                    for (i = 0; i < 3; i++)
                    {
                        j = random.Next(10);
                        if (Ubicacion[j] == "-1")
                            Ubicacion[j] = solution2[i];
                        else
                            i--;
                    }
                    break;

                case 2:
                    for (i = 0; i < 3; i++)
                    {
                        j = random.Next(10);
                        if (Ubicacion[j] == "-1")
                            Ubicacion[j] = solution3[i];
                        else
                            i--;
                    }
                    break;
            }

            for (i = 0; i < 7; i++)
            {
                j = random.Next(10);
                k = random.Next(14);
                if (Ubicacion[j] == "-1")
                {
                    if (Comprobar(Ubicacion, things2[k]))
                        i--;
                    else
                        Ubicacion[j] = things2[k];
                }
                else
                    i--;
            }

            for (i = 0; i < ListaUse.Count; i++)
            {
                myBitmap = new Bitmap(Application.StartupPath + @"/Image/" + Ubicacion[i] + ".png");
                ListaUse[i].BackgroundImage = myBitmap;
                ListaUse[i].Name = Ubicacion[i];
            }
        }

        public void AllowDropAll(List<PictureBox> ListaUse)
        {
            for (int i = 0; i < ListaUse.Count; i++)
            {
                ListaUse[i].AllowDrop = true;
            }
        }

        #endregion
    }
}