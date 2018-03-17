namespace WinAppProyectoFinal.Forms
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnReturnHome1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnHome1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnHome1
            // 
            this.btnReturnHome1.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnHome1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturnHome1.BackgroundImage")));
            this.btnReturnHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnHome1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnHome1.Location = new System.Drawing.Point(285, 58);
            this.btnReturnHome1.Name = "btnReturnHome1";
            this.btnReturnHome1.Size = new System.Drawing.Size(86, 90);
            this.btnReturnHome1.TabIndex = 2;
            this.btnReturnHome1.TabStop = false;
            this.btnReturnHome1.Click += new System.EventHandler(this.btnReturnHome1_Click);
            this.btnReturnHome1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReturnHome1_MouseMove);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location = new System.Drawing.Point(310, 241);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(84, 79);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseMove);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(578, 583);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnReturnHome1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMenuPrincipal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnHome1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnReturnHome1;
        private System.Windows.Forms.PictureBox btnPlay;
    }
}