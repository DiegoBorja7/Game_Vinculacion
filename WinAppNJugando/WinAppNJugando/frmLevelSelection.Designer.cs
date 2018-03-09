namespace RegiAnimal
{
    partial class frmLevelSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevelSelection));
            this.picLvlEasy = new System.Windows.Forms.PictureBox();
            this.picLvlMedium = new System.Windows.Forms.PictureBox();
            this.picLvlHard = new System.Windows.Forms.PictureBox();
            this.grbeasy = new System.Windows.Forms.GroupBox();
            this.grbmedium = new System.Windows.Forms.GroupBox();
            this.grbHard = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLvlEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLvlMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLvlHard)).BeginInit();
            this.grbeasy.SuspendLayout();
            this.grbmedium.SuspendLayout();
            this.grbHard.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLvlEasy
            // 
            this.picLvlEasy.Image = ((System.Drawing.Image)(resources.GetObject("picLvlEasy.Image")));
            this.picLvlEasy.Location = new System.Drawing.Point(116, 198);
            this.picLvlEasy.Name = "picLvlEasy";
            this.picLvlEasy.Size = new System.Drawing.Size(150, 150);
            this.picLvlEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLvlEasy.TabIndex = 0;
            this.picLvlEasy.TabStop = false;
            this.picLvlEasy.Click += new System.EventHandler(this.pictureBox1_Click);
            this.picLvlEasy.MouseLeave += new System.EventHandler(this.picLvlEasy_MouseLeave);
            this.picLvlEasy.MouseHover += new System.EventHandler(this.picLvlEasy_MouseHover);
            // 
            // picLvlMedium
            // 
            this.picLvlMedium.Image = ((System.Drawing.Image)(resources.GetObject("picLvlMedium.Image")));
            this.picLvlMedium.Location = new System.Drawing.Point(111, 198);
            this.picLvlMedium.Name = "picLvlMedium";
            this.picLvlMedium.Size = new System.Drawing.Size(150, 150);
            this.picLvlMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLvlMedium.TabIndex = 1;
            this.picLvlMedium.TabStop = false;
            this.picLvlMedium.Click += new System.EventHandler(this.picLvlMedium_Click);
            this.picLvlMedium.MouseLeave += new System.EventHandler(this.picLvlMedium_MouseLeave);
            this.picLvlMedium.MouseHover += new System.EventHandler(this.picLvlMedium_MouseHover);
            // 
            // picLvlHard
            // 
            this.picLvlHard.Image = ((System.Drawing.Image)(resources.GetObject("picLvlHard.Image")));
            this.picLvlHard.Location = new System.Drawing.Point(129, 198);
            this.picLvlHard.Name = "picLvlHard";
            this.picLvlHard.Size = new System.Drawing.Size(150, 150);
            this.picLvlHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLvlHard.TabIndex = 2;
            this.picLvlHard.TabStop = false;
            this.picLvlHard.Click += new System.EventHandler(this.picLvlHard_Click);
            this.picLvlHard.MouseLeave += new System.EventHandler(this.picLvlHard_MouseLeave);
            this.picLvlHard.MouseHover += new System.EventHandler(this.picLvlHard_MouseHover);
            // 
            // grbeasy
            // 
            this.grbeasy.Controls.Add(this.picLvlEasy);
            this.grbeasy.Location = new System.Drawing.Point(24, 12);
            this.grbeasy.Name = "grbeasy";
            this.grbeasy.Size = new System.Drawing.Size(383, 636);
            this.grbeasy.TabIndex = 3;
            this.grbeasy.TabStop = false;
            // 
            // grbmedium
            // 
            this.grbmedium.Controls.Add(this.picLvlMedium);
            this.grbmedium.Location = new System.Drawing.Point(455, 12);
            this.grbmedium.Name = "grbmedium";
            this.grbmedium.Size = new System.Drawing.Size(383, 636);
            this.grbmedium.TabIndex = 4;
            this.grbmedium.TabStop = false;
            // 
            // grbHard
            // 
            this.grbHard.Controls.Add(this.picLvlHard);
            this.grbHard.Location = new System.Drawing.Point(890, 12);
            this.grbHard.Name = "grbHard";
            this.grbHard.Size = new System.Drawing.Size(383, 636);
            this.grbHard.TabIndex = 5;
            this.grbHard.TabStop = false;
            // 
            // frmLevelSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 660);
            this.Controls.Add(this.grbHard);
            this.Controls.Add(this.grbeasy);
            this.Controls.Add(this.grbmedium);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLevelSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelSelection";
            ((System.ComponentModel.ISupportInitialize)(this.picLvlEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLvlMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLvlHard)).EndInit();
            this.grbeasy.ResumeLayout(false);
            this.grbmedium.ResumeLayout(false);
            this.grbHard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLvlEasy;
        private System.Windows.Forms.PictureBox picLvlMedium;
        private System.Windows.Forms.PictureBox picLvlHard;
        private System.Windows.Forms.GroupBox grbeasy;
        private System.Windows.Forms.GroupBox grbmedium;
        private System.Windows.Forms.GroupBox grbHard;
    }
}