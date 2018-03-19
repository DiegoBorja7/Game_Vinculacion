namespace WinAppNiñitosEnAccion
{
    partial class frmHelpAutoevaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelpAutoevaluacion));
            this.HelpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.HelpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpVideo
            // 
            this.HelpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpVideo.Enabled = true;
            this.HelpVideo.Location = new System.Drawing.Point(0, 0);
            this.HelpVideo.Name = "HelpVideo";
            this.HelpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("HelpVideo.OcxState")));
            this.HelpVideo.Size = new System.Drawing.Size(784, 461);
            this.HelpVideo.TabIndex = 0;
            // 
            // frmHelpAutoevaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.HelpVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHelpAutoevaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHelpAutoevaluacion_FormClosed);
            this.MouseEnter += new System.EventHandler(this.frmHelpAutoevaluacion_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.HelpVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer HelpVideo;
    }
}