﻿namespace RegiAnimal
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.wmpHelp = new AxWMPLib.AxWindowsMediaPlayer();
            this.clock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpHelp
            // 
            this.wmpHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpHelp.Enabled = true;
            this.wmpHelp.Location = new System.Drawing.Point(0, 0);
            this.wmpHelp.Name = "wmpHelp";
            this.wmpHelp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpHelp.OcxState")));
            this.wmpHelp.Size = new System.Drawing.Size(1300, 660);
            this.wmpHelp.TabIndex = 0;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 660);
            this.Controls.Add(this.wmpHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.wmpHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpHelp;
        private System.Windows.Forms.Timer clock;
    }
}