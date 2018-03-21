namespace WinAppNiñitosEnAccion
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.picExit = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picBtnPlay = new System.Windows.Forms.PictureBox();
            this.picVideo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Location = new System.Drawing.Point(1148, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(120, 110);
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.toolTip1.SetToolTip(this.picExit, "Salir del Juego");
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            // 
            // picBtnPlay
            // 
            this.picBtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.picBtnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBtnPlay.BackgroundImage")));
            this.picBtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBtnPlay.Location = new System.Drawing.Point(490, 310);
            this.picBtnPlay.Name = "picBtnPlay";
            this.picBtnPlay.Size = new System.Drawing.Size(335, 140);
            this.picBtnPlay.TabIndex = 4;
            this.picBtnPlay.TabStop = false;
            this.toolTip1.SetToolTip(this.picBtnPlay, "Comencemos el Juego");
            this.picBtnPlay.Click += new System.EventHandler(this.picBtnPlay_Click);
            this.picBtnPlay.MouseEnter += new System.EventHandler(this.picBtnPlay_MouseEnter);
            // 
            // picVideo
            // 
            this.picVideo.BackColor = System.Drawing.Color.Transparent;
            this.picVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVideo.BackgroundImage")));
            this.picVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVideo.Location = new System.Drawing.Point(12, 12);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(110, 110);
            this.picVideo.TabIndex = 5;
            this.picVideo.TabStop = false;
            this.toolTip1.SetToolTip(this.picVideo, "Créditos");
            this.picVideo.Click += new System.EventHandler(this.picVideo_Click);
            this.picVideo.MouseEnter += new System.EventHandler(this.picVideo_MouseEnter);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.picVideo);
            this.Controls.Add(this.picBtnPlay);
            this.Controls.Add(this.picExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.MouseEnter += new System.EventHandler(this.frmInicio_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picBtnPlay;
        private System.Windows.Forms.PictureBox picVideo;
    }
}

