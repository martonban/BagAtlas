﻿namespace LauncherWinForms.View {
    partial class MainLauncherView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLauncherView));
            this.menuStripUserControl1 = new LauncherWinForms.View.MainLauncherControls.MenuStripUserControl();
            this.SuspendLayout();
            // 
            // menuStripUserControl1
            // 
            this.menuStripUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStripUserControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripUserControl1.Location = new System.Drawing.Point(0, 0);
            this.menuStripUserControl1.Name = "menuStripUserControl1";
            this.menuStripUserControl1.Size = new System.Drawing.Size(350, 953);
            this.menuStripUserControl1.TabIndex = 0;
            // 
            // MainLauncherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1782, 953);
            this.Controls.Add(this.menuStripUserControl1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainLauncherView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.MainLauncherView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MainLauncherControls.MenuStripUserControl menuStripUserControl1;
    }
}