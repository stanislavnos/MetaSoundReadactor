using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetaSoundReadactor
{
    public partial class MainForm : Form
    {
        //private Stream file;
          
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenMp3File()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3 Audio File (*.mp3)|*.mp3";
            if (open.ShowDialog() != DialogResult.OK) return;

            var file = File.Open(open.FileName, FileMode.OpenOrCreate);
            audioWaveViewer.WaveStream = new NAudio.Wave.Mp3FileReader(file);
            
            audioWaveViewer.FitToScreen();
        }

        private void loadMP3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenMp3File();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // audioWaveViewer.Dispose();
            /*
            if(file!=null)
                file.Close();*/
        }

    }
}
