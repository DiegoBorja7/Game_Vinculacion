namespace WinAppProyectoFinal.Forms
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
            this.btnRepeatGame = new System.Windows.Forms.PictureBox();
            this.picFestejo = new System.Windows.Forms.PictureBox();
            this.picTrofeo = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeatGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFestejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrofeo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRepeatGame
            // 
            this.btnRepeatGame.BackColor = System.Drawing.Color.Transparent;
            this.btnRepeatGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRepeatGame.BackgroundImage")));
            this.btnRepeatGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepeatGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepeatGame.Location = new System.Drawing.Point(376, 524);
            this.btnRepeatGame.Name = "btnRepeatGame";
            this.btnRepeatGame.Size = new System.Drawing.Size(79, 79);
            this.btnRepeatGame.TabIndex = 23;
            this.btnRepeatGame.TabStop = false;
            this.btnRepeatGame.Click += new System.EventHandler(this.btnRepeatGame_Click);
            this.btnRepeatGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRepeatGame_MouseMove);
            // 
            // picFestejo
            // 
            this.picFestejo.BackColor = System.Drawing.Color.Transparent;
            this.picFestejo.Image = ((System.Drawing.Image)(resources.GetObject("picFestejo.Image")));
            this.picFestejo.Location = new System.Drawing.Point(53, 1);
            this.picFestejo.Name = "picFestejo";
            this.picFestejo.Size = new System.Drawing.Size(376, 498);
            this.picFestejo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFestejo.TabIndex = 25;
            this.picFestejo.TabStop = false;
            // 
            // picTrofeo
            // 
            this.picTrofeo.BackColor = System.Drawing.Color.Transparent;
            this.picTrofeo.Image = ((System.Drawing.Image)(resources.GetObject("picTrofeo.Image")));
            this.picTrofeo.Location = new System.Drawing.Point(154, 197);
            this.picTrofeo.Name = "picTrofeo";
            this.picTrofeo.Size = new System.Drawing.Size(169, 182);
            this.picTrofeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrofeo.TabIndex = 26;
            this.picTrofeo.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblMessage.Location = new System.Drawing.Point(148, 57);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(173, 125);
            this.lblMessage.TabIndex = 27;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 625);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picTrofeo);
            this.Controls.Add(this.picFestejo);
            this.Controls.Add(this.btnRepeatGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPuntuacion";
            this.Text = "frmPuntuacion";
            this.Load += new System.EventHandler(this.frmPuntuacion_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPuntuacion_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeatGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFestejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrofeo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRepeatGame;
        private System.Windows.Forms.PictureBox picFestejo;
        private System.Windows.Forms.PictureBox picTrofeo;
        private System.Windows.Forms.Label lblMessage;
    }
}