using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppNiñitosEnAccion
{
    public partial class frmMessageAutoevaluacion : Form
    {
        private CInstructions ObjInstruction = new CInstructions();

        public frmMessageAutoevaluacion(String Name)
        {
            InitializeComponent();
            if(Name == "Correcto")
            {
                ObjInstruction.playSound("BienAutoevaluacion");
                lblResult.Text = "Muy Bien Hecho.";
                lblResult.ForeColor = Color.Green;
                picResult.Image = new Bitmap(Application.StartupPath + @"/Image/Correcto.gif");
            }
            else
            {
                ObjInstruction.playSound("Fail");
                lblResult.Text = "Excediste en tus Intentos.";
                lblResult.ForeColor = Color.Red;
                picResult.Image = new Bitmap(Application.StartupPath + @"/Image/Incorrecto.gif");
            }
        }

        private void tmrExit_Tick(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
