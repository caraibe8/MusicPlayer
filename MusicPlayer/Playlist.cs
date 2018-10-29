using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class PlaylistManager : IPlaylist
    {
        private List<IMediaFile> playlist;
        public IMediaFile CurrentFile { get; private set; }
        public bool Random { get; set; }
        public ReadMode ReadMode { get; set; }

        public PlaylistManager()
        {
            CurrentFile = null;
            Random = false;
            ReadMode = ReadMode.Normal;
            playlist = new List<IMediaFile>();
        }

        public void AddToPlaylist(IMediaFile file)
        {
            throw new NotImplementedException();
        }

        public void AddToPlaylist(IEnumerable<IMediaFile> files)
        {
            throw new NotImplementedException();
        }

        public IMediaFile GetNextFile()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMediaFile> GetPlaylist()
        {
            throw new NotImplementedException();
        }

        public IMediaFile JumpToNextFile()
        {
            throw new NotImplementedException();
        }

        public IMediaFile JumpToPreviousFile()
        {
            throw new NotImplementedException();
        }

        public bool RemoveFromPlaylist(IMediaFile file)
        {
            throw new NotImplementedException();
        }

        public void ResetPlaylist(IEnumerable<IMediaFile> files = null)
        {
            throw new NotImplementedException();
        }
    }
}
