using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioTask1
{
    public partial class PotatoPlayer : Form
    {
        
        public PotatoPlayer()
        {
            InitializeComponent();
            MediaPlayer.uiMode = "none";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.play(); // Start / Resume video
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.pause(); // Stop video
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog // Opens a window to allow file selection
            {
                // Set the filter to only show video files
                Filter = "Video Files|*.mp4;*.avi;*.mov;*.wmv;*.flv;*.mkv|All Files (*.*)|*.*",
                Title = "Select a Video File",
                InitialDirectory = @"C:\Documents"
            };

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                MediaPlayer.URL = OFD.FileName;
            }
        }
    }
}
