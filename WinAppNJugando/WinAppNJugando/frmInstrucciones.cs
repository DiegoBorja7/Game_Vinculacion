using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoFinal.Forms
{
    public partial class frmInstrucciones : Form
    {
        public frmInstrucciones()
        {
            InitializeComponent();

        }

        private void lblButtonJugarAyuda_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmInstrucciones_Load(object sender, EventArgs e)
        {

        }

    }
}
