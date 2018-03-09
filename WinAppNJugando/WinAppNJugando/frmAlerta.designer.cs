namespace WinAppNiñitosEnAccion
{
    partial class frmAlerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlerta));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picBtnYes = new System.Windows.Forms.PictureBox();
            this.picBtnNo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnNo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBtnYes
            // 
            this.picBtnYes.BackColor = System.Drawing.Color.Transparent;
            this.picBtnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBtnYes.BackgroundImage")));
            this.picBtnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBtnYes.Location = new System.Drawing.Point(93, 164);
            this.picBtnYes.Name = "picBtnYes";
            this.picBtnYes.Size = new System.Drawing.Size(75, 75);
            this.picBtnYes.TabIndex = 2;
            this.picBtnYes.TabStop = false;
            this.toolTip1.SetToolTip(this.picBtnYes, "Si");
            this.picBtnYes.Click += new System.EventHandler(this.picBtnYes_Click);
            this.picBtnYes.MouseEnter += new System.EventHandler(this.picBtnYes_MouseEnter);
            // 
            // picBtnNo
            // 
            this.picBtnNo.BackColor = System.Drawing.Color.Transparent;
            this.picBtnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBtnNo.BackgroundImage")));
            this.picBtnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBtnNo.Location = new System.Drawing.Point(242, 164);
            this.picBtnNo.Name = "picBtnNo";
            this.picBtnNo.Size = new System.Drawing.Size(75, 75);
            this.picBtnNo.TabIndex = 3;
            this.picBtnNo.TabStop = false;
            this.toolTip1.SetToolTip(this.picBtnNo, "No");
            this.picBtnNo.Click += new System.EventHandler(this.picBtnNo_Click);
            this.picBtnNo.MouseEnter += new System.EventHandler(this.picBtnNo_MouseEnter);
            // 
            // frmAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 250);
            this.Controls.Add(this.picBtnNo);
            this.Controls.Add(this.picBtnYes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmAlerta_Load);
            this.MouseEnter += new System.EventHandler(this.frmAlerta_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.picBtnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picBtnYes;
        private System.Windows.Forms.PictureBox picBtnNo;
    }
}