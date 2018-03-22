namespace WinAppNiñitosEnAccion
{
    partial class frmPuntajeAutoevaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntajeAutoevaluacion));
            this.picHome = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picCalification = new System.Windows.Forms.PictureBox();
            this.picStar1 = new System.Windows.Forms.PictureBox();
            this.picStar2 = new System.Windows.Forms.PictureBox();
            this.picStar3 = new System.Windows.Forms.PictureBox();
            this.picStar4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).BeginInit();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHome.BackgroundImage")));
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Location = new System.Drawing.Point(448, 370);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(70, 55);
            this.picHome.TabIndex = 4;
            this.picHome.TabStop = false;
            this.toolTip1.SetToolTip(this.picHome, "Elección de Juego");
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.picHome.MouseEnter += new System.EventHandler(this.picHome_MouseEnter);
            // 
            // picCalification
            // 
            this.picCalification.BackColor = System.Drawing.Color.Transparent;
            this.picCalification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCalification.Location = new System.Drawing.Point(152, 68);
            this.picCalification.Name = "picCalification";
            this.picCalification.Size = new System.Drawing.Size(243, 213);
            this.picCalification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCalification.TabIndex = 5;
            this.picCalification.TabStop = false;
            // 
            // picStar1
            // 
            this.picStar1.BackColor = System.Drawing.Color.Transparent;
            this.picStar1.Image = ((System.Drawing.Image)(resources.GetObject("picStar1.Image")));
            this.picStar1.Location = new System.Drawing.Point(112, 287);
            this.picStar1.Name = "picStar1";
            this.picStar1.Size = new System.Drawing.Size(80, 70);
            this.picStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar1.TabIndex = 6;
            this.picStar1.TabStop = false;
            this.picStar1.Visible = false;
            // 
            // picStar2
            // 
            this.picStar2.BackColor = System.Drawing.Color.Transparent;
            this.picStar2.Image = ((System.Drawing.Image)(resources.GetObject("picStar2.Image")));
            this.picStar2.Location = new System.Drawing.Point(193, 287);
            this.picStar2.Name = "picStar2";
            this.picStar2.Size = new System.Drawing.Size(80, 70);
            this.picStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar2.TabIndex = 7;
            this.picStar2.TabStop = false;
            this.picStar2.Visible = false;
            // 
            // picStar3
            // 
            this.picStar3.BackColor = System.Drawing.Color.Transparent;
            this.picStar3.Image = ((System.Drawing.Image)(resources.GetObject("picStar3.Image")));
            this.picStar3.Location = new System.Drawing.Point(274, 287);
            this.picStar3.Name = "picStar3";
            this.picStar3.Size = new System.Drawing.Size(80, 70);
            this.picStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar3.TabIndex = 8;
            this.picStar3.TabStop = false;
            this.picStar3.Visible = false;
            // 
            // picStar4
            // 
            this.picStar4.BackColor = System.Drawing.Color.Transparent;
            this.picStar4.Image = ((System.Drawing.Image)(resources.GetObject("picStar4.Image")));
            this.picStar4.Location = new System.Drawing.Point(355, 287);
            this.picStar4.Name = "picStar4";
            this.picStar4.Size = new System.Drawing.Size(80, 70);
            this.picStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar4.TabIndex = 9;
            this.picStar4.TabStop = false;
            this.picStar4.Visible = false;
            // 
            // frmPuntajeAutoevaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.picStar4);
            this.Controls.Add(this.picStar3);
            this.Controls.Add(this.picStar2);
            this.Controls.Add(this.picStar1);
            this.Controls.Add(this.picCalification);
            this.Controls.Add(this.picHome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPuntajeAutoevaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntaje Autoevaluación";
            this.Load += new System.EventHandler(this.frmPuntajeAutoevaluacion_Load);
            this.MouseEnter += new System.EventHandler(this.frmPuntajeAutoevaluacion_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picCalification;
        private System.Windows.Forms.PictureBox picStar1;
        private System.Windows.Forms.PictureBox picStar2;
        private System.Windows.Forms.PictureBox picStar3;
        private System.Windows.Forms.PictureBox picStar4;
    }
}