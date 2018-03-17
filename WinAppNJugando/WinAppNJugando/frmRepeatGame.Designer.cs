namespace WinAppProyectoFinal.Forms
{
    partial class frmRepeatGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepeatGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRepeatGame = new System.Windows.Forms.PictureBox();
            this.picGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeatGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "SE ACABO EL TIEMPO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 103);
            this.label2.TabIndex = 1;
            this.label2.Text = "INTENTA OTRA VEZ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRepeatGame
            // 
            this.btnRepeatGame.BackColor = System.Drawing.Color.Transparent;
            this.btnRepeatGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRepeatGame.BackgroundImage")));
            this.btnRepeatGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepeatGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepeatGame.Location = new System.Drawing.Point(207, 273);
            this.btnRepeatGame.Name = "btnRepeatGame";
            this.btnRepeatGame.Size = new System.Drawing.Size(116, 116);
            this.btnRepeatGame.TabIndex = 2;
            this.btnRepeatGame.TabStop = false;
            this.btnRepeatGame.Click += new System.EventHandler(this.btnRepeatGame_Click);
            this.btnRepeatGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRepeatGame_MouseMove);
            // 
            // picGif
            // 
            this.picGif.BackColor = System.Drawing.Color.Transparent;
            this.picGif.Image = ((System.Drawing.Image)(resources.GetObject("picGif.Image")));
            this.picGif.Location = new System.Drawing.Point(356, 289);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(143, 85);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 3;
            this.picGif.TabStop = false;
            // 
            // frmRepeatGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 457);
            this.Controls.Add(this.picGif);
            this.Controls.Add(this.btnRepeatGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepeatGame";
            this.Text = "frmRepeatGame";
            this.Load += new System.EventHandler(this.frmRepeatGame_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRepeatGame_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeatGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnRepeatGame;
        private System.Windows.Forms.PictureBox picGif;
    }
}