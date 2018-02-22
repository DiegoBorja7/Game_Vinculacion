namespace WinAppProject
{
    partial class frmAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyuda));
            this.lblButtonJugarAyuda = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picMouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblButtonJugarAyuda
            // 
            this.lblButtonJugarAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblButtonJugarAyuda.Location = new System.Drawing.Point(401, 402);
            this.lblButtonJugarAyuda.Name = "lblButtonJugarAyuda";
            this.lblButtonJugarAyuda.Size = new System.Drawing.Size(238, 68);
            this.lblButtonJugarAyuda.TabIndex = 0;
            this.lblButtonJugarAyuda.Click += new System.EventHandler(this.lblButtonJugarAyuda_Click);
            // 
            // lblText1
            // 
            this.lblText1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblText1.Location = new System.Drawing.Point(50, 146);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(653, 67);
            this.lblText1.TabIndex = 1;
            this.lblText1.Text = "Tu reto en el juego de concentracion sera, identificar los objetos y relacionar c" +
    "orrectamente";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(41, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 54);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(41, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 50);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(102, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 82);
            this.label3.TabIndex = 4;
            this.label3.Text = "Haz clic sobre cada imagen y mantenlo presionado";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(102, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 79);
            this.label4.TabIndex = 5;
            this.label4.Text = "Llevalo hacia la casa o escuela donde tu creas que sea correcto";
            // 
            // picMouse
            // 
            this.picMouse.Image = ((System.Drawing.Image)(resources.GetObject("picMouse.Image")));
            this.picMouse.Location = new System.Drawing.Point(327, 231);
            this.picMouse.Name = "picMouse";
            this.picMouse.Size = new System.Drawing.Size(134, 56);
            this.picMouse.TabIndex = 6;
            this.picMouse.TabStop = false;
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 489);
            this.ControlBox = false;
            this.Controls.Add(this.picMouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblButtonJugarAyuda);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAyuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.frmAyuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblButtonJugarAyuda;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picMouse;
    }
}