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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.picBtnPlay = new System.Windows.Forms.PictureBox();
            this.picBtnHome = new System.Windows.Forms.PictureBox();
            this.picRegianimal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegianimal)).BeginInit();
            this.SuspendLayout();
            // 
            // picBtnPlay
            // 
            this.picBtnPlay.Location = new System.Drawing.Point(500, 289);
            this.picBtnPlay.Name = "picBtnPlay";
            this.picBtnPlay.Size = new System.Drawing.Size(300, 261);
            this.picBtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnPlay.TabIndex = 1;
            this.picBtnPlay.TabStop = false;
            this.picBtnPlay.Click += new System.EventHandler(this.picBtnPlay_Click);
            this.picBtnPlay.MouseLeave += new System.EventHandler(this.picBtnPlay_MouseLeave);
            this.picBtnPlay.MouseHover += new System.EventHandler(this.picBtnPlay_MouseHover);
            // 
            // picBtnHome
            // 
            this.picBtnHome.Location = new System.Drawing.Point(25, 10);
            this.picBtnHome.Name = "picBtnHome";
            this.picBtnHome.Size = new System.Drawing.Size(120, 120);
            this.picBtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnHome.TabIndex = 2;
            this.picBtnHome.TabStop = false;
            this.picBtnHome.Click += new System.EventHandler(this.picBtnHome_Click);
            this.picBtnHome.MouseLeave += new System.EventHandler(this.picBtnHome_MouseLeave);
            this.picBtnHome.MouseHover += new System.EventHandler(this.picBtnHome_MouseHover);
            // 
            // picRegianimal
            // 
            this.picRegianimal.Image = ((System.Drawing.Image)(resources.GetObject("picRegianimal.Image")));
            this.picRegianimal.Location = new System.Drawing.Point(395, 14);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegianimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBtnPlay;
        private System.Windows.Forms.PictureBox picBtnHome;
        private System.Windows.Forms.PictureBox picRegianimal;
    }
}