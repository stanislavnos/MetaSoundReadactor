using MetaSoundReadactor.AudioViewer;

namespace MetaSoundReadactor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.loadMP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioWaveViewer = new MetaSoundReadactor.AudioViewer.AudioWaveViewer();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1040, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMP3ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // loadMP3ToolStripMenuItem
            // 
            this.loadMP3ToolStripMenuItem.Name = "loadMP3ToolStripMenuItem";
            this.loadMP3ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.loadMP3ToolStripMenuItem.Text = "Load MP3";
            this.loadMP3ToolStripMenuItem.Click += new System.EventHandler(this.loadMP3ToolStripMenuItem_Click);
            // 
            // audioWaveViewer
            // 
            this.audioWaveViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioWaveViewer.Location = new System.Drawing.Point(0, 25);
            this.audioWaveViewer.Name = "audioWaveViewer";
            this.audioWaveViewer.PenColor = System.Drawing.Color.DodgerBlue;
            this.audioWaveViewer.PenWidth = 1F;
            this.audioWaveViewer.SamplesPerPixel = 128;
            this.audioWaveViewer.Size = new System.Drawing.Size(1040, 237);
            this.audioWaveViewer.StartPosition = ((long)(0));
            this.audioWaveViewer.TabIndex = 1;
            this.audioWaveViewer.WaveStream = null;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1040, 262);
            this.Controls.Add(this.audioWaveViewer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem loadMP3ToolStripMenuItem;
        private AudioWaveViewer audioWaveViewer;
    }
}

