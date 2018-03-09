namespace WinAppProyectoFinal.Forms
{
    partial class frmInstrucciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstrucciones));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picMouse = new System.Windows.Forms.PictureBox();
            this.lblButtonJugarAyuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(40, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 54);
            this.label1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(101, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 188);
            this.label3.TabIndex = 5;
            this.label3.Text = "Haz clic sobre el objeto y arrastralo hacia la casa o escuela donde tu creas que " +
    "sea correcto";
            // 
            // picMouse
            // 
            this.picMouse.BackColor = System.Drawing.Color.Transparent;
            this.picMouse.Image = ((System.Drawing.Image)(resources.GetObject("picMouse.Image")));
            this.picMouse.Location = new System.Drawing.Point(317, 170);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(134, 56);
            this.picMouse.TabIndex = 7;
            this.picMouse.TabStop = false;
            // 
            // lblButtonJugarAyuda
            // 
            this.lblButtonJugarAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblButtonJugarAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblButtonJugarAyuda.Location = new System.Drawing.Point(355, 383);
            this.lblButtonJugarAyuda.Name = "lblButtonJugarAyuda";
            this.lblButtonJugarAyuda.Size = new System.Drawing.Size(214, 68);
            this.lblButtonJugarAyuda.TabIndex = 8;
            this.lblButtonJugarAyuda.Click += new System.EventHandler(this.lblButtonJugarAyuda_Click);
            // 
            // frmInstrucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.ControlBox = false;
            this.Controls.Add(this.lblButtonJugarAyuda);
            this.Controls.Add(this.picMouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstrucciones";
            this.Text = "frmInstrucciones";
            this.Load += new System.EventHandler(this.frmInstrucciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picMouse;
        private System.Windows.Forms.Label lblButtonJugarAyuda;
    }
}