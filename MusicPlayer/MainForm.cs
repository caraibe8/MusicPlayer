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
using MusicPlayerLib;
using static MusicPlayerLib.TextManager;
using static MusicPlayerLib.TextManager.StringKey;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private PlaylistManager playList;

        public MainForm()
        {
            InitializeComponent();

            InitializeTexts();
            playList = new PlaylistManager();
        }

        private void InitializeTexts()
        {
            loadFileButton.Text = GetString(LoadFileBtnText);
            loadplaylistButton.Text = GetString(LoadPlaylistBtnText);
            playlistPanelButton.Text = GetString(ShowPlaylistBtnText);
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
                    MessageBox.Show(GetString(FileNotFoundMsg), GetString(FileNotFoundTitle), MessageBoxButtons.OK);
                }
                catch (Exception)
                {

                }

                ReadNextFile();
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

        private void ReadNextFile()
        {
            mediaPlayer.URL = playList.GetNextFile().Path;
        }

        private void mediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
          
        }

        private void loadplaylistButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(folderDialog.SelectedPath))
                {
                    MessageBox.Show(GetString(FolderNotFoundMsg), GetString(FolderNotFoundTitle), MessageBoxButtons.OK);
                    return;
                }

                foreach (string filePath in Directory.GetFiles(folderDialog.SelectedPath))
                {
                    try
                    {
                        playList.AddToPlaylist(new MediaFile(filePath));
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                ReadNextFile();
            }
        }
    }
}
