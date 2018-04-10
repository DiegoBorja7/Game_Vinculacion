namespace WinAppNiñitosEnAccion
{
    partial class frmVideoCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideoCreditos));
            this.VideoCreditos = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.VideoCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoCreditos
            // 
            this.VideoCreditos.Enabled = true;
            this.VideoCreditos.Location = new System.Drawing.Point(-1, 0);
            this.VideoCreditos.Name = "VideoCreditos";
            this.VideoCreditos.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoCreditos.OcxState")));
            this.VideoCreditos.Size = new System.Drawing.Size(1269, 681);
            this.VideoCreditos.TabIndex = 0;
            // 
            // frmVideoCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.VideoCreditos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVideoCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVideoCreditos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.VideoCreditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer VideoCreditos;
    }
}