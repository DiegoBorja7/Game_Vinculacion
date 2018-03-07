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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalification)).BeginInit();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHome.BackgroundImage")));
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Location = new System.Drawing.Point(419, 297);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(59, 44);
            this.picHome.TabIndex = 4;
            this.picHome.TabStop = false;
            this.toolTip1.SetToolTip(this.picHome, "Elección del Juego");
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.picHome.MouseEnter += new System.EventHandler(this.picHome_MouseEnter);
            // 
            // picCalification
            // 
            this.picCalification.BackColor = System.Drawing.Color.Transparent;
            this.picCalification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCalification.Location = new System.Drawing.Point(157, 87);
            this.picCalification.Name = "picCalification";
            this.picCalification.Size = new System.Drawing.Size(200, 175);
            this.picCalification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCalification.TabIndex = 5;
            this.picCalification.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // frmPuntajeAutoevaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCalification);
            this.Controls.Add(this.picHome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPuntajeAutoevaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntaje Autoevaluación";
            this.Load += new System.EventHandler(this.frmPuntajeAutoevaluacion_Load);
            this.MouseEnter += new System.EventHandler(this.frmPuntajeAutoevaluacion_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picCalification;
        private System.Windows.Forms.Label label1;
    }
}