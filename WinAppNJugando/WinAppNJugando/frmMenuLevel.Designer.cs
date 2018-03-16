namespace WinAppProyectoFinal.Forms
{
    partial class frmMenuLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuLevel));
            this.picMedio = new System.Windows.Forms.PictureBox();
            this.picDificil = new System.Windows.Forms.PictureBox();
            this.picFacil = new System.Windows.Forms.PictureBox();
            this.btnReturnGame = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDificil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // picMedio
            // 
            this.picMedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMedio.Location = new System.Drawing.Point(125, 115);
            this.picMedio.Name = "picMedio";
            this.picMedio.Size = new System.Drawing.Size(150, 150);
            this.picMedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedio.TabIndex = 2;
            this.picMedio.TabStop = false;
            this.picMedio.Click += new System.EventHandler(this.picMedio_Click);
            this.picMedio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMedio_MouseMove);
            // 
            // picDificil
            // 
            this.picDificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDificil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDificil.Location = new System.Drawing.Point(525, 115);
            this.picDificil.Name = "picDificil";
            this.picDificil.Size = new System.Drawing.Size(150, 150);
            this.picDificil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDificil.TabIndex = 3;
            this.picDificil.TabStop = false;
            this.picDificil.Click += new System.EventHandler(this.picDificil_Click);
            this.picDificil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDificil_MouseMove);
            // 
            // picFacil
            // 
            this.picFacil.BackColor = System.Drawing.SystemColors.Control;
            this.picFacil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFacil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacil.Location = new System.Drawing.Point(275, 233);
            this.picFacil.Name = "picFacil";
            this.picFacil.Size = new System.Drawing.Size(250, 250);
            this.picFacil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFacil.TabIndex = 4;
            this.picFacil.TabStop = false;
            this.picFacil.Click += new System.EventHandler(this.picFacil_Click);
            this.picFacil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFacil_MouseMove);
            // 
            // btnReturnGame
            // 
            this.btnReturnGame.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturnGame.BackgroundImage")));
            this.btnReturnGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnGame.Location = new System.Drawing.Point(-1, 0);
            this.btnReturnGame.Name = "btnReturnGame";
            this.btnReturnGame.Size = new System.Drawing.Size(74, 74);
            this.btnReturnGame.TabIndex = 7;
            this.btnReturnGame.TabStop = false;
            this.btnReturnGame.Click += new System.EventHandler(this.btnReturnGame_Click_1);
            this.btnReturnGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReturnGame_MouseMove);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Location = new System.Drawing.Point(96, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(74, 74);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHelp_MouseMove);
            // 
            // frmMenuLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnReturnGame);
            this.Controls.Add(this.picFacil);
            this.Controls.Add(this.picDificil);
            this.Controls.Add(this.picMedio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuLevel";
            this.Text = "frmMenuLevel";
            this.Load += new System.EventHandler(this.frmMenuLevel_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMenuLevel_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picMedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDificil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picMedio;
        private System.Windows.Forms.PictureBox picDificil;
        private System.Windows.Forms.PictureBox picFacil;
        private System.Windows.Forms.PictureBox btnReturnGame;
        private System.Windows.Forms.PictureBox btnHelp;
    }
}