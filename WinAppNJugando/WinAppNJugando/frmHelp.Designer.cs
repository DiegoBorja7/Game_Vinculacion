namespace RegiAnimal
{
    partial class frmHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.wmpHelp = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblInstruccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmpHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // wmpHelp
            // 
            this.wmpHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpHelp.Enabled = true;
            this.wmpHelp.Location = new System.Drawing.Point(0, 0);
            this.wmpHelp.Name = "wmpHelp";
            this.wmpHelp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpHelp.OcxState")));
            this.wmpHelp.Size = new System.Drawing.Size(1281, 686);
            this.wmpHelp.TabIndex = 0;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstruccion.Font = new System.Drawing.Font("Showcard Gothic", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.ForeColor = System.Drawing.Color.Red;
            this.lblInstruccion.Location = new System.Drawing.Point(759, 465);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(357, 65);
            this.lblInstruccion.TabIndex = 1;
            this.lblInstruccion.Text = "INSTRUCCIÓN";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1281, 686);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.wmpHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer clock;
        private AxWMPLib.AxWindowsMediaPlayer wmpHelp;
        private System.Windows.Forms.Label lblInstruccion;
    }
}