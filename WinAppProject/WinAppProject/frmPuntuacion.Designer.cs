namespace WinAppProject
{
    partial class frmPuntuacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntuacion));
            this.picRegalo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRegalo)).BeginInit();
            this.SuspendLayout();
            // 
            // picRegalo
            // 
            this.picRegalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRegalo.Image = ((System.Drawing.Image)(resources.GetObject("picRegalo.Image")));
            this.picRegalo.Location = new System.Drawing.Point(107, 119);
            this.picRegalo.Name = "picRegalo";
            this.picRegalo.Size = new System.Drawing.Size(209, 217);
            this.picRegalo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRegalo.TabIndex = 0;
            this.picRegalo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Enhorabuena¡ Exelente Puntuación ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRepeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRepeat.BackgroundImage")));
            this.btnRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepeat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Location = new System.Drawing.Point(312, 457);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(95, 95);
            this.btnRepeat.TabIndex = 2;
            this.btnRepeat.UseVisualStyleBackColor = false;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // frmPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picRegalo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPuntuacion";
            this.Text = "Puntuacion";
            this.Load += new System.EventHandler(this.frmPuntuacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRegalo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRegalo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRepeat;
    }
}