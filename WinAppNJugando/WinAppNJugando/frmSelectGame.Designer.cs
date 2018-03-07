namespace WinAppNiñitosEnAccion
{
    partial class frmSelectGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectGame));
            this.picExit = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picAutoevaluacion = new System.Windows.Forms.PictureBox();
            this.picRegiAnimalGame = new System.Windows.Forms.PictureBox();
            this.picTuCasaoTuEscuelaGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoevaluacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegiAnimalGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTuCasaoTuEscuelaGame)).BeginInit();
            this.SuspendLayout();
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picExit.BackgroundImage")));
            this.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picExit.Location = new System.Drawing.Point(27, 608);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(100, 100);
            this.picExit.TabIndex = 4;
            this.picExit.TabStop = false;
            this.toolTip1.SetToolTip(this.picExit, "Salir del Juego");
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            this.picExit.MouseEnter += new System.EventHandler(this.picExit_MouseEnter);
            // 
            // picAutoevaluacion
            // 
            this.picAutoevaluacion.BackColor = System.Drawing.Color.Transparent;
            this.picAutoevaluacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAutoevaluacion.BackgroundImage")));
            this.picAutoevaluacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAutoevaluacion.Location = new System.Drawing.Point(844, 524);
            this.picAutoevaluacion.Name = "picAutoevaluacion";
            this.picAutoevaluacion.Size = new System.Drawing.Size(147, 126);
            this.picAutoevaluacion.TabIndex = 5;
            this.picAutoevaluacion.TabStop = false;
            this.toolTip1.SetToolTip(this.picAutoevaluacion, "Autoevaluación");
            this.picAutoevaluacion.Click += new System.EventHandler(this.picAutoevaluacion_Click);
            this.picAutoevaluacion.MouseEnter += new System.EventHandler(this.picAutoevaluacion_MouseEnter);
            // 
            // picRegiAnimalGame
            // 
            this.picRegiAnimalGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRegiAnimalGame.BackgroundImage")));
            this.picRegiAnimalGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRegiAnimalGame.Location = new System.Drawing.Point(581, 56);
            this.picRegiAnimalGame.Name = "picRegiAnimalGame";
            this.picRegiAnimalGame.Size = new System.Drawing.Size(344, 422);
            this.picRegiAnimalGame.TabIndex = 7;
            this.picRegiAnimalGame.TabStop = false;
            this.toolTip1.SetToolTip(this.picRegiAnimalGame, "Juego Regi-Animal");
            this.picRegiAnimalGame.Click += new System.EventHandler(this.picRegiAnimalGame_Click);
            this.picRegiAnimalGame.MouseEnter += new System.EventHandler(this.picRegiAnimalGame_MouseEnter);
            // 
            // picTuCasaoTuEscuelaGame
            // 
            this.picTuCasaoTuEscuelaGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTuCasaoTuEscuelaGame.BackgroundImage")));
            this.picTuCasaoTuEscuelaGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTuCasaoTuEscuelaGame.Location = new System.Drawing.Point(122, 56);
            this.picTuCasaoTuEscuelaGame.Name = "picTuCasaoTuEscuelaGame";
            this.picTuCasaoTuEscuelaGame.Size = new System.Drawing.Size(347, 422);
            this.picTuCasaoTuEscuelaGame.TabIndex = 8;
            this.picTuCasaoTuEscuelaGame.TabStop = false;
            this.toolTip1.SetToolTip(this.picTuCasaoTuEscuelaGame, "Juego Tu Casa o Tu Escuela");
            this.picTuCasaoTuEscuelaGame.Click += new System.EventHandler(this.picTuCasaoTuEscuelaGame_Click);
            this.picTuCasaoTuEscuelaGame.MouseEnter += new System.EventHandler(this.picTuCasaoTuEscuelaGame_MouseEnter);
            // 
            // frmSelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.ControlBox = false;
            this.Controls.Add(this.picTuCasaoTuEscuelaGame);
            this.Controls.Add(this.picRegiAnimalGame);
            this.Controls.Add(this.picAutoevaluacion);
            this.Controls.Add(this.picExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSelectGame_Load);
            this.MouseEnter += new System.EventHandler(this.frmSelectGame_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoevaluacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegiAnimalGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTuCasaoTuEscuelaGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picAutoevaluacion;
        private System.Windows.Forms.PictureBox picRegiAnimalGame;
        private System.Windows.Forms.PictureBox picTuCasaoTuEscuelaGame;
    }
}