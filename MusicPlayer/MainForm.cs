using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private PlaylistManager playList;

        public MainForm()
        {
            InitializeComponent();
            playList = new PlaylistManager();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    playList.AddToPlaylist(new MediaFile(fileDialog.FileName));
                }
                catch (FileNotFoundException)
                {

                }
            }
        }

        private void playlistPanelButton_Click(object sender, EventArgs e)
        {
            playlistPanelButton.Checked = !playlistPanelButton.Checked;
            if (playlistPanelButton.Checked)
                splitContainer.Panel1Collapsed = false;
            else
                splitContainer.Panel1Collapsed = true;
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
