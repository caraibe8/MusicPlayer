using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            
            fileDialog.ShowDialog();

            mediaPlayer.URL = fileDialog.FileName;
        }

        private void playlistPanelButton_Click(object sender, EventArgs e)
        {
            playlistPanelButton.Checked = !playlistPanelButton.Checked;
            if (playlistPanelButton.Checked)
                splitContainer.Panel1Collapsed = false;
            else
                splitContainer.Panel1Collapsed = true;
        }
    }
}
