namespace RegiAnimal
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.picBtnLevel = new System.Windows.Forms.PictureBox();
            this.picBtnPlay = new System.Windows.Forms.PictureBox();
            this.picBtnHome = new System.Windows.Forms.PictureBox();
            this.picRegianimal = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBtnLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegianimal)).BeginInit();
            this.SuspendLayout();
            // 
            // picBtnLevel
            // 
            this.picBtnLevel.Location = new System.Drawing.Point(69, 41);
            this.picBtnLevel.Name = "picBtnLevel";
            this.picBtnLevel.Size = new System.Drawing.Size(100, 100);
            this.picBtnLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnLevel.TabIndex = 0;
            this.picBtnLevel.TabStop = false;
            this.toolTip1.SetToolTip(this.picBtnLevel, "Seleccionar el Nivel");
            this.picBtnLevel.Click += new System.EventHandler(this.picBtnLevel_Click);
            this.picBtnLevel.MouseEnter += new System.EventHandler(this.picBtnLevel_MouseEnter);
            // 
            // picBtnPlay
            // 
            this.picBtnPlay.Location = new System.Drawing.Point(563, 41);
            this.picBtnPlay.Name = "picBtnPlay";
            this.picBtnPlay.Size = new System.Drawing.Size(100, 100);
            this.picBtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnPlay.TabIndex = 1;
            this.picBtnPlay.TabStop = false;
            this.toolTip1.SetToolTip(this.picBtnPlay, "Comenzar el Juego");
            this.picBtnPlay.Click += new System.EventHandler(this.picBtnPlay_Click);
            this.picBtnPlay.MouseEnter += new System.EventHandler(this.picBtnPlay_MouseEnter);
            // 
            // picBtnHome
            // 
            this.picBtnHome.Location = new System.Drawing.Point(1186, 41);
            this.picBtnHome.Name = "picBtnHome";
            this.picBtnHome.Size = new System.Drawing.Size(100, 100);
            this.picBtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnHome.TabIndex = 2;
            this.picBtnHome.TabStop = false;
            this.toolTip1.SetToolTip(this.picBtnHome, "Regresar a Elegir un Juego");
            this.picBtnHome.Click += new System.EventHandler(this.picBtnHome_Click);
            this.picBtnHome.MouseEnter += new System.EventHandler(this.picBtnHome_MouseEnter);
            // 
            // picRegianimal
            // 
            this.picRegianimal.Image = ((System.Drawing.Image)(resources.GetObject("picRegianimal.Image")));
            this.picRegianimal.Location = new System.Drawing.Point(435, 533);
            this.picRegianimal.Name = "picRegianimal";
            this.picRegianimal.Size = new System.Drawing.Size(516, 116);
            this.picRegianimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegianimal.TabIndex = 3;
            this.picRegianimal.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 660);
            this.Controls.Add(this.picRegianimal);
            this.Controls.Add(this.picBtnHome);
            this.Controls.Add(this.picBtnPlay);
            this.Controls.Add(this.picBtnLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseEnter += new System.EventHandler(this.frmMenu_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picBtnLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegianimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBtnLevel;
        private System.Windows.Forms.PictureBox picBtnPlay;
        private System.Windows.Forms.PictureBox picBtnHome;
        private System.Windows.Forms.PictureBox picRegianimal;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}